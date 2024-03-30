using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lica_Games.Models;
using System.Text.Json;

namespace Lica_Games.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Jogos> jogos = [];
        using (StreamReader leitor = new("Data\\jogos.json"))
        {
            string dados = leitor.ReadToEnd();
            jogos = JsonSerializer.Deserialize<List<Jogos>>(dados);
        }
        return View(jogos);
    }
    
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
