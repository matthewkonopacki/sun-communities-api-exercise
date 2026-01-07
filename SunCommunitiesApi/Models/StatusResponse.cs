namespace SunCommunitiesApi.Models;

public class StatusResponse
{
  public string Status { get; set; }  

  public StatusResponse(string status)
    {
        Status = status;
    }
};