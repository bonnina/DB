using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Animal
    {
        public enum Diet
        {
            Carnivore,
            Herbivore
        }

        public enum Zone
        {
            Arctic,
            Temperate,
            Tropical,
            Subtropical
        }

        public enum Sex
        {
            Male,
            Female
        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, StringLength(24)]
        public string Name { get; set; }

        [Required, StringLength(24)]
        public string Species { get; set; }

        [Required]
        public Sex Gender { get; set; }

        [Required]
        public double Age { get; set; }

        [Required]
        [Display(Name = "Weight (kg)")]
        public double Weight { get; set; }

        [Required]
        [Display(Name = "Height (m)")]
        public double Height { get; set; }

        [Required]
        public Zone ClimatZone { get; set; }

        [Required]
        public Diet DietType { get; set; }

        [Required]
        [Display(Name = "Enclosure number")]
        public int EnclosureNumber { get; set; }

        [Required]
        public DateTime DateJoined { get; set; }

        [Required]
        public bool NeedsRelocation { get; set; }

        [Required]
        public MedicalRecord MedicalRecord { get; set; }

        [Required]
        public Menu Menu { get; set; }

        public ICollection<Animal> Children { get; set; }
    }
}
