using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Drink
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? PricePerPerson { get; set; }
        public string? VTA { get; set; }

        public string? Description { get; set; }
        public bool? Alcohol { get; set; }
     //   public List<Days> Days { get; set; } = new List<Days>();
       // public List<ServingTimes> ServingTimes { get; set; } = new List<ServingTimes>();



    }
}
