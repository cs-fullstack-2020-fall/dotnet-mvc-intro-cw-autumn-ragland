using Microsoft.AspNetCore.Mvc;

namespace Classwork.Controllers
{
    public class GreetingController : Controller
    {
        // Endpoint to display simple message
        // localhost:5001/Greeting/Greet
        public IActionResult Greet()
        {
            return Content("Well Hello There");
        }
        // Endpoint with two query params that displays a simple message
        // localhost:5001/Greetin/GreetUser?name=Autumn&visits=10
        public IActionResult GreetUser(string name, int visits)
        {
            return Content($"Well Hello There {name}! You have visited the site {visits} times!");
        }
    }
}