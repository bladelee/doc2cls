#!/usr/bin/python3
# -*- coding: utf-8 -*-

import re
import xml.etree.ElementTree as ET
import zipfile
import os
import traceback
import sys

nsmap = {'w': 'http://schemas.openxmlformats.org/wordprocessingml/2006/main'}

def qn(tag):
    """
    Stands for 'qualified name', a utility function to turn a namespace
    prefixed tag name into a Clark-notation qualified tag name for lxml. For
    example, ``qn('p:cSld')`` returns ``'{http://schemas.../main}cSld'``.
    Source: https://github.com/python-openxml/python-docx/
    """
    prefix, tagroot = tag.split(':')
    uri = nsmap[prefix]
    return '{%s}%s' % (uri, tagroot)

def xml2text(xml):
    """
    A string representing the textual content of this run, with content
    child elements like ``<w:tab/>`` translated to their Python
    equivalent.
    Adapted from: https://github.com/python-openxml/python-docx/
    """
    text = ''
    root = ET.fromstring(xml)
    for child in root.iter():
        if child.tag == qn('w:t'):
            t_text = child.text
            text += t_text if t_text is not None else ''
        elif child.tag == qn('w:tab'):
            text += '\t'
        elif child.tag in (qn('w:br'), qn('w:cr')):
            text += '\n'
        elif child.tag == qn("w:p"):
            text += '\n\n'
    return text

def process(docx):
    text = ''

    # unzip the docx in memory
    zipf = zipfile.ZipFile(docx)
    filelist = zipf.namelist()

    # get header text
    # there can be 3 header files in the zip
    header_xmls = 'word/header[0-9]*.xml'
    for fname in filelist:
        if re.match(header_xmls, fname):
            text += xml2text(zipf.read(fname))

    # get main text
    doc_xml = 'word/document.xml'
    text += xml2text(zipf.read(doc_xml))

    # get footer text
    # there can be 3 footer files in the zip
    footer_xmls = 'word/footer[0-9]*.xml'
    for fname in filelist:
        if re.match(footer_xmls, fname):
            text += xml2text(zipf.read(fname))

    zipf.close()
    return text.strip()

#=============================
def getSections(path):
    doc = process(path)
    beginBoundary ='接口说明'
    endBoundary ='附录'

    beginIndex = doc.rfind(beginBoundary)
    # print(beginIndex)
    endIndex = doc.rfind(endBoundary)
    # print(endIndex)
    content = doc[beginIndex:endIndex]
    section = content.split('接口介绍')
    # print(len(section))
    # writeToFile('r3.txt',section[0])
    # writeToFile('r4.txt',section[1])
    return section

def resolveSection(sec):
    ifNameBoundary = '接口'
    reqXmlBeginBoundary = '<request>'
    reqXmlEndBoundary ='</request>'
    reqXmlEndBoundaryExt = len(reqXmlEndBoundary)
    respXmlBeginBoundary = '<response>'
    respXmlEndBoundary = '</response>'
    respXmlEndBoundaryExt = len(respXmlEndBoundary)

    lines = sec.splitlines()
    interfaceApi = ''
    for line in lines:
        if line.find('ERP') > -1 and line.find('API') > -1:
            interfaceApi = line.replace('：',':').split(':')[1].strip()
            break;

    nexInterfaceName = lines[-1].strip()
    if nexInterfaceName.find(ifNameBoundary) == -1:
        nexInterfaceName = ''

    reqBeginIndex = sec.find(reqXmlBeginBoundary)
    respBeginIndex = sec.find(respXmlBeginBoundary)
    reqXml = ''
    respXml = ''
    if  reqBeginIndex > -1 and respBeginIndex > -1:
        reqXml = sec[reqBeginIndex : sec.find(reqXmlEndBoundary)+reqXmlEndBoundaryExt]
        respXml = sec[respBeginIndex : sec.find(respXmlEndBoundary)+respXmlEndBoundaryExt]
    reqXml = reqXml.strip().replace('，',',').replace('；',';').replace('（','(').replace('）',')')
    respXml = respXml.strip().replace('，',',').replace('；',';').replace('（','(').replace('）',')')
    return reqXml,respXml,nexInterfaceName,interfaceApi

