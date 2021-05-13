using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Encounter
    {
        static void EncounterEngine()
        {
            Races Race = new Races();
            var Encounterchance = StaticRandom.Instance.Next(1, 101);
            if (Encounterchance > 75)
            {
                foreach (var name in Race.GetRaceName())
                {
                    Console.WriteLine(Race.GetRaceName(name));
                }

            }
        }
    }
}
