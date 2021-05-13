using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Commands
    {
        public enum CommandKind
        {
            Walk,
            Sit,
            Sleep
        }
        public String Action(CommandKind command)
        {
            switch (command)
            {
                case CommandKind.Walk:
                    return "You walk thru the forest";
                case CommandKind.Sit:
                    return "You sit idly for a minute";
                case CommandKind.Sleep:
                    return "You sleep the day away";
                default:
                    return "Undefined";
            }
        }
        public CommandKind StringtoAction(string move)
        {
            switch (move.ToUpper())
            {
                case "WALK":
                    return CommandKind.Walk;
                case "SIT":
                    return CommandKind.Sit;
                case "SLEEP":
                    return CommandKind.Sleep;
                default:
                    return CommandKind.Walk;
            }
        }
        public CommandKind[] GetUsableCommands()
        {
            return new CommandKind[] { CommandKind.Sit, CommandKind.Sleep, CommandKind.Walk};
        }
    }
}
