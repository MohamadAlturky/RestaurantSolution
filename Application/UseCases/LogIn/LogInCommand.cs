using Application.CQRSAbstractions.Commands;
using Domain.Entites;

namespace Application.UseCases.LogIn;
public record LogInCommand(LogInRequest<int> Request):ICommand<string>;
