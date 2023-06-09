using System.Threading.Tasks;
using RestSharp;
using OnlineStore.Services.fcInterviewAPI.Models;

namespace OnlineStore.Services.fcInterviewAPI.Orders
{
  public class OrderService : BaseService, IOrderService
  {
    public OrderService(string endpoint, string apiKey) : base(endpoint, apiKey)
    {
    }

    public Task<Order> GetOrder(string id)
    {
      return ExecuteAsync<Order>($"api/orders/{id}", Method.Get);
    }

    public Task<OrdersResponse> GetOrders()
    {
      return ExecuteAsync<OrdersResponse>("api/orders", Method.Get);
    }

    public Task<object> PlaceOrder(OrderRequest orderDetails)
    {
      return ExecuteAsync<object>("api/orders", Method.Post, orderDetails);
    }
  }
}