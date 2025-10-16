using System.Data;
using System.Runtime.CompilerServices;
using RPGRenovado.View;

namespace RPGRenovado.Models;

public class Rolagens
{
    public static Random rng = new();
    public static readonly Dictionary<int, int> BuffOuDebuff = new()
    {
        {1, -5},
        {2, -5},
        {3, -4},
        {4, -4},
        {5, -3},
        {6, -2},
        {7, -2},
        {8, -1},
        {9, -1},
        {10, 0},
        {11, 0},
        {12, 1},
        {13, 1},
        {14, 2},
        {15, 2},
        {16, 3},
        {17, 3},
        {18, 4},
        {19, 4},
        {20, 5}
    };

    public static int RolagemForca(Personagem p)
    {
        var rnd = rng.Next(1, 21);
        if (rnd > 1)
            return rnd + BuffOuDebuff[p.Forca];
        else
            return rnd;
    }
    public static int RolagemAgilidade(Personagem p)
    {
        var rnd = rng.Next(1, 21);
        if (rnd > 1)
            return rnd + BuffOuDebuff[p.Agilidade];
        else
            return rnd;
    }
    public static int RolagemInteligencia(Personagem p)
    {
        var rnd = rng.Next(1, 21);
        if (rnd > 1)
            return rnd + BuffOuDebuff[p.Inteligencia];
        else
            return rnd;
    }
    public static int RolagemResistencia(Personagem p)
    {
        var rnd = rng.Next(1, 21);
        if (rnd > 1)
            return rnd + BuffOuDebuff[p.Resistencia];
        else
            return rnd;
    }
    public static int RolagemCarisma(Personagem p)
    {
        var rnd = rng.Next(1, 21);
        if (rnd > 1)
            return rnd + BuffOuDebuff[p.Carisma];
        else
            return rnd;
    }
    public static bool AnalisaResultado(int valor, int cd)
    {
        if (valor >= cd)
        {
            ConsoleRenderer.WriteLine("Sucesso");
            return true;
        }
        else
        {
            ConsoleRenderer.WriteLine("Falha");
            return false;
        }
    }
}