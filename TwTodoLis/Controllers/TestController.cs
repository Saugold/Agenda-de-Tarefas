using Microsoft.AspNetCore.Mvc;

namespace TwTodoLis.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            
            TempData["message"] = "Mensagem vinda da action Index";
            return View();
        }

       
    }
}
