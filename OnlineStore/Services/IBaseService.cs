using RestSharp;

namespace OnlineStore.Services
{
  public interface IBaseService
  {
    Task<T> ExecuteAsync<T>(string resource, Method method, object body = null) where T : new();
  }
}
