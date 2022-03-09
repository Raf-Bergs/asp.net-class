﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotoGP.Data;
using MotoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        private readonly GPContext _context;

        public ShopController(GPContext context)
        {
            _context = context;
        }

        public IActionResult OrderTicket()
        {
            ViewData["BannerNr"] = 3;
            ViewData["Countries"] =
                new SelectList(_context.Countries.OrderBy(c => c.Name),
                "CountryID",
                "Name");
            ViewData["Races"] = _context.Races.OrderBy(r => r.Name).ToList();
            return View();
        }

        public IActionResult ConfirmOrder()
        {
            ViewData["BannerNr"] = 3;
            return View();
        }

       

        // GET: Tickets/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Countries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Email,Address,Number,CountryID")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                ticket.RaceID = 1;
                ticket.OrderDate = DateTime.Now;
                ticket.Paid = false;
                _context.Add(ticket);
                _context.SaveChanges();
                return RedirectToAction("ConfirmOrder");
            }
            return View(ticket);
        }

    }
}
