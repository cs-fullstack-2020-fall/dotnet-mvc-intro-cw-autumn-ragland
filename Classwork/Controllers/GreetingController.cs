using Microsoft.AspNetCore.Mvc;

namespace Classwork.Controllers
{
    public class GreetingController : Controller
    {
        public IActionResult Greet()
        {
            return Content("Well Hello There");
        }
        public IActionResult GreetUser(string name, int visits)
        {
            return Content($"Well Hello There {name}! You have visited the site {visits} times!");
        }
    }
}