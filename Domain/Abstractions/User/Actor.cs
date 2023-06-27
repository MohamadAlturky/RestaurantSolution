namespace Domain.Abstractions.User;
public abstract class Actor
{
	public Actor(int id, string name, string password)
	{
		Id = id;
		Name = name;
		this.password = password;
	}

	public int Id { get; set; }

	public string Name { get; set; }

	public string password { get; set; }
}
