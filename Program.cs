using System;
using dotnet_poo.Entities;

namespace DotnetPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 469, 72);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 89);
            WhiteWizard jennica = new WhiteWizard("Jennica", 42, "White Wizard", 325, 474);
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard", 106, 611);

            Console.WriteLine(arus);
            Console.WriteLine(wedge);
            Console.WriteLine(jennica);
            Console.WriteLine(topapa);
            Console.WriteLine(jennica.Attack(468) + arus.Name);
            arus.LoseHP(468);
            Console.WriteLine(jennica.Attack(1) + arus.Name);
            arus.LoseHP(1);
            arus.IsDead();
        }
    }
}
