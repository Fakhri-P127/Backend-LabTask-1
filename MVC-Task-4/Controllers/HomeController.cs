using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Task_4.DAL;
using MVC_Task_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Task_4.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _options;

        public HomeController(AppDbContext options)
        {
            _options = options;
        }

        public IActionResult Index()
        {
            List<Card> cards = _options.Cards.Include(x => x.Profession).ToList();
            return View(cards);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            Card card = _options.Cards.Include(x => x.Profession).Include(x => x.Skills).FirstOrDefault(x => x.Id == id);
            if (card == null) return NotFound();

            return View(card);
        }
        public IActionResult ProfessionPage(int? id)
        {
            if (id == null) return NotFound();
           
            List<Card> cards = _options.Cards.Include(x=>x.Profession).Include( x=>x.Skills).Where(x => x.ProfessionId == id).ToList();
            if (cards == null) return NotFound();

            return View(cards);
        }
    }
}
