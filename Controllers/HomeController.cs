using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    //localhost/
    public string Index()
    {
        return "home/index";
    }
}