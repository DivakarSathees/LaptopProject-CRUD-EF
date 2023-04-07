using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LaptopProject.Models;

namespace LaptopProject.Controllers
{
    public class LaptopController : Controller
    {
        private readonly LaptopDbContext _context;

        public LaptopController(LaptopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var laptops = _context.Laptops.ToList();
            return View(laptops);
        }

        public IActionResult Details(int id)
        {
            var laptop = _context.Laptops.FirstOrDefault(u => u.Id == id);
            return View(laptop);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Laptop laptop)
        {
            if (ModelState.IsValid)
            {
                _context.Laptops.Add(laptop);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laptop);
        }

        public IActionResult Edit(int id)
        {
            var laptop = _context.Laptops.FirstOrDefault(u => u.Id == id);
            return View(laptop);
        }

        [HttpPost]
        public IActionResult Edit(Laptop laptop)
        {
            if (ModelState.IsValid)
            {
                _context.Laptops.Update(laptop);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laptop);
        }

        public IActionResult Delete(int id)
        {
            var laptop = _context.Laptops.FirstOrDefault(u => u.Id == id);
            return View(laptop);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var laptop = _context.Laptops.FirstOrDefault(u => u.Id == id);
            _context.Laptops.Remove(laptop);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
