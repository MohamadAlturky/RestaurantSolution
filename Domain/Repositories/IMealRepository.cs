using Domain.Entites;
namespace Domain.Repositories
{
    public interface IMealRepository
    {
        int CreateMeal(Meal meal);
        IEnumerable<Meal> GetMeals();
    }
}