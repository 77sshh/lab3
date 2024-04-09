using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.Server.Models;

namespace TRPO_Lab3.Server.Controllers
{
    public class CircleSegmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(CircleSegmentModel model)
        {
            // Проверка модели на валидность
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            try
            {
                // Вычислить площадь сегмента круга на основе модели
                double area = Lib.Class1.CircleSegment(model.radiu5, model.angle);

                // Передать результат в представление
                ViewBag.Area = area;
            }
            catch (Exception ex)
            {
                // Обработка исключения, если радиус или угол отрицательные
                ViewBag.ErrorMessage = ex.Message;
            }

            return View("Index");
        }
    }
}
