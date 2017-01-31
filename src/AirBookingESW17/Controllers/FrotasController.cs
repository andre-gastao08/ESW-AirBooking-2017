using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AirBookingESW17.Data;
using AirBookingESW17.Models;

namespace AirBookingESW17.Controllers
{
    public class FrotasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FrotasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Frotas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Frotas.ToListAsync());
        }

        // GET: Frotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frota = await _context.Frotas.SingleOrDefaultAsync(m => m.FrotaId == id);
            if (frota == null)
            {
                return NotFound();
            }

            return View(frota);
        }

        // GET: Frotas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Frotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FrotaId,Email,Morada,NIF,Nome,Telefone")] Frota frota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frota);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(frota);
        }

        // GET: Frotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frota = await _context.Frotas.SingleOrDefaultAsync(m => m.FrotaId == id);
            if (frota == null)
            {
                return NotFound();
            }
            return View(frota);
        }

        // POST: Frotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FrotaId,Email,Morada,NIF,Nome,Telefone")] Frota frota)
        {
            if (id != frota.FrotaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrotaExists(frota.FrotaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(frota);
        }

        // GET: Frotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frota = await _context.Frotas.SingleOrDefaultAsync(m => m.FrotaId == id);
            if (frota == null)
            {
                return NotFound();
            }

            return View(frota);
        }

        // POST: Frotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frota = await _context.Frotas.SingleOrDefaultAsync(m => m.FrotaId == id);
            _context.Frotas.Remove(frota);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FrotaExists(int id)
        {
            return _context.Frotas.Any(e => e.FrotaId == id);
        }


        
    }
}
