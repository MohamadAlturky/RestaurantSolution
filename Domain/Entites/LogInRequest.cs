namespace Domain.Entites;

public class LogInRequest<TIdent>
{
	public LogInRequest(TIdent identifier, string password)
	{
		this.identifier = identifier;
		Password = password;
	}

	public TIdent identifier { get; set; }
	public string Password { get; set; }
}
