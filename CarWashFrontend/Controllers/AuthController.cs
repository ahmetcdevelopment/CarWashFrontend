using Microsoft.AspNetCore.Mvc;

namespace CarWashFrontend.Controllers;

public class AuthController : Controller
{
    public async Task<IActionResult> Index()
    {
        return View();
    }

    public async Task<IActionResult> Login()
    {
        return View();
    }
}
