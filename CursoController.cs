using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult PageCurso()
        {
            return View();
        }
    }
}
