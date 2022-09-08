using Microsoft.AspNetCore.Mvc;
using SignalR5.Models;
using SinemaOtomasyonu;
using System.Diagnostics;

namespace SignalR5.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            ViewBag.Mesajlar = context.Mesajlar;
            return View();
        }

        [HttpPost]
        public IActionResult MesajEkle([FromBody] Mesaj m)
        {
            context.Mesajlar.Add(m);
            context.SaveChanges();
            //return RedirectToAction("Index", "Home");
            return Ok();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        // /Home/GetData

        [HttpPost]
        public IActionResult GetData([FromBody] Mesaj model)
        {
            return Ok();
        }
    }
}