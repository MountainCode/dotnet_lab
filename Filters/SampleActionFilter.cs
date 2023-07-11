using Microsoft.AspNetCore.Mvc.Filters;

public class SampleActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) {
        Console.WriteLine("OnActionExecuting");
        // Do something before the action executes.
    }

    public void OnActionExecuted(ActionExecutedContext content) {
        // Do something after the action executes.
        Console.WriteLine("OnActionExecuted");
    }
}
