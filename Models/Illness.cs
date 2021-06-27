using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Illness
    {
        public enum Desease
        {
            Anthrax,
            Arthritis,
            Botulism,
            Brucellosis,
            Encephalitis,
            Fever,
            Influenza,
            Leptospirosis,
            Psittacosis,
            Rabies,
            Salmonella,
            Tetanus,
            Tick,
            Warts,
            Parasites
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public Desease Name { get; set; }

        [Required]
        public bool IsolationRequired { get; set; }

        [Required]
        public DateTime DateStarted { get; set; }

        public DateTime DateEnded { get; set; }
    }
}
