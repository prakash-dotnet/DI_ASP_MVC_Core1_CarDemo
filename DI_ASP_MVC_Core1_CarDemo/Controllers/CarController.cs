using DI_ASP_MVC_Core1_CarDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI_ASP_MVC_Core1_CarDemo.Controllers
{
    public class CarController : Controller
    {

        private readonly IEngine _engine;
        public CarController(IEngine engine) { 
        
            _engine = engine;   

        }
        public IActionResult Index()
        {
            ViewBag.EngMessage = _engine.StartEngine();
            ViewBag.CarMessage= " Car Started....";
            return View();
        }
    }
}
