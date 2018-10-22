
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spotifi.Models;

namespace Spotifi.Controllers
{
    public class GruposController : Controller
    {
        private readonly SpotifiContext _context;
        public GruposController(SpotifiContext context)
        {
            this._context = context;

        }
        public IActionResult RegistroGrupo()
        {
            return View();
        }

        public IActionResult RegistroCategoria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistroCategoria(Categoria c)
        {
            if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();

                return RedirectToAction("RegistroCategoriaConfirmacion");
            }

            return View(c);
        }

        public IActionResult RegistroCategoriaConfirmacion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistroGrupo(Banda b)
        {
            if (ModelState.IsValid)
            {
                _context.Add(b);
                _context.SaveChanges();

                return RedirectToAction("RegistroGrupoConfirmacion");
            }

            ViewBag.Bandas = new SelectList(_context.Bandas, "Id", "Nombre");

            return View(b);
        }

        public IActionResult RegistroGrupoConfirmacion()
        {
            return View();
        }
        
        public IActionResult RegistroAlbum() {
            ViewBag.Bandas = new SelectList(_context.Bandas, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult RegistroAlbum(Album a) {
            if (ModelState.IsValid) {
                _context.Albumes.Add(a);
                _context.SaveChanges();

                return RedirectToAction("RegistroAlbumConfirmacion");
            }
                

            return View();
        }

        public IActionResult RegistroAlbumConfirmacion() {
            return View();
        }
        
        public IActionResult Lista()
        {
            var lista = _context.Bandas.Include(x => x.Albumes)
                                       .OrderByDescending(b => b.Id)
                                       .ToList();

            return View(lista);
        }
    }
}