using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 订单流水查询接口
/// taobao.qimen.orderprocess.query
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMOrderProcessQueryResponse
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

[XmlElement("orderProcess", typeof(QMOrderProcessQueryResponseOrderProcess))]
public QMOrderProcessQueryResponseOrderProcess OrderProcess {get; set;}
}
[Serializable]
public class QMOrderProcessQueryResponseOrderProcess
{
/// <summary>
/// 单据号
/// </summary>
[XmlElement("orderCode", typeof(string))]
public string OrderCode { get; set; }
/// <summary>
/// 仓储系统单据号
/// </summary>
[XmlElement("orderId", typeof(string))]
public string OrderId { get; set; }
/// <summary>
/// 单据类型,JYCK= 一般交易出库单,HHCK= 换货出库 ,BFCK= 补发出库,PTCK=普通出库单,DBCK=调拨出库 ,QTCK=其他出库,B2BRK=B2B入库,B2BCK=B2B出库,CGRK=采购入库 ,DBRK= 调拨入库 ,QTRK= 其他入库 ,XTRK= 销退入库,HHRK= 换货入库,CNJG= 仓内加工单
/// </summary>
[XmlElement("orderType", typeof(string))]
public string OrderType { get; set; }
/// <summary>
/// 仓库编码
/// </summary>
[XmlElement("warehouseCode", typeof(string))]
public string WarehouseCode { get; set; }

[XmlArray("processes")]
[XmlArrayItem("process", typeof(QMOrderProcessQueryResponseOrderProcessProcess))]
public QMOrderProcessQueryResponseOrderProcessProcess[] Processes {get; set;}

[XmlElement("extendProps", typeof(QMOrderProcessQueryResponseOrderProcessExtendProps))]
public QMOrderProcessQueryResponseOrderProcessExtendProps ExtendProps {get; set;}
}
[Serializable]
public class QMOrderProcessQueryResponseOrderProcessExtendProps
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
[Serializable]
public class QMOrderProcessQueryResponseOrderProcessProcess
{
/// <summary>
/// 单据状态,NEW=新增, ACCEPT=仓库接单,  PRINT = 打印,  PICK=捡货,  CHECK = 复核,  PACKAGE= 打包,  WEIGH= 称重, READY=待提货, DELIVERED=已发货,EXCEPTION =异常 ,CLOSED= 关闭,  CANCELED= 取消,  REJECT=仓库拒单, REFUSE=客户拒签, CANCELEDFAIL=取消失败,SIGN=签收,TMSCANCELED=快递拦截, PARTFULFILLED-部分收货完成,  FULFILLED-收货完成,PARTDELIVERED=部分发货完成, OTHER=其他
/// </summary>
[XmlElement("processStatus", typeof(string))]
public string ProcessStatus { get; set; }
/// <summary>
/// 该状态操作员编码
/// </summary>
[XmlElement("operatorCode", typeof(string))]
public string OperatorCode { get; set; }
/// <summary>
/// 该状态操作员姓名
/// </summary>
[XmlElement("operatorName", typeof(string))]
public string OperatorName { get; set; }
/// <summary>
/// 该状态操作时间, YYYY-MM-DD HH:MM:SS 
/// </summary>
[XmlElement("operateTime", typeof(string))]
public string OperateTime { get; set; }
/// <summary>
/// 操作内容
/// </summary>
[XmlElement("operateInfo", typeof(string))]
public string OperateInfo { get; set; }
/// <summary>
/// 备注
/// </summary>
[XmlElement("remark", typeof(string))]
public string Remark { get; set; }
}
}
