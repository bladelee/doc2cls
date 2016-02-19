using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 库存查询接口（多条件）
/// taobao.qimen.stock.query
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMStockQueryRequest
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
[MaxLength(50)]
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 仓储系统商品ID
/// </summary>
[MaxLength(50)]
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损, ZT=在途库存,默认为查所有类型的库存
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 批次编码
/// </summary>
[MaxLength(50)]
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 商品生产日期 YYYY-MM-DD
/// </summary>
[MaxLength(50)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期YYYY-MM-DD
/// </summary>
[MaxLength(50)]
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 当前页,从1开始
/// </summary>
[Required]
[Description("当前页")]
[MaxLength(50)]
[XmlElement("page", typeof(string))]
public string Page { get; set; }
/// <summary>
/// 每页条数(最多100条)
/// </summary>
[Required]
[Description("每页条数")]
[MaxLength(50)]
[XmlElement("pageSize", typeof(string))]
public string PageSize { get; set; }

[XmlElement("extendProps", typeof(QMStockQueryRequestExtendProps))]
public QMStockQueryRequestExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMStockQueryRequestExtendProps
{
/// <summary>
/// 库存查询类型(菜鸟业务使用), 1- 汇总库存,不区分批次和渠道 2- 批次库存,库存按商品批次维度划分 3- 渠道库存,库存按渠道维度划分 (当前业务不支持批次库存和渠道库存共存,批次库存无渠道属性,渠道库存无批次属性)
/// </summary>
[MaxLength(50)]
[XmlElement("type", typeof(string))]
public string Type { get; set; }
/// <summary>
/// 渠道编码(菜鸟业务使用),TB=淘系,OTHERS=其他,菜鸟业务使用
/// </summary>
[MaxLength(50)]
[XmlElement("channelCode", typeof(string))]
public string ChannelCode { get; set; }
}
}
