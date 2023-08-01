using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hall
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surface { get; set; }
        public string? Reunion { get; set; }

        public string? TableInU { get; set; }
        public string? SchoolRank { get; set; }
        public string? Conference { get; set; }
        public string? Cabaret { get; set; }
        public string? Banquet { get; set; }
        public string? Showroom { get; set; }
        public string? vide { get; set; }
        public string? Cocktail { get; set; }
        public string? DayLight { get; set; }
        public string? PricePerDay { get; set; }
        public string? PriceHalfDay { get; set; }
        public bool? NoHalfDay { get; set; }
        public string? Description { get; set; }
        public bool? OnlyForSeminar { get; set; }
        
       // public List<string> Equipements { get; set; } = new List<string>();





    }
}
