using System.Runtime.InteropServices.Marshalling;
using RPGRenovado.View;

namespace RPGRenovado.Models.Historias_Inicio;

public class ComecoBar : IHistoria
{
    public static string Titulo => "=== Taverna ===";
    public static string Descricao => "|Como manda o manual, aquele começo clássico e inesquecível!|\n";

    public static void Iniciar(Personagem p)
    {
        ConsoleRenderer.WriteLine(Titulo);
        ConsoleRenderer.WriteLine(Descricao);
        ConsoleRenderer.WriteLine("Você acorda em uma taverna. Bebeu muito, tanto que mal se lembra do próprio nome.");
        ConsoleRenderer.WriteLine($"Bartender: {p.Nome}! Eu já fechei e abri a taverna e você está no mesmo lugar");
        ConsoleRenderer.WriteLine("Você");
        ConsoleRenderer.WriteLine("Está");
        ConsoleRenderer.WriteLine("MALUCO?");
        int escolha = ConsoleRenderer.ReadLine(["[1] Desculpa... Não sou muito forte com álcool...", "[2] Mentira sua. Não tem como isso ser verdade.", "[3] Mil perdões, lorde! *Fazer reverência*"]);
        switch (escolha)
        {
            case 1: ConsoleRenderer.WriteLine("Bartender: Então por que caixas d'água você ainda bebe TANTO?!"); break;
            case 2:
                ConsoleRenderer.WriteLine("Bartender: Olha lá fora então! - Ele diz irritado.");
                ConsoleRenderer.WriteLine("Você olha e a noite que te acompanhava no bar te largou ao canto dos pássaros e ao raiar do Sol.");
                break;
            case 3: ConsoleRenderer.WriteLine("Bartender: Hum... Tá bom. - Ele faz pouco caso"); break;
        }
        ConsoleRenderer.WriteLine($"Bartender: De qualquer forma... Não é só isso que eu tenho para falar. Tem um povo querendo falar contigo, {p.Nome}");

        //TODO História continua
    }
}