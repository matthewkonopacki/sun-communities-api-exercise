namespace SunCommunitiesApi.Models;

public class FeeResponse
{
  public decimal InputAmount { get; set; }
  public bool Preferred { get; set; }
  public decimal BaseRate { get; set; }
  public decimal EffectiveRate { get; set; }
  public decimal CalculatedFee { get; set; }
  public bool IsCapped { get; set; }

  public FeeResponse(
    decimal inputAmount, 
    bool preferred, 
    decimal baseRate, 
    decimal effectiveRate, 
    decimal calculatedFee, 
    bool isCapped)
    {
        InputAmount = inputAmount;
        Preferred = preferred;
        BaseRate = baseRate;
        EffectiveRate = effectiveRate;
        CalculatedFee = calculatedFee;
        IsCapped = isCapped;
    }
};