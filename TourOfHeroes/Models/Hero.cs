using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TourOfHeroes.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Hero
    {
        public Hero()
        {
        }

        public Hero(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}