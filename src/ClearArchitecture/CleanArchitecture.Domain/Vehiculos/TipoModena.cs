namespace CleanArquitecture.Domain.vehiculos;

public record TipoModena
{
    public static TipoModena None => new("");
    public static TipoModena Dolar => new("USD");
    public static TipoModena Euro => new("EUR");
    private TipoModena(string codigo) => Codigo = codigo;

    public string? Codigo { get; init; }

    public static readonly IReadOnlyCollection<TipoModena> All = new[]
    {
        Dolar,
        Euro
    };

    public static TipoModena FromCodigo(string codigo)
    {
        return All.FirstOrDefault(x => x.Codigo == codigo) ??
            throw new ApplicationException($"Tipo de moneda '{codigo}' no soportado");
        ;
    }
}