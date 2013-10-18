using Blakeit.RunBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Blakeit.RunBet.Controllers
{
    public class RunnersController : Controller
    {
        private RunnerDbContext db = new RunnerDbContext();
        
        public ActionResult Index()
        {
            return View(GetRunners());
        }

        [HttpGet]
        public ActionResult MakeBet()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeBet(int id, int hours, int minutes, int seconds)
        {
            db.Guesses.Add(new Guess() { 
                Hours = hours, Minutes = minutes, Seconds = seconds 
            });
            db.SaveChanges();
            return View();
        }

        public IList<Runner> GetRunners()
        {
            return new List<Runner>()
            {
                new Runner 
                {
                    ID = 1,
                    DisplayName = "Michael Blake"                    
                }
            };
        }

    }
}
