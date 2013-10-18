using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Blakeit.RunBet.Models
{
    public class Guess
    {
        public int ID { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }


    public class RunnerDbContext : DbContext
    {
        public DbSet<Guess> Guesses { get; set; }
    }
}
