using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    class Races
    {
        public void Human() 
        {
            Races Human = new Races();
            var health = 100;
            var armor = 2;
            var attack = 2;
            Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
        }
        public void HalfElf()
        {
            Races HalfElf = new Races();
            var health = 75;
            var armor = 1;
            var attack = 3;
            Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
        }
        public void Elf()
        {
            Races Elf = new Races();
            var health = 85;
            var armor = 0;
            var attack = 4;
            Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
        }
        public void Orc()
        {
            Races Orc = new Races();
            var health = 115;
            var armor = 2;
            var attack = 7;
            Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
        }
        public void Gnome()
        {
            Races Gnome = new Races();
            var health = 60;
            var armor = 3;
            var attack = 2;
            Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
        }
    }
}
