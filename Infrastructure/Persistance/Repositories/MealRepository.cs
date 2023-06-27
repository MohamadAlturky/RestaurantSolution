
using Domain.Entites;
using Domain.Repositories;

namespace Persistance.Repositories;

public class MealRepository : IMealRepository
{
    public IEnumerable<Meal> GetMeals()
    {
        List<Meal> meals = new List<Meal>();
        meals.Add(
            new Meal("دجاج بالزر", "طيبة", "مافي صورة", 12)
        );
        
        return meals;
    }

    public int CreateMeal(Meal meal)
    {
        throw new NotImplementedException();
    }
}
