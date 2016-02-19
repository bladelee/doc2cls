using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 组合商品接口
/// taobao.qimen.combineitem.synchronize
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMCombineItemSynchronizeRequest
{
/// <summary>
/// 组合商品的ERP编码
/// </summary>
[Required]
[Description("组合商品的ERP编码")]
[MaxLength(50)]
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[Required]
[Description("货主编码")]
[MaxLength(50)]
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMCombineItemSynchronizeRequestItem))]
public QMCombineItemSynchronizeRequestItem[] Items {get; set;}
}
[Serializable]
public class QMCombineItemSynchronizeRequestItem
{
/// <summary>
/// 商品编码
/// </summary>
[Required]
[Description("商品编码")]
[MaxLength(50)]
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 后端商品编码
/// </summary>
[Required]
[Description("后端商品编码")]
[MaxLength(50)]
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 组合商品中的该商品个数
/// </summary>
[Required]
[Description("组合商品中的该商品个数")]
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
}
}
