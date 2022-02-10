using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Wiz");
            Ninja ninja = new Ninja("Ninja");
            Samurai samurai = new Samurai("Samuari");
            ninja.Attack(samurai);
            ninja.Steal(samurai);
            samurai.Meditate();
            Console.WriteLine(samurai.Strength);
            Console.WriteLine(samurai.Intelligence);
            Console.WriteLine(samurai.Dexterity);
            Console.WriteLine(samurai.Health);
        }
    }
}
