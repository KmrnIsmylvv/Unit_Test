using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests;
[TestFixture]
public class MathTests
{
     [Test]
     public void Add_WhenCalled_ReturnSumOfArguments()
     {
          var math = new Math();

          var result = math.Add(1, 2);
          
          Assert.That(result, Is.EqualTo(3));
     }
}