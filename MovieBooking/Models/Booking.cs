using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking.Models
{
    public class Booking
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        public int NumberOfTickets { get; set; }

        [Required]
        public double Amount { get; set; }
        
        [Required]
        public string Currency { get; set; }

    }
}
