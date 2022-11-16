namespace TestNinja.Fundamentals;

public class CustomerController
{
    public ActionResult GetCustomer(int id)
    {
        if (id is 0)
            return new NotFound();

        return new Ok();
    }
}

public class ActionResult
{
}

public class NotFound : ActionResult
{
}

public class Ok : ActionResult
{
}