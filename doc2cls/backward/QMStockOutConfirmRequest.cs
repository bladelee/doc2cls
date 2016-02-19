using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 出库单确认接口
/// stockout.confirm
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMStockOutConfirmRequest
{

[XmlElement("deliveryOrder", typeof(QMStockOutConfirmRequestDeliveryOrder))]
public QMStockOutConfirmRequestDeliveryOrder DeliveryOrder {get; set;}

[XmlArray("packages")]
[XmlArrayItem("package", typeof(QMStockOutConfirmRequestPackage))]
public QMStockOutConfirmRequestPackage[] Packages {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMStockOutConfirmRequestOrderLine))]
public QMStockOutConfirmRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMStockOutConfirmRequestDeliveryOrder
{
/// <summary>
/// 单据总行数,当单据需要分多个请求发送时,发送方需要将totalOrderLines填入,接收方收到后,根据实际接收到的条数和totalOrderLines进行比对,如果小于,则继续等待接收请求。如果等于,则表示该单据的所有请求发送完成。
/// </summary>
[XmlElement("totalOrderLines", typeof(int?), IsNullable = true)]
public int? TotalOrderLines { get; set; }
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
/// 出库单类型,PTCK=普通出库单,DBCK=调拨出库 ,B2BCK=B2B出库,QTCK=其他出库,,CGTH=采购退货出库单
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 出库单状态,  ACCEPT-仓库接单 , PARTDELIVERED-部分发货完成,  DELIVERED-发货完成,  EXCEPTION-异常,  CANCELED-取消,  CLOSED-关闭,  REJECT-拒单,  CANCELEDFAIL-取消失败) ,  (只传英文编码)
/// </summary>
[XmlElement("status", typeof(string))]
public string Status { get; set; }
/// <summary>
/// string (50) , 外部业务编码, 外部业务编码, 同一请求的唯一性标示编码。ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,条件为一单需要多次确认, 外部业务编码, 外部业务编码, 同一请求的唯一性标示编码。ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,条件必填,条件为一单需要多次确认时
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 支持出库单多次发货,多次发货后确认时0 表示发货单最终状态确认;1 表示发货单中间状态确认;
/// </summary>
[XmlElement("confirmType", typeof(int?), IsNullable = true)]
public int? ConfirmType { get; set; }
/// <summary>
/// 物流公司编码, SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通  、ZTO=中通 (ZTO) 、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递  、QFKD=全峰、FAST=快捷、POSTB=邮政小包  、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、OTHER=其他,(只传英文编码)
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
/// 订单完成时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("orderConfirmTime", typeof(string))]
public string OrderConfirmTime { get; set; }
}
[Serializable]
public class QMStockOutConfirmRequestPackage
{
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
/// 包裹重量 (千克) 
/// </summary>
[XmlElement("weight", typeof(double?), IsNullable = true)]
public double? Weight { get; set; }
/// <summary>
/// 包裹体积 (升, L) 
/// </summary>
[XmlElement("volume", typeof(double?), IsNullable = true)]
public double? Volume { get; set; }

[XmlArray("packageMaterialList")]
[XmlArrayItem("packageMaterial", typeof(QMStockOutConfirmRequestPackagePackageMaterial))]
public QMStockOutConfirmRequestPackagePackageMaterial[] PackageMaterialList {get; set;}

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMStockOutConfirmRequestPackageItem))]
public QMStockOutConfirmRequestPackageItem[] Items {get; set;}
}
[Serializable]
public class QMStockOutConfirmRequestPackagePackageMaterial
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
public class QMStockOutConfirmRequestPackageItem
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
public class QMStockOutConfirmRequestOrderLine
{
/// <summary>
/// 外部业务编码, 消息ID, 用于去重,当单据需要分批次发送时使用
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 单据行号
/// </summary>
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
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
/// 商品名称
/// </summary>
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
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
[XmlArrayItem("batch", typeof(QMStockOutConfirmRequestOrderLineBatch))]
public QMStockOutConfirmRequestOrderLineBatch[] Batchs {get; set;}
}
[Serializable]
public class QMStockOutConfirmRequestOrderLineBatch
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP
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
