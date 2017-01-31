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
    public class PesquisasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PesquisasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Pesquisas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ResAvioes.Include(p => p.Avioes).Include(p => p.Reservas);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pesquisas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesquisa = await _context.ResAvioes.SingleOrDefaultAsync(m => m.Id == id);
            if (pesquisa == null)
            {
                return NotFound();
            }

            return View(pesquisa);
        }

        // GET: Pesquisas/Create
        public IActionResult Create()
        {
            ViewData["AviaoId"] = new SelectList(_context.Avioes, "Id", "AvNome");
            ViewData["ReservaId"] = new SelectList(_context.Reservas, "Id", "Id");
            return View();
        }

        // POST: Pesquisas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AviaoId,DataIda,DataRegresso,Destino,Origem,ReservaId")] ReservaAviao resAviao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resAviao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["AviaoId"] = new SelectList(_context.Avioes, "Id", "AvNome", resAviao.AviaoId);
            ViewData["ReservaId"] = new SelectList(_context.Reservas, "Id", "Id", resAviao.ReservaId);
            return View(resAviao);
        }

        // GET: Pesquisas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesquisa = await _context.ResAvioes.SingleOrDefaultAsync(m => m.Id == id);
            if (pesquisa == null)
            {
                return NotFound();
            }
            ViewData["AviaoId"] = new SelectList(_context.Avioes, "Id", "AvNome", pesquisa.AviaoId);
            ViewData["ReservaId"] = new SelectList(_context.Reservas, "Id", "Id", pesquisa.ReservaId);
            return View(pesquisa);
        }

        // POST: Pesquisas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AviaoId,DataIda,DataRegresso,Destino,Origem,ReservaId")] ReservaAviao resAviao)
        {
            if (id != resAviao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resAviao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PesquisaExists(resAviao.Id))
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
            ViewData["AviaoId"] = new SelectList(_context.Avioes, "Id", "AvNome", resAviao.AviaoId);
            ViewData["ReservaId"] = new SelectList(_context.Reservas, "Id", "Id", resAviao.ReservaId);
            return View(resAviao);
        }

        // GET: Pesquisas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesquisa = await _context.ResAvioes.SingleOrDefaultAsync(m => m.Id == id);
            if (pesquisa == null)
            {
                return NotFound();
            }

            return View(pesquisa);
        }

        // POST: Pesquisas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pesquisa = await _context.ResAvioes.SingleOrDefaultAsync(m => m.Id == id);
            _context.ResAvioes.Remove(pesquisa);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PesquisaExists(int id)
        {
            return _context.ResAvioes.Any(e => e.Id == id);
        }
    }
}
