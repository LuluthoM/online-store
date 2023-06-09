using OnlineStore.Services.fcInterviewAPI.Models;
using RestSharp;

namespace OnlineStore.Services.fcInterviewAPI.Products
{
  public class ProductService : BaseService, IProductService
  {
    public ProductService(string endpoint, string apiKey) : base(endpoint, apiKey)
    {
    }

    public Task<List<Product>> GetProducts()
    {
      return ExecuteAsync<List<Product>>("api/Products", Method.Get);
    }

    public Task<Product> GetProduct(string id)
    {
      return ExecuteAsync<Product>($"api/Products/{id}", Method.Get);
    }
  }
}
