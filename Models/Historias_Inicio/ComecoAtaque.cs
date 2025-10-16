namespace RPGRenovado.Models.Historias_Inicio;

public class ComecoAtaque : IHistoria
{
    public string Titulo => "=== Ataque dos Dragões ===";
    public string Descricao => "Tudo estava bem... De onde essas criaturas surgiram?!\n";

    public static void Iniciar(Personagem p)
    {
        Console.WriteLine("Po");
        // TODO: História será feita aqui

    }
}