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
            int attack;
            int armor;

            public RacialModifiers(int hp, int atk, int arm) {
                this.health = hp;
                this.armor = arm;
                this.attack = atk;
            }

            public int GetHealthModifier() {
                return this.health;
            }
            
            public int GetArmorModifier() {
                return this.armor;
            }

            public int GetAttackModifier() {
                return this.attack;
            }

        }
        public static String RaceKindToString(RaceKind race) {
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

        public static RaceKind StringToRaceKind(string race) {
            switch (race.ToUpper()) {
                case "HUMAN":
                    return RaceKind.Human;
                case "HALF-ELF":
                    return RaceKind.HalfElf;
                case "ELF":
                    return RaceKind.Elf;
                case "ORC":
                    return RaceKind.Orc;
                case "GNOME":
                    return RaceKind.Gnome;
                case "DWARF":
                    return RaceKind.Dwarf;
                case "SKELETON":
                    return RaceKind.Skeleton;
                case "GOBLIN":
                    return RaceKind.Goblin;
                default:
                    return RaceKind.Human;
            }
        }

        public static RacialModifiers GetRacialModifier(RaceKind race) {
            switch (race) {
                case RaceKind.Human:
                    return new RacialModifiers(100, 2, 2);
                case RaceKind.HalfElf:
                    return new RacialModifiers(75, 1, 3);
                case RaceKind.Elf:
                    return new RacialModifiers(85, 0, 4);
                case RaceKind.Orc:
                    return new RacialModifiers(115, 2, 7);
                case RaceKind.Gnome:
                    return new RacialModifiers(60, 3, 2);
                case RaceKind.Skeleton:
                    return new RacialModifiers(75, 3, 0);
                case RaceKind.Dwarf:
                    return new RacialModifiers(100, 2, 2);
                case RaceKind.Goblin:
                    return new RacialModifiers(50, 1, 1);
                default:
                    return new RacialModifiers(0,0,0);
            }
        }
        public static void GetRaceName(RaceKind name)
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
        public static RaceKind[] EnemyNPCRaceTypes()
        {
            return new RaceKind[] { RaceKind.Skeleton, RaceKind.Dwarf, RaceKind.Goblin };
        }
        public static RaceKind[] GetPlayableRaces() {
            return new RaceKind[] {RaceKind.Human, RaceKind.HalfElf, RaceKind.Elf, RaceKind.Orc, RaceKind.Gnome};
        }
    }
}
