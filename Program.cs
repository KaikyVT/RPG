using RPGRenovado.Controller;
using RPGRenovado.Models;
using RPGRenovado.View;

namespace RPGRenovado;

public class Program
{
    static void Main(string[] args)
    {
        // Temporariamente comentar a linha abaixo para facilitar o debug
        Personagem personagem = CriacaoPersonagem.Criar();   //! Criação do personagem! Não tirar daqui do começo!!

        // Temporariamente descomentar a linha abaixo para facilitar o debug
        // Personagem personagem = new("Beta Tester", "Guerreiro", "Humano");

        DefineComeco.DefinirComeco(personagem);

    }
}