using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja (string name) : base (name)
        {
            Name = name;
            // Ninja should have a default dexterity of 175
            Dexterity = 175;
        }

        // Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack(Human target)
        {
            Random rand = new Random(); 
            int additionalDamage = 0;
            if (rand.Next(5) == 0){
                additionalDamage += 10;
            }
            int damage = (Dexterity * 5) + additionalDamage;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} and dealt {damage} damage! {target.Name} now has {target.Health} health.");
            return target.Health;
        }

        // Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public int Steal(Human target)
        {
            target.Health -= 5;
            health += 5;
            Console.WriteLine($"{Name} stole 5 health from {target.Name}! {Name} now has {Health} health. {target.Name} now has {target.Health} health.") ;
            return target.Health;
        }
    }
}