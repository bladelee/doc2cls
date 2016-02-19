using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 仓内加工单创建接口
/// taobao.qimen.storeprocess.create
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMStoreProcessCreateRequest
{
/// <summary>
/// 加工单编码
/// </summary>
[Required]
[Description("加工单编码")]
[MaxLength(50)]
[XmlElement("processOrderCode", typeof(string))]
public string ProcessOrderCode { get; set; }
/// <summary>
/// 仓库编码,统仓统配等无需ERP指定仓储编码的情况填OTHER
/// </summary>
[Required]
[Description("仓库编码")]
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 单据类型 CNJG=仓内加工作业单
/// </summary>
[Required]
[Description("单据类型 CNJG=仓内加工作业单")]
[MaxLength(50)]
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 加工单创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[Required]
[Description("加工单创建时间")]
[MaxLength(19)]
[XmlElement("orderCreateTime", typeof(string))]
public string OrderCreateTime { get; set; }
/// <summary>
/// 计划加工时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[Required]
[Description("计划加工时间")]
[MaxLength(19)]
[XmlElement("planTime", typeof(string))]
public string PlanTime { get; set; }
/// <summary>
/// 加工类型:1:仓内组合加工 2:仓内组合拆分
/// </summary>
[Required]
[Description("加工类型:1:仓内组合加工 2:仓内组合拆分")]
[MaxLength(50)]
[XmlElement("serviceType", typeof(string))]
public string ServiceType { get; set; }
/// <summary>
/// 成品计划数量
/// </summary>
[MaxLength(50)]
[XmlElement("planQty", typeof(string))]
public string PlanQty { get; set; }

[XmlElement("extendProps", typeof(QMStoreProcessCreateRequestExtendProps))]
public QMStoreProcessCreateRequestExtendProps ExtendProps {get; set;}
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }

[XmlArray("materialitems")]
[XmlArrayItem("item", typeof(QMStoreProcessCreateRequestItem))]
public QMStoreProcessCreateRequestItem[] Materialitems {get; set;}

[XmlArray("productitems")]
[XmlArrayItem("item", typeof(QMStoreProcessCreateRequestItem))]
public QMStoreProcessCreateRequestItem[] Productitems {get; set;}
}
[Serializable]
public class QMStoreProcessCreateRequestExtendProps
{
/// <summary>
/// value1
/// </summary>
[MaxLength(50)]
[XmlElement("key1", typeof(string))]
public string Key1 { get; set; }
/// <summary>
/// value2
/// </summary>
[MaxLength(50)]
[XmlElement("key2", typeof(string))]
public string Key2 { get; set; }
}
[Serializable]
public class QMStoreProcessCreateRequestItem
{
/// <summary>
/// erp系统商品编码
/// </summary>
[Required]
[Description("erp系统商品编码")]
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,默认为ZP,
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 数量
/// </summary>
[Required]
[Description("数量")]
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
/// <summary>
/// 商品生产日期 ,YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期,YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[MaxLength(50)]
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
[Serializable]
public class QMStoreProcessCreateRequestItem
{
/// <summary>
/// erp系统商品编码
/// </summary>
[Required]
[Description("erp系统商品编码")]
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
/// 库存类型, ZP=正品, CC=残次,JS=机损, XS= 箱损,,默认为ZP,
/// </summary>
[MaxLength(50)]
[XmlElement("inventoryType", typeof(string))]
public string InventoryType { get; set; }
/// <summary>
/// 数量
/// </summary>
[Required]
[Description("数量")]
[XmlElement("quantity", typeof(int?), IsNullable = true)]
public int? Quantity { get; set; }
/// <summary>
/// 商品生产日期 ,YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 商品过期日期,YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 生产批号
/// </summary>
[MaxLength(50)]
[XmlElement("produceCode", typeof(string))]
public string ProduceCode { get; set; }
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
}
