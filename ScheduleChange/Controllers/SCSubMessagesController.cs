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
    public class SCSubMessagesController : Controller
    {
        private readonly SCContext _context;

        public SCSubMessagesController(SCContext context)
        {
            _context = context;
        }

        // GET: SCSubMessages
        public async Task<IActionResult> Index()
        {
            return View(await _context.SCSubMessages.ToListAsync());
        }
        [Route("sub-messages/{id:int:min(1)}")]
        public async Task<IActionResult> GetSubMessagesBySitatex(int id)
        {
            var data = await _context.SCSubMessages.ToListAsync();
            data = data.Where(x => x.SC_SITATEXID == id).ToList();
            var SITATEX_FILE = await _context.SC_SITATEXes.FindAsync(id);
            ViewBag.FILE_NAME = SITATEX_FILE.FileName;
            return View(data);
        }
        // GET: SCSubMessages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCSubMessage = await _context.SCSubMessages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sCSubMessage == null)
            {
                return NotFound();
            }

            return View(sCSubMessage);
        }

        // GET: SCSubMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SCSubMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MessageID,Content,SC_SITATEXID")] SCSubMessage sCSubMessage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sCSubMessage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sCSubMessage);
        }

        // GET: SCSubMessages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCSubMessage = await _context.SCSubMessages.FindAsync(id);
            if (sCSubMessage == null)
            {
                return NotFound();
            }
            return View(sCSubMessage);
        }

        // POST: SCSubMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MessageID,Content,SC_SITATEXID")] SCSubMessage sCSubMessage)
        {
            if (id != sCSubMessage.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sCSubMessage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SCSubMessageExists(sCSubMessage.ID))
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
            return View(sCSubMessage);
        }

        // GET: SCSubMessages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sCSubMessage = await _context.SCSubMessages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sCSubMessage == null)
            {
                return NotFound();
            }

            return View(sCSubMessage);
        }

        // POST: SCSubMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sCSubMessage = await _context.SCSubMessages.FindAsync(id);
            _context.SCSubMessages.Remove(sCSubMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SCSubMessageExists(int id)
        {
            return _context.SCSubMessages.Any(e => e.ID == id);
        }
    }
}
