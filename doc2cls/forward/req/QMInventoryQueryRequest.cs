using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 库存查询接口（多商品）
/// taobao.qimen.inventory.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMInventoryQueryRequest
{

[XmlArray("criteriaList")]
[XmlArrayItem("criteria", typeof(QMInventoryQueryRequestCriteria))]
public QMInventoryQueryRequestCriteria[] CriteriaList {get; set;}
}
[Serializable]
public class QMInventoryQueryRequestCriteria
{
/// <summary>
/// 仓库编码
/// </summary>
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 货主编码
/// </summary>
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
/// 仓储系统商品ID
/// </summary>
[Required]
[Description("仓储系统商品ID")]
[MaxLength(50)]
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存,默认为查所有类型的库存
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
}
}
