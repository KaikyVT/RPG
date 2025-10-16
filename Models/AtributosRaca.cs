namespace RPGRenovado.Models;

public class AtributosRaca
{
    public static readonly Dictionary<string, Dictionary<string, int>> AtributosBonusRacas = new()
    {
        {"Humano", new Dictionary<string, int>
            {
                {"Forca", 1},
                {"Agilidade", 1},
                {"Resistencia", 0},
                {"Carisma", 1},
                {"Inteligencia", 1}
            }
        },
        {"Elfo", new Dictionary<string, int>
            {
                {"Forca", 0},
                {"Agilidade", 2},
                {"Resistencia", 0},
                {"Carisma", 1},
                {"Inteligencia", 0}
            }
        },
        {"Tiefling", new Dictionary<string, int>
            {
                {"Forca", 0},
                {"Agilidade", 0},
                {"Resistencia", 1},
                {"Carisma", 0},
                {"Inteligencia", 1}
            }
        },
        {"Orc", new Dictionary<string, int>
            {
                {"Forca", 2},
                {"Agilidade", 1},
                {"Resistencia", 2},
                {"Carisma", -1},
                {"Inteligencia", -1}
            }
        },
        {"Anão", new Dictionary<string, int>
            {
                {"Forca", 1},
                {"Agilidade", -1},
                {"Resistencia", 1},
                {"Carisma", 1},
                {"Inteligencia", 0}
            }
        },
        {"Draconato", new Dictionary<string, int>
            {
                {"Forca", 1},
                {"Agilidade", 0},
                {"Resistencia", 2},
                {"Carisma", 0},
                {"Inteligencia", 0}
            }
        },
    };
}