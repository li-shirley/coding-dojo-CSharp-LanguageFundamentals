using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50)
        {
            // Wizard should have a default health of 50 and Intelligence of 25
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

        // Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal(Human target)
        {
            int hp = Intelligence * 10;
            target.Health += hp;
            Console.WriteLine($"{Name} healed {target.Name} by {hp} hp! {target.Name} now has {target.Health} health.");
            return target.Health;
        }
    }
}