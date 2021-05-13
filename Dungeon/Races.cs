using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{

    public enum RaceKind {
        Human,
        HalfElf,
        Elf,
        Orc,
        Gnome
    }
    class Races
    {
        public String RaceKindToString(RaceKind race) {
            switch (race) {
                case RaceKind.Human:
                    return "Human";
                case RaceKind.HalfElf:
                    return "Half-Elf";
                case RaceKind.Elf:
                    return "Elf";
                case RaceKind.Orc:
                    return "Orc";
                case RaceKind.Gnome:
                    return "Gnome";
                default:
                    return "Undefined";
            }
        }
        public void GetRacialModifier(RaceKind race) {
            int health;
            int armor;
            int attack;
            switch (race) {
                case RaceKind.Human:
                    health = 100;
                    armor = 2;
                    attack = 2;
                    Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
                case RaceKind.HalfElf:
                    health = 75;
                    armor = 1;
                    attack = 3;
                    Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
                case RaceKind.Elf:
                    health = 85;
                    armor = 0;
                    attack = 4;
                    Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
                case RaceKind.Orc:
                    health = 115;
                    armor = 2;
                    attack = 7;
                    Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
                case RaceKind.Gnome:
                    health = 60;
                    armor = 3;
                    attack = 2;
                    Console.WriteLine($"You have {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
            }
        }
    }
}
