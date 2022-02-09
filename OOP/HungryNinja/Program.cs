using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet yum = new Buffet();
            Ninja shirley = new Ninja("Shirley");
            while(!shirley.IsFull)
            {
                shirley.Eat(yum.Serve());
            }
        }
    }
}