def resolveRequestXml(xml, name, api, needAttribute):
    def resolveChild (element, parentTag, parentClsName, parentCls, isBackward):
        childCount = len(list(element))
        if 0 == childCount:
            parentCls.append(resolveField(element, not isBackward, needAttribute))
        elif 1 == childCount:
            for child in element:
                if element.tag.find(child.tag) != -1:
                    clsName = parentClsName + capitalFirstLetter(child.tag)
                    clsDefine = ''
                    if isBackward:
                        clsDefine = getClassDefine(clsName, '', '[Serializable]')
                    else:
                        # clsDefine = getClassDefine(clsName, 'EntityChecker', '[Serializable]')
                        clsDefine = getClassDefine(clsName, '', '[Serializable]')
                    parentCls.append(getParentArrayFieldDefine(clsName, child.tag, element.tag))
                    doResolve(clsName, clsDefine, child, isBackward)
                else:
                    clsName = parentClsName + capitalFirstLetter(element.tag)
                    clsDefine = ''
                    if isBackward:
                        clsDefine = getClassDefine(clsName, '', '[Serializable]')
                    else:
                        # clsDefine = getClassDefine(clsName, 'EntityChecker', '[Serializable]')
                        clsDefine = getClassDefine(clsName, '', '[Serializable]')
                    parentCls.append(getParentFieldDefine(clsName, element.tag, '[XmlElement("{0}", typeof({1}))]'.format(element.tag, clsName)))
                    doResolve(clsName, clsDefine, element, isBackward)

        else:
            clsName = parentClsName + capitalFirstLetter(element.tag)
            clsDefine = ''
            if isBackward:
                clsDefine = getClassDefine(clsName, '', '[Serializable]')
            else:
                # clsDefine = getClassDefine(clsName, 'EntityChecker', '[Serializable]')
                clsDefine = getClassDefine(clsName, '', '[Serializable]')
            parentCls.append(getParentFieldDefine(clsName, element.tag, '[XmlElement("{0}", typeof({1}))]'.format(element.tag, clsName)))
            doResolve(clsName, clsDefine, element, isBackward)

    def doResolve(clsName, clsDefine, element, isBackward):
        curCls = []
        childCls.append(curCls)
        curCls.append(clsDefine)
        curCls.append(regionBgin)
        for i in element:
            resolveChild(i,element.tag, clsName, curCls, isBackward)
        curCls.append(regionEnd)
        # childCls.append(curCls)

    forwardUsings = 'using System;\nusing System.Xml.Serialization;\nusing System.ComponentModel;\nusing Wms.Common;\n\n'
    backwardUsings = 'using System;\nusing System.Xml.Serialization;\nusing Wms.Common;\n\n'
    forwardNameSpace = 'namespace Wms.Request.QM\n'
    backwrdNameSapce = 'namespace Wms.CallBack.Request\n'
    LF = '\n'
    regionBgin = '{\n'
    regionEnd = '}\n'

    fileNS = []
    mainCls = []
    childCls = []
    isBackward = len(api.split('.')) == 2
    if isBackward:
        fileNS.append(backwardUsings)
        fileNS.append(backwrdNameSapce)
    else:
        fileNS.append(forwardUsings)
        fileNS.append(forwardNameSpace)
    fileNS.append(regionBgin)#ns
    mainCls.append(getComment(name, api))

    mainClsName = getMainClsName(api, True)
    root = ET.fromstring(xml)
    mainClsDefine = ''
    if isBackward:
        # mainClsDefine = getClassDefine(mainClsName,'CallBackRequest','[Serializable]','[XmlRoot("request")]')
        mainClsDefine = getClassDefine(mainClsName,'','[Serializable]','[XmlRoot("request")]')
    else:
        # mainClsDefine =  getClassDefine(mainClsName,'WmsBaseRequest','[Serializable]','[XmlRoot("request")]')
        mainClsDefine =  getClassDefine(mainClsName,'','[Serializable]','[XmlRoot("request")]')
    mainCls.append(mainClsDefine)
    mainCls.append(regionBgin)
    for el in root:
        childCount = len(list(el))
        if childCount == 0:
            mainCls.append(resolveField(el, not isBackward, needAttribute))
        else:
            resolveChild(el, root.tag, mainClsName, mainCls, isBackward)
    mainCls.append(regionEnd)
    fileNS.append(''.join(mainCls))
    # childCls.reverse()
    for cls in childCls:
        fileNS.append(''.join(cls))
    fileNS.append(regionEnd)#ns

    if isBackward:
        writeToFile('doc2cls/backward/{0}.cs'.format(mainClsName), ''.join(fileNS))
    else:
        writeToFile('doc2cls/forward/req/{0}.cs'.format(mainClsName), ''.join(fileNS))

