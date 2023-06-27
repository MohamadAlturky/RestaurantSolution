using Domain.Abstractions.User;

namespace Domain.Entites.Actors;
public class NCDStudent : Actor
{
	public NCDStudent(int id, string name, string password) : 
		base(id, name, password) { }
}
