using OnlineStore.Services.fcInterviewAPI.Models;

namespace OnlineStore.Services.fcInterviewAPI.Orders
{
  public interface IOrderService: IBaseService
  {
    public Task<OrdersResponse> GetOrders();
    public Task<Order> GetOrder(string id);
    public Task<object> PlaceOrder(OrderRequest orderDetails);
  }
}
