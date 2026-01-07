using SunCommunitiesApi.Models;

namespace SunCommunitiesApi.Interfaces;

public interface IFeeCalculator
{
    FeeResponse Calculate(decimal amount, bool preferredCustomer);
}   