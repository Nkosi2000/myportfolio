using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myportfolio.Models;
using data;

namespace myportfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly userswhoreachedoutContext _context;

    public HomeController(ILogger<HomeController> logger, userswhoreachedoutContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Contact([Bind("Name,Email,Message")] myportfolio.Models.UsersWhoReachedOut model)
    {
        if (ModelState.IsValid)
        {
            _context.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("ContactConfirmation");
        }
        return View(model);
    }

    public IActionResult ContactConfirmation()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
