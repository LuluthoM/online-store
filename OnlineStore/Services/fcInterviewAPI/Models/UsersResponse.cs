namespace OnlineStore.Services.fcInterviewAPI.Models
{
  public class User
  {
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public List<string> Orders { get; set; }
  }

  public class UsersResponse
  {
    public List<User> Users { get; set; }
  }
}
