using Domain.Abstractions.Result;
using MediatR;

namespace Application.CQRSAbstractions.Queries;

public interface IQueryHandler<TQuery,TResponse> :
    IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse> { }