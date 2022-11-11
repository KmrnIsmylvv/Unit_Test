using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests;

[TestFixture]
public class MathTests
{
    private Math _math;

    [SetUp]
    public void SetUp()
    {
        _math = new Math();
    }

    [Test]
    public void Add_WhenCalled_ReturnSumOfArguments()
    {
        var result = _math.Add(1, 2);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Max_FirstArgumentGreater_ReturnTheFirstArgument()
    {
        var result = _math.Max(2, 1);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Max_SecondArgumentGreater_ReturnTheSecondArgument()
    {
        var result = _math.Max(1, 2);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
    {
        var result = _math.Max(1, 1);

        Assert.That(result, Is.EqualTo(1));
    }
}