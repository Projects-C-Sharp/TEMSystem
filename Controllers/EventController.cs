using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TEMSystem.Data;
using TEMSystem.Models;

namespace TEMSystem.Controllers;

public class EventController :  Controller
{
    private readonly MysqlDbContext _context;

    public EventController(MysqlDbContext context)
    {
        _context = context;
    }

    // 🟢 Vista pública
    public IActionResult Public()
    {
        var eventos = _context.events.ToList();
        return View(eventos);
    }

    // 🟢 Panel admin
    public IActionResult Index()
    {
        return View(_context.events.ToList());
    }

    // CREATE
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Event e)
    {
        if (ModelState.IsValid)
        {
            _context.events.Add(e);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(e);
    }

    // EDIT
    public IActionResult Edit(int id)
    {
        var e = _context.events.Find(id);
        return View(e);
    }

    [HttpPost]
    public IActionResult Edit(Event e)
    {
        _context.events.Update(e);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    // DELETE
    public IActionResult Delete(int id)
    {
        var e = _context.events.Find(id);
        _context.events.Remove(e);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}