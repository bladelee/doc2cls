using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 入库单创建接口
/// taobao.qimen.entryorder.create
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMEntryOrderCreateRequest
{

[XmlElement("entryOrder", typeof(QMEntryOrderCreateRequestEntryOrder))]
public QMEntryOrderCreateRequestEntryOrder EntryOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMEntryOrderCreateRequestOrderLine))]
public QMEntryOrderCreateRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMEntryOrderCreateRequestEntryOrder
{
/// <summary>
/// 单据总行数,当单据需要分多个请求发送时,发送方需要将totalOrderLines填入,接收方收到后,根据实际接收到的条数和totalOrderLines进行比对,如果小于,则继续等待接收请求。如果等于,则表示该单据的所有请求发送完成。
/// </summary>
[XmlElement("totalOrderLines", typeof(int?), IsNullable = true)]
public int? TotalOrderLines { get; set; }
/// <summary>
/// 入库单号
/// </summary>
[Required]
[Description("入库单号")]
[MaxLength(50)]
[XmlElement("entryOrderCode", typeof(string))]
public string EntryOrderCode { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[Required]
[Description("货主编码")]
[MaxLength(50)]
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 采购单号,当orderType=CGRK时,使用
/// </summary>
[MaxLength(50)]
[XmlElement("purchaseOrderCode", typeof(string))]
public string PurchaseOrderCode { get; set; }
/// <summary>
/// 仓库编码,统仓统配等无需ERP指定仓储编码的情况填OTHER
/// </summary>
[Required]
[Description("仓库编码")]
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 订单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("orderCreateTime", typeof(string))]
public string OrderCreateTime { get; set; }
/// <summary>
/// 业务类型 (SCRK=生产入库,LYRK=领用入库,CCRK=残次品入库,CGRK=采购入库,DBRK=调拨入库, QTRK=其他入库,B2BRK=B2B入库,  (只传英文编码)
/// </summary>
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 预期到货时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("expectStartTime", typeof(string))]
public string ExpectStartTime { get; set; }
/// <summary>
/// 最迟预期到货时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("expectEndTime", typeof(string))]
public string ExpectEndTime { get; set; }
/// <summary>
/// 物流公司编码, SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通  、ZTO=中通 (ZTO) 、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递  、QFKD=全峰、FAST=快捷、POSTB=邮政小包  、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、OTHER=其他(只传英文编码)
/// </summary>
[MaxLength(50)]
[XmlElement("logisticsCode", typeof(string))]
public string LogisticsCode { get; set; }
/// <summary>
/// 物流公司名称
/// </summary>
[MaxLength(200)]
[XmlElement("logisticsName", typeof(string))]
public string LogisticsName { get; set; }
/// <summary>
/// 运单号
/// </summary>
[MaxLength(50)]
[XmlElement("expressCode", typeof(string))]
public string ExpressCode { get; set; }
/// <summary>
/// 供应商编码 string (50
/// </summary>
[MaxLength(50)]
[XmlElement("supplierCode", typeof(string))]
public string SupplierCode { get; set; }
/// <summary>
/// 供应商名称 string (200
/// </summary>
[MaxLength(200)]
[XmlElement("supplierName", typeof(string))]
public string SupplierName { get; set; }
/// <summary>
/// 操作员编码
/// </summary>
[MaxLength(50)]
[XmlElement("operatorCode", typeof(string))]
public string OperatorCode { get; set; }
/// <summary>
/// 操作员名称
/// </summary>
[MaxLength(50)]
[XmlElement("operatorName", typeof(string))]
public string OperatorName { get; set; }
/// <summary>
/// 操作时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("operateTime", typeof(string))]
public string OperateTime { get; set; }

[XmlElement("senderInfo", typeof(QMEntryOrderCreateRequestEntryOrderSenderInfo))]
public QMEntryOrderCreateRequestEntryOrderSenderInfo SenderInfo {get; set;}

[XmlElement("receiverInfo", typeof(QMEntryOrderCreateRequestEntryOrderReceiverInfo))]
public QMEntryOrderCreateRequestEntryOrderReceiverInfo ReceiverInfo {get; set;}
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }

[XmlElement("extendProps", typeof(QMEntryOrderCreateRequestEntryOrderExtendProps))]
public QMEntryOrderCreateRequestEntryOrderExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMEntryOrderCreateRequestEntryOrderSenderInfo
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
[MaxLength(50)]
[XmlElement("province", typeof(string))]
public string Province { get; set; }
/// <summary>
/// 城市
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
}
[Serializable]
public class QMEntryOrderCreateRequestEntryOrderReceiverInfo
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
[MaxLength(50)]
[XmlElement("province", typeof(string))]
public string Province { get; set; }
/// <summary>
/// 城市
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
}
[Serializable]
public class QMEntryOrderCreateRequestEntryOrderExtendProps
{
/// <summary>
/// value1
/// </summary>
[MaxLength(50)]
[XmlElement("key1", typeof(string))]
public string Key1 { get; set; }
/// <summary>
/// value2
/// </summary>
[MaxLength(50)]
[XmlElement("key2", typeof(string))]
public string Key2 { get; set; }
}
[Serializable]
public class QMEntryOrderCreateRequestOrderLine
{
/// <summary>
/// 外部业务编码, 消息ID, 用于去重,当单据需要分批次发送时使用
/// </summary>
[MaxLength(50)]
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 入库单的行号
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
/// 仓储系统商品ID
/// </summary>
[Required]
[Description("仓储系统商品ID")]
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
/// 应收商品数量
/// </summary>
[Required]
[Description("应收商品数量")]
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 商品属性
/// </summary>
[MaxLength(200)]
[XmlElement("skuProperty", typeof(string))]
public string SkuProperty { get; set; }
/// <summary>
/// 采购价
/// </summary>
[XmlElement("purchasePrice", typeof(double?), IsNullable = true)]
public double? PurchasePrice { get; set; }
/// <summary>
/// 零售价
/// </summary>
[XmlElement("retailPrice", typeof(double?), IsNullable = true)]
public double? RetailPrice { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
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
/// <summary>
/// 批次编码
/// </summary>
[MaxLength(50)]
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }

[XmlElement("extendProps", typeof(QMEntryOrderCreateRequestOrderLineExtendProps))]
public QMEntryOrderCreateRequestOrderLineExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMEntryOrderCreateRequestOrderLineExtendProps
{
/// <summary>
/// value1
/// </summary>
[MaxLength(50)]
[XmlElement("key1", typeof(string))]
public string Key1 { get; set; }
/// <summary>
/// value2
/// </summary>
[MaxLength(50)]
[XmlElement("key2", typeof(string))]
public string Key2 { get; set; }
}
}
