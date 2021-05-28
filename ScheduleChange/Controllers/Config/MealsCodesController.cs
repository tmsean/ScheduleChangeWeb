using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScheduleChange.Models.Config;
using ScheduleChange.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers.Config
{
    public class MealsCodesController : Controller
    {
        private readonly SCContext _context;

        public MealsCodesController(SCContext context)
        {
            _context = context;
        }

        // GET: MealsCodes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meals.ToListAsync());
        }

        // GET: MealsCodes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealsCode = await _context.Meals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealsCode == null)
            {
                return NotFound();
            }

            return View(mealsCode);
        }

        // GET: MealsCodes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MealsCodes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Segment,FromTime,ToTime,Compartment,MealCode,FromDate,ToDate,CreateBy,CreateDate,UpdateBy,UpdateDate")] MealsCode mealsCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mealsCode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mealsCode);
        }

        // GET: MealsCodes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealsCode = await _context.Meals.FindAsync(id);
            if (mealsCode == null)
            {
                return NotFound();
            }
            return View(mealsCode);
        }

        // POST: MealsCodes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Segment,FromTime,ToTime,Compartment,MealCode,FromDate,ToDate,CreateBy,CreateDate,UpdateBy,UpdateDate")] MealsCode mealsCode)
        {
            if (id != mealsCode.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mealsCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealsCodeExists(mealsCode.Id))
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
            return View(mealsCode);
        }

        // GET: MealsCodes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealsCode = await _context.Meals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealsCode == null)
            {
                return NotFound();
            }

            return View(mealsCode);
        }

        // POST: MealsCodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mealsCode = await _context.Meals.FindAsync(id);
            _context.Meals.Remove(mealsCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealsCodeExists(int id)
        {
            return _context.Meals.Any(e => e.Id == id);
        }
    }
}
