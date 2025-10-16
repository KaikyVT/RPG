namespace RPGRenovado.View;

public class GameOver
{
    public static void ShowGameOver(string mensagem)
    {
        ConsoleRenderer.ReadKey();
        Console.Clear();
        ConsoleRenderer.WriteLine("====== GAME OVER ======");
        ConsoleRenderer.WriteLine($"Mensagem do criador: {mensagem}");
    }
}