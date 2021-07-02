using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Vaccination
    {
        public enum Desease
        {
            Encephalitis,
            Leptospirosis,
            Rabies,
            Tetanus
        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public Desease Vaccine { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
