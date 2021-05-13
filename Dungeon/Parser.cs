using System.Linq;
using System;

namespace Dungeon {
    class Parser {
        public void Parse(string prs) {
            string[] Args = prs.Split(" ");
            Args = Args.Where(x => !IsPreposition(x)).ToArray();
            Console.Write("Parsed: ");
            foreach (string arg in Args) {
                Console.Write($"{arg} ");
            }
            Console.Write("\n");
        }

        public bool IsPreposition(string arg) {
            if (arg == "the") {
                return true;
            }
            else {
                return false;
            }
        }
    }
}