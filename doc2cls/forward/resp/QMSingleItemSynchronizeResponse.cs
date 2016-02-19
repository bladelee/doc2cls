using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 商品同步接口
/// taobao.qimen.singleitem.synchronize
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMSingleItemSynchronizeResponse
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
/// <summary>
/// 仓储系统商品Id, 当这个字段不为空的时候, 所有erp传输的时候都碰到itemid必传
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
}
}
