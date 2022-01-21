using System;
using ProjetoRPG.src.Entities;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard Wizard = new Wizard("Jeny", 23, "White Wizard");
            BlackWizard Voldemort = new BlackWizard("Voldemort", 71, "Black Wizard");
            Ninja LiuKang = new Ninja("Liu Kang", 54, "Ninja");

            Console.WriteLine(Wizard.Attack(1));
            Console.WriteLine(Voldemort.Attack(7));
            Console.WriteLine(Wizard.Attack(10));
            Console.WriteLine(Voldemort.Attack(100));
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(LiuKang.Attack());
        }
    }
}
