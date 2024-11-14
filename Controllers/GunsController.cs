using Microsoft.AspNetCore.Mvc;
using GunStore.Models;
using System.Linq;
using GunStore.Data;

namespace GunStore.Controllers
{
    public class GunsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GunsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Guns
        public IActionResult Index()
        {
            var guns = _context.Guns.ToList();
            return View(guns);
        }

        // GET: Guns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guns/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gun gun)
        {
            if (ModelState.IsValid)
            {
                _context.Guns.Add(gun);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(gun);
        }

        // GET: Guns/Edit/5
        public IActionResult Edit(int id)
        {
            var gun = _context.Guns.Find(id);
            if (gun == null)
            {
                return NotFound();
            }
            return View(gun);
        }

        // POST: Guns/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Gun gun)
        {
            if (ModelState.IsValid)
            {
                _context.Guns.Update(gun);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(gun);
        }

        // GET: Guns/Delete/5
        public IActionResult Delete(int id)
        {
            var gun = _context.Guns.Find(id);
            if (gun == null)
            {
                return NotFound();
            }
            return View(gun);
        }

        // POST: Guns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var gun = _context.Guns.Find(id);
            if (gun != null)
            {
                _context.Guns.Remove(gun);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}