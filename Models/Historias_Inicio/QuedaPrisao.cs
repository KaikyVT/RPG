using RPGRenovado.Historia_Contexto;
using RPGRenovado.View;

namespace RPGRenovado.Models.Historias_Inicio;

public class QuedaPrisao : IHistoria
{
    public static string Titulo => "=== A Queda ===";

    public static string Descricao => "Será que a liberdade é digna da minha vida?";

    public static void Iniciar(Personagem p)
    {
        ConsoleRenderer.WriteLine("Carla: VAMOS, E AÍ??");
        int escolha = ConsoleRenderer.ReadLine(["[1] Pular. Melhor que nada né...", "[2] Jamais, tá doida?!", "[3] Buscar outra rota"]);
        switch (escolha)
        {
            case 1:
                ConsoleRenderer.WriteLine("Você pula e...");
                ConsoleRenderer.WriteLine("E...");
                ConsoleRenderer.WriteLine("E...");
                ConsoleRenderer.WriteLine("E...");
                ConsoleRenderer.WriteLine("Você desmaia. Vai saber quanto tempo se passou...");
                ConsoleRenderer.WriteLine("Ao abrir os olhos você está em uma jaula. O pensamento imediato em sua mente é \"Não pode ser... Voltei para a prisão?!\"");
                ContextoMissao.Iniciar(p);
                break;
            case 2:
                ConsoleRenderer.WriteLine("Carla: Tudo bem, covarde...");
                ConsoleRenderer.WriteLine("Tudo bem, covarde...");
                ConsoleRenderer.WriteLine("Carla pula e você nem sequer vê ou escuta se ela caiu na água de forma segura. Há uma névoa muito densa impedindo de ver muito abaixo");
                ConsoleRenderer.WriteLine("Você ouve lentamente passos de guardas fazendo vigia no local");
                ConsoleRenderer.WriteLine("Antes dos guardas sequer chegarem em você, um sono repentino bate e você apaga.");
                ContextoMissao.Iniciar(p);
                break;
            case 3:
                ConsoleRenderer.WriteLine("Você vê Carla pulando no abismo e não consegue visualizar sequer se ela chegou em algum lugar seguro.");
                ConsoleRenderer.WriteLine("Olhando ao redor um pouco, você encontra uma pequena rota de trilha nas florestas.");
                ConsoleRenderer.WriteLine("Ao tentar ir com cuidado, você acaba encurralado por duas duplas de guardas fazendo a vigia do local.");
                ConsoleRenderer.WriteLine("Guarda: FUGITIVO, PEGA ELE!!!");
                ConsoleRenderer.WriteLine("Antes de qualquer coisa, você ouve vindo logo atrás do seu corpo estático de medo");
                ConsoleRenderer.WriteLine("Voz Misteriosa: Não se preocupem, ele é meu.");
                ConsoleRenderer.WriteLine("Você sente uma sonolência forte e apaga");
                ContextoMissao.Iniciar(p);
                break;
        }
    }

}