using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class TinhToanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(TinhToan calc)
        {
            switch (calc.Operation)
            {
                case "sum":
                    calc.Result = calc.Number1 + calc.Number2;
                    break;
                case "sub":
                    calc.Result = calc.Number1 - calc.Number2;
                    break;
                case "mul":
                    calc.Result = calc.Number1 * calc.Number2;
                    break;
                case "div":
                    calc.Result = calc.Number2 != 0 ? calc.Number1 / calc.Number2 : double.NaN;
                    break;
            }

            return View(calc);
        }
    }
}