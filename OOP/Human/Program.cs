using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human mandalorian = new Human("Mandalorian");
            Human moffGideon = new Human("Moff Gideon");
            mandalorian.Attack(moffGideon);
        }
    }
}
