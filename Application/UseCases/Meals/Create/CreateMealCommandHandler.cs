using Application.CQRSAbstractions.Commands;
using Domain.Abstractions.Result;
using Domain.UnitOfWork;

namespace Application.UseCases.Meals.Create;
public class GetMealsCommandHandler : ICommandHandler<CreateMealCommand>
{

    public IUnitOfWork UnitOfWork { get; set; }

    public GetMealsCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateMealCommand request, CancellationToken cancellationToken)
    {
        Domain.Entites.Meal meal = new Domain.Entites.Meal(
            request.Name,
            request.Description,
            request.ImageURL,
            request.NumberOfCalories
        );
        UnitOfWork.MealRepository.CreateMeal(meal);
        return Result.Success();
    }
}

