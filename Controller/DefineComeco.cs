using System.Security.Cryptography;
using RPGRenovado.Models;
using RPGRenovado.Models.Historias_Inicio;

namespace RPGRenovado.Controller;

public class DefineComeco
{
    private static Random ComecoAleatorio = new();

    public static void DefinirComeco(Personagem p)
    {
        // Temporariamente comentar a linha abaixo para facilitar o debug
        int comeco = ComecoAleatorio.Next(1, 4);

        // Temporariamente descomentar a linha abaixo para facilitar o debug
        // int comeco = 3;
        switch (comeco)
        {
            case 1: ComecoBar.Iniciar(p); p.Passado = "Bêbado"; break;
            case 2: ComecoFloresta.Iniciar(p); p.Passado = "Caçador"; break;
            case 3: ComecoAtaque.Iniciar(p); p.Passado = "Sobrevivente"; break;
            case 4: ComecoFuga.Iniciar(p); p.Passado = "Prisioneiro"; break;
        }
    }
}