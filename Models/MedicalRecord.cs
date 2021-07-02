using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public class MedicalRecord
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public bool Fertility { get; set; }

        [Required]
        public bool ExpectingChildren { get; set; }

        public DateTime? DateExpectingChildren { get; set; }

        public ICollection<Illness> Illnesses { get; set; }

        public ICollection<Vaccination> Vaccinations { get; set; }
    }
}
