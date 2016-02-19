using System;
using System.Xml.Serialization;
using Wms.Common;

namespace Wms.CallBack.Request
{
/// <summary>
/// 入库单确认接口
/// entryorder.confirm
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMEntryOrderConfirmRequest
{

[XmlElement("entryOrder", typeof(QMEntryOrderConfirmRequestEntryOrder))]
public QMEntryOrderConfirmRequestEntryOrder EntryOrder {get; set;}

[XmlArray("orderLines")]
[XmlArrayItem("orderLine", typeof(QMEntryOrderConfirmRequestOrderLine))]
public QMEntryOrderConfirmRequestOrderLine[] OrderLines {get; set;}
}
[Serializable]
public class QMEntryOrderConfirmRequestEntryOrder
{
/// <summary>
/// 单据总行数,当单据需要分多个请求发送时,发送方需要将totalOrderLines填入,接收方收到后,根据实际接收到的条数和totalOrderLines进行比对,如果小于,则继续等待接收请求。如果等于,则表示该单据的所有请求发送完成。
/// </summary>
[XmlElement("totalOrderLines", typeof(int?), IsNullable = true)]
public int? TotalOrderLines { get; set; }
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
/// 外部业务编码, 消息ID, 用于去重, ISV对于同一请求,分配一个唯一性的编码。用来保证因为网络等原因导致重复传输,请求不会被重复处理, 
/// </summary>
[XmlElement("outBizCode", typeof(string))]
public string OutBizCode { get; set; }
/// <summary>
/// 支持出入库单多次收货,多次收货后确认时0 表示入库单最终状态确认;1 表示入库单中间状态确认;每次入库传入的数量为增量,特殊情况,同一入库单,如果先收到0,后又收到1,允许修改收货的数量。
/// </summary>
[XmlElement("confirmType", typeof(int?), IsNullable = true)]
public int? ConfirmType { get; set; }
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
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMEntryOrderConfirmRequestOrderLine
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
/// 货主编码
/// </summary>
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
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

[XmlArray("batchs")]
[XmlArrayItem("batch", typeof(QMEntryOrderConfirmRequestOrderLineBatch))]
public QMEntryOrderConfirmRequestOrderLineBatch[] Batchs {get; set;}
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMEntryOrderConfirmRequestOrderLineBatch
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP, (收到商品总数=正品数+残品数+机损数+箱损数)
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
