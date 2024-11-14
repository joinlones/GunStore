using Microsoft.AspNetCore.Mvc;

namespace GunStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Возвращаем пустое представление
        }

        public IActionResult Privacy()
        {
            return View(); // Возвращаем представление для страницы конфиденциальности
        }
    }
}