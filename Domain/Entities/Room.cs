using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room
    {
        public Guid Id { get; set; }
        public string? Denomination { get; set; }
        public string? BedNumber { get; set; }
        public string? MaxAdultsOccupation { get; set; }

        public string? MaxKidsOccupation { get; set; }
        public string? TotalRoomNumber { get; set; }
        public string? Description { get; set; }
        public string? PMSIntegration { get; set; }

    }
}
