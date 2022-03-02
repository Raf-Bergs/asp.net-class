using Microsoft.AspNetCore.Mvc;
using MotoGP.Data;
using MotoGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        private readonly GPContext _context;

        public InfoController(GPContext context)
        {
            _context = context;
        }
        public IActionResult ListRaces()
        {

            var races = _context.Races.OrderBy(r => r.Date);
            ViewData["BannerNr"] = 0;
            return View(races.ToList());
        }

        public IActionResult BuildMap()
        {

            var races = _context.Races.OrderBy(r => r.Name);
            
            ViewData["BannerNr"] = 0;
            ViewData["Title"] = "Races";
            return View(races.ToList());
        }

        public IActionResult ShowRace(int id)
        {
            var race = _context.Races
                        .SingleOrDefault(r => r.RaceID == id);
            return View(race);
        }
    }
}
