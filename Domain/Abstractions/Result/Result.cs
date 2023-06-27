

using Domain.Abstractions.Errors;

namespace Domain.Abstractions.Result;

public class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }
    public bool IsSuccess { get; set; }
    public Error Error { get; set; }

    public static Result Success() =>new Result(true, Error.None);
    public static Result<TValue> Success<TValue>(TValue value){
        return new Result<TValue>(value, true, Error.None);
    }
    public static Result Failure(Error error) => new Result(false, error);
}

