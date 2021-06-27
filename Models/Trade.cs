using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Trade
    {
        public enum Type
        {
            Given,
            Recieved
        }

        public int Id { get; set; }

        [Required, StringLength(24)]
        public string ZooName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Type TradeType { get; set; }

        [Required]
        public Animal Animal { get; set; }
    }
}
