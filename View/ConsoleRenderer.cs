using System.Runtime.Intrinsics.Arm;

namespace RPGRenovado.View;

public class ConsoleRenderer
{

    private const int VelocidadeFrameMs = 50;
    // * Imprime o texto letra por letra com efeito Typewriter
    public static void WriteLine(string texto)
    {
        foreach (var caractere in texto)
        {
            Console.Write(caractere);
            Thread.Sleep(12);
        }
        Console.WriteLine();
        Thread.Sleep(125);
    }
    public static int ReadLine(List<string> opcoes)
    {
        int escolhaValida = 0;
        bool inputValido = false;
        do
        {
            foreach (var opcao in opcoes)
            {
                WriteLine(opcao);
            }
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out escolhaValida))
            {
                if (escolhaValida >= 1 && escolhaValida <= opcoes.Count)
                {
                    inputValido = true;
                }
                else
                {
                    Console.WriteLine("Opção fora do intervalo. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite apenas o número.");
            }
        }
        while (!inputValido);
        Console.Clear();
        return escolhaValida;
    }

    public static void Sleep(int duracaoTotalMs)
    {
        // 1. Array com os caracteres da animação
        string[] frames = { "|", "/", "-", "\\" };

        // 2. Calcula quantos frames a animação terá (DuracaoTotal / Velocidade do Piscar)
        int numFrames = duracaoTotalMs / VelocidadeFrameMs;

        int frameIndex = 0;

        // Configurações de console para animação suave
        Console.Clear();
        Console.CursorVisible = false;

        for (int i = 0; i < numFrames; i++)
        {
            // Posiciona o cursor no início para redesenhar o frame (mais rápido que Console.Clear)
            Console.SetCursorPosition(0, 0);

            // Imprime o frame atual
            Console.Write($"{frames[frameIndex]}");

            // Avança para o próximo frame, garantindo que volte ao 0 (o resto da divisão)
            frameIndex = (frameIndex + 1) % frames.Length;

            // Pausa controlada (o valor constante definido lá em cima)
            Thread.Sleep(VelocidadeFrameMs);
        }

        // Restaura o console
        Console.Clear();
        Console.CursorVisible = true;
    }

    public static void ReadKey()
    {
        WriteLine("Aperte qualquer tecla para avançar!");
        Console.ReadKey();
    }
}
