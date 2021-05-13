using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dungeon
{
    class Enemy
    {
        public static void Main(string[] args)
        {
            Menu Creation = new Menu();
            Creation.BeginCreation();
        }
        public void EnemyTypes()
        {
            string[] EnemyNPCType = { "Goblin", "Skeleton", "Dwarf" };
            int Index = StaticRandom.Instance.Next(EnemyNPCType.Length);
            if (EnemyNPCType[Index] == "Goblin")
            {
                var health = 50;
                var attack = StaticRandom.Instance.Next(1, 6);
                var armor = StaticRandom.Instance.Next(0, 2);
                Console.WriteLine($"They have: {health} health points, {attack} attack damage and {armor} armor points!");
            }
            else if (EnemyNPCType[Index] == "Skeleton")
            {
                var health = 75;
                var attack = StaticRandom.Instance.Next(3, 5);
                var armor = StaticRandom.Instance.Next(0, 12);
                Console.WriteLine($"They have: {health} health points, {attack} attack damage and {armor} armor points!");
            }
            else if (EnemyNPCType[Index] == "Dwarf")
            {
                var health = 100;
                var attack = StaticRandom.Instance.Next(2, 4);
                var armor = StaticRandom.Instance.Next(1, 3);
                Console.WriteLine($"They have: {health} health points, {attack} attack damage and {armor} armor points!");
            }
        }
    }
}