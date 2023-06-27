using Application.CQRSAbstractions.Queries;
using Domain.Abstractions.Result;
using Domain.Entites;
using Domain.Errors;
using Domain.UnitOfWork;

namespace Application.UseCases.Meals.GetAll;
public class GetMealsQueryHandler : IQueryHandler<GetMealsQuery, IEnumerable<Meal>>
{

    public IUnitOfWork UnitOfWork { get; set; }

    public GetMealsQueryHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<Result<IEnumerable<Meal>>> Handle(GetMealsQuery request,
        CancellationToken cancellationToken)
    {
        if (8 == 9)
        {
            return (Result<IEnumerable<Meal>>)Result.Failure(ErrorsDictionary.Meals.NoMealAvailableNow);
        }
        var result = Result.Success(UnitOfWork.MealRepository.GetMeals());
        return result;
    }
}

