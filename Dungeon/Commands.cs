using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Commands
    {
        public string[] CommandsList = new string[] {"LOOK"};
        
        public void CommandHook(string[] args, Entity ent) {
            switch (args[0].ToUpper()) {
                case "LOOK":
                    DoLook(ent.GetRoom());
                    break;
                default:
                    break;
            }
        }

        public bool IsValidCommand(string command) {
            return CommandsList.Contains(command.ToUpper());
        }
        public void DoWalk() {
            Console.WriteLine("You trek through the forest");
        }
        public void DoLook(Room env) {
            Console.WriteLine($"{env.ShortDescription}\n{env.LongDescription}");
        }
    }
}
