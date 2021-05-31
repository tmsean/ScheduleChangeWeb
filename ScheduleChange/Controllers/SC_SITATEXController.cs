using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models;
using ScheduleChange.Repository;

namespace ScheduleChange.Controllers
{
    public class SC_SITATEXController : Controller
    {
        private readonly SCContext _context;

        public SC_SITATEXController(SCContext context)
        {
            _context = context;
        }

        // GET: SC_SITATEX
        public async Task<IActionResult> Index()
        {
            var data = await _context.SC_SITATEXes.ToListAsync();
            //data = data.OrderByDescending(x => x.ID).ToList();
            data = (from s in data
                   orderby s.ID descending
                   select s).ToList();
            return View(data);
        }

        // GET: SC_SITATEX/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sC_SITATEX = await _context.SC_SITATEXes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sC_SITATEX == null)
            {
                return NotFound();
            }

            return View(sC_SITATEX);
        }

        // GET: SC_SITATEX/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SC_SITATEX/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FileName,Header,Priority,Destinations,Origin,MessageId,SMI,Text,MessageEnd")] SC_SITATEX sC_SITATEX)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sC_SITATEX);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sC_SITATEX);
        }

        // GET: SC_SITATEX/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sC_SITATEX = await _context.SC_SITATEXes.FindAsync(id);
            if (sC_SITATEX == null)
            {
                return NotFound();
            }
            return View(sC_SITATEX);
        }

        // POST: SC_SITATEX/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FileName,Header,Priority,Destinations,Origin,MessageId,SMI,Text,MessageEnd")] SC_SITATEX sC_SITATEX)
        {
            if (id != sC_SITATEX.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sC_SITATEX);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SC_SITATEXExists(sC_SITATEX.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sC_SITATEX);
        }

        // GET: SC_SITATEX/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sC_SITATEX = await _context.SC_SITATEXes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sC_SITATEX == null)
            {
                return NotFound();
            }

            return View(sC_SITATEX);
        }

        // POST: SC_SITATEX/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sC_SITATEX = await _context.SC_SITATEXes.FindAsync(id);
            _context.SC_SITATEXes.Remove(sC_SITATEX);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SC_SITATEXExists(int id)
        {
            return _context.SC_SITATEXes.Any(e => e.ID == id);
        }
    }
}
