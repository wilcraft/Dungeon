using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace Dungeon
{
    public static class Database
    {
        private static readonly string ConString = "Data Source=./db.db;Version=3";
        public static List<Room> LoadRooms()
        {
            using IDbConnection cnn = new SQLiteConnection(ConString);
            var output = cnn.Query<Room>("select * from Rooms", new DynamicParameters());
            return output.ToList();
        }
    }
}