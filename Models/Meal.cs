using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Meal
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public Food Food { get; set; }

        [Required]
        [Display(Name = "Amount (kg)")]
        public double Amount { get; set; }

        [Required]
        public TimeSpan Time { get; set; }
    }
}
