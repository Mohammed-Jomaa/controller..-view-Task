using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult getAll()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        public IActionResult update()
        {
            return View();
        }
        public IActionResult delete()
        {
            return View();
        }
    }
}
