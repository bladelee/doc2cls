using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 退货入库单确认接口
/// returnorder.confirm
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMReturnOrderConfirmRequest
{

[XmlElement("returnOrder", typeof(QMReturnOrderConfirmRequestReturnOrder))]
public QMReturnOrderConfirmRequestReturnOrder ReturnOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMReturnOrderConfirmRequestOrderLine))]
public QMReturnOrderConfirmRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMReturnOrderConfirmRequestReturnOrder
{
/// <summary>
/// 退货单编码
/// </summary>
[XmlElement("returnOrderCode", typeof(string))]
public string ReturnOrderCode { get; set; }
/// <summary>
/// 仓库系统订单编码
/// </summary>
[XmlElement("returnOrderId", typeof(string))]
public string ReturnOrderId { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 单据类型,THRK=退货入库单,HHRK=换货入库
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 确认入库时间,YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("orderConfirmTime", typeof(string))]
public string OrderConfirmTime { get; set; }
/// <summary>
/// 退货原因
/// </summary>
[XmlElement("returnReason", typeof(string))]
public string ReturnReason { get; set; }
/// <summary>
/// 物流公司编码, SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通  、ZTO=中通 (ZTO) 、HTKY=百世汇通、UC=优速、STO=申通、TTKDEX=天天快递  、QFKD=全峰、FAST=快捷、POSTB=邮政小包  、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、OTHER=其他, (只传英文编码)
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

[XmlElement("senderInfo", typeof(QMReturnOrderConfirmRequestReturnOrderSenderInfo))]
public QMReturnOrderConfirmRequestReturnOrderSenderInfo SenderInfo {get; set;}
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMReturnOrderConfirmRequestReturnOrderSenderInfo
{
/// <summary>
/// 公司名称
/// </summary>
[XmlElement("company", typeof(string))]
public string Company { get; set; }
/// <summary>
/// 姓名
/// </summary>
[XmlElement("name", typeof(string))]
public string Name { get; set; }
/// <summary>
/// 邮编
/// </summary>
[XmlElement("zipCode", typeof(string))]
public string ZipCode { get; set; }
/// <summary>
/// 固定电话
/// </summary>
[XmlElement("tel", typeof(string))]
public string Tel { get; set; }
/// <summary>
/// 移动电话
/// </summary>
[XmlElement("mobile", typeof(string))]
public string Mobile { get; set; }
/// <summary>
/// 电子邮箱
/// </summary>
[XmlElement("email", typeof(string))]
public string Email { get; set; }
/// <summary>
/// 国家二字码
/// </summary>
[XmlElement("countryCode", typeof(string))]
public string CountryCode { get; set; }
/// <summary>
/// 省份
/// </summary>
[XmlElement("province", typeof(string))]
public string Province { get; set; }
/// <summary>
/// 城市
/// </summary>
[XmlElement("city", typeof(string))]
public string City { get; set; }
/// <summary>
/// 区域
/// </summary>
[XmlElement("area", typeof(string))]
public string Area { get; set; }
/// <summary>
/// 村镇
/// </summary>
[XmlElement("town", typeof(string))]
public string Town { get; set; }
/// <summary>
/// 详细地址
/// </summary>
[XmlElement("detailAddress", typeof(string))]
public string DetailAddress { get; set; }
}
[Serializable]
public class QMReturnOrderConfirmRequestOrderLine
{
/// <summary>
/// 单据行号
/// </summary>
[XmlElement("orderLineNo", typeof(string))]
public string OrderLineNo { get; set; }
/// <summary>
/// 交易平台订单
/// </summary>
[XmlElement("sourceOrderCode", typeof(string))]
public string SourceOrderCode { get; set; }
/// <summary>
/// 交易平台子订单编码
/// </summary>
[XmlElement("subSourceOrderCode", typeof(string))]
public string SubSourceOrderCode { get; set; }
/// <summary>
/// 商品编码
/// </summary>
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 仓储系统商品编码
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次, JS=机损, XS=箱损, 默认为ZP
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 应收商品数量
/// </summary>
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 实收商品数量
/// </summary>
[XmlElement("actualQty", typeof(int?), IsNullable = true)]
public int? ActualQty { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 生产日期, YYYY-MM-DD
/// </summary>
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 过期日期, YYYY-MM-DD
/// </summary>
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }

[XmlArray("batchs")]
[XmlArrayItem("batch", typeof(QMReturnOrderConfirmRequestOrderLineBatch))]
public QMReturnOrderConfirmRequestOrderLineBatch[] Batchs {get; set;}
/// <summary>
/// 商品的二维码(类似电子产品的SN码),用来进行商品的溯源,多个二维码之间用分号(;)隔开
/// </summary>
[XmlElement("qrCode", typeof(string))]
public string QrCode { get; set; }
}
[Serializable]
public class QMReturnOrderConfirmRequestOrderLineBatch
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
/// 库存类型, ZP=正品, CC=残次, JS=机损, XS=箱损, 默认为ZP
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 实收数量,要求batchs节点下所有的实收数量之和等于orderline中的实收数量
/// </summary>
[XmlElement("actualQty", typeof(int?), IsNullable = true)]
public int? ActualQty { get; set; }
}
}
