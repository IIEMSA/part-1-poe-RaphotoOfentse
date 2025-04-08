using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace EventEaseDB.Models
{
	public class Booking
	{
        public int BookingID { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Customer Email")]
        [EmailAddress]
        [StringLength(100)]
        public string CustomerEmail { get; set; }

        [Required]
        [Display(Name = "Event Name")]
        [StringLength(100)]
        public string EventName { get; set; }

        [Required]
        [Display(Name = "Number of Guests")]
        public int NumberOfGuests { get; set; }
    }
}