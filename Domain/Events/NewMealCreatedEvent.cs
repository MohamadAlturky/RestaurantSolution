using Domain.Abstractions.DomainEvent;
using Domain.Entites;

namespace Domain.Events;
public sealed record NewMealCreatedEvent(Meal meal):IDomainEvent;
