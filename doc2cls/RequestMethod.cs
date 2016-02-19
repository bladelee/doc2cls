public class QMRequestMethod
{
/// <summary>
/// 商品同步接口
/// </summary>
public const string SingleItemSynchronize = "taobao.qimen.singleitem.synchronize";
/// <summary>
/// 商品同步接口 (批量)
/// </summary>
public const string ItemsSynchronize = "taobao.qimen.items.synchronize";
/// <summary>
/// 组合商品接口
/// </summary>
public const string CombineItemSynchronize = "taobao.qimen.combineitem.synchronize";
/// <summary>
/// 入库单创建接口
/// </summary>
public const string EntryOrderCreate = "taobao.qimen.entryorder.create";
/// <summary>
/// 入库单确认接口
/// </summary>
public const string EntryOrderConfirm = "entryorder.confirm";
/// <summary>
/// 入库单查询接口
/// </summary>
public const string EntryOrderQuery = "taobao.qimen.entryorder.query";
/// <summary>
/// 退货入库单创建接口
/// </summary>
public const string ReturnOrderCreate = "taobao.qimen.returnorder.create";
/// <summary>
/// 退货入库单确认接口
/// </summary>
public const string ReturnOrderConfirm = "returnorder.confirm";
/// <summary>
/// 退货入库单查询接口
/// </summary>
public const string ReturnOrderQuery = "taobao.qimen.returnorder.query";
/// <summary>
/// 出库单创建接口
/// </summary>
public const string StockOutCreate = "taobao.qimen.stockout.create";
/// <summary>
/// 出库单确认接口
/// </summary>
public const string StockOutConfirm = "stockout.confirm";
/// <summary>
/// 出库单查询接口
/// </summary>
public const string StockOutQuery = "taobao.qimen.stockout.query";
/// <summary>
/// 发货单创建接口
/// </summary>
public const string DeliveryOrderCreate = "taobao.qimen.deliveryorder.create";
/// <summary>
/// 发货单创建接口 （批量）
/// </summary>
public const string DeliveryOrderBatchCreate = "taobao.qimen.deliveryorder.batchcreate";
/// <summary>
/// 发货单确认接口
/// </summary>
public const string DeliveryOrderConfirm = "deliveryorder.confirm";
/// <summary>
/// 发货单确认接口  (批量)
/// </summary>
public const string DeliveryOrderBatchConfirm = "deliveryorder.batchconfirm";
/// <summary>
/// 发货单查询接口
/// </summary>
public const string DeliveryOrderQuery = "taobao.qimen.deliveryorder.query";
/// <summary>
/// 发货单SN通知接口
/// </summary>
public const string SnReport = "sn.report";
/// <summary>
/// 订单流水查询接口
/// </summary>
public const string OrderProcessQuery = "taobao.qimen.orderprocess.query";
/// <summary>
/// 订单状态查询接口 （批量）
/// </summary>
public const string OrderStatusBatchQuery = "taobao.qimen.orderstatus.batchquery";
/// <summary>
/// 订单流水通知接口
/// </summary>
public const string OrderProcessReport = "orderprocess.report";
/// <summary>
/// 发货单缺货通知接口
/// </summary>
public const string ItemLackReport = "itemlack.report";
/// <summary>
/// 发货单缺货查询接口
/// </summary>
public const string ItemLackQuery = "taobao.qimen.itemlack.query";
/// <summary>
/// 单据取消接口
/// </summary>
public const string OrderCancel = "taobao.qimen.order.cancel";
/// <summary>
/// 单据挂起（恢复）接口
/// </summary>
public const string OrderPending = "taobao.qimen.order.pending";
/// <summary>
/// 库存查询接口（多商品）
/// </summary>
public const string InventoryQuery = "taobao.qimen.inventory.query";
/// <summary>
/// 库存查询接口（多条件）
/// </summary>
public const string StockQuery = "taobao.qimen.stock.query";
/// <summary>
/// 库存盘点通知接口
/// </summary>
public const string InventoryReport = "inventory.report";
/// <summary>
/// 库存盘点查询接口
/// </summary>
public const string InventoryCheckQuery = "taobao.qimen.inventorycheck.query";
/// <summary>
/// 仓内加工单创建接口
/// </summary>
public const string StoreProcessCreate = "taobao.qimen.storeprocess.create";
/// <summary>
/// 仓内加工单确认接口
/// </summary>
public const string StoreProcessConfirm = "storeprocess.confirm";
/// <summary>
/// 库存异动通知接口
/// </summary>
public const string StockChangeReport = "stockchange.report";
/// <summary>
/// 菜鸟自动流转查询接口  （扩展）
/// </summary>
public const string AutoTransferQuery = "taobao.qimen.autotransfer.query";
/// <summary>
/// 店铺同步接口
/// </summary>
public const string ShopSynchronize = "taobao.qimen.shop.synchronize";
/// <summary>
/// 心跳接口
/// </summary>
public const string ServiceHeartBeat = "service.heartbeat";
}
