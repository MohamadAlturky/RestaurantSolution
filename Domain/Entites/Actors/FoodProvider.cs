
using Domain.Abstractions.User;

namespace Domain.Entites.Actors;
public class FoodProvider : Actor
{
	public FoodProvider(int id, string name, string password)
		: base(id, name, password) { }
}
