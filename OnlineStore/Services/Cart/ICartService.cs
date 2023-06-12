namespace OnlineStore.Services.Cart
{
  public interface ICartService
  {
    Task AddToCart(string productId, int quantity);
    Task RemoveFromCart(string productId);
    Task<Dictionary<string, int>> GetCartItems();
    Task<int> GetQuantity(string productId);
  }
}
