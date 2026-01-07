namespace SunCommunitiesApi.Services;

using Microsoft.Extensions.Options;
using SunCommunitiesApi.Interfaces;
using SunCommunitiesApi.Models;

public class FeeCalculatorService : IFeeCalculator
{
    private readonly FeeOptions _options;
    private readonly ILogger<FeeCalculatorService> _logger;

    public FeeCalculatorService(ILogger<FeeCalculatorService> logger, IOptions<FeeOptions> options)
    {
        _logger = logger;
        _options = options.Value;
    }
    public FeeResponse Calculate(decimal amount, bool preferredCustomer)
    {
        _logger.LogInformation("Starting fee estimate calculation...");
        decimal feeEstimate = amount * _options.BaseRate;
        decimal effectiveRate = 0m;
        bool isCapped = false;

        if (preferredCustomer)
        {
            effectiveRate = _options.BaseRate - _options.PreferredCustomerDiscount;
            feeEstimate = amount * effectiveRate;
        }

        if (feeEstimate > _options.MaxFee)
        {
            feeEstimate = _options.MaxFee;
            isCapped = true;
            _logger.LogWarning("Fee estimate is above configuration's max fee value. Fee is capped at ${}.", _options.MaxFee);
        }

        return new FeeResponse(amount, preferredCustomer, _options.BaseRate, effectiveRate, feeEstimate, isCapped);
    }
}