using Domain.Abstractions.User;

namespace Domain.Entites.Actors;
public class SystemManager : Actor
{
	public SystemManager(int id, string name, string password) :
		base(id, name, password) { }
}
