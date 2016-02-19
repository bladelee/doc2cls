using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 出库单创建接口
/// taobao.qimen.stockout.create
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMStockOutCreateRequest
{

[XmlElement("deliveryOrder", typeof(QMStockOutCreateRequestDeliveryOrder))]
public QMStockOutCreateRequestDeliveryOrder DeliveryOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMStockOutCreateRequestOrderLine))]
public QMStockOutCreateRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMStockOutCreateRequestDeliveryOrder
{
/// <summary>
/// 单据总行数,当单据需要分多个请求发送时,发送方需要将totalOrderLines填入,接收方收到后,根据实际接收到的条数和totalOrderLines进行比对,如果小于,则继续等待接收请求。如果等于,则表示该单据的所有请求发送完成。
/// </summary>
[XmlElement("totalOrderLines", typeof(int?), IsNullable = true)]
public int? TotalOrderLines { get; set; }
/// <summary>
/// 出库单号(ERP分配)
/// </summary>
[Required]
[Description("出库单号")]
[MaxLength(50)]
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 出库单类型, PTCK=普通出库单,DBCK=调拨出库 ,B2BCK=B2B出库,QTCK=其他出库,CGTH=采购退货出库单
/// </summary>
[Required]
[Description("出库单类型")]
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 仓库编码,统仓统配等无需ERP指定仓储编码的情况填OTHER
/// </summary>
[Required]
[Description("仓库编码")]
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 出库单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[Required]
[Description("出库单创建时间")]
[MaxLength(19)]
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
/// <summary>
/// 要求出库时间, YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("scheduleDate", typeof(string))]
public string ScheduleDate { get; set; }
/// <summary>
/// 物流公司编码, SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通  、ZTO=中通 (ZTO) 、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递  、QFKD=全峰、FAST=快捷、POSTB=邮政小包  、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、OTHER=其他 ,(只传英文编码)
/// </summary>
[MaxLength(50)]
[XmlElement("logisticsCode", typeof(string))]
public string LogisticsCode { get; set; }
/// <summary>
/// 物流公司名称(包括干线物流公司等)
/// </summary>
[MaxLength(200)]
[XmlElement("logisticsName", typeof(string))]
public string LogisticsName { get; set; }
/// <summary>
/// 提货方式(到仓自提,快递,干线物流)
/// </summary>
[MaxLength(50)]
[XmlElement("transportMode", typeof(string))]
public string TransportMode { get; set; }

[XmlElement("pickerInfo", typeof(QMStockOutCreateRequestDeliveryOrderPickerInfo))]
public QMStockOutCreateRequestDeliveryOrderPickerInfo PickerInfo {get; set;}

[XmlElement("senderInfo", typeof(QMStockOutCreateRequestDeliveryOrderSenderInfo))]
public QMStockOutCreateRequestDeliveryOrderSenderInfo SenderInfo {get; set;}

[XmlElement("receiverInfo", typeof(QMStockOutCreateRequestDeliveryOrderReceiverInfo))]
public QMStockOutCreateRequestDeliveryOrderReceiverInfo ReceiverInfo {get; set;}
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMStockOutCreateRequestDeliveryOrderPickerInfo
{
/// <summary>
/// 公司名称
/// </summary>
[MaxLength(200)]
[XmlElement("company", typeof(string))]
public string Company { get; set; }
/// <summary>
/// 姓名
/// </summary>
[MaxLength(50)]
[XmlElement("name", typeof(string))]
public string Name { get; set; }
/// <summary>
/// 固定电话
/// </summary>
[MaxLength(50)]
[XmlElement("tel", typeof(string))]
public string Tel { get; set; }
/// <summary>
/// 移动电话
/// </summary>
[MaxLength(50)]
[XmlElement("mobile", typeof(string))]
public string Mobile { get; set; }
/// <summary>
/// 证件号
/// </summary>
[MaxLength(50)]
[XmlElement("id", typeof(string))]
public string Id { get; set; }
/// <summary>
/// 车牌号
/// </summary>
[MaxLength(50)]
[XmlElement("carNo", typeof(string))]
public string CarNo { get; set; }
}
[Serializable]
public class QMStockOutCreateRequestDeliveryOrderSenderInfo
{
/// <summary>
/// 公司名称
/// </summary>
[MaxLength(200)]
[XmlElement("company", typeof(string))]
public string Company { get; set; }
/// <summary>
/// 姓名,
/// </summary>
[MaxLength(50)]
[XmlElement("name", typeof(string))]
public string Name { get; set; }
/// <summary>
/// 邮编
/// </summary>
[MaxLength(50)]
[XmlElement("zipCode", typeof(string))]
public string ZipCode { get; set; }
/// <summary>
/// 固定电话
/// </summary>
[MaxLength(50)]
[XmlElement("tel", typeof(string))]
public string Tel { get; set; }
/// <summary>
/// 移动电话,
/// </summary>
[MaxLength(50)]
[XmlElement("mobile", typeof(string))]
public string Mobile { get; set; }
/// <summary>
/// 电子邮箱
/// </summary>
[MaxLength(50)]
[XmlElement("email", typeof(string))]
public string Email { get; set; }
/// <summary>
/// 国家二字码
/// </summary>
[MaxLength(50)]
[XmlElement("countryCode", typeof(string))]
public string CountryCode { get; set; }
/// <summary>
/// 省份,
/// </summary>
[MaxLength(50)]
[XmlElement("province", typeof(string))]
public string Province { get; set; }
/// <summary>
/// 城市,
/// </summary>
[MaxLength(50)]
[XmlElement("city", typeof(string))]
public string City { get; set; }
/// <summary>
/// 区域
/// </summary>
[MaxLength(50)]
[XmlElement("area", typeof(string))]
public string Area { get; set; }
/// <summary>
/// 村镇
/// </summary>
[MaxLength(50)]
[XmlElement("town", typeof(string))]
public string Town { get; set; }
/// <summary>
/// 详细地址
/// </summary>
[MaxLength(200)]
[XmlElement("detailAddress", typeof(string))]
public string DetailAddress { get; set; }
/// <summary>
/// 证件号
/// </summary>
[MaxLength(50)]
[XmlElement("id", typeof(string))]
public string Id { get; set; }
}
[Serializable]
public class QMStockOutCreateRequestDeliveryOrderReceiverInfo
{
/// <summary>
/// 公司名称
/// </summary>
[MaxLength(200)]
[XmlElement("company", typeof(string))]
public string Company { get; set; }
/// <summary>
/// 姓名(注：当出库为调拨出库时,这里填写为目标仓库编码)
/// </summary>
[Required]
[Description("姓名")]
[MaxLength(50)]
[XmlElement("name", typeof(string))]
public string Name { get; set; }
/// <summary>
/// 邮编
/// </summary>
[MaxLength(50)]
[XmlElement("zipCode", typeof(string))]
public string ZipCode { get; set; }
/// <summary>
/// 固定电话
/// </summary>
[MaxLength(50)]
[XmlElement("tel", typeof(string))]
public string Tel { get; set; }
/// <summary>
/// 移动电话
/// </summary>
[Required]
[Description("移动电话")]
[MaxLength(50)]
[XmlElement("mobile", typeof(string))]
public string Mobile { get; set; }
/// <summary>
/// 电子邮箱
/// </summary>
[MaxLength(50)]
[XmlElement("email", typeof(string))]
public string Email { get; set; }
/// <summary>
/// 国家二字码
/// </summary>
[MaxLength(50)]
[XmlElement("countryCode", typeof(string))]
public string CountryCode { get; set; }
/// <summary>
/// 省份
/// </summary>
[Required]
[Description("省份")]
[MaxLength(50)]
[XmlElement("province", typeof(string))]
public string Province { get; set; }
/// <summary>
/// 城市
/// </summary>
[Required]
[Description("城市")]
[MaxLength(50)]
[XmlElement("city", typeof(string))]
public string City { get; set; }
/// <summary>
/// 区域
/// </summary>
[MaxLength(50)]
[XmlElement("area", typeof(string))]
public string Area { get; set; }
/// <summary>
/// 村镇
/// </summary>
[MaxLength(50)]
[XmlElement("town", typeof(string))]
public string Town { get; set; }
/// <summary>
/// 详细地址
/// </summary>
[Required]
[Description("详细地址")]
[MaxLength(200)]
[XmlElement("detailAddress", typeof(string))]
public string DetailAddress { get; set; }
/// <summary>
/// 证件号
/// </summary>
[MaxLength(50)]
[XmlElement("id", typeof(string))]
public string Id { get; set; }
}
[Serializable]
public class QMStockOutCreateRequestOrderLine
{
/// <summary>
/// 外部业务编码, 消息ID, 用于去重,当单据需要分批次发送时使用
/// </summary>
[MaxLength(50)]
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 单据行号
/// </summary>
[MaxLength(50)]
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[Required]
[Description("货主编码")]
[MaxLength(50)]
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 商品编码
/// </summary>
[Required]
[Description("商品编码")]
[MaxLength(50)]
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 仓储系统商品编码
/// </summary>
[Required]
[Description("仓储系统商品编码")]
[MaxLength(50)]
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 商品名称
/// </summary>
[MaxLength(200)]
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 应发商品数量
/// </summary>
[Required]
[Description("应发商品数量")]
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[MaxLength(50)]
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 商品生产日期 YYYY-MM-DD
/// </summary>
[MaxLength(50)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期YYYY-MM-DD
/// </summary>
[MaxLength(50)]
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[MaxLength(50)]
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
}
}
