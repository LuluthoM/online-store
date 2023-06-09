namespace OnlineStore.Services.fcInterviewAPI.Models
{
  public class Product
  {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public decimal UnitPrice { get; set; }
    public List<string> OrderDetails { get; set; }
  }
}
