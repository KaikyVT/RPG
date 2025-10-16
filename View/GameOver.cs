namespace RPGRenovado.View;

public class GameOver
{
    public static void ShowGameOver(string mensagem)
    {
        ConsoleRenderer.WriteLine("Pressione qualquer tecla para prosseguir.");
        Console.ReadKey();
        Console.Clear();
        ConsoleRenderer.WriteLine("====== GAME OVER ======");
        ConsoleRenderer.WriteLine($"Mensagem do criador: {mensagem}");
    }
}