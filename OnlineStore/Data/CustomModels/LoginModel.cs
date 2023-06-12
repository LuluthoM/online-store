using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Data.CustomModels
{
  public class LoginModel
  {
    public string UserKey { get; set; }
    public string Name { get; set; }

    [Required(ErrorMessage = "*EmailID is Required")]
    public string EmailID { get; set; }

    [Required(ErrorMessage = "*Password is Required")]
    public string Password { get; set; }

  }
}
