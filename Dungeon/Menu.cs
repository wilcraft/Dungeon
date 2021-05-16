using System;

namespace Dungeon
{
    class Menu
    {
        public static void Main(string[] args) {
            Menu menu = new Menu();
            menu.BeginCreation();
        }
        private void BeginCreation()
        {
            Console.WriteLine("Would you like to create a character? Y/N");
            var Input = Console.ReadLine().ToUpper();
            Console.Clear();
            var character = Input == "Y" ? "Select a race:" : Input == "N" ? "Farewell." : "";
            Console.WriteLine(character);
            SelectRace();
        }
        private void SelectRace()
        {
            foreach (var race in Races.GetPlayableRaces())
            {
                Console.WriteLine(Races.RaceKindToString(race));
            }
            var Input = Console.ReadLine().ToUpper();
            Races.RacialModifiers stats;
            switch (Input)
            {
                case "HUMAN":
                    stats = Races.GetRacialModifier(RaceKind.Human);
                    break;
                case "HALF-ELF":
                    stats = Races.GetRacialModifier(RaceKind.HalfElf);
                    break;
                case "ELF":
                    stats = Races.GetRacialModifier(RaceKind.Elf);
                    break;
                case "ORC":
                    stats = Races.GetRacialModifier(RaceKind.Orc);
                    break;
                case "GNOME":
                    stats = Races.GetRacialModifier(RaceKind.Gnome);
                    break;
                case "SKELETON":
                    Races.GetRaceName(RaceKind.Skeleton);
                    stats = Races.GetRacialModifier(RaceKind.Skeleton);
                    break;
                case "DWARF":
                    Races.GetRaceName(RaceKind.Dwarf);
                    stats = Races.GetRacialModifier(RaceKind.Dwarf);
                    break;
                case "GOBLIN":
                    Races.GetRaceName(RaceKind.Goblin);
                    stats = Races.GetRacialModifier(RaceKind.Goblin);
                    break;
                default:
                    stats = Races.GetRacialModifier(RaceKind.Human);
                    break;
            }
            Console.WriteLine($"You have {stats.GetAttackModifier()} attack, {stats.GetArmorModifier()} armor and {stats.GetHealthModifier()} health");
            Console.Clear();
            Adventure();
        }
        private void Adventure()
        {
            Console.WriteLine("What do you wish to do?\n" +
                              "Walk, Sit, Sleep?");
            SelectAction();
        }
        private void SelectAction()
        {
            Player player = new Player();
            Room rom = new Room("The creepy forest", "Very creepy indeed.");
            player.TransferEntity(player, rom);
            Parser parser = new Parser(player);
            while (true) {
                String Input = Console.ReadLine();
                parser.Parse(Input);
            }
        }
    }
}