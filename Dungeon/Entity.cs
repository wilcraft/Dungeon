namespace Dungeon {
    abstract class Entity {
        private RaceKind _race;
        public RaceKind Race {
            get {
                return _race;
            }
            set {
                _race = value;
            }
        }
    }
}