using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

[TestFixture]
public class FizzBuzzTests
{
    [Test]
    public void GetOutput_DivideThreeAndFive_ReturnFizzBuzz()
    {
        var result = FizzBuzz.GetOutput(15);
        
        Assert.That(result,Is.EqualTo("FizzBuzz"));
    }

    [Test]
    public void GetOutput_DivideThreeOnly_ReturnFizz()
    {
        var result = FizzBuzz.GetOutput(3);
        
        Assert.That(result, Is.EqualTo("Fizz"));
    }

    [Test]
    public void GetOutput_DivideFiveOnly_ReturnBuzz()
    {
        var result = FizzBuzz.GetOutput(5);
        
        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [Test]
    public void GetOutput_NotDivideThreeAndFive_ReturnNumber()
    {
        var result = FizzBuzz.GetOutput(7);
        
        Assert.That(result, Is.EqualTo("7")); 
    }

}