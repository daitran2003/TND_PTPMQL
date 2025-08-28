using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person/Input
        public IActionResult Index()
        {
            return View();
        }

        // POST: Person/Result
        [HttpPost]
        public IActionResult Result(Person person)
        {
            return View(person);
        }
    }
}
