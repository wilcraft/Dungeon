using System;
using System.Linq;

namespace Dungeon
{
    class Commands
    {
        private readonly string[] CommandsList = new string[] {"LOOK"};
        
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
        private void DoLook(Room env) {
            Console.WriteLine($"{env.ShortDescription}\n{env.LongDescription}");
        }

        private void DoLookAt(Entity ent)
        {
            
        }
    }
}
