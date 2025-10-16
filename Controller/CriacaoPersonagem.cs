using RPGRenovado.Models;
using RPGRenovado.View;
using System.Security.Cryptography.X509Certificates;
using System.Threading; // Adicionado para Sleep

namespace RPGRenovado.Controller;

public static class CriacaoPersonagem
{
    // Dicionários permanecem inalterados.
    public static Dictionary<int, string> ClasseDict = new()
    {
        {1, "Guerreiro"}, {2, "Mago"}, {3, "Ladino"}, {4, "Bardo"}
    };
    public static Dictionary<int, string> RacaDict = new()
    {
        {1, "Humano"}, {2, "Elfo"}, {3, "Tiefling"}, {4, "Orc"}, {5, "Anão"}, {6, "Draconato"}
    };
    public static Personagem Criar()
    {
        string nome;
        string classe;
        string raca;
        bool personagemAceito;
        Console.Clear();
        ConsoleRenderer.WriteLine($"Boas vindas ao RPG! Para criar o personagem, digite suas informações!");
        ConsoleRenderer.ReadKey();

        do // Loop de criação: Continua se o Sumario retornar false
        {
            // CAPTURA o valor retornado por cada método (Define...)
            nome = DefineNome();
            classe = DefineClasse();
            raca = DefineRaca();

            // O Sumario agora RETORNA se o personagem foi ACEITO ou não
            personagemAceito = Sumario(nome, classe, raca);

        }
        while (personagemAceito == false);

        // Finalização: Só executa se o personagem foi aceito
        Console.Clear();
        ConsoleRenderer.WriteLine($"Vamos então para esse mundo mágico! Você deve escolher sabiamente as situações!");
        ConsoleRenderer.ReadKey();
        ConsoleRenderer.Sleep(250);
        Console.Clear();

        // Cria e retorna o objeto Personagem FINAL e ÚNICO
        return new Personagem(nome, classe, raca);
    }

    // 2. DefineNome() (Corrigido para usar ConsoleRenderer.ObterEscolha, se existir)
    public static string DefineNome()
    {
        string nomeAtual;
        int escolha;

        do
        {
            Console.Clear();
            ConsoleRenderer.WriteLine($"Digite seu nome!");
            nomeAtual = Console.ReadLine() ?? string.Empty;

            ConsoleRenderer.WriteLine($"Gostou do nome |{nomeAtual.Trim()}|?");
            // Assumindo que você usa ObterEscolha em ConsoleRenderer para segurança
            escolha = ConsoleRenderer.ReadLine(["[1] Sim, ótimo nome!", "[2] Nah, vou mudar"]);

            if (escolha == 1)
            {
                ConsoleRenderer.WriteLine($"Nome |{nomeAtual.Trim()}| Registrado!");
                ConsoleRenderer.Sleep(250);
                return nomeAtual.Trim(); // RETORNA e sai do loop
            }
        }
        while (true);
    }

    public static string DefineClasse()
    {
        int escolhaClasse;
        int confirmacao;

        do
        {
            Console.Clear();
            ConsoleRenderer.WriteLine("Ótimo, agora escolha a sua classe:");

            escolhaClasse = ConsoleRenderer.ReadLine(
                ["[1] Guerreiro", "[2] Mago", "[3] Ladino", "[4] Bardo"]
            );

            ConsoleRenderer.WriteLine($"Gostou da classe? [{ClasseDict[escolhaClasse]}]");
            confirmacao = ConsoleRenderer.ReadLine(
                ["[1] Sim, ótima classe!", "[2] Nah... Vou mudar"]
            );

            if (confirmacao == 1)
            {
                string classeFinal = ClasseDict[escolhaClasse];
                ConsoleRenderer.WriteLine($"Classe registrada: {classeFinal}!");
                ConsoleRenderer.Sleep(250);
                return classeFinal;
            }
        }
        while (true);
    }

    // 4. DefineRaca() (Já estava correto no seu último envio, adaptado para ObterEscolha)
    public static string DefineRaca()
    {
        int escolhaRaca;
        int confirmacao;

        do
        {
            Console.Clear();
            ConsoleRenderer.WriteLine("Perfeito! Agora vamos definir sua raça!");

            escolhaRaca = ConsoleRenderer.ReadLine(
                ["[1] Humano", "[2] Elfo", "[3] Tiefling", "[4] Orc", "[5] Anão", "[6] Draconato"]
            );

            ConsoleRenderer.WriteLine($"Gostou da raça? [{RacaDict[escolhaRaca]}]");
            confirmacao = ConsoleRenderer.ReadLine(
                ["[1] Sim, ótima raça", "[2] Nah... Vou mudar"]
            );

            if (confirmacao == 1)
            {
                string racaFinal = RacaDict[escolhaRaca];
                ConsoleRenderer.WriteLine($"Raça registrada: {racaFinal}!");
                ConsoleRenderer.Sleep(250);
                return racaFinal;
            }
        }
        while (true);
    }

    // 5. Sumario() agora retorna um booleano para controlar o loop principal
    public static bool Sumario(string nome, string classe, string raca)
    {
        Console.Clear();
        // O Personagem agora é instanciado com as variáveis locais válidas, não nulas!
        Personagem p = new(nome, classe, raca);

        ConsoleRenderer.WriteLine($"Seu personagem ficou da seguinte maneira!");
        // Chame aqui seu método VisualizarFicha.VisualizarFichaPersonagem(p);

        VisualizarFicha.VisualizarFichaPersonagem(p);
        ConsoleRenderer.WriteLine("\nIsso está bom? Ou deseja tentar novamente?");
        int escolha = ConsoleRenderer.ReadLine(["[1] Quero isso mesmo!", "[2] Não! Deixa eu mudar uma coisinha..."]);

        // Retorna TRUE se a escolha for 1 (aceito), FALSE se for 2 (rejeitado)
        return escolha == 1;
    }
}