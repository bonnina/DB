using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Food
    {
        public enum FoodType
        {
            Grass,
            Hay,
            Fruit,
            Vegetables,
            FishFood,
            Meat,
            Mice,
            Birds,
            Fish,
            Insects,
            Grains
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public FoodType Type { get; set; }
    }
}
