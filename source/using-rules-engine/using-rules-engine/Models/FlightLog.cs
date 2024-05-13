using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class FlightLog
    {
        public int Id { get; set; }
        public required string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public bool Augmented { get; set; }
        public bool TakeOff { get; set; }
        public bool Landing { get; set; }
        public string? TakeOffLocation { get; set; }
        public string? LandingLocation { get; set; }
        public int FlightHours { get; set; }
        public bool RightSeat { get; set; }
        public bool ETOPS { get; set; }
        public string? Rank { get; set; }
        public string? Role { get; set; }
        public string? Training { get; set; }
        public bool IsETR { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public required User User { get; set; }
    }
}

