using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 店铺同步接口
/// taobao.qimen.shop.synchronize
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMShopSynchronizeResponse
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
}
}
