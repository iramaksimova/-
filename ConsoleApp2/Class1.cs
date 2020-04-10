using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main()
        {
            Monster Masha = new Monster(200, 200, "Masha");
            Masha.Passport();
            --Masha.Health;
        
            Masha.Ammo += 100;
            Masha.Passport();
        }
    }
}
