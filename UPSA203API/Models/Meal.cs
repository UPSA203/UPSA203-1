using System;
using System.ComponentModel.DataAnnotations;

namespace UPSA203API.Models
{
    public class Meal
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime EntryDate { get; set; }

        [Required, MaxLength(100)]
        public string FoodName { get; set; }

        [Required]
        public int Calories { get; set; }

        public int? Protein { get; set; }
        public int? Carbs { get; set; }
        public int? Fat { get; set; }
    }
}