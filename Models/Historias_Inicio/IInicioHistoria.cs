namespace RPGRenovado.Models.Historias_Inicio;

public interface IHistoria
{
    static abstract void Iniciar(Personagem p);

    static string? Titulo { get; }
    static string? Descricao { get; }
}