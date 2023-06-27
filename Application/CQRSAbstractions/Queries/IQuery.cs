using Domain.Abstractions.Result;
using MediatR;

namespace Application.CQRSAbstractions.Queries;
public interface IQuery<TResponse> :
    IRequest<Result<TResponse>> { }