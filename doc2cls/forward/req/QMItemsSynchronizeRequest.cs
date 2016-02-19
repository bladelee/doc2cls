using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 商品同步接口 (批量)
/// taobao.qimen.items.synchronize
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMItemsSynchronizeRequest
{
/// <summary>
/// add|update
/// </summary>
[Required]
[Description("add|update")]
[MaxLength(50)]
[XmlElement("actionType", typeof(string))]
public string ActionType { get; set; }
/// <summary>
/// 仓库编码,统仓统配等无需ERP指定仓储编码的情况填OTHER
/// </summary>
[Required]
[Description("仓库编码")]
[MaxLength(50)]
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }
/// <summary>
/// 货主编码
/// </summary>
[Required]
[Description("货主编码")]
[MaxLength(50)]
[XmlElement("ownerCode", typeof(string))]
public string OwnerCode { get; set; }

[XmlArray("items")]
[XmlArrayItem("item", typeof(QMItemsSynchronizeRequestItem))]
public QMItemsSynchronizeRequestItem[] Items {get; set;}
}
[Serializable]
public class QMItemsSynchronizeRequestItem
{
/// <summary>
/// 供应商编码
/// </summary>
[MaxLength(50)]
[XmlElement("supplierCode", typeof(string))]
public string SupplierCode { get; set; }
/// <summary>
/// 供应商名称
/// </summary>
[MaxLength(200)]
[XmlElement("supplierName", typeof(string))]
public string SupplierName { get; set; }
/// <summary>
/// 商品编码
/// </summary>
[Required]
[Description("商品编码")]
[MaxLength(50)]
[XmlElement("itemCode", typeof(string))]
public string ItemCode { get; set; }
/// <summary>
/// 仓储系统商品编码, 条件为商品同步接口, 出参itemId不为空
/// </summary>
[Required]
[Description("仓储系统商品编码")]
[MaxLength(50)]
[XmlElement("itemId", typeof(string))]
public string ItemId { get; set; }
/// <summary>
/// 货号
/// </summary>
[MaxLength(50)]
[XmlElement("goodsCode", typeof(string))]
public string GoodsCode { get; set; }
/// <summary>
/// 商品名称
/// </summary>
[Required]
[Description("商品名称")]
[MaxLength(200)]
[XmlElement("itemName", typeof(string))]
public string ItemName { get; set; }
/// <summary>
/// 商品简称
/// </summary>
[MaxLength(200)]
[XmlElement("shortName", typeof(string))]
public string ShortName { get; set; }
/// <summary>
/// 英文名
/// </summary>
[MaxLength(200)]
[XmlElement("englishName", typeof(string))]
public string EnglishName { get; set; }
/// <summary>
/// 条形码, 可多个,用分号(;)隔开
/// </summary>
[Required]
[Description("条形码")]
[MaxLength(500)]
[XmlElement("barCode", typeof(string))]
public string BarCode { get; set; }
/// <summary>
/// 商品属性 (如红色, XXL) 
/// </summary>
[MaxLength(200)]
[XmlElement("skuProperty", typeof(string))]
public string SkuProperty { get; set; }
/// <summary>
/// 商品计量单位
/// </summary>
[MaxLength(50)]
[XmlElement("stockUnit", typeof(string))]
public string StockUnit { get; set; }
/// <summary>
/// 长 (厘米) 
/// </summary>
[XmlElement("length", typeof(double?), IsNullable = true)]
public double? Length { get; set; }
/// <summary>
/// 宽 (厘米) 
/// </summary>
[XmlElement("width", typeof(double?), IsNullable = true)]
public double? Width { get; set; }
/// <summary>
/// 高 (厘米) 
/// </summary>
[XmlElement("height", typeof(double?), IsNullable = true)]
public double? Height { get; set; }
/// <summary>
/// 体积 (升) 
/// </summary>
[XmlElement("volume", typeof(double?), IsNullable = true)]
public double? Volume { get; set; }
/// <summary>
/// 毛重 (千克) 
/// </summary>
[XmlElement("grossWeight", typeof(double?), IsNullable = true)]
public double? GrossWeight { get; set; }
/// <summary>
/// 净重 (千克) 
/// </summary>
[XmlElement("netWeight", typeof(double?), IsNullable = true)]
public double? NetWeight { get; set; }
/// <summary>
/// 颜色
/// </summary>
[MaxLength(50)]
[XmlElement("color", typeof(string))]
public string Color { get; set; }
/// <summary>
/// 尺寸
/// </summary>
[MaxLength(50)]
[XmlElement("size", typeof(string))]
public string Size { get; set; }
/// <summary>
/// 渠道中的商品标题
/// </summary>
[MaxLength(200)]
[XmlElement("title", typeof(string))]
public string Title { get; set; }
/// <summary>
/// 商品类别ID
/// </summary>
[MaxLength(50)]
[XmlElement("categoryId", typeof(string))]
public string CategoryId { get; set; }
/// <summary>
/// 商品类别名称
/// </summary>
[MaxLength(200)]
[XmlElement("categoryName", typeof(string))]
public string CategoryName { get; set; }
/// <summary>
/// 计价货类
/// </summary>
[MaxLength(200)]
[XmlElement("pricingCategory", typeof(string))]
public string PricingCategory { get; set; }
/// <summary>
/// 安全库存
/// </summary>
[XmlElement("safetyStock", typeof(int?), IsNullable = true)]
public int? SafetyStock { get; set; }
/// <summary>
/// 商品类型 (ZC=正常商品, FX=分销商品, ZH=组合商品, ZP=赠品, BC=包材, HC=耗材, FL=辅料, XN=虚拟品, FS=附属品, CC=残次品, OTHER=其它) ,  (只传英文编码)
/// </summary>
[Required]
[Description("商品类型")]
[MaxLength(10)]
[XmlElement("itemType", typeof(string))]
public string ItemType { get; set; }
/// <summary>
/// 吊牌价
/// </summary>
[XmlElement("tagPrice", typeof(double?), IsNullable = true)]
public double? TagPrice { get; set; }
/// <summary>
/// 零售价
/// </summary>
[XmlElement("retailPrice", typeof(double?), IsNullable = true)]
public double? RetailPrice { get; set; }
/// <summary>
/// 成本价
/// </summary>
[XmlElement("costPrice", typeof(double?), IsNullable = true)]
public double? CostPrice { get; set; }
/// <summary>
/// 采购价
/// </summary>
[XmlElement("purchasePrice", typeof(double?), IsNullable = true)]
public double? PurchasePrice { get; set; }
/// <summary>
/// 季节编码
/// </summary>
[MaxLength(50)]
[XmlElement("seasonCode", typeof(string))]
public string SeasonCode { get; set; }
/// <summary>
/// 季节名称
/// </summary>
[MaxLength(50)]
[XmlElement("seasonName", typeof(string))]
public string SeasonName { get; set; }
/// <summary>
/// 品牌代码
/// </summary>
[MaxLength(50)]
[XmlElement("brandCode", typeof(string))]
public string BrandCode { get; set; }
/// <summary>
/// 品牌名称
/// </summary>
[MaxLength(50)]
[XmlElement("brandName", typeof(string))]
public string BrandName { get; set; }
/// <summary>
/// 是否需要串号管理, Y/N (默认为N)
/// </summary>
[MaxLength(1)]
[XmlElement("isSNMgmt", typeof(string))]
public string IsSNMgmt { get; set; }
/// <summary>
/// 生产日期, YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("productDate", typeof(string))]
public string ProductDate { get; set; }
/// <summary>
/// 过期日期, YYYY-MM-DD
/// </summary>
[MaxLength(10)]
[XmlElement("expireDate", typeof(string))]
public string ExpireDate { get; set; }
/// <summary>
/// 是否需要保质期管理, Y/N (默认为N)
/// </summary>
[MaxLength(1)]
[XmlElement("isShelfLifeMgmt", typeof(string))]
public string IsShelfLifeMgmt { get; set; }
/// <summary>
/// 保质期 (小时) 
/// </summary>
[XmlElement("shelfLife", typeof(int?), IsNullable = true)]
public int? ShelfLife { get; set; }
/// <summary>
/// 保质期禁收天数
/// </summary>
[XmlElement("rejectLifecycle", typeof(int?), IsNullable = true)]
public int? RejectLifecycle { get; set; }
/// <summary>
/// 保质期禁售天数
/// </summary>
[XmlElement("lockupLifecycle", typeof(int?), IsNullable = true)]
public int? LockupLifecycle { get; set; }
/// <summary>
/// 保质期临期预警天数
/// </summary>
[XmlElement("adventLifecycle", typeof(int?), IsNullable = true)]
public int? AdventLifecycle { get; set; }
/// <summary>
/// 是否需要批次管理, Y/N (默认为N)
/// </summary>
[MaxLength(1)]
[XmlElement("isBatchMgmt", typeof(string))]
public string IsBatchMgmt { get; set; }
/// <summary>
/// 批次代码
/// </summary>
[MaxLength(50)]
[XmlElement("batchCode", typeof(string))]
public string BatchCode { get; set; }
/// <summary>
/// 批次备注
/// </summary>
[MaxLength(200)]
[XmlElement("batchRemark", typeof(string))]
public string BatchRemark { get; set; }
/// <summary>
/// 包装代码
/// </summary>
[MaxLength(50)]
[XmlElement("packCode", typeof(string))]
public string PackCode { get; set; }
/// <summary>
/// 箱规
/// </summary>
[MaxLength(50)]
[XmlElement("pcs", typeof(string))]
public string Pcs { get; set; }
/// <summary>
/// 商品的原产地
/// </summary>
[MaxLength(50)]
[XmlElement("originAddress", typeof(string))]
public string OriginAddress { get; set; }
/// <summary>
/// 批准文号
/// </summary>
[MaxLength(50)]
[XmlElement("approvalNumber", typeof(string))]
public string ApprovalNumber { get; set; }
/// <summary>
/// 是否易碎品, Y/N,  (默认为N)
/// </summary>
[MaxLength(1)]
[XmlElement("isFragile", typeof(string))]
public string IsFragile { get; set; }
/// <summary>
/// 是否危险品, Y/N,  (默认为N)
/// </summary>
[MaxLength(1)]
[XmlElement("isHazardous", typeof(string))]
public string IsHazardous { get; set; }
/// <summary>
/// 备注
/// </summary>
[MaxLength(500)]
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
/// <summary>
/// 创建时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("createTime", typeof(string))]
public string CreateTime { get; set; }
/// <summary>
/// 更新时间, YYYY-MM-DD HH:MM:SS
/// </summary>
[MaxLength(19)]
[XmlElement("updateTime", typeof(string))]
public string UpdateTime { get; set; }
/// <summary>
/// 是否有效, Y/N (默认为Y)
/// </summary>
[MaxLength(1)]
[XmlElement("isValid", typeof(string))]
public string IsValid { get; set; }
/// <summary>
/// 是否sku, Y/N,  (默认为Y)
/// </summary>
[MaxLength(1)]
[XmlElement("isSku", typeof(string))]
public string IsSku { get; set; }
/// <summary>
/// 商品包装材料类型
/// </summary>
[MaxLength(200)]
[XmlElement("packageMaterial", typeof(string))]
public string PackageMaterial { get; set; }

[XmlElement("extendProps", typeof(QMItemsSynchronizeRequestItemExtendProps))]
public QMItemsSynchronizeRequestItemExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMItemsSynchronizeRequestItemExtendProps
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
}
