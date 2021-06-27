using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class Worker
    {
        public enum Job
        {
            Vet,
            Cleaner,
            Builder,
            Trainer,
            Administrator
        }

        public enum Sex
        {
            Male,
            Female,
            Other
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, StringLength(24)]
        public string FirstName { get; set; }

        [Required, StringLength(24)]
        public string LastName { get; set; }

        [Required]
        public Sex Gender { get; set; }

        [Required]
        public float Age { get; set; }

        [Required]
        public Job Occupation { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Payrate { get; set; }

        [Required]
        public DateTime DateJoined { get; set; }

        [Required]
        public ICollection<Animal> Animals { get; set; }
    }
}
