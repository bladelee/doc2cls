using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 入库单查询接口
/// taobao.qimen.entryorder.query
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMEntryOrderQueryResponse
{
/// <summary>
/// success|failure
/// </summary>
[XmlElement("flag", typeof(string))]
public string Flag { get; set; }
/// <summary>
/// 响应码
/// </summary>
[XmlElement("code", typeof(string))]
public string Code { get; set; }
/// <summary>
/// 响应信息
/// </summary>
[XmlElement("message", typeof(string))]
public string Message { get; set; }
/// <summary>
/// orderLines总条数
/// </summary>
[XmlElement("totalLines", typeof(int?), IsNullable = true)]
public int? TotalLines { get; set; }

[XmlElement("entryOrder", typeof(QMEntryOrderQueryResponseEntryOrder))]
public QMEntryOrderQueryResponseEntryOrder EntryOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMEntryOrderQueryResponseOrderLine))]
public QMEntryOrderQueryResponseOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMEntryOrderQueryResponseOrderLine
{
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
/// 仓储系统商品ID
/// </summary>
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 商品名称
/// </summary>
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP, (收到商品总数=正品数+残品数+机损数+箱损数)
/// </summary>
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 应收数量
/// </summary>
[XmlElement("planQty", typeof(int?), IsNullable = true)]
public int? PlanQty { get; set; }
/// <summary>
/// 实收数量
/// </summary>
[XmlElement("actualQty", typeof(int?), IsNullable = true)]
public int? ActualQty { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 商品生产日期, YYYY-MM-DD
/// </summary>
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期,YYYY-MM-DD
/// </summary>
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMEntryOrderQueryResponseEntryOrder
{
/// <summary>
/// 入库单编码
/// </summary>
[XmlElement("entryOrderCode", typeof(string))]
public string EntryOrderCode { get; set; }
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
/// 仓储系统入库单ID
/// </summary>
[XmlElement("entryOrderId", typeof(string))]
public string EntryOrderId { get; set; }
/// <summary>
/// 入库单类型 ,SCRK=生产入库,LYRK=领用入库,CCRK=残次品入库,CGRK=采购入库, DBRK=调拨入库, QTRK=其他入库,B2BRK=B2B入库
/// </summary>
[XmlElement("entryOrderType", typeof(string))]
public string EntryOrderType { get; set; }
/// <summary>
/// 入库单状态,  ACCEPT-仓库接单 , PARTFULFILLED-部分收货完成,  FULFILLED-收货完成,  EXCEPTION-异常,  CANCELED-取消,  CLOSED-关闭,  REJECT-拒单,  CANCELEDFAIL-取消失败) ,  (只传英文编码)
/// </summary>
[XmlElement("status", typeof(string))]
public string Status { get; set; }
/// <summary>
/// 操作时间, YYYY-MM-DD HH:MM:SS,(当status=FULFILLED, operateTime为入库时间)
/// </summary>
[XmlElement("operateTime", typeof(string))]
public string OperateTime { get; set; }
}
}
