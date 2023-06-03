using Microsoft.AspNetCore.Mvc;

namespace MVCAsp.Controllers
{
    public class LearningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
