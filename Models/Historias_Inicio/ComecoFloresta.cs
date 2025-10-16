using RPGRenovado.Historia_Contexto;
using RPGRenovado.View;

namespace RPGRenovado.Models.Historias_Inicio;

public class ComecoFloresta : IHistoria
{
    public static string Titulo => "=== Floresta ===";
    public static string Descricao => "Um começo um pouco alternativo... Ok, uma floresta, mas onde?";

    public static void Iniciar(Personagem p)
    {
        // TODO: História será feita aqui
        ConsoleRenderer.WriteLine(Titulo);
        ConsoleRenderer.WriteLine(Descricao);
        ConsoleRenderer.WriteLine($"Você está caçando algo grande. Já fazem 2, talvez 3 dias que você não dorme confortavelmente.");
        ConsoleRenderer.WriteLine($"Você está devendo isso, afinal, como a vila vai se alimentar sem a sua caça?");
        ConsoleRenderer.WriteLine($"Após alguns minutos desbravando matas densas e abafadas, você ouve um barulho vindo de um arbusto.");
        var escolha = ConsoleRenderer.ReadLine(["[1] Tacar uma pedra no arbusto", "[2] Analisar furtivamente", "[3] Correr muito"]);
        switch (escolha)
        {
            case 1:
                var rol = Rolagens.RolagemForca(p);
                if (Rolagens.AnalisaResultado(rol, 8))
                {
                    ConsoleRenderer.WriteLine($"Você dá uma pedrada e ouve um *tuc*");
                    ConsoleRenderer.WriteLine($"Voz do arbusto: AIII, CALMA!");
                    ConsoleRenderer.WriteLine($"Você vê uma pessoa saindo do arbusto, um humano. Ele possui uma roupa azul e laranja, cores essas que você reconhece imediatamente como cores da realeza.");
                    ConsoleRenderer.WriteLine($"Homem da realeza: Bom... Pelo menos o que dizem sobre sua força é verdade... Sou membro da família Real e gostaria de convocar-te para serviços particulares");
                    ConsoleRenderer.WriteLine($"Antes de poder dizer qualquer coisa você sente sua visão apagando lentamente, até desmaiar.");
                    ContextoMissao.Iniciar(p);
                }
                else
                {
                    ConsoleRenderer.WriteLine($"Você taca a pedra, mas vai tão fraco que mal derruba uma folha.");
                    ConsoleRenderer.WriteLine($"Porém, um barulho estranho surge. Algo se ergue do arbusto, uma figura humana, masculina, um humano!");
                    ConsoleRenderer.WriteLine($"Voz do arbusto: Nossa, que patético, mas a família Real deve estar muito desesperada, então...");
                    ConsoleRenderer.WriteLine($"Antes de poder dizer qualquer coisa você sente sua visão apagando lentamente, até desmaiar.");
                    ContextoMissao.Iniciar(p);
                }
                break;
            case 2:
                var rol2 = Rolagens.RolagemAgilidade(p);
                if (Rolagens.AnalisaResultado(rol2, 8))
                {
                    ConsoleRenderer.WriteLine("Você vê uma movimentação crescente.");
                    ConsoleRenderer.WriteLine("Algo que aparenta grande.");
                    ConsoleRenderer.WriteLine("Você sente medo por toda a sua espinha");
                    ConsoleRenderer.WriteLine("Mas");
                    ConsoleRenderer.WriteLine("No fim");
                    ConsoleRenderer.WriteLine("Era um senhor. Calvo de bigode com roupas azuis e laranja.");
                    ConsoleRenderer.WriteLine($"Antes de poder dizer qualquer coisa você sente sua visão apagando lentamente, até desmaiar.");
                    ContextoMissao.Iniciar(p);
                }
                else
                {
                    ConsoleRenderer.WriteLine($"Antes de poder fazer qualquer coisa você sente sua visão apagando lentamente, até desmaiar.");
                    ContextoMissao.Iniciar(p);
                }
                break;
        }


    }
}