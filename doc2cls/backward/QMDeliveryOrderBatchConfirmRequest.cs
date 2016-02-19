using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 发货单确认接口  (批量)
/// deliveryorder.batchconfirm
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMDeliveryOrderBatchConfirmRequest
{

[XmlArray("orders")]
[XmlArrayItem("order", typeof(QMDeliveryOrderBatchConfirmRequestOrder))]
public QMDeliveryOrderBatchConfirmRequestOrder[] Orders {get; set;}
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrder
{

[XmlElement("deliveryOrder", typeof(QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrder))]
public QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrder DeliveryOrder {get; set;}

[XmlArray("packages")]
[XmlArrayItem("package", typeof(QMDeliveryOrderBatchConfirmRequestOrderPackage))]
public QMDeliveryOrderBatchConfirmRequestOrderPackage[] Packages {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMDeliveryOrderBatchConfirmRequestOrderOrderLine))]
public QMDeliveryOrderBatchConfirmRequestOrderOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrder
{
/// <summary>
/// 出库单号
/// </summary>
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 仓储系统出库单号
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 出库单类型,JYCK=一般交易出库,HHCK=换货出库,BFCK=补发出库,QTCK=其他出库单
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 出库单状态,  ACCEPT-仓库接单 , PARTDELIVERED-部分发货完成,  DELIVERED-发货完成,  EXCEPTION-异常,  CANCELED-取消,  CLOSED-关闭,  REJECT-拒单,  CANCELEDFAIL-取消失败) ,  (只传英文编码)
/// </summary>
[XmlElement("status", typeof(string))]
public string Status { get; set; }
/// <summary>
/// string (50) , 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,条件为一单需要多次确认, 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,条件必填,条件为一单需要多次确认时
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 支持出库单多次发货,多次发货后确认时0 表示发货单最终状态确认;1 表示发货单中间状态确认;
/// </summary>
[XmlElement("confirmType", typeof(int?), IsNullable = true)]
public int? ConfirmType { get; set; }
/// <summary>
/// 订单完成时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("orderConfirmTime", typeof(string))]
public string OrderConfirmTime { get; set; }
/// <summary>
/// 当前状态操作员编码
/// </summary>
[XmlElement("operatorCode", typeof(string))]
public string OperatorCode { get; set; }
/// <summary>
/// 当前状态操作员姓名
/// </summary>
[XmlElement("operatorName", typeof(string))]
public string OperatorName { get; set; }
/// <summary>
/// 当前状态操作时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("operateTime", typeof(string))]
public string OperateTime { get; set; }

[XmlArray("invoices")]
[XmlArrayItem("invoice", typeof(QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoice))]
public QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoice[] Invoices {get; set;}
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoice
{
/// <summary>
/// 发票抬头
/// </summary>
[XmlElement("header", typeof(string))]
public string Header { get; set; }
/// <summary>
/// 发票金额
/// </summary>
[XmlElement("amount", typeof(double?), IsNullable = true)]
public double? Amount { get; set; }
/// <summary>
/// 发票内容
/// </summary>
[XmlElement("content", typeof(string))]
public string Content { get; set; }

[XmlElement("detail", typeof(QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoiceDetail))]
public QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoiceDetail Detail {get; set;}
/// <summary>
/// 发票代码,纳税企业的标识
/// </summary>
[XmlElement("code", typeof(string))]
public string Code { get; set; }
/// <summary>
/// 发票号码,纳税企业内部的发票号
/// </summary>
[XmlElement("number", typeof(string))]
public string Number { get; set; }
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoiceDetail
{

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoiceDetailItem))]
public QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoiceDetailItem[] Items {get; set;}
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderDeliveryOrderInvoiceDetailItem
{
/// <summary>
/// 商品名称
/// </summary>
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 商品单位
/// </summary>
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
public class QMDeliveryOrderBatchConfirmRequestOrderPackage
{
/// <summary>
/// 物流公司编码, SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通  、ZTO=中通 (ZTO) 、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递  、QFKD=全峰、FAST=快捷、POSTB=邮政小包  、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、OTHER=其他,  (只传英文编码)
/// </summary>
[XmlElement("logisticsCode", typeof(string))]
public string LogisticsCode { get; set; }
/// <summary>
/// 物流公司名称
/// </summary>
[XmlElement("logisticsName", typeof(string))]
public string LogisticsName { get; set; }
/// <summary>
/// 运单号
/// </summary>
[XmlElement("expressCode", typeof(string))]
public string ExpressCode { get; set; }
/// <summary>
/// 包裹编号
/// </summary>
[XmlElement("packageCode", typeof(string))]
public string PackageCode { get; set; }
/// <summary>
/// 包裹长度 (厘米) 
/// </summary>
[XmlElement("length", typeof(double?), IsNullable = true)]
public double? Length { get; set; }
/// <summary>
/// 包裹宽度 (厘米) 
/// </summary>
[XmlElement("width", typeof(double?), IsNullable = true)]
public double? Width { get; set; }
/// <summary>
/// 包裹高度 (厘米) 
/// </summary>
[XmlElement("height", typeof(double?), IsNullable = true)]
public double? Height { get; set; }
/// <summary>
/// 包裹理论重量 (千克) 
/// </summary>
[XmlElement("theoreticalWeight", typeof(double?), IsNullable = true)]
public double? TheoreticalWeight { get; set; }
/// <summary>
/// 包裹重量 (千克) 
/// </summary>
[XmlElement("weight", typeof(double?), IsNullable = true)]
public double? Weight { get; set; }
/// <summary>
/// 包裹体积 (升, L) 
/// </summary>
[XmlElement("volume", typeof(double?), IsNullable = true)]
public double? Volume { get; set; }
/// <summary>
/// 发票号
/// </summary>
[XmlElement("invoiceNo", typeof(string))]
public string InvoiceNo { get; set; }

[XmlArray("packageMaterialList")]
[XmlArrayItem("packageMaterial", typeof(QMDeliveryOrderBatchConfirmRequestOrderPackagePackageMaterial))]
public QMDeliveryOrderBatchConfirmRequestOrderPackagePackageMaterial[] PackageMaterialList {get; set;}

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMDeliveryOrderBatchConfirmRequestOrderPackageItem))]
public QMDeliveryOrderBatchConfirmRequestOrderPackageItem[] Items {get; set;}
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderPackagePackageMaterial
{
/// <summary>
/// 包材型号
/// </summary>
[XmlElement("type", typeof(string))]
public string Type { get; set; }
/// <summary>
/// 包材的数量
/// </summary>
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderPackageItem
{
/// <summary>
/// 商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 商品仓储系统编码
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 包裹内该商品的数量
/// </summary>
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderOrderLine
{
/// <summary>
/// 单据行号
/// </summary>
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
/// <summary>
/// 平台交易订单编码
/// </summary>
[XmlElement("orderSourceCode", typeof(string))]
public string OrderSourceCode { get; set; }
/// <summary>
/// 平台交易子订单编码
/// </summary>
[XmlElement("subSourceCode", typeof(string))]
public string SubSourceCode { get; set; }
/// <summary>
/// 商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 商品仓储系统编码
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存,默认为查所有类型的库存
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 商品名称
/// </summary>
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 交易平台商品编码
/// </summary>
[XmlElement("extCode", typeof(string))]
public string ExtCode { get; set; }
/// <summary>
/// 应发商品数量
/// </summary>
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 实发商品数量
/// </summary>
[XmlElement("actualQty", typeof(int?), IsNullable = true)]
public int? ActualQty { get; set; }
/// <summary>
/// 批次编号,
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 生产日期,YYYY-MM-DD
/// </summary>
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 过期日期,YYYY-MM-DD
/// </summary>
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号,
/// </summary>
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }

[XmlArray("batchs")]
[XmlArrayItem("batch", typeof(QMDeliveryOrderBatchConfirmRequestOrderOrderLineBatch))]
public QMDeliveryOrderBatchConfirmRequestOrderOrderLineBatch[] Batchs {get; set;}
/// <summary>
/// 商品的二维码(类似电子产品的SN码),用来进行商品的溯源,多个二维码之间用分号(;)隔开
/// </summary>
[XmlElement("qrCode", typeof(string))]
public string QrCode { get; set; }
}
[Serializable]
public class QMDeliveryOrderBatchConfirmRequestOrderOrderLineBatch
{
/// <summary>
/// 批次编号
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 生产日期,YYYY-MM-DD
/// </summary>
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 过期日期,YYYY-MM-DD
/// </summary>
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号,
/// </summary>
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存,默认为查所有类型的库存
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 实发数量,要求batchs节点下所有的实发数量之和等于orderline中的实发数量
/// </summary>
[XmlElement("actualQty", typeof(int?), IsNullable = true)]
public int? ActualQty { get; set; }
}
}
