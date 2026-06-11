using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp03Ahorcado.Models;

namespace Tp03Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado juegoPalabras = new PalabrasAhorcado();

        ViewBag.PalabraSecreta = juegoPalabras.ObtenerPalabra();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}