using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using POE_Part1_ST10452650.Models;

namespace POE_Part1_ST10452650.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Bookings()
    {
        return View();
    }
    public IActionResult Events()
    {
        return View();
    }
    public IActionResult Venues()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
