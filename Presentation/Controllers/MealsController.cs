using Domain.Entites;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.UseCases.Meals.GetAll;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealsController : APIController
    {
        private readonly ILogger<MealsController> _logger;

        public MealsController(ILogger<MealsController> logger, ISender sender) 
            : base(sender)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAllMeals")]
        public async Task<IEnumerable<Meal>> GetAllMeals()
        {
            var query = new GetMealsQuery();

            var response = await _sender.Send(query);
            var meals = response.Value;
            return meals;
        }
		[HttpPost(Name = "Post")]
		public Task<int> GetInt()
		{

			int c = 0;
			throw new Exception("Demo");

			return Task.FromResult(c);
		}
		[HttpPut(Name = "Postr")]
		public Task<int> GetIntger()
		{
			int c = 0;

			_logger.LogWarning("The Admin want to Edit something"+"He Updated the record .....BLA....");
			return Task.FromResult(c);
		}
	}
}
