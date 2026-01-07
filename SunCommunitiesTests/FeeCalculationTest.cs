using Xunit;
using Moq;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace SunCommunitiesTests;
using SunCommunitiesApi.Services;
using SunCommunitiesApi.Models;

public class FeeCalculationTest
{
    private readonly IOptions<FeeOptions> _feeOptions;
    private readonly Mock<ILogger<FeeCalculatorService>> _mockLogger;

    public FeeCalculationTest()
    {
        FeeOptions feeOptions = new FeeOptions
        {
            BaseRate = 0.05m,
            PreferredCustomerDiscount = 0.01m,
            MaxFee = 250m
        };

        _feeOptions = Options.Create(feeOptions);
        _mockLogger = new Mock<ILogger<FeeCalculatorService>>();

    }

    [Fact]
    public void Test1()
    {

        var service = new FeeCalculatorService(_mockLogger.Object, _feeOptions);

        var result = service.Calculate(1000.00m, false);

        Assert.Multiple(
            () => Assert.IsType<FeeResponse>(result),
            () => Assert.Equal(50.00m, result.CalculatedFee),
            () => Assert.False(result.IsCapped)
        );

    }

    [Fact]
    public void Test2()
    {
        var service = new FeeCalculatorService(_mockLogger.Object, _feeOptions);

        var result = service.Calculate(1000.00m, true);

        Assert.Multiple(
            () => Assert.IsType<FeeResponse>(result),
            () => Assert.Equal(40.00m, result.CalculatedFee),
            () => Assert.False(result.IsCapped)
        );

    }

    [Fact]
    public void Test3()
    {
        var service = new FeeCalculatorService(_mockLogger.Object, _feeOptions);

        var result = service.Calculate(20000.00m, true);

        Assert.Multiple(
            () => Assert.IsType<FeeResponse>(result),
            () => Assert.Equal(250.00m, result.CalculatedFee),
            () => Assert.True(result.IsCapped)
        );

    }
}
