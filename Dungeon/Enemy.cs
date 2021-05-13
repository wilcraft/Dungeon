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
            Enemy Creation = new Enemy(); 
            Creation.BeginCreation();
        }
        public void BeginCreation()
        {
            Enemy Player = new Enemy();
            Console.WriteLine("Would you like to create a character? Y/N");
            var Input = Console.ReadLine().ToUpper();
            var character = Input == "Y" ? "Select a race:" : Input == "N" ? "Farewell." : "";
            Console.WriteLine(character);
            Player.Player();
        }
        public void Player()
        {
            String[] PlayerRace = { "Human", "Half-Elf", "Elf", "Orc", "Gnome" };
            foreach (var race in PlayerRace)
            {
                Console.WriteLine(race.ToString());
            }
            String CharacterRace = Console.ReadLine();
            switch (CharacterRace)
            {
                case "Human":
                    var health = 100;
                    var armor = 1;
                    var attack = 4;
                    Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
                    Console.WriteLine("Are you sure about your choice? Y/N");
                    var input = Console.ReadLine();
                    var confirmation = input == "Y" ? "You're now Human!" : "";
                    break;

                default:
                    Console.WriteLine("Wrong input!");
                    var Input = Console.ReadLine();
                    break;

            }

            public void EnemyTypes()
        {
            string[] EnemyNPCType = { "Goblin", "Skeleton", "Dwarf" };
            String[] DwarfBaseName = { "Nodreat", "Kisdras", "Reistoud", "Brundrek", "Thebaeck" };
            String[] SkeletonBaseName = { "Indiana Bones", "Lazy Bonez", "Edward", "Dee Ceased", "Leboneski" };
            String[] GoblinBaseName = { "Talk", "Zyskasb", "Zearark", "Srazz", "Klimirm" };
            int Index = StaticRandom.Instance.Next(EnemyNPCType.Length);
            int IndexDwarf = StaticRandom.Instance.Next(DwarfBaseName.Length);
            int IndexSkeleton = StaticRandom.Instance.Next(SkeletonBaseName.Length);
            int IndexGoblin = StaticRandom.Instance.Next(GoblinBaseName.Length);
            if (EnemyNPCType[Index] == "Goblin")
            {
                Console.WriteLine($"{GoblinBaseName[IndexGoblin]} the {EnemyNPCType[Index]} has appeared! ");
            }
            else if (EnemyNPCType[Index] == "Skeleton")
            {
                Console.WriteLine($"{SkeletonBaseName[IndexSkeleton]} the {EnemyNPCType[Index]} has appeared! ");
            }
            else if (EnemyNPCType[Index] == "Dwarf")
            {
                Console.WriteLine($"{DwarfBaseName[IndexDwarf]} the {EnemyNPCType[Index]} has appeared! ");
            }

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