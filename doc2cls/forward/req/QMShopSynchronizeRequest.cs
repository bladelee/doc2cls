using System;
using System.Xml.Serialization;
using System.ComponentModel;
using Wms.Common;

namespace Wms.Request.QM
{
/// <summary>
/// 店铺同步接口
/// taobao.qimen.shop.synchronize
/// </summary>
[Serializable]
[XmlRoot("request")]
public class QMShopSynchronizeRequest
{
/// <summary>
/// add|update
/// </summary>
[Required]
[Description("add|update")]
[MaxLength(50)]
[XmlElement("actionType", typeof(string))]
public string ActionType { get; set; }

[XmlElement("shop", typeof(QMShopSynchronizeRequestShop))]
public QMShopSynchronizeRequestShop Shop {get; set;}
}
[Serializable]
public class QMShopSynchronizeRequestShop
{
/// <summary>
/// 来源平台编码,TB= 淘宝 、TM=天猫 、JD=京东、DD=当当、PP=拍拍、YX=易讯、EBAY=ebay、QQ=QQ网购、AMAZON=亚马逊、SN=苏宁、GM=国美、WPH=唯品会、JM=聚美、LF=乐蜂、MGJ=蘑菇街、JS=聚尚、PX=拍鞋、YT=银泰、YHD=1号店、VANCL=凡客、YL=邮乐、YG=优购、1688=阿里巴巴、POS=POS门店、OTHER=其他,  (只传英文编码)
/// </summary>
[Required]
[Description("来源平台编码")]
[MaxLength(50)]
[XmlElement("sourcePlatformCode", typeof(string))]
public string SourcePlatformCode { get; set; }
/// <summary>
/// ERP店铺编码
/// </summary>
[Required]
[Description("ERP店铺编码")]
[MaxLength(50)]
[XmlElement("shopCode", typeof(string))]
public string ShopCode { get; set; }
/// <summary>
/// ERP店铺名称
/// </summary>
[MaxLength(50)]
[XmlElement("shopName", typeof(string))]
public string ShopName { get; set; }
/// <summary>
/// 平台店铺Id(如淘宝店铺Id)
/// </summary>
[MaxLength(50)]
[XmlElement("platformShopCode", typeof(string))]
public string PlatformShopCode { get; set; }
/// <summary>
/// 平台店铺名称(如淘宝店铺名称)
/// </summary>
[MaxLength(50)]
[XmlElement("platformShopName", typeof(string))]
public string PlatformShopName { get; set; }

[XmlElement("shopAddress", typeof(QMShopSynchronizeRequestShopShopAddress))]
public QMShopSynchronizeRequestShopShopAddress ShopAddress {get; set;}
}
[Serializable]
public class QMShopSynchronizeRequestShopShopAddress
{
/// <summary>
/// 邮编
/// </summary>
[MaxLength(50)]
[XmlElement("zipCode", typeof(string))]
public string ZipCode { get; set; }
/// <summary>
/// 省份
/// </summary>
[MaxLength(50)]
[XmlElement("province", typeof(string))]
public string Province { get; set; }
/// <summary>
/// 城市
/// </summary>
[MaxLength(50)]
[XmlElement("city", typeof(string))]
public string City { get; set; }
/// <summary>
/// 区域
/// </summary>
[MaxLength(50)]
[XmlElement("area", typeof(string))]
public string Area { get; set; }
/// <summary>
/// 村镇
/// </summary>
[MaxLength(50)]
[XmlElement("town", typeof(string))]
public string Town { get; set; }
/// <summary>
/// 详细地址
/// </summary>
[MaxLength(200)]
[XmlElement("detailAddress", typeof(string))]
public string DetailAddress { get; set; }
}
}
