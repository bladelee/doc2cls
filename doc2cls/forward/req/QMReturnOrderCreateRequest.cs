using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 退货入库单创建接口
/// taobao.qimen.returnorder.create
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMReturnOrderCreateRequest
{

[XmlElement("returnOrder", typeof(QMReturnOrderCreateRequestReturnOrder))]
public QMReturnOrderCreateRequestReturnOrder ReturnOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMReturnOrderCreateRequestOrderLine))]
public QMReturnOrderCreateRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMReturnOrderCreateRequestReturnOrder
{
/// <summary>
/// ERP的退货入库单编码
/// </summary>
[Required]
[Description("ERP的退货入库单编码")]
[MaxLength(50)]
[XmlElement("returnOrderCode", typeof(string))]
public string ReturnOrderCode { get; set; }
/// <summary>
/// 仓库编码,统仓统配等无需ERP指定仓储编码的情况填OTHER
/// </summary>
[Required]
[Description("仓库编码")]
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 单据类型,THRK=退货入库,HHRK=换货入库   (只传英文编码)
/// </summary>
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 用字符串格式来表示订单标记列表：比如VISIT^ SELLER_AFFORD^SYNC_RETURN_BILL 等, 中间用“^”来隔开 订单标记list (所有字母全部大写) ： VISIT=上门;SELLER_AFFORD=是否卖家承担运费 (默认是) ;SYNC_RETURN_BILL=同时退回发票;
/// </summary>
[MaxLength(50)]
[XmlElement("orderFlag", typeof(string))]
public string OrderFlag { get; set; }
/// <summary>
/// 原出库单号(ERP分配)
/// </summary>
[Required]
[Description("原出库单号")]
[MaxLength(50)]
[XmlElement("preDeliveryOrderCode", typeof(string))]
public string PreDeliveryOrderCode { get; set; }
/// <summary>
/// 原出库单号(WMS分配)
/// </summary>
[Required]
[Description("原出库单号")]
[MaxLength(50)]
[XmlElement("preDeliveryOrderId", typeof(string))]
public string PreDeliveryOrderId { get; set; }
/// <summary>
/// 物流公司编码, SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通  、ZTO=中通 (ZTO) 、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递  、QFKD=全峰、FAST=快捷、POSTB=邮政小包  、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、OTHER=其他,  (只传英文编码)
/// </summary>
[Required]
[Description("物流公司编码")]
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
/// 退货原因
/// </summary>
[MaxLength(200)]
[XmlElement("returnReason", typeof(string))]
public string ReturnReason { get; set; }
/// <summary>
/// 买家昵称
/// </summary>
[MaxLength(50)]
[XmlElement("buyerNick", typeof(string))]
public string BuyerNick { get; set; }

[XmlElement("senderInfo", typeof(QMReturnOrderCreateRequestReturnOrderSenderInfo))]
public QMReturnOrderCreateRequestReturnOrderSenderInfo SenderInfo {get; set;}
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMReturnOrderCreateRequestReturnOrderSenderInfo
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
}
[Serializable]
public class QMReturnOrderCreateRequestOrderLine
{
/// <summary>
/// 单据行号
/// </summary>
[MaxLength(50)]
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
/// <summary>
/// 交易平台订单
/// </summary>
[MaxLength(50)]
[XmlElement("sourceOrderCode", typeof(string))]
public string SourceOrderCode { get; set; }
/// <summary>
/// 交易平台子订单编码
/// </summary>
[MaxLength(50)]
[XmlElement("subSourceOrderCode", typeof(string))]
public string SubSourceOrderCode { get; set; }
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
/// 仓储系统商品编码,条件为提供后端(仓储系统)商品编码的仓储系统
/// </summary>
[Required]
[Description("仓储系统商品编码")]
[MaxLength(50)]
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, 默认为ZP,
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 应收商品数量
/// </summary>
[Required]
[Description("应收商品数量")]
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[MaxLength(50)]
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 生产日期, YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 过期日期, YYYY-MM-DD
/// </summary>
[MaxLength(10)]
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
