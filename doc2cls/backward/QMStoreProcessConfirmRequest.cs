using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 仓内加工单确认接口
/// storeprocess.confirm
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMStoreProcessConfirmRequest
{
/// <summary>
/// 加工单编码
/// </summary>
[XmlElement("processOrderCode", typeof(string))]
public string ProcessOrderCode { get; set; }
/// <summary>
/// 仓储系统加工单ID
/// </summary>
[XmlElement("processOrderId", typeof(string))]
public string ProcessOrderId { get; set; }
/// <summary>
/// 外部业务编码, 一个合作伙伴中要求唯一多次确认时, 每次传入要求唯一 (一般传入WMS损益单据编码) 
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 单据类型 ,CNJG=仓内加工作业单
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 加工单完成时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("orderCompleteTime", typeof(string))]
public string OrderCompleteTime { get; set; }
/// <summary>
/// 实际作业总数量
/// </summary>
[XmlElement("actualQty", typeof(string))]
public string ActualQty { get; set; }

[XmlElement("extendProps", typeof(QMStoreProcessConfirmRequestExtendProps))]
public QMStoreProcessConfirmRequestExtendProps ExtendProps {get; set;}
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }

[XmlArray("materialitems")]
[XmlArrayItem("item", typeof(QMStoreProcessConfirmRequestItem))]
public QMStoreProcessConfirmRequestItem[] Materialitems {get; set;}

[XmlArray("productitems")]
[XmlArrayItem("item", typeof(QMStoreProcessConfirmRequestItem))]
public QMStoreProcessConfirmRequestItem[] Productitems {get; set;}
}
[Serializable]
public class QMStoreProcessConfirmRequestExtendProps
{
/// <summary>
/// value1
/// </summary>
[XmlElement("key1", typeof(string))]
public string Key1 { get; set; }
/// <summary>
/// value2
/// </summary>
[XmlElement("key2", typeof(string))]
public string Key2 { get; set; }
}
[Serializable]
public class QMStoreProcessConfirmRequestItem
{
/// <summary>
/// 商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 仓储系统商品ID
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP,
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 数量
/// </summary>
[XmlElement("quantity", typeof(string))]
public string Quantity { get; set; }
/// <summary>
/// 商品生产日期 YYYY-MM-DD
/// </summary>
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期YYYY-MM-DD
/// </summary>
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMStoreProcessConfirmRequestItem
{
/// <summary>
/// 商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 仓储系统商品ID
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP,
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 数量
/// </summary>
[XmlElement("quantity", typeof(string))]
public string Quantity { get; set; }
/// <summary>
/// 商品生产日期 YYYY-MM-DD
/// </summary>
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期YYYY-MM-DD
/// </summary>
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
}
