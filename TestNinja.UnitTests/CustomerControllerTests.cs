using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests;

public class CustomerControllerTests
{
    [Test]
    public void GetCustomer_IdIsZero_ReturnNotFound()
    {
        var controller = new CustomerController();

        var results = controller.GetCustomer(0);

        // NotFound
        Assert.That(results, Is.TypeOf<NotFound>());

        // NotFound and one of its derivatives
        // Assert.That(results, Is.InstanceOf<NotFound>());
    }

    [Test]
    public void GetCustomer_IdIsNotZero_ReturnOk()
    {
        var controller = new CustomerController();

        var results = controller.GetCustomer(1);
        
        Assert.That(results, Is.TypeOf<Ok>());
        
        // Assert.That(results, Is.InstanceOf<Ok>());
    }
}