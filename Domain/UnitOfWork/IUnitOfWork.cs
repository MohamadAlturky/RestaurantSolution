using Domain.Repositories;
namespace Domain.UnitOfWork;
public interface IUnitOfWork
{
    IMealRepository MealRepository { get; set; }
}
