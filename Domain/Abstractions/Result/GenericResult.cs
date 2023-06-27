
using Domain.Abstractions.Errors;

namespace Domain.Abstractions.Result;
public class Result<T> : Result
{
    private  T _value;
    protected internal Result(T value, bool isSuccess, Error error) 
        : base(isSuccess, error)
    {
        _value = value;
    }

    public T Value => IsSuccess? _value:
        throw new InvalidOperationException("The value of a failure result can't be accessed.");
}

