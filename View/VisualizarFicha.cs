using RPGRenovado.Models;

namespace RPGRenovado.View;

public class VisualizarFicha
{
    public static void VisualizarFichaPersonagem(Personagem p)
    {
        ConsoleRenderer.WriteLine($"Nome: {p.Nome}");
        ConsoleRenderer.WriteLine($"Classe: {p.Classe}");
        ConsoleRenderer.WriteLine($"Raca: {p.Raca}");
        ConsoleRenderer.WriteLine("=== ATRIBUTOS ===");
        ConsoleRenderer.WriteLine($"Vida: {p.Vida}❤️");
        ConsoleRenderer.WriteLine($"Força: {p.Forca}");
        ConsoleRenderer.WriteLine($"Agilidade: {p.Agilidade}");
        ConsoleRenderer.WriteLine($"Inteligência: {p.Inteligencia}");
        ConsoleRenderer.WriteLine($"Resistência: {p.Resistencia}");
        ConsoleRenderer.WriteLine($"Carisma: {p.Carisma}");
        ConsoleRenderer.WriteLine($"Level: {p.Level}");
        ConsoleRenderer.WriteLine("=== INVENTÁRIO ===");
        foreach (var i in p.Inventario)
        {
            ConsoleRenderer.WriteLine($"- {i}".ToUpper());
        }
    }
}