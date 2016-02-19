using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 菜鸟自动流转查询接口  （扩展）
/// taobao.qimen.autotransfer.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMAutoTransferQueryRequest
{
/// <summary>
/// 交易平台订单编码
/// </summary>
[MaxLength(50)]
[XmlElement("orderSourceCode", typeof(string))]
public string OrderSourceCode { get; set; }
}
}
