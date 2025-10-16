using System.Runtime.InteropServices.Marshalling;
using RPGRenovado.Controller;

namespace RPGRenovado.Models;

public class Personagem
{
    //! Obrigatório
    public string Nome { get; set; }
    public string Classe { get; set; }
    public string Raca { get; set; }

    //? Opcionais
    public int Vida { get; set; }
    public int Magia { get; set; }
    public int Level { get; set; }
    public int Forca { get; set; }
    public int Inteligencia { get; set; }
    public int Agilidade { get; set; }
    public int Resistencia { get; set; }
    public int Carisma { get; set; }
    public List<string> Inventario { get; set; }
    public string Passado { get; set; }

    public Personagem(string n, string c, string r)
    {
        Nome = n;
        Classe = c;
        Raca = r;
        Level = 1;
        Inventario = new();
        InicializaPersonagem.AdicionaItensIniciais(this);
        InicializaPersonagem.DistribuiAtributos(this);
        Vida = Resistencia * 2 + (Forca / 2);
    }
}