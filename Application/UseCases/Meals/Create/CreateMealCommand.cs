using Application.CQRSAbstractions.Commands;

namespace Application.UseCases.Meals.Create;
public sealed record CreateMealCommand(string Name, string Description,
    string ImageURL, int NumberOfCalories) : ICommand;
