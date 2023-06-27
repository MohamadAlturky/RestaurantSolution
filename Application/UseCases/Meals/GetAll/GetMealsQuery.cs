using Application.CQRSAbstractions.Queries;
using Domain.Entites;
namespace Application.UseCases.Meals.GetAll;
public sealed record GetMealsQuery() : IQuery<IEnumerable<Meal>>;

