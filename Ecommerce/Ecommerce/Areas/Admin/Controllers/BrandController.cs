﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Areas.Admin.Data;
using Ecommerce.Areas.Admin.Models;

namespace Ecommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly DPContext _context;

        public BrandController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Brand
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brand.ToListAsync());
        }

        // GET: Admin/Brand/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandModel = await _context.Brand
                .FirstOrDefaultAsync(m => m.BrandID == id);
            if (brandModel == null)
            {
                return NotFound();
            }

            return View(brandModel);
        }

        // GET: Admin/Brand/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Brand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrandID,BrandName,BrandPicture,BrandDescription,BrandStatus")] BrandModel brandModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brandModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brandModel);
        }

        // GET: Admin/Brand/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandModel = await _context.Brand.FindAsync(id);
            if (brandModel == null)
            {
                return NotFound();
            }
            return View(brandModel);
        }

        // POST: Admin/Brand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BrandID,BrandName,BrandPicture,BrandDescription,BrandStatus")] BrandModel brandModel)
        {
            if (id != brandModel.BrandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brandModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandModelExists(brandModel.BrandID))
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
            return View(brandModel);
        }

        // GET: Admin/Brand/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brandModel = await _context.Brand
                .FirstOrDefaultAsync(m => m.BrandID == id);
            if (brandModel == null)
            {
                return NotFound();
            }

            return View(brandModel);
        }

        // POST: Admin/Brand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brandModel = await _context.Brand.FindAsync(id);
            _context.Brand.Remove(brandModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrandModelExists(int id)
        {
            return _context.Brand.Any(e => e.BrandID == id);
        }
    }
}