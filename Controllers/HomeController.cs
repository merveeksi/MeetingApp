using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    //localhost/
    public IActionResult Index()
    {
       int saat = DateTime.Now.Hour;
       
       // ViewBag.Selamlama = saat > 12 ? "İyi Günler!" : "Günaydın!";
       // ViewBag.UserName = "Merve";
       
       ViewData["Selamlama"] =  saat > 12 ? "İyi Günler!" : "Günaydın!";
       ViewData["UserName"] = "Merve";

        return View();
    }
}