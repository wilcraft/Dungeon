using System.Data;
using System.Data.Sql;

using RoomId = System.UInt32;

namespace Dungeon {
    public class Room {
        public RoomId Id { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public Room() { }
    }
}