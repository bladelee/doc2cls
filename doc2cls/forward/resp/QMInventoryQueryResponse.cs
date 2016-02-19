using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 库存查询接口（多商品）
/// taobao.qimen.inventory.query
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMInventoryQueryResponse
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

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMInventoryQueryResponseItem))]
public QMInventoryQueryResponseItem[] Items {get; set;}
}
[Serializable]
public class QMInventoryQueryResponseItem
{
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
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
/// 未冻结库存数量
/// </summary>
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
/// <summary>
/// 冻结库存数量
/// </summary>
[XmlElement("lockQuantity", typeof(int?), IsNullable = true)]
public int? LockQuantity { get; set; }
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

[XmlElement("extendProps", typeof(QMInventoryQueryResponseItemExtendProps))]
public QMInventoryQueryResponseItemExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMInventoryQueryResponseItemExtendProps
{
/// <summary>
/// value1
/// </summary>
[XmlElement("key1", typeof(string))]
public string Key1 { get; set; }
/// <summary>
/// value2
/// </summary>
[XmlElement("key2", typeof(string))]
public string Key2 { get; set; }
}
}
