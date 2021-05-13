using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public enum CommandKind
    {
        Walk,
        Sit,
        Sleep,
        End
    }
    class Commands
    {
        public static String ActionToString(CommandKind command)
        {
            switch (command)
            {
                case CommandKind.Walk:
                    return "You trek thru the forest";
                case CommandKind.Sit:
                    return "You sit idly for a minute";
                case CommandKind.Sleep:
                    return "You sleep the day away";
                case CommandKind.End:
                    return "You Leave the forest";
                default:
                    return "Undefined";
            }
        }
        public static CommandKind StringToAction(string walk)
        {
            switch (walk.ToUpper())
            {
                case "WALK":
                    return CommandKind.Walk;
                case "SIT":
                    return CommandKind.Sit;
                case "SLEEP":
                    return CommandKind.Sleep;
                case "LEAVE":
                    return CommandKind.End;
                default:
                    return CommandKind.Walk;
            }
        }
        public static CommandKind[] GetUsableCommands()
        {
            return new CommandKind[] { CommandKind.Sit, CommandKind.Sleep, CommandKind.Walk, CommandKind.End};
        }
    }
}
