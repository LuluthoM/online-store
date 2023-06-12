using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Data.CustomModels
{
  public class ResponseModel
  {
    public bool Status { get; set; }
    public string Message { get; set; }

  }
}
