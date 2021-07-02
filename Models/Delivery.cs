using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Delivery
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public Food Product { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [Display(Name = "Price (USD)")]
        public decimal Price { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
