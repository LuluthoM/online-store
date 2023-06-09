using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace OnlineStore.Services
{
  public abstract class BaseService : IBaseService
  {
    protected IRestClient API { get; private set; }
    protected string ApiKey { get; private set; }

    public BaseService(string endpoint, string apiKey)
    {
      API = new RestClient(endpoint);
      ApiKey = apiKey;
    }

    public async Task<T> ExecuteAsync<T>(string resource, Method method, object body = null) where T : new()
    {
      var request = new RestRequest(resource, method);

      if (body != null)
      {
        string jsonToSend = JsonConvert.SerializeObject(body);
        request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
      }

      request.RequestFormat = DataFormat.Json;

      // Adding headers to the request
      request.AddHeader("X-APi-Key", ApiKey);
      request.AddHeader("Content-Type", "application/json");

      try
      {
        var response = await API.ExecuteAsync<T>(request);

        if (response.StatusCode == HttpStatusCode.OK)
        {
          return response.Data;
        }
        else
        {
          return default(T);
        }
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
