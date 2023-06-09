using OnlineStore.Services.fcInterviewAPI.Models;
using RestSharp;

namespace OnlineStore.Services.fcInterviewAPI.Users
{
  public class UserService : BaseService, IUserService
  {
    public UserService(string endpoint, string apiKey) : base(endpoint, apiKey)
    {
    }

    public bool Login(string username, string password)
    {
      return true;
    }
    public Task<UsersResponse> GetUsers()
    {
      return ExecuteAsync<UsersResponse>($"api/Users", Method.Get);
    }
    public Task<object> CreateUser(CreateUserRequest createUserRequest)
    {
      return ExecuteAsync<object>("/api/Users", Method.Post, createUserRequest);

    }

    public Task<User> GetUser(string id)
    {
      return ExecuteAsync<User>($"/api/Users/{id}", Method.Get);
    }
  }
}