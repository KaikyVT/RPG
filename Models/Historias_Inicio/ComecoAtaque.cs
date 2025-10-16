using RPGRenovado.Historia_Contexto;
using RPGRenovado.View;

namespace RPGRenovado.Models.Historias_Inicio;

public class ComecoAtaque : IHistoria
{
    public string Titulo => "=== Ataque dos Dragões ===";
    public string Descricao => "Tudo estava bem... De onde essas criaturas surgiram?!\n";

    public static void Iniciar(Personagem p)
    {
        ConsoleRenderer.WriteLine("Você está vivendo pacificamente em sua pequena vila, vila essa que você viveu toda a sua infância, adolescência e início da vida adulta.");
        ConsoleRenderer.WriteLine("De repente, um barulho ao longe estrida e o solo vibra levemente. Alguns terremotos já ocorreram antes, você pensa que está tudo bem.");
        ConsoleRenderer.WriteLine("...");
        ConsoleRenderer.WriteLine("O barulho ocorre novamente, dessa vez mais alto, junto com o que parece um grito agudo de uma criatura uma vez extinta... Ou uma porta rangendo.");
        ConsoleRenderer.WriteLine("Seu instinto começa a sentir algo incomum... ");
        int escolha = ConsoleRenderer.ReadLine(["[1] Ir em direção ao barulho", "[2] Fugir para algum lugar", "[3] Não deve ser nada... Continuar na vila"]);
        switch (escolha)
        {
            case 1:
                ConsoleRenderer.WriteLine("Você dá alguns passos na direção do barulho que está a alguns quilômetros.");
                ConsoleRenderer.WriteLine("O barulho ressoa novamente, dessa vez alto e você vê, ao fundo, uma silhueta voando.");
                ConsoleRenderer.WriteLine("Civil: Mas o que em Oblivion é isso??!");
                break;
            case 2:
                ConsoleRenderer.WriteLine("Você começa a correr e ouve ao fundo o barulho pela terceira vez.");
                ConsoleRenderer.WriteLine("Uma sombra enorme se forma sobre seu corpo e parece estar indo em sua direção, ao longe.");
                ConsoleRenderer.WriteLine("Civil: Mas o que em Oblivion é isso??!");
                break;
            case 3:
                ConsoleRenderer.WriteLine("O barulho ressoa novamente, dessa vez alto e você vê, ao fundo, uma silhueta voando.");
                ConsoleRenderer.WriteLine("Civil: Mas o que em Oblivion é isso??!");
                break;
        }
        ConsoleRenderer.WriteLine("Você vê ao longe 3 dragões, um azul, um vermelho e um verde, indo para a direção da vila");
        ConsoleRenderer.WriteLine("Guarda: Rápido, entre nessa torre! - Diz um guarda da realeza chamando para uma porta");
        ConsoleRenderer.WriteLine("Chegando perto da porta, o dragão verde desmorona a parte superior da torre com sua asa, caindo na frente da porta e, com o impacto, te nocauteando.");
        ContextoMissao.Iniciar(p);


    }
}