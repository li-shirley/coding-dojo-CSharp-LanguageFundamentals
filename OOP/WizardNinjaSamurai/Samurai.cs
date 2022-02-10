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

        // Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.       
        public override int Attack(Human target)
        {
            int damage = Strength * 5;
            if (target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{Name} finished {target.Name} off with an OP move!");
            }
            else {
                target.Health -= damage;
                Console.WriteLine($"{Name} attacked {target.Name} and dealt {damage} damage! {target.Name} now has {target.Health} health.");
            }
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