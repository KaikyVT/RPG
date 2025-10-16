using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using RPGRenovado.Models;
using RPGRenovado.View;

namespace RPGRenovado.Models;

public class InicializaPersonagem
{
    public static readonly Dictionary<string, string> ItensIniciais = new()
    {
        {"Guerreiro", "espada"},
        {"Mago", "cajado"},
        {"Ladino", "adaga"},
        {"Bardo", "alaúde"}
    };

    public static void AdicionaItensIniciais(Personagem p)
    {
        Console.Clear();
        if (ItensIniciais.TryGetValue(p.Classe, out string? itemInicial))
        {
            p.Inventario.Add(itemInicial);
            p.Inventario.Add("poção de vida");
        }
    }

    public static void DistribuiAtributos(Personagem p)
    {
        if (AtributosClasse.AtributosBaseClasses.TryGetValue(p.Classe, out var baseStats))
        {
            p.Forca = baseStats["Forca"];
            p.Agilidade = baseStats["Agilidade"];
            p.Resistencia = baseStats["Resistencia"];
            p.Inteligencia = baseStats["Inteligencia"];
            p.Carisma = baseStats["Carisma"];
        }
        if (AtributosRaca.AtributosBonusRacas.TryGetValue(p.Raca, out var baseStatsRaca))
        {
            p.Forca += baseStatsRaca["Forca"];
            p.Agilidade += baseStatsRaca["Agilidade"];
            p.Resistencia += baseStatsRaca["Resistencia"];
            p.Inteligencia += baseStatsRaca["Inteligencia"];
            p.Carisma += baseStatsRaca["Carisma"];
        }
    }
}