using System;
using System.Collections.Generic;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> unitList = new List<Unit>() { new MilitaryUnit(3, 10,
                15, 10), new SettlerUnit(2, 8) };

            foreach(Unit u in unitList)
            {
                Console.WriteLine(u);
                u.Move();
            }
        }
    }
}
