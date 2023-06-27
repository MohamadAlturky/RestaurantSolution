using Application.CQRSAbstractions.Commands;
using Application.JWTProvider;
using Domain.Abstractions.Result;
using Domain.Abstractions.User;
using Domain.Entites.Actors;
using MediatR;

namespace Application.UseCases.LogIn;
public class LogInCommandHandler : ICommandHandler<LogInCommand, string>
{

	private readonly IJWTProvider _provider;


	#warning "Not Implemented Yet"
	public LogInCommandHandler(IJWTProvider provider)
	{
		_provider = provider;
	}

	public Task<Result<string>> Handle(LogInCommand request, CancellationToken cancellationToken)
	{
		// see if the Person is registerd



		Actor actor = new NCDStudent(1, "mohamad", "123");
		// create a JWT


		string JWT = _provider.GenerateJWT(actor);


		// return the JWT
		return Task.FromResult(Result.Success(JWT));
	}
}

