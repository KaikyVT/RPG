using RPGRenovado.Controller;
using RPGRenovado.Models;
using RPGRenovado.View;

namespace RPGRenovado;

public class Program
{
    static void Main(string[] args)
    {
        Personagem personagem = CriacaoPersonagem.Criar();   //! Criação do personagem! Não tirar daqui do começo!!

        DefineComeco.DefinirComeco(personagem);

    }
}