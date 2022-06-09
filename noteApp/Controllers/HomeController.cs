using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using noteApp.Entities;
using noteApp.Models;

namespace noteApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly NoteDbContext _db;

    public HomeController(ILogger<HomeController> logger, NoteDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable<Entities.Note> noteObjList = _db.Notes;
        
        return View(noteObjList);
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