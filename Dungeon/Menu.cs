﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    class Menu
    {
        public void BeginCreation()
        {
            Console.WriteLine("Would you like to create a character? Y/N");
            var Input = Console.ReadLine().ToUpper();
            var character = Input == "Y" ? "Select a race:" : Input == "N" ? "Farewell." : "";
            Console.WriteLine(character);
            Player();
        }
        public void Player()
        {
            foreach (var race in Races.GetPlayableRaces())
            {
                Console.WriteLine(Races.RaceKindToString(race));
            }
            Selectrace();
        }
        public void Selectrace()
        {
            String Input = Console.ReadLine().ToUpper();
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
            Console.WriteLine("Your Adventure begins in the creepy forest");
            Adventure();
        }
        public void Adventure()
        {
            Console.WriteLine("What do you wish to do?");
            Commands Usable = new Commands();
            foreach (var usableaction in Usable.GetUsableCommands)
            {
                {
                    Console.WriteLine();
                }
            }
        }
        public void Actions()
        {
            Commands command = new Commands();
            command.Action(command.StringtoAction(Console.ReadLine()));
        }
    }
}