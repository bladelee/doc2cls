using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 库存异动通知接口
/// stockchange.report
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMStockChangeReportRequest
{

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMStockChangeReportRequestItem))]
public QMStockChangeReportRequestItem[] Items {get; set;}
}
[Serializable]
public class QMStockChangeReportRequestItem
{
/// <summary>
/// 货主编码
/// </summary>
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 引起异动的单据编码
/// </summary>
[XmlElement("orderCode", typeof(string))]
public string OrderCode { get; set; }
/// <summary>
/// 单据类型 ,JYCK= 一般交易出库单,HHCK= 换货出库 ,BFCK= 补发出库 PTCK=普通出库单,DBCK=调拨出库 ,QTCK=其他出库, SCRK=生产入库,LYRK=领用入库,CCRK=残次品入库,CGRK=采购入库 ,DBRK= 调拨入库 ,QTRK= 其他入库 ,XTRK= 销退入库 HHRK= 换货入库 CNJG= 仓内加工单 ZTTZ=状态调整单
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 外部业务编码, 消息ID, 用于去重,用来保证因为网络等原因导致重复传输,请求不会被重复处理
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 商品变化量,可为正为负
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

[XmlArray("batchs")]
[XmlArrayItem("batch", typeof(QMStockChangeReportRequestItemBatch))]
public QMStockChangeReportRequestItemBatch[] Batchs {get; set;}
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMStockChangeReportRequestItemBatch
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 异动数量,要求batchs节点下所有的异动数量之和等于orderline中的异动数量
/// </summary>
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
}
}
