using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai (string name) : base(name)
        {
            Name = name;
            // Samurai should have a default health of 200
            Health = 200;
        }

        public override int Attack(Human target)
        {
            int damage = Strength * 5;
            if (target.Health <= 50)
            {
                target.Health = 0;
            }
            else {
                target.Health -= damage;
            }
            Console.WriteLine($"{Name} attacked {target.Name} and dealt {damage} damage! {target.Name} now has {target.Health} health.");
            return target.Health;
        }

        // Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
        public int Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} used MEDITATE. Health has been restored.");
            return Health;
        }
    }
}