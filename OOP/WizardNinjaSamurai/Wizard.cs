using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            // Wizard should have a default health of 50 and Intelligence of 25
            Intelligence = 25;
            Health = 50;
        }

        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target)
        {
            int damage = Intelligence * 5;
            target.Health -= damage;
            Health += damage;
            Console.WriteLine($"{Name} attacked {target.Name} and dealt {damage} damage! {target.Name} now has {target.Health} health.");
            return target.Health;
        }
    }
}