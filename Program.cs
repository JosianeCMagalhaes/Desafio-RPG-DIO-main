using Projeto_RPG.src.entities;

namespace Projeto_RPG {

    class Program {
        static void Main(string[] args) {
           Hero arus = new Knight("Arus", 23, "Knight");
           Wizard wizard = new Wizard("Jennica", 99, "White Wizard");

           Console.WriteLine(wizard.Attack(1));
           Console.WriteLine(wizard.Attack(7));
           Console.WriteLine(arus.Attack());


           
        }
    }
}