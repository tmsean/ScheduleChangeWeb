using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Data.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class AddressesController : Controller
    {
        private readonly SCCContext _context;

        public AddressesController(SCCContext context)
        {
            _context = context;
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Addresses.ToListAsync());
        }

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addresses = await _context.Addresses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addresses == null)
            {
                return NotFound();
            }

            return View(addresses);
        }

        // GET: Addresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,City,Address")] Addresses addresses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addresses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addresses);
        }

        // GET: Addresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addresses = await _context.Addresses.FindAsync(id);
            if (addresses == null)
            {
                return NotFound();
            }
            return View(addresses);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,City,Address")] Addresses addresses)
        {
            if (id != addresses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addresses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressesExists(addresses.Id))
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
            return View(addresses);
        }

        // GET: Addresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addresses = await _context.Addresses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addresses == null)
            {
                return NotFound();
            }

            return View(addresses);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addresses = await _context.Addresses.FindAsync(id);
            _context.Addresses.Remove(addresses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressesExists(int id)
        {
            return _context.Addresses.Any(e => e.Id == id);
        }
    }
}
