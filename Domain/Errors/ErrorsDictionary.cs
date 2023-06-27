using Domain.Abstractions.Errors;

namespace Domain.Errors;
public static class ErrorsDictionary
{
    public static class Meals
    {
        public static readonly Error NoMealAvailableNow =
            new Error("No Meal Available", "Sorry We Didn't Cook Today");
    }
}
