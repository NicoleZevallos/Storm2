using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers;

public class AdminController : Controller {
     private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }


   public IActionResult Index()
    {
        return View();
    }
    public IActionResult ListarCuentas()
    {
        return View();
    }
    public IActionResult ListarOferta()
    {
        return View();
    }
    public IActionResult ListarProducto()
    {
        return View();
    }
    public IActionResult ListarTransacciones()
    {
        return View();
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

   