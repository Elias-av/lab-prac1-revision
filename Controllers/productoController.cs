using Microsoft.AspNetCore.Mvc;
using lab_prac1.Models;
using lab_prac1.data;
using System.Linq;

namespace lab_prac1.Controllers
{
    public class productoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public productoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult index()
        {
            
            return View(_context.Dataproducto.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(producto objproducto)
        {
            _context.Add(objproducto);
            _context.SaveChanges();
            ViewData["Message"] = "El producto ya esta registrado";
            //return RedirectToAction(nameof(Index));
            return View();
        }

        
        public IActionResult Edit(int id)
        {
            producto objproducto = _context.Dataproducto.Find(id);
            if(objproducto == null){
                return NotFound();
            }
            return View(objproducto);
        }

        [HttpPost]
        public IActionResult Edit(int id,[Bind("id,Nombre, Categoria, Precio, Descuento")] producto objproducto)
        {
             _context.Update(objproducto);
             _context.SaveChanges();
              ViewData["Message"] = "El producto ya esta actualizado";
             return View(objproducto);
        }

        public IActionResult Delete(int id)
        {
            producto objContacto = _context.Dataproducto.Find(id);
            _context.Dataproducto.Remove(objContacto);
            _context.SaveChanges();
            return RedirectToAction(nameof(index));
        }
    }
}
