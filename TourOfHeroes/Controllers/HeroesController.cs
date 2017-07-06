using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TourOfHeroes.Data;
using TourOfHeroes.Models;

namespace TourOfHeroes.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private readonly HeroContext dbContext;

        public HeroesController(HeroContext heroContext)
        {
            dbContext = heroContext;
        }

        // GET api/heroes
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return dbContext.Heroes.ToList();
        }

        // GET api/heroes/search/Mr
        [HttpGet("search/{name}")]
        public IEnumerable<Hero> Search(string name)
        {
            return dbContext.Heroes.Where(x => x.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase));
        }

		// GET api/heroes/5
		[HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var hero = dbContext.Heroes.FirstOrDefault(x => x.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return new ObjectResult(hero);
        }

		// POST api/heroes
		[HttpPost]
        public IActionResult Post([FromBody]Hero hero)
        {
            if (hero == null)
            {
                return BadRequest();
            }

            dbContext.Heroes.Add(hero);
            dbContext.SaveChanges();

            return new ObjectResult(hero);
        }

		// PUT api/heroes/5
		[HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Hero hero)
        {
            if (hero == null)
            {
                return BadRequest();
            }

            var herofromdb = dbContext.Heroes.FirstOrDefault(x => x.Id == id);
            if (herofromdb == null)
            {
                return NotFound();
            }

            herofromdb.Name = hero.Name;

            dbContext.Heroes.Update(herofromdb);
            dbContext.SaveChanges();

            return new NoContentResult();
        }

		// DELETE api/heroes/5
		[HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var herofromdb = dbContext.Heroes.FirstOrDefault(x => x.Id == id);
            if (herofromdb == null)
            {
                return NotFound();
            }

            dbContext.Heroes.Remove(herofromdb);
            dbContext.SaveChanges();

            return new NoContentResult();
        }
    }
}
