using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

[TestFixture]
public class DemeritPointsCalculatorTests
{
    [Test]
    public void CalculateDemeritPoints_SpeedIsNotGreaterZero_ThrowsArgumentOutOfRangeException()
    {
        var demerit = new DemeritPointsCalculator();

        // var results = demerit.CalculateDemeritPoints(-1);
        
        Assert.That(()=> demerit.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException> ());
    }

    [Test]
    public void CalculateDemeritPoints_SpeedIsNotGreaterSpeedLimit_ReturnZero()
    {
        var demerit = new DemeritPointsCalculator();

        var results = demerit.CalculateDemeritPoints(30);
        
        Assert.That(results, Is.EqualTo(0));
    }

    [Test]
    public void CalculateDemeritPoints_SpeedGreaterSpeedLimit_ReturnDemeritPoint()
    {
        var demerit = new DemeritPointsCalculator();

        var results = demerit.CalculateDemeritPoints(70);
        
        Assert.That(results, Is.EqualTo(1));
    }
}