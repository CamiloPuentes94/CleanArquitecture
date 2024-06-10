using CleanArquitecture.Domain.Abstractions;

namespace CleanArquitecture.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent
{

}
