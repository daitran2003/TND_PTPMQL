using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class BMIController : Controller
    {
        // Hiển thị form nhập
        public IActionResult Index()
        {
            return View();
        }

        // Xử lý kết quả
        [HttpPost]
        public IActionResult Result(BMI bmi)
        {
            if (bmi.Height > 0)
            {
                bmi.Result = bmi.Weight / (bmi.Height * bmi.Height);

                if (bmi.Result < 18.5)
                    bmi.Category = "Gầy";
                else if (bmi.Result < 24.9)
                    bmi.Category = "Bình thường";
                else if (bmi.Result < 29.9)
                    bmi.Category = "Thừa cân";
                else
                    bmi.Category = "Béo phì";
            }
            else
            {
                bmi.Result = 0;
                bmi.Category = "Chiều cao không hợp lệ";
            }

            return View(bmi);
        }
    }
}
