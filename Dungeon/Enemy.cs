using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dungeon
{
    class Enemy
    {
        private RaceKind race;

        public RaceKind GetRace() {
            return race;
        }

        public void SetRace(RaceKind NewRace) {
            this.race = NewRace;
        }
    }
}