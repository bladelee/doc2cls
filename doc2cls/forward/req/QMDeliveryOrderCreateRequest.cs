using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 发货单创建接口
/// taobao.qimen.deliveryorder.create
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMDeliveryOrderCreateRequest
{

[XmlElement("deliveryOrder", typeof(QMDeliveryOrderCreateRequestDeliveryOrder))]
public QMDeliveryOrderCreateRequestDeliveryOrder DeliveryOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMDeliveryOrderCreateRequestOrderLine))]
public QMDeliveryOrderCreateRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMDeliveryOrderCreateRequestDeliveryOrder
{
/// <summary>
/// 出库单号
/// </summary>
[Required]
[Description("出库单号")]
[MaxLength(50)]
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 原出库单号(ERP分配),条件为换货出库
/// </summary>
[Required]
[Description("原出库单号")]
[MaxLength(50)]
[XmlElement("preDeliveryOrderCode", typeof(string))]
public string PreDeliveryOrderCode { get; set; }
/// <summary>
/// 原出库单号(WMS分配),条件为换货出库
/// </summary>
[Required]
[Description("原出库单号")]
[MaxLength(50)]
[XmlElement("preDeliveryOrderId", typeof(string))]
public string PreDeliveryOrderId { get; set; }
/// <summary>
/// 出库单类型, JYCK=一般交易出库单, HHCK=换货出库单, BFCK=补发出库单,QTCK=其他出库单
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
/// 订单标记 ,用字符串格式来表示订单标记列表： 比如COD, 中间用“^”来隔开, COD =货到付款 , LIMIT=限时配送 , PRESELL=预售 , COMPLAIN=已投诉 , SPLIT=拆单,  EXCHANGE=换货,  VISIT=上门 ,  MODIFYTRANSPORT=是否可改配送方式,  是否可改配送方式 默认可更改 , CONSIGN =物流宝代理发货, 自动更改发货状态 SELLER_AFFORD =是否卖家承担运费 默认是, 即没 ,  FENXIAO=分销订单
/// </summary>
[MaxLength(200)]
[XmlElement("orderFlag", typeof(string))]
public string OrderFlag { get; set; }
/// <summary>
/// 订单来源平台编码,TB= 淘宝 、TM=天猫 、JD=京东、DD=当当、PP=拍拍、YX=易讯、EBAY=ebay、QQ=QQ网购、AMAZON=亚马逊、SN=苏宁、GM=国美、WPH=唯品会、JM=聚美、LF=乐蜂、MGJ=蘑菇街、JS=聚尚、PX=拍鞋、YT=银泰、YHD=1号店、VANCL=凡客、YL=邮乐、YG=优购、1688=阿里巴巴、POS=POS门店、OTHER=其他,  (只传英文编码)
/// </summary>
[Required]
[Description("订单来源平台编码")]
[MaxLength(50)]
[XmlElement("sourcePlatformCode", typeof(string))]
public string SourcePlatformCode { get; set; }
/// <summary>
/// 订单来源平台名称
/// </summary>
[MaxLength(200)]
[XmlElement("sourcePlatformName", typeof(string))]
public string SourcePlatformName { get; set; }
/// <summary>
/// 发货单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[Required]
[Description("发货单创建时间")]
[MaxLength(19)]
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
/// <summary>
/// 前台订单 (店铺订单) 创建时间 (下单时间) , YYYY-MM-DD HH:MM:SS
/// </summary>
[Required]
[Description("前台订单")]
[MaxLength(19)]
[XmlElement("placeOrderTime", typeof(string))]
public string PlaceOrderTime { get; set; }
/// <summary>
/// 订单支付时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("payTime", typeof(string))]
public string PayTime { get; set; }
/// <summary>
/// 支付平台交易号, 淘系订单传支付宝交易号
/// </summary>
[MaxLength(50)]
[XmlElement("payNo", typeof(string))]
public string PayNo { get; set; }
/// <summary>
/// 操作员 (审核员) 编码
/// </summary>
[MaxLength(50)]
[XmlElement("operatorCode", typeof(string))]
public string OperatorCode { get; set; }
/// <summary>
/// 操作员 (审核员) 名称
/// </summary>
[MaxLength(50)]
[XmlElement("operatorName", typeof(string))]
public string OperatorName { get; set; }
/// <summary>
/// 操作 (审核) 时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[Required]
[Description("操作")]
[MaxLength(19)]
[XmlElement("operateTime", typeof(string))]
public string OperateTime { get; set; }
/// <summary>
/// 店铺名称
/// </summary>
[Required]
[Description("店铺名称")]
[MaxLength(200)]
[XmlElement("shopNick", typeof(string))]
public string ShopNick { get; set; }
/// <summary>
/// 卖家名称
/// </summary>
[MaxLength(200)]
[XmlElement("sellerNick", typeof(string))]
public string SellerNick { get; set; }
/// <summary>
/// 买家昵称
/// </summary>
[MaxLength(200)]
[XmlElement("buyerNick", typeof(string))]
public string BuyerNick { get; set; }
/// <summary>
/// 订单总金额 (元) , 订单总金额=应收金额+已收金额=商品总金额-订单折扣金额+快递费用
/// </summary>
[XmlElement("totalAmount", typeof(double?), IsNullable = true)]
public double? TotalAmount { get; set; }
/// <summary>
/// 商品总金额 (元) 
/// </summary>
[XmlElement("itemAmount", typeof(double?), IsNullable = true)]
public double? ItemAmount { get; set; }
/// <summary>
/// 订单折扣金额 (元) 
/// </summary>
[XmlElement("discountAmount", typeof(double?), IsNullable = true)]
public double? DiscountAmount { get; set; }
/// <summary>
/// 快递费用 (元) 
/// </summary>
[XmlElement("freight", typeof(double?), IsNullable = true)]
public double? Freight { get; set; }
/// <summary>
/// 应收金额 (元) , 消费者还需要支付多少(货到付款时消费者还需要支付多少约定使用这个字段)
/// </summary>
[XmlElement("arAmount", typeof(double?), IsNullable = true)]
public double? ArAmount { get; set; }
/// <summary>
/// 已收金额 (元) , 消费者已经支付多少
/// </summary>
[XmlElement("gotAmount", typeof(double?), IsNullable = true)]
public double? GotAmount { get; set; }
/// <summary>
/// COD服务费
/// </summary>
[XmlElement("serviceFee", typeof(double?), IsNullable = true)]
public double? ServiceFee { get; set; }
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
/// 快递区域编码, 大头笔信息
/// </summary>
[MaxLength(50)]
[XmlElement("logisticsAreaCode", typeof(string))]
public string LogisticsAreaCode { get; set; }

[XmlElement("deliveryRequirements", typeof(QMDeliveryOrderCreateRequestDeliveryOrderDeliveryRequirements))]
public QMDeliveryOrderCreateRequestDeliveryOrderDeliveryRequirements DeliveryRequirements {get; set;}

[XmlElement("senderInfo", typeof(QMDeliveryOrderCreateRequestDeliveryOrderSenderInfo))]
public QMDeliveryOrderCreateRequestDeliveryOrderSenderInfo SenderInfo {get; set;}

[XmlElement("receiverInfo", typeof(QMDeliveryOrderCreateRequestDeliveryOrderReceiverInfo))]
public QMDeliveryOrderCreateRequestDeliveryOrderReceiverInfo ReceiverInfo {get; set;}
/// <summary>
/// 是否紧急, Y/N, 默认为N
/// </summary>
[MaxLength(1)]
[XmlElement("isUrgency", typeof(string))]
public string IsUrgency { get; set; }
/// <summary>
/// 是否需要发票, Y/N, 默认为N
/// </summary>
[MaxLength(1)]
[XmlElement("invoiceFlag", typeof(string))]
public string InvoiceFlag { get; set; }

[XmlArray("invoices")]
[XmlArrayItem("invoice", typeof(QMDeliveryOrderCreateRequestDeliveryOrderInvoice))]
public QMDeliveryOrderCreateRequestDeliveryOrderInvoice[] Invoices {get; set;}
/// <summary>
/// 是否需要保险, Y/N, 默认为N
/// </summary>
[MaxLength(1)]
[XmlElement("insuranceFlag", typeof(string))]
public string InsuranceFlag { get; set; }

[XmlElement("insurance", typeof(QMDeliveryOrderCreateRequestDeliveryOrderInsurance))]
public QMDeliveryOrderCreateRequestDeliveryOrderInsurance Insurance {get; set;}
/// <summary>
/// 买家留言
/// </summary>
[MaxLength(500)]
[XmlElement("buyerMessage", typeof(string))]
public string BuyerMessage { get; set; }
/// <summary>
/// 卖家留言
/// </summary>
[MaxLength(500)]
[XmlElement("sellerMessage", typeof(string))]
public string SellerMessage { get; set; }
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMDeliveryOrderCreateRequestDeliveryOrderDeliveryRequirements
{
/// <summary>
/// 投递时延要求, 1=工作日,2=节假日,101=当日达,102=次晨达,103=次日达, 104=预约达
/// </summary>
[XmlElement("scheduleType", typeof(int?), IsNullable = true)]
public int? ScheduleType { get; set; }
/// <summary>
/// 要求送达日期, YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("scheduleDay", typeof(string))]
public string ScheduleDay { get; set; }
/// <summary>
/// 投递时间范围要求 (开始时间) , HH:MM:SS
/// </summary>
[MaxLength(8)]
[XmlElement("scheduleStartTime", typeof(string))]
public string ScheduleStartTime { get; set; }
/// <summary>
/// 投递时间范围要求 (结束时间) , HH:MM:SS
/// </summary>
[MaxLength(8)]
[XmlElement("scheduleEndTime", typeof(string))]
public string ScheduleEndTime { get; set; }
/// <summary>
/// 发货服务类型,PTPS(普通配送),LLPS(冷链配送)
/// </summary>
[MaxLength(50)]
[XmlElement("deliveryType", typeof(string))]
public string DeliveryType { get; set; }
}
[Serializable]
public class QMDeliveryOrderCreateRequestDeliveryOrderSenderInfo
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
public class QMDeliveryOrderCreateRequestDeliveryOrderReceiverInfo
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
public class QMDeliveryOrderCreateRequestDeliveryOrderInvoice
{
/// <summary>
/// 发票类型, INVOICE=普通发票,VINVOICE=增值税普通发票, EVINVOICE=电子增票
/// </summary>
[Required]
[Description("发票类型")]
[MaxLength(50)]
[XmlElement("type", typeof(string))]
public string Type { get; set; }
/// <summary>
/// 发票抬头,  (条件为invoiceFlag为Y)
/// </summary>
[MaxLength(200)]
[XmlElement("header", typeof(string))]
public string Header { get; set; }
/// <summary>
/// 发票总金额,  (条件为invoiceFlag为Y)
/// </summary>
[XmlElement("amount", typeof(double?), IsNullable = true)]
public double? Amount { get; set; }
/// <summary>
/// 发票内容,不推荐使用
/// </summary>
[MaxLength(500)]
[XmlElement("content", typeof(string))]
public string Content { get; set; }

[XmlElement("detail", typeof(QMDeliveryOrderCreateRequestDeliveryOrderInvoiceDetail))]
public QMDeliveryOrderCreateRequestDeliveryOrderInvoiceDetail Detail {get; set;}
}
[Serializable]
public class QMDeliveryOrderCreateRequestDeliveryOrderInvoiceDetail
{

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMDeliveryOrderCreateRequestDeliveryOrderInvoiceDetailItem))]
public QMDeliveryOrderCreateRequestDeliveryOrderInvoiceDetailItem[] Items {get; set;}
}
[Serializable]
public class QMDeliveryOrderCreateRequestDeliveryOrderInvoiceDetailItem
{
/// <summary>
/// 商品名称
/// </summary>
[MaxLength(50)]
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 商品单位
/// </summary>
[MaxLength(50)]
[XmlElement("unit", typeof(string))]
public string Unit { get; set; }
/// <summary>
/// 商品单价
/// </summary>
[XmlElement("price", typeof(double?), IsNullable = true)]
public double? Price { get; set; }
/// <summary>
/// 数量
/// </summary>
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
/// <summary>
/// 金额
/// </summary>
[XmlElement("amount", typeof(double?), IsNullable = true)]
public double? Amount { get; set; }
}
[Serializable]
public class QMDeliveryOrderCreateRequestDeliveryOrderInsurance
{
/// <summary>
/// 保险类型
/// </summary>
[MaxLength(50)]
[XmlElement("type", typeof(string))]
public string Type { get; set; }
/// <summary>
/// 保险金额
/// </summary>
[XmlElement("amount", typeof(double?), IsNullable = true)]
public double? Amount { get; set; }
}
[Serializable]
public class QMDeliveryOrderCreateRequestOrderLine
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
/// 支付平台交易号, 淘系订单传支付宝交易号
/// </summary>
[MaxLength(50)]
[XmlElement("payNo", typeof(string))]
public string PayNo { get; set; }
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存,默认为查所有类型的库存
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 商品名称
/// </summary>
[MaxLength(200)]
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 交易平台商品编码
/// </summary>
[MaxLength(50)]
[XmlElement("extCode", typeof(string))]
public string ExtCode { get; set; }
/// <summary>
/// 应发商品数量
/// </summary>
[Required]
[Description("应发商品数量")]
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 零售价, 零售价=实际成交价+单件商品折扣金额
/// </summary>
[XmlElement("retailPrice", typeof(double?), IsNullable = true)]
public double? RetailPrice { get; set; }
/// <summary>
/// 实际成交价
/// </summary>
[Required]
[Description("实际成交价")]
[XmlElement("actualPrice", typeof(double?), IsNullable = true)]
public double? ActualPrice { get; set; }
/// <summary>
/// 单件商品折扣金额
/// </summary>
[XmlElement("discountAmount", typeof(double?), IsNullable = true)]
public double? DiscountAmount { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[MaxLength(50)]
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 生产日期,YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 过期日期,YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
}
}
