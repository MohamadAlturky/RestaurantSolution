using Domain.Abstractions.Entity;

namespace Domain.Entites;
/// <summary>
/// The Meal Entity
/// </summary>
public class Meal : BaseEntity
{
    public Meal(string name, string description, string imageURL, int numberOfCalories)
    {
        Name = name;
        Description = description;
        ImageURL = imageURL;
        NumberOfCalories = numberOfCalories;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public int NumberOfCalories { get; set; }
}
