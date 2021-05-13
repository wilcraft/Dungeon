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
            foreach (var race in Race.GetPlayableRaces())
            {
                Console.WriteLine(Race.RaceKindToString(race));
            }
            while (true)
            {
                String Input = Console.ReadLine().ToUpper();
                Races.RacialModifiers stats;
                switch (Input) {
                    case "HUMAN":
                        stats = Race.GetRacialModifier(RaceKind.Human);
                        break;
                    case "HALF-ELF":
                        stats = Race.GetRacialModifier(RaceKind.HalfElf);
                        break;
                    case "ELF":
                        stats = Race.GetRacialModifier(RaceKind.Elf);
                        break;
                    case "ORC":
                        stats = Race.GetRacialModifier(RaceKind.Orc);
                        break;
                    case "GNOME":
                        stats = Race.GetRacialModifier(RaceKind.Gnome);
                        break;
                    case "SKELETON":
                        Race.GetRaceName(RaceKind.Skeleton);
                        stats = Race.GetRacialModifier(RaceKind.Skeleton);
                        break;
                    case "DWARF":
                        Race.GetRaceName(RaceKind.Dwarf);
                        stats = Race.GetRacialModifier(RaceKind.Dwarf);
                        break;
                    case "GOBLIN":
                        Race.GetRaceName(RaceKind.Goblin);
                        stats = Race.GetRacialModifier(RaceKind.Goblin);
                        break;
                    default:
                        stats = Race.GetRacialModifier(RaceKind.Human);
                        break;
                }
                Console.WriteLine($"You have {stats.GetAttackModifier()} attack, {stats.GetArmorModifier()} armor and {stats.GetHealthModifier()} health");
            }
        }
        public void Actions()
        {

        }
    }
}
