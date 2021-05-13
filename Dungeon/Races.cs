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
        Gnome,
        Dwarf,
        Skeleton,
        Goblin
    }
    class Races
    {
        public struct RacialModifiers {
            int health;
            int armor;
            int attack;

            public RacialModifiers(int hp, int arm, int atk) {
                this.health = hp;
                this.armor = arm;
                this.attack = atk;
            }
        }
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
                case RaceKind.Dwarf:
                    return "Dwarf";
                case RaceKind.Skeleton:
                    return "Skeleton";
                case RaceKind.Goblin:
                    return "Goblin";
                default:
                    return "Undefined";
            }
        }
        public RacialModifiers GetRacialModifier(RaceKind race) {
            switch (race) {
                case RaceKind.Human:
                    return new RacialModifiers(100, 2, 2);
                case RaceKind.HalfElf:
                    return new RacialModifiers(75, 1, 3);
                default:
                    return new RacialModifiers(0,0,0);
            }
        }
        public void GetRaceName(RaceKind name)
        {
            switch (name)
            {
                case RaceKind.Skeleton:
                    String[] SkeletonBaseName = { "Indiana Bones", "Lazy Bonez", "Edward", "Dee Ceased", "Leboneski" };
                    Console.WriteLine($"{SkeletonBaseName[StaticRandom.Instance.Next(SkeletonBaseName.Length)]} the {RaceKind.Skeleton} has appeared! ");
                    break;
                case RaceKind.Dwarf:
                    String[] DwarfBaseName = { "Nodreat", "Kisdras", "Reistoud", "Brundrek", "Thebaeck" };
                    Console.WriteLine($"{DwarfBaseName[StaticRandom.Instance.Next(DwarfBaseName.Length)]} the {RaceKind.Dwarf} has appeared! ");
                    break;
                case RaceKind.Goblin:
                    String[] GoblinBaseName = { "Talk", "Zyskasb", "Zearark", "Srazz", "Klimirm" };
                    Console.WriteLine($"{GoblinBaseName[StaticRandom.Instance.Next(GoblinBaseName.Length)]} the {RaceKind.Goblin} has appeared! ");
                    break;
            }
                
        }
    }
}
