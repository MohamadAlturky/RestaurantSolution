
namespace Persistance.Models;

public partial class MealPricing
{
	public MealPricing()
	{
		Meals = new HashSet<Meal>();
	}

	public int Id { get; set; }
	public int RoleId { get; set; }

	public virtual ICollection<Meal> Meals { get; set; }
}
