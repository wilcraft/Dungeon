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
                Console.WriteLine(race.ToString());
            }
            String CharacterRace = Console.ReadLine();
            while (CharacterRace != "N")
            {
                String Input = Console.ReadLine().ToUpper();
                if (Input == "Human")
                {
                    Race.Human();
                }
                else if (Input == "Half-Elf")
                {
                    Race.HalfElf();
                }
                else if (Input == "Elf")
                {
                    Race.Elf();
                }
                else if (Input == "Orc")
                {
                    Race.Orc();
                }
                else if (Input == "Gnome")
                {
                    Race.Gnome();
                }
                else if (Input == "N")
                {
                    CharacterRace = "N";
                }
            }
        }
    }
}
