namespace Dungeon {
    class Room {
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public Room(string shortd, string longd) {
            this.ShortDescription = shortd;
            this.LongDescription = longd;
        }
    }
}