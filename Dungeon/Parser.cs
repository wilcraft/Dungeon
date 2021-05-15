using System.Linq;
using System;

namespace Dungeon {
    class Parser {
        private Commands Commands = new Commands();
        private readonly Entity player = null;

        public Parser(Entity _player) {
            player = _player;
        }
        public void Parse(string prs) {
            string[] Args = prs.Split(" ");
            Args = Args.Where(x => !IsArticle(x)).ToArray();
            if (Commands.IsValidCommand(Args[0])) {
                Commands.CommandHook(Args, player);
            }
        }

        private bool IsArticle(string arg) {
            if (arg == "the") {
                return true;
            }
            else {
                return false;
            }
        }
    }
}