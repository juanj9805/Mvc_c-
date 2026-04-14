using Microsoft.AspNetCore.Mvc;

namespace juan.Controllers;

public class UserController : Controller
{
    //views, json, xml, soap
    public IActionResult Index()
    {
        return View();
    }
}