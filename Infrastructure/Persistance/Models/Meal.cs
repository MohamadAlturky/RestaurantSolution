using System;
using System.Collections.Generic;

namespace Persistance.Models
{
    public partial class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Type { get; set; }
        public int PriceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime UpdatedBy { get; set; }
        public string Description { get; set; } = null!;

        public virtual MealPricing Price { get; set; } = null!;
    }
}
