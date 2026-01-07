namespace SunCommunitiesApi.Models;

public class FeeResponse
{
  public decimal InputAmount { get; set; }
  public bool IsPreferred { get; set; }
  public decimal BaseRate { get; set; }
  public decimal EffectiveRate { get; set; }
  public decimal CalculatedFee { get; set; }
  public bool IsCapped { get; set; }

  public FeeResponse(
    decimal inputAmount, 
    bool isPreferred, 
    decimal baseRate, 
    decimal effectiveRate, 
    decimal calculatedFee, 
    bool isCapped)
    {
        InputAmount = inputAmount;
        IsPreferred = isPreferred;
        BaseRate = baseRate;
        EffectiveRate = effectiveRate;
        CalculatedFee = calculatedFee;
        IsCapped = isCapped;
    }
};