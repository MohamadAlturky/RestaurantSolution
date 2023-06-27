using Domain.Abstractions.User;

namespace Application.JWTProvider;
public interface IJWTProvider
{
	string GenerateJWT(Actor actor);
}
