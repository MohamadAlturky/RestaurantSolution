using Domain.Abstractions.Result;
using MediatR;

namespace Application.CQRSAbstractions.Commands;
public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
            where TCommand : ICommand { }

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
            where TCommand : ICommand<TResponse> { }
