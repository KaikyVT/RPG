using RPGRenovado.Historia_Contexto;
using RPGRenovado.View;

namespace RPGRenovado.Models.Historias_Inicio;

public class ComecoFuga : IHistoria
{
    public static string Titulo => "=== Fuga da Prisão ===";
    public static string Descricao => "Não é fácil, mas o sabor da liberdade é digno do maior esforço.\n";

    public static void Iniciar(Personagem p)
    {
        // TODO: História será feita aqui
        ConsoleRenderer.WriteLine(Titulo);
        ConsoleRenderer.WriteLine(Descricao);
        ConsoleRenderer.WriteLine("Você se encontra nos dutos do esgoto, logo abaixo dos passos pesados dos guardas da prisão. É possível vê-los pelas grades e até mesmo escutar as falas nojentas sobre os prisioneiros e prisioneiras.");
        ConsoleRenderer.WriteLine("O cheiro é pútrido, uma mistura de urina de rato com sangue. Você mal consegue respirar.");
        ConsoleRenderer.WriteLine("Junto com você está Carla, sua antiga companheira de cela.");
        ConsoleRenderer.WriteLine("Carla(sussurrando): Estamos quase lá, aguenta mais um pouco. Sei que o cheiro está tenebroso, mas vai valer a pena...");
        int escolha = ConsoleRenderer.ReadLine(["[1] Continuar seguindo a Carla", "[2] Dedurar a Carla na esperança de reduzir sua pena", "[3] Seguir por um caminho alternativo nos dutos"]);
        switch (escolha)
        {
            case 1:
                ConsoleRenderer.WriteLine("No caminho vocês ouvem conversas imorais sobre métodos de tortura até então desconhecidos pelo homem. Métodos utilizados nos mais crueis prisioneiros.");
                ConsoleRenderer.WriteLine("Você tenta se lembrar, como de costume, o que você fez... Você não se lembra... Como pode?!");
                ConsoleRenderer.WriteLine("Eventualmente vocês saem da prisão e se deparam com um alto penhasco.");
                ConsoleRenderer.WriteLine("Carla: Olha... Vamos ter que pular...");
                QuedaPrisao.Iniciar(p);
                break;
            case 2:
                ConsoleRenderer.WriteLine("Você grita os guardas, que abrem as grades e pegam ambos, colocando vocês em uma fila.");
                ConsoleRenderer.WriteLine("Carla: VOCÊ É IMBECIL AO EXTREMO, ESPERO QUE SUA MORTE SEJA LENTA E DOL...");
                ConsoleRenderer.WriteLine("Carla é atingida por um virote de besta na cabeça, caindo no chão, falecida.");
                ConsoleRenderer.WriteLine("Após isso você fica com o corpo amarrado em um poste por dias, com o sol escaldante batendo em você. Sem se alimentar e sem beber líquidos, até desidratar e também falecer");
                GameOver.ShowGameOver("Você acha que X9 dura muito no mundo? Entregando os outros assim... Pensa que é quem? Decepcionado do meu joguinho ter chegado em alguém com uma índole tão questionável...");
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