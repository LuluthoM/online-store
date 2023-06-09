﻿using OnlineStore.Data.CustomModels;
using OnlineStore.Services.fcInterviewAPI.Models;

namespace OnlineStore.Services.fcInterviewAPI.Users
{
  public interface IUserService
  {
    Task<object> CreateUser(CreateUserRequest createUserRequest);
    Task<User> GetUser(string id);
    Task<UsersResponse> GetUsers();
    ResponseModel Login(LoginModel loginModel);
  }
}