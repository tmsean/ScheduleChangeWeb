using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class PCCsController : Controller
    {
        private readonly SCContext _context;

        public PCCsController(SCContext context)
        {
            _context = context;
        }

        // GET: PCCs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PCCs.ToListAsync());
        }

        // GET: PCCs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCC = await _context.PCCs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pCC == null)
            {
                return NotFound();
            }

            return View(pCC);
        }

        // GET: PCCs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PCCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CityCode,PCCCode,PCCName,QueueNumber,TimeZone,CityName,PCCFullName,CreateBy,CreateDate,UpdateBy,UpdateDate")] PCC pCC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pCC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pCC);
        }

        // GET: PCCs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCC = await _context.PCCs.FindAsync(id);
            if (pCC == null)
            {
                return NotFound();
            }
            return View(pCC);
        }

        // POST: PCCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CityCode,PCCCode,PCCName,QueueNumber,TimeZone,CityName,PCCFullName,CreateBy,CreateDate,UpdateBy,UpdateDate")] PCC pCC)
        {
            if (id != pCC.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pCC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PCCExists(pCC.Id))
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
            return View(pCC);
        }

        // GET: PCCs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCC = await _context.PCCs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pCC == null)
            {
                return NotFound();
            }

            return View(pCC);
        }

        // POST: PCCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pCC = await _context.PCCs.FindAsync(id);
            _context.PCCs.Remove(pCC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PCCExists(int id)
        {
            return _context.PCCs.Any(e => e.Id == id);
        }
    }
}
