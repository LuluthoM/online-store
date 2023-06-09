namespace OnlineStore.Services.fcInterviewAPI.Models
{
  public class OrderDetail
  {
    public int OrderDetailsId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string Order { get; set; }
    public Product Product { get; set; }
  }
}
