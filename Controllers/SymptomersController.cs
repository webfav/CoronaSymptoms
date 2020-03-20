using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoronaSymptoms.Data;
using CoronaSymptoms.Models;

namespace CoronaSymptoms.Controllers
{
    public class SymptomersController : Controller
    {
        private readonly SymptomerContext _context;

        public SymptomersController(SymptomerContext context)
        {
            _context = context;
        }

        // GET: Symptomers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Symptomer.ToListAsync());
        }

        // GET: Symptomers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptomer = await _context.Symptomer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (symptomer == null)
            {
                return NotFound();
            }

            return View(symptomer);
        }

        // GET: Symptomers/Create
        public IActionResult Create()
        {
            //List<Region> regionlist = new List<Region>();
            ////------Getting data from Database using EntityFrameWorkCore------
            //regionlist = (from product in _context.Region 
            //              select product).ToList();

            ////------Inserting select Item in list------
            //regionlist.Insert(0, new Region { RegionId = 0, RegionNavn = "Vælg region" });

            ////------Assignig regionlist to ViewBag.ListOfRegion------
            //ViewBag.ListOfRegion = regionlist;
            return View();
        }

        // POST: Symptomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Alder,Køn,Region,SymptomerBool,Nyser,Hoster,Feber,Muskelømhed,Diarre,Opkast,Hovedpine,Halsonde,Stakåndethed,Udmattet,Sansetab,Andet")] Symptomer symptomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(symptomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(symptomer);
        }

        // GET: Symptomers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptomer = await _context.Symptomer.FindAsync(id);
            if (symptomer == null)
            {
                return NotFound();
            }
            return View(symptomer);
        }

        // POST: Symptomers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Alder,Køn,Region,SymptomerBool,Nyser,Hoster,Feber,Muskelømhed,Diarre,Opkast,Hovedpine,Halsonde,Stakåndethed,Udmattet,Sansetab,Andet")] Symptomer symptomer)
        {
            if (id != symptomer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(symptomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SymptomerExists(symptomer.Id))
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
            return View(symptomer);
        }

        // GET: Symptomers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var symptomer = await _context.Symptomer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (symptomer == null)
            {
                return NotFound();
            }

            return View(symptomer);
        }

        // POST: Symptomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var symptomer = await _context.Symptomer.FindAsync(id);
            _context.Symptomer.Remove(symptomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SymptomerExists(int id)
        {
            return _context.Symptomer.Any(e => e.Id == id);
        }
    }
}
