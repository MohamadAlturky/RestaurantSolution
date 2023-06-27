using Application.UnitOfWork;
using Domain.Repositories;
using Persistance.Repositories;

namespace Persistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {

        }
        public IMealRepository MealRepository { get => new MealRepository(); set => throw new NotImplementedException(); }
    }
}
