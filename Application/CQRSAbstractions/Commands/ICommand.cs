
using Domain.Abstractions.Result;
using MediatR;

namespace Application.CQRSAbstractions.Commands;
public interface ICommand : IRequest<Result> { }

public interface ICommand<TResponse> : IRequest<Result<TResponse>> { }