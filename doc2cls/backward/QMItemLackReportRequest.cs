using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 发货单缺货通知接口
/// itemlack.report
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMItemLackReportRequest
{
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// ERP的发货单编码
/// </summary>
[XmlElement("deliveryOrderCode", typeof(string))]
public string DeliveryOrderCode { get; set; }
/// <summary>
/// 仓库系统的发货单编码
/// </summary>
[XmlElement("deliveryOrderId", typeof(string))]
public string DeliveryOrderId { get; set; }
/// <summary>
/// 缺货回告创建时间
/// </summary>
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
/// <summary>
/// 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理,
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMItemLackReportRequestItem))]
public QMItemLackReportRequestItem[] Items {get; set;}
}
[Serializable]
public class QMItemLackReportRequestItem
{
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
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
/// 应发商品数量
/// </summary>
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 缺货商品数量
/// </summary>
[XmlElement("lackQty", typeof(int?), IsNullable = true)]
public int? LackQty { get; set; }
/// <summary>
/// 缺货原因 (系统报缺, 实物报缺) 
/// </summary>
[XmlElement("reason", typeof(string))]
public string Reason { get; set; }
}
}
