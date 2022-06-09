using Microsoft.AspNetCore.Mvc;
using noteApp.Entities;

namespace noteApp.Controllers;

[Route("/note")]
public class Note : Controller
{
    private readonly NoteDbContext _db;

    public Note(NoteDbContext db)
    {
        _db = db;
    }

    // GET
    [HttpGet("{id}")]
    public IActionResult SpecyficNote([FromRoute] int id)
    {
        Entities.Note note = _db.Notes.FirstOrDefault(n => n.Id == id);

        if (note is null)
        {
            return NotFound();
        }
        
        return View(note);
    }
    
    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(Entities.Note obj)
    {
        if (ModelState.IsValid)
        {
            _db.Notes.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        return View(obj);
    }
    
    [HttpGet("edit/{id}")]
    public IActionResult Edit([FromRoute] int id)
    {
        var note = _db.Notes.FirstOrDefault(n => n.Id == id);
        if (note is null)
        {
            return NotFound();
        }
        return View(note);
    }
    
    [HttpPost("edit/{id}")]
    public async Task<IActionResult> Edit([FromRoute] int id, Entities.Note obj)
    {
        if (ModelState.IsValid)
        {
            _db.Notes.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("SpecyficNote", new {id = obj.Id});
        }
        return View(obj);
    }
    
    [HttpGet("delete/{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var note = _db.Notes.FirstOrDefault(n => n.Id == id);
        if (note is null)
        {
            return NotFound();
        }

        _db.Notes.Remove(note);
        _db.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
}