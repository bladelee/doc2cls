using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 库存盘点通知接口
/// inventory.report
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMInventoryReportRequest
{
/// <summary>
/// 总页数
/// </summary>
[XmlElement("totalPage", typeof(int?), IsNullable = true)]
public int? TotalPage { get; set; }
/// <summary>
/// 当前页, 从1开始
/// </summary>
[XmlElement("currentPage", typeof(int?), IsNullable = true)]
public int? CurrentPage { get; set; }
/// <summary>
/// 每页记录的条数
/// </summary>
[XmlElement("pageSize", typeof(int?), IsNullable = true)]
public int? PageSize { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 盘点单编码
/// </summary>
[XmlElement("checkOrderCode", typeof(string))]
public string CheckOrderCode { get; set; }
/// <summary>
/// 仓储系统的盘点单编码
/// </summary>
[XmlElement("checkOrderId", typeof(string))]
public string CheckOrderId { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 盘点时间,string (19) , YYYY-MM-DD HH:MM:SS
/// </summary>
[XmlElement("checkTime", typeof(string))]
public string CheckTime { get; set; }
/// <summary>
/// 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMInventoryReportRequestItem))]
public QMInventoryReportRequestItem[] Items {get; set;}
}
[Serializable]
public class QMInventoryReportRequestItem
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存,默认为ZP
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 盘盈盘亏商品变化量,盘盈为正数,盘亏为负数
/// </summary>
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
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
/// 商品序列号
/// </summary>
[XmlElement("snCode", typeof(string))]
public string SnCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
}