def resolveResponseXml(xml, name, api):
    def resolveChild (element, parentTag, parentClsName, parentCls):
        childCount = len(list(element))
        if 0 == childCount:
            parentCls.append(resolveField(element,  False, False))
        elif 1 == childCount:
            for child in element:
                if element.tag.find(child.tag) != -1:
                    clsName = parentClsName + capitalFirstLetter(child.tag)
                    clsDefine = getClassDefine(clsName, '', '[Serializable]')
                    parentCls.append(getParentArrayFieldDefine(clsName, child.tag, element.tag))
                    doResolve(clsName, clsDefine, child)
                else:
                    clsName = parentClsName + capitalFirstLetter(element.tag)
                    clsDefine = getClassDefine(clsName, '', '[Serializable]')
                    parentCls.append(getParentFieldDefine(clsName, element.tag, '[XmlElement("{0}", typeof({1}))]'.format(element.tag, clsName)))
                    doResolve(clsName, clsDefine, element)

        else:
            clsName = parentClsName + capitalFirstLetter(element.tag)
            clsDefine = getClassDefine(clsName, '', '[Serializable]')
            parentCls.append(getParentFieldDefine(clsName, element.tag, '[XmlElement("{0}", typeof({1}))]'.format(element.tag, clsName)))
            doResolve(clsName, clsDefine, element)

    def doResolve(clsName, clsDefine, element):
        curCls = []
        curCls.append(clsDefine)
        curCls.append(regionBgin)
        for i in element:
            resolveChild(i,element.tag, clsName, curCls)
        curCls.append(regionEnd)
        childCls.append(curCls)

    apiComponentLength = len(api.split('.'))
    if apiComponentLength == 2:
        return
    forwardUsings = 'using System;\nusing System.Xml.Serialization;\n\n'
    forwardNameSpace = 'namespace Wms.Response.QM\n'
    LF = '\n'
    regionBgin = '{\n'
    regionEnd = '}\n'
    baseField = ['flag','code','message']

    fileNS = []
    mainCls = []
    childCls = []

    fileNS.append(forwardUsings)
    fileNS.append(forwardNameSpace)
    fileNS.append(regionBgin)#ns
    mainCls.append(getComment(name, api))

    mainClsName = getMainClsName(api, False)
    root = ET.fromstring(xml)
    # mainCls.append(getClassDefine(mainClsName,'QMResponseBase','[Serializable]','[XmlRoot("response")]'))
    mainCls.append(getClassDefine(mainClsName,'','[Serializable]','[XmlRoot("response")]'))
    mainCls.append(regionBgin)
    for el in root:
        childCount = len(list(el))
        if childCount == 0:
            # if el.tag in baseField:
            #     continue
            mainCls.append(resolveField(el, False, False))
        else:
            resolveChild(el, root.tag, mainClsName, mainCls)
    mainCls.append(regionEnd)
    fileNS.append(''.join(mainCls))
    childCls.reverse()
    for cls in childCls:
        fileNS.append(''.join(cls))
    fileNS.append(regionEnd)#ns

    writeToFile('doc2cls/forward/resp/{0}.cs'.format(mainClsName), ''.join(fileNS))

def getMainClsName(api, isRequest):
    if isRequest:
        return 'QM{0}Request'.format(getApiPart(api))
    else:
        return 'QM{0}Response'.format(getApiPart(api))

def getApiPart(api):
    part = api.split('.')
    if len(part) != 2:
        part = part[-2:]
    firstPart = ['item','order','out','process','status','lack','check','change','transfer']
    secondPart = ['batch','heart']
    first = part[0].strip()
    second = part[1].strip()
    result = []
    for i in firstPart:
        if first.endswith(i):
            index = first.index(i)
            if index == 0:
                result.append(capitalFirstLetter(first))
            else:
                result.append(capitalFirstLetter(first[:index]))
                result.append(capitalFirstLetter(first[index:]))
            break
    else:
        result.append(capitalFirstLetter(first))

    for j in secondPart:
        if second.startswith(j):
            index = len(j)
            result.append(capitalFirstLetter(second[:index]))
            result.append(capitalFirstLetter(second[index:]))
            break
    else:
        result.append(capitalFirstLetter(second))
    return ''.join(result)

def getClassDefine(clsName, parentName, *attributes):
    components = []
    for i in attributes:
        components.append(i+'\n')
    if parentName:
        components.append('public class {0} : {1}\n'.format(clsName, parentName))
    else:
        components.append('public class {0}\n'.format(clsName))
    return ''.join(components)

def getParentFieldDefine(clsName, tag, *attributes):
    result = []
    result.append('\n')
    for i in attributes:
        result.append(i+'\n')
    result.append('public {0} {1} {{get; set;}}\n'.format(clsName, capitalFirstLetter(tag)))
    return ''.join(result)

def getParentArrayFieldDefine(clsName, tag, parentTag):
    result = []
    result.append('\n')
    result.append('[XmlArray("{0}")]\n'.format(parentTag))
    result.append('[XmlArrayItem("{0}", typeof({1}))]\n'.format(tag, clsName))
    result.append('public {0}[] {1} {{get; set;}}\n'.format(clsName, capitalFirstLetter(parentTag)))
    return ''.join(result)

def getComment(*comments):
    result = '/// <summary>\n'
    for i in comments:
        result += '/// {0}\n'.format(i)
    result += '/// </summary>\n'
    return result

def resolveField(element, needExt, needAttribute):
    tag = element.tag
    txt = element.text.strip()
    simpleDescription = getSimpleDescription(txt)
    blMust, fieldType, mxLen, description = resolveDescription(txt)

    result = []
    result.append('/// <summary>\n/// {0}\n/// </summary>\n'.format(description))
    if needAttribute and blMust and needExt:
        result.append('[Required]\n')
        result.append('[Description("{0}")]\n'.format(simpleDescription))
    if fieldType == 0:
        if needAttribute and needExt:
            result.append('[MaxLength({0})]\n'.format(mxLen))
        result.append('[XmlElement("{0}", typeof(string))]\n'.format(tag))
        result.append('public string {0} {{ get; set; }}\n'.format(capitalFirstLetter(tag)))
    elif fieldType == 1:
        result.append('[XmlElement("{0}", typeof(int?), IsNullable = true)]\n'.format(tag))
        result.append('public int? {0} {{ get; set; }}\n'.format(capitalFirstLetter(tag)))
    elif fieldType == 2:
        result.append('[XmlElement("{0}", typeof(double?), IsNullable = true)]\n'.format(tag))
        result.append('public double? {0} {{ get; set; }}\n'.format(capitalFirstLetter(tag)))
    return ''.join(result)

def capitalFirstLetter(tag):
    try:
        return tag[0].upper() + tag[1:]
    except:
        print('tag:',tag)
        traceback.print_exc()

def getSimpleDescription(txt):
    des = txt
    i = txt.find(',')
    if i > -1:
        des=txt[:i]
    j = des.find('(')
    if j > -1:
        des=des[:j]
    return des.strip()

def resolveDescription(txt):
    strMust = '必填'
    strConditionalMust = '条件必填'
    strYN = 'Y/N'
    blMust = False
    fieldType = 0 #0:string, 1:int, 2:double
    mxLen = '' #fieldType=0
    description = ''

    txt = txt.replace('\r\n', '').replace('\n','').replace('\r', '')
    indexInt = txt.find('int')
    if indexInt > -1:
        fieldType = 1
        begin = txt.rfind(',', 0, indexInt)
        end = txt.find(',', indexInt)
        if end > -1:
            description = txt[:begin] + txt[end:]
        else:
            description = txt[:begin]
    indexDouble = txt.find('double')
    if indexDouble > -1:
        fieldType = 2
        begin = txt.rfind(',', 0, indexDouble)
        end = txt.find(',', txt.find(')', indexDouble))
        if end > -1:
            description = txt[:begin] + txt[end:]
        else:
            description = txt[:begin]
    indexStr = txt.find('string')
    if indexStr > -1:
        begin = txt.rfind(',', 0, indexStr)
        mxBegin = txt.find('(', indexStr)
        mxEnd = txt.find(')', indexStr)
        mxLen = txt[mxBegin+1:mxEnd].strip()
        end = txt.find(',', indexStr)
        if end > -1:
            description = txt[:begin] + txt[end:]
        else:
            description = txt[:begin]
    elif fieldType == 0:
        description = txt
        indexYN = txt.find(strYN)
        if indexYN > -1:
            mxLen = '1'
        else:
            mxLen = '50'

    indexMust = description.find(strMust)
    if indexMust > -1:
        begin = description[:indexMust].rfind(',')
        end = description[indexMust:].find(',')
        if end > -1:
            description = description[:begin] + description[indexMust+end:]
        else:
            description = description[:begin]

    indexConMust = description.find(strConditionalMust)
    if indexMust > -1 and indexConMust == -1:
        blMust = True
    return blMust, fieldType, mxLen, description

def writeToFile(fileName, content):
    with open(fileName, 'w', encoding='utf-8') as f:
        f.write(content)
        f.close()

