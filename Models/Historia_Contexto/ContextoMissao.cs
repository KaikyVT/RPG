using RPGRenovado.Models;
using RPGRenovado.Models.Historias_Inicio;
using RPGRenovado.View;

namespace RPGRenovado.Historia_Contexto;

public class ContextoMissao : IHistoria
{
    public static void Iniciar(Personagem p)
    {
        ConsoleRenderer.WriteLine("História está para acabar");
    }
}
