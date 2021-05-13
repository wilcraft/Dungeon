﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{

    public enum RaceKind {
        Human,
        HalfElf,
        Elf,
        Orc,
        Gnome,
        Dwarf,
        Skeleton,
        Goblin
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
                case RaceKind.Skeleton:
                    health = 75;
                    attack = StaticRandom.Instance.Next(3, 5);
                    armor = StaticRandom.Instance.Next(0, 12);
                    Console.WriteLine($"They have: {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
                case RaceKind.Dwarf:
                    health = 100;
                    attack = StaticRandom.Instance.Next(2, 4);
                    armor = StaticRandom.Instance.Next(1, 3);
                    Console.WriteLine($"They have: {health} health points, {attack} attack damage and {armor} armor points!");
                    break;
                case RaceKind.Goblin:
                    health = 50;
                    attack = StaticRandom.Instance.Next(1, 6);
                    armor = StaticRandom.Instance.Next(0, 2);
                    Console.WriteLine($"They have: {health} health points, {attack} attack damage and {armor} armor points!");
                    break;

            }
        }
        public void GetRaceName(RaceKind name)
        {
            switch (name)
            {
                case RaceKind.Skeleton:
                    String[] SkeletonBaseName = { "Indiana Bones", "Lazy Bonez", "Edward", "Dee Ceased", "Leboneski" };
                    int IndexSkeleton = StaticRandom.Instance.Next(SkeletonBaseName.Length);
                    Console.WriteLine($"{SkeletonBaseName[IndexSkeleton]} the {RaceKind.Skeleton} has appeared! ");
                    break;
                case RaceKind.Dwarf:
                    String[] DwarfBaseName = { "Nodreat", "Kisdras", "Reistoud", "Brundrek", "Thebaeck" };
                    int IndexDwarf = StaticRandom.Instance.Next(DwarfBaseName.Length);
                    Console.WriteLine($"{DwarfBaseName[IndexDwarf]} the {RaceKind.Dwarf} has appeared! ");
                    break;
                case RaceKind.Goblin:
                    String[] GoblinBaseName = { "Talk", "Zyskasb", "Zearark", "Srazz", "Klimirm" };
                    int IndexGoblin = StaticRandom.Instance.Next(GoblinBaseName.Length);
                    Console.WriteLine($"{GoblinBaseName[IndexGoblin]} the {RaceKind.Goblin} has appeared! ");
                    break;
            }
                
        }
    }
}
