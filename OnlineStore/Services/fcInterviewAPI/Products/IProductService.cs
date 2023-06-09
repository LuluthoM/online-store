using OnlineStore.Services.fcInterviewAPI.Models;

namespace OnlineStore.Services.fcInterviewAPI.Products
{
  public interface IProductService
  {
    Task<Product> GetProduct(string id);
    Task<List<Product>> GetProducts();
  }
}