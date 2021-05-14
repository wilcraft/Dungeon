namespace Dungeon {
    class Room {
        private string _short;
        private string _long;
        public string ShortDescription {
            get {
                return _short;
            }
            set {
                _short = value;
            }
        }
        public string LongDescription {
            get {
                return _long;
            }
            set {
                _long = value;
            }
        }

        public Room(string shortd, string longd) {
            this.ShortDescription = shortd;
            this.LongDescription = longd;
        }
    }
}