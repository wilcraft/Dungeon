using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Encounter : Menu
    {
        
        public void EncounterEngine()
        {
            var Encounterchance = StaticRandom.Instance.Next(1, 101);
            if (Encounterchance > 75) {}

        }
    }
}
