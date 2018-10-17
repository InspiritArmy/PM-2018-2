
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult RegistroGrupo(GrupoMusical g)
        {
            if (ModelState.IsValid)
            {
                _context.Add(g);
                _context.SaveChanges();

                return RedirectToAction("RegistroGrupoConfirmacion");
            }

            return View(g);
        }

        public IActionResult RegistroGrupoConfirmacion()
        {
            return View();
        }
        public IActionResult Lista()
        {
            var lista = _context.Bandas.Include(x => x.Albumes).ToList();

            return View(lista);
        }
    }
}