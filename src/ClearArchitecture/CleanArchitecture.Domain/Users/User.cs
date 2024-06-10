using CleanArquitecture.Domain.Abstractions;
using CleanArquitecture.Domain.Users.Events;

namespace CleanArquitecture.Domain.Users;

public sealed class User : Entity
{
    private User(
        Guid id,
        Nombre nombre,
        Apellido apellido,
        Email email
        ) : base(id)
    {
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
    }

    public Nombre? Nombre { get; private set; }
    public Apellido? Apellido { get; private set; }
    public Email? Email { get; private set; }

    public static User Create(
        Nombre nombre,
        Apellido apellido,
        Email email
        )
    {
        var user = new User(
            Guid.NewGuid(),
            nombre,
            apellido,
            email
        );
        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));
        return user;
    }
}