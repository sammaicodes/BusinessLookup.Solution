using System;
using System.ComponentModel.DataAnnotations;


namespace BusinessLookup.Models
{
    public class LocalBusiness
    {
        [Key]
        [Required]
        public int LocalBusinessId { get; set; }

        [Required]
        public string BusinessType { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Rate must be a number between 1 and 5")]
        public int RateReview { get; set; }

    }
}