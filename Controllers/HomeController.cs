using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    //localhost/
    public IActionResult Index()
    {
        return View();
    }
}