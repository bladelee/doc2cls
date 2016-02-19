using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 组合商品接口
/// taobao.qimen.combineitem.synchronize
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMCombineItemSynchronizeResponse
{
/// <summary>
/// success|failure
/// </summary>
[XmlElement("flag", typeof(string))]
public string Flag { get; set; }
/// <summary>
/// 响应码
/// </summary>
[XmlElement("code", typeof(string))]
public string Code { get; set; }
/// <summary>
/// 响应信息
/// </summary>
[XmlElement("message", typeof(string))]
public string Message { get; set; }
}
}
