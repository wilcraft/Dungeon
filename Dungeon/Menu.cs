using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    class Menu
    {
        public void BeginCreation()
        {
            Menu Player = new Menu();
            Console.WriteLine("Would you like to create a character? Y/N");
            var Input = Console.ReadLine().ToUpper();
            var character = Input == "Y" ? "Select a race:" : Input == "N" ? "Farewell." : "";
            Console.WriteLine(character);
            Player.Player();
        }

        public void Player()
        {
            Races Race = new Races();
            String[] PlayerRace = { "Human", "Half-Elf", "Elf", "Orc", "Gnome" };
            foreach (var race in PlayerRace)
            {
                Console.WriteLine(race);
            }
            while (true)
            {
                String Input = Console.ReadLine().ToUpper();
                switch (Input) {
                    case "HUMAN":
                        Race.GetRacialModifier(RaceKind.Human);
                        break;
                    case "HALF-ELF":
                        Race.GetRacialModifier(RaceKind.HalfElf);
                        break;
                    case "ELF":
                        Race.GetRacialModifier(RaceKind.Elf);
                        break;
                    case "ORC":
                        Race.GetRacialModifier(RaceKind.Orc);
                        break;
                    case "GNOME":
                        Race.GetRacialModifier(RaceKind.Gnome);
                        break;
                    case "SKELETON":
                        Race.GetRaceName(RaceKind.Skeleton);
                        Race.GetRacialModifier(RaceKind.Skeleton);
                        break;
                    case "DWARF":
                        Race.GetRaceName(RaceKind.Dwarf);
                        Race.GetRacialModifier(RaceKind.Dwarf);
                        break;
                    case "GOBLIN":
                        Race.GetRaceName(RaceKind.Goblin);
                        Race.GetRacialModifier(RaceKind.Goblin);
                        break;
                }
            }
        }
    }
}
