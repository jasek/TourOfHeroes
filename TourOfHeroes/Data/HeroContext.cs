using System;
using Microsoft.EntityFrameworkCore;
using TourOfHeroes.Models;

namespace TourOfHeroes.Data
{
    public class HeroContext: DbContext
    {
		public HeroContext(DbContextOptions<HeroContext> options)
			: base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
