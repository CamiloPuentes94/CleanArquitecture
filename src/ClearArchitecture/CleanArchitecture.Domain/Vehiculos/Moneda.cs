namespace CleanArquitecture.Domain.vehiculos;

public record Moneda(decimal Monto, TipoModena TipoModena)
{
    public static Moneda operator +(Moneda primero, Moneda segundo)
    {
        if (primero.TipoModena != segundo.TipoModena)
        {
            throw new ApplicationException("No se pueden sumar montos de diferentes monedas");
        }
        return new Moneda(primero.Monto + segundo.Monto, primero.TipoModena);
    }

    public static Moneda Zero() => new(0, TipoModena.None);
    public static Moneda Zero(TipoModena tipoModena) => new(0, tipoModena);

    public bool IsZero() => this == Zero(TipoModena);
}