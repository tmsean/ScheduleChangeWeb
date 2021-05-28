using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class DomesticCitiesController : Controller
    {
        private readonly SCContext _context;

        public DomesticCitiesController(SCContext context)
        {
            _context = context;
        }

        // GET: DomesticCities
        public async Task<IActionResult> Index()
        {
            return View(await _context.DomesticCities.ToListAsync());
        }

        // GET: DomesticCities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domesticCity = await _context.DomesticCities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domesticCity == null)
            {
                return NotFound();
            }

            return View(domesticCity);
        }

        // GET: DomesticCities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DomesticCities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CityCode,CityName,CreateBy,CreateDate,UpdateBy,UpdateDate")] DomesticCity domesticCity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domesticCity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(domesticCity);
        }

        // GET: DomesticCities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domesticCity = await _context.DomesticCities.FindAsync(id);
            if (domesticCity == null)
            {
                return NotFound();
            }
            return View(domesticCity);
        }

        // POST: DomesticCities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CityCode,CityName,CreateBy,CreateDate,UpdateBy,UpdateDate")] DomesticCity domesticCity)
        {
            if (id != domesticCity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domesticCity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomesticCityExists(domesticCity.Id))
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
            return View(domesticCity);
        }

        // GET: DomesticCities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var domesticCity = await _context.DomesticCities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (domesticCity == null)
            {
                return NotFound();
            }

            return View(domesticCity);
        }

        // POST: DomesticCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var domesticCity = await _context.DomesticCities.FindAsync(id);
            _context.DomesticCities.Remove(domesticCity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DomesticCityExists(int id)
        {
            return _context.DomesticCities.Any(e => e.Id == id);
        }
    }
}
