namespace OnlineStore.Services.Cart
{
  public class CartService : ICartService
  {
    private Dictionary<string, int> cart = new Dictionary<string, int>();

    public Task AddToCart(string productId, int quantity)
    {
      if (cart.ContainsKey(productId))
      {
        cart[productId] += quantity;
      }
      else
      {
        cart[productId] = quantity;
      }
      return Task.CompletedTask;
    }

    public Task RemoveFromCart(string productId)
    {
      if (cart.ContainsKey(productId))
      {
        cart.Remove(productId);
      }
      return Task.CompletedTask;
    }

    public Task<Dictionary<string, int>> GetCartItems()
    {
      return Task.FromResult(cart);
    }

    public Task<int> GetQuantity(string productId)
    {
      return Task.FromResult(cart.ContainsKey(productId) ? cart[productId] : 0);
    }
  }
}