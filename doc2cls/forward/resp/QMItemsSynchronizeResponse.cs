using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 商品同步接口 (批量)
/// taobao.qimen.items.synchronize
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMItemsSynchronizeResponse
{
/// <summary>
/// success|failure,只要有一个失败flag就置为failure,如果是success,就忽略下面的items节点
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

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMItemsSynchronizeResponseItem))]
public QMItemsSynchronizeResponseItem[] Items {get; set;}
}
[Serializable]
public class QMItemsSynchronizeResponseItem
{
/// <summary>
/// 没有同步成功的商品的编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 出错信息
/// </summary>
[XmlElement("message", typeof(string))]
public string Message { get; set; }
}
}
