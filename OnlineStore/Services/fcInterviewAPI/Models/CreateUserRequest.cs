namespace OnlineStore.Services.fcInterviewAPI.Models
{
  public class CreateUserRequest
  {
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public List<Order> Orders { get; set; }
  }
}
