using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required, StringLength(24)]
        public string Name { get; set; }

        [Required]
        public ICollection<Food> Food { get; set; }
    }
}