def main(path, needAttribute):
    sections = getSections(path)
    interfaceName = ''
    for sec in sections:
        reqXml,respXml,nexInterfaceName,interfaceApi = resolveSection(sec.strip())
        if interfaceApi != '':
            resolveRequestXml(reqXml, interfaceName, interfaceApi, needAttribute)
            resolveResponseXml(respXml, interfaceName, interfaceApi)
        if nexInterfaceName == '':
            break
        interfaceName = nexInterfaceName

def doSteps(docPath, needResolveDoc, needAttribute):
    if needResolveDoc:
        doc2xml(docPath)
    xml2cls(needAttribute)

def doc2xml(docPath):
    sections = getSections(docPath)
    interfaceName = ''
    interfaceList = []
    for sec in sections:
        reqXml,respXml,nexInterfaceName,interfaceApi = resolveSection(sec.strip())
        if interfaceApi != '':
            writeToFile('doc2cls/xml/req/{0}'.format(interfaceName+'-'+interfaceApi), reqXml)
            writeToFile('doc2cls/xml/resp/{0}'.format(interfaceName+'-'+interfaceApi), respXml)
            interfaceList.append((interfaceApi, interfaceName))
        if nexInterfaceName == '':
            break
        interfaceName = nexInterfaceName
    saveRequestApi(interfaceList)

def saveRequestApi(interfaceList):
    fieldList = []
    fieldList.append('public class QMRequestMethod\n{\n')
    for item in interfaceList:
        key, name = item
        fieldName = getApiPart(key)
        fieldList.append('/// <summary>\n/// {0}\n/// </summary>\n'.format(name))
        fieldList.append('public const string {0} = "{1}";\n'.format(fieldName, key))
    fieldList.append('}\n')
    writeToFile('doc2cls/RequestMethod.cs', ''.join(fieldList))

def xml2cls(needAttribute):
    reqPath = 'doc2cls/xml/req'
    respPath = 'doc2cls/xml/resp'

    reqFileNames = os.listdir(reqPath)
    for fileName in reqFileNames:
        interfaceName, interfaceApi = fileName.split('-')
        print(interfaceName)
        with open(os.path.join(reqPath, fileName), 'r', encoding='utf-8') as f:
            reqXml = f.read()
        resolveRequestXml(reqXml, interfaceName, interfaceApi, needAttribute)

    respFileNames = os.listdir(respPath)
    for fileName in respFileNames:
        interfaceName, interfaceApi = fileName.split('-')
        print(interfaceName)
        with open(os.path.join(respPath, fileName), 'r', encoding='utf-8') as f:
            respXml = f.read()
        resolveResponseXml(respXml, interfaceName, interfaceApi)

def mkOutputPath():
    cfq = 'doc2cls/forward/req'
    cfp = 'doc2cls/forward/resp'
    cb = 'doc2cls/backward'
    xq = 'doc2cls/xml/req'
    xp = 'doc2cls/xml/resp'

    if not os.path.exists(cfq):
        os.makedirs(cfq)
    if not os.path.exists(cfp):
        os.makedirs(cfp)
    if not os.path.exists(cb):
        os.makedirs(cb)
    if not os.path.exists(xq):
        os.makedirs(xq)
    if not os.path.exists(xp):
        os.makedirs(xp)

if __name__ == '__main__':
    tip = '''Usage:
    python doc2cls_cs.py [arguments...]
Arguments:
    --path  指定奇门文档的路径
    --nresolve  不从docx文档开始解析，直接从上次生成的xml文件生成实体，默认每次都从docx文档开始解析
    --attr  生成字段的校验特性，如必填字段[Required], string类型字段[MaxLength(50)]，默认不生成校验特性
Demo:
    python doc2cls_cs.py --path D:/document/api.docx :从api.docx文档开始解析，并且不生成字段校验特性
    python doc2cls_cs.py --nresolve --attr :从已生成的xml文件开始解析，并且生成字段校验特性'''
    # docPath = 'data/api.docx'
    if len(sys.argv) == 1:
        print(tip)
        sys.exit()
    docPath = ''
    needResolveDoc = True
    needAttribute = False
    i = 0
    args = sys.argv[1:]
    while i < len(args):
        p = args[i]
        if p == '--path':
            i += 1
            docPath = args[i]
        elif p == '--nresolve':
            needResolveDoc = False
        elif p == '--attr':
            needAttribute = True
        i += 1

    if needResolveDoc and not os.path.exists(docPath):
        print('指定的文档路径不存在')
        sys.exit()
    mkOutputPath()
    # main(docPath, False)
    doSteps(docPath, needResolveDoc, needAttribute)