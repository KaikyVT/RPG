namespace RPGRenovado.Models;

public class AtributosClasse
{
    public static readonly Dictionary<string, Dictionary<string, int>> AtributosBaseClasses = new()
    {
        // G U E R R E I R O (Foco em Força e Resistencia)
        {"Guerreiro", new Dictionary<string, int>
            {
                {"Forca", 15},
                {"Agilidade", 10},
                {"Resistencia", 14},
                {"Carisma", 8},
                {"Inteligencia", 7}
            }
        },
        // M A G O (Foco em Inteligência)
        {"Mago", new Dictionary<string, int>
            {
                {"Forca", 7},
                {"Agilidade", 12},
                {"Resistencia", 9},
                {"Carisma", 10},
                {"Inteligencia", 16}
            }
        },
        {"Ladino", new Dictionary<string, int>
            {
                {"Forca", 10},
                {"Agilidade", 16},
                {"Resistencia", 11},
                {"Carisma", 10},
                {"Inteligencia", 7}
            }
        },
        {"Bardo", new Dictionary<string, int>
            {
                {"Forca", 9},
                {"Agilidade", 11},
                {"Resistencia", 9},
                {"Carisma", 16},
                {"Inteligencia", 12}
            }
        },
    };
}