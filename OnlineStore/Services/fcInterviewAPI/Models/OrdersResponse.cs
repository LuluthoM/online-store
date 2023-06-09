﻿namespace OnlineStore.Services.fcInterviewAPI.Models
{
  public class Order
  {
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public string CustomerName { get; set; }
    public decimal SalesValueExcl { get; set; }
    public decimal AppliedDiscount { get; set; }
    public decimal SalesValueIncl { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
  }

  public class OrdersResponse
  {
    public List<Order> Orders { get; set; }
  }

}
