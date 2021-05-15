namespace Dungeon {
    abstract class Entity {
        private RaceKind _race;
        private Room _room = null;

        public RaceKind Race {
            get => _race;
            set {
                _race = value;
            }
        }

        public void TransferEntity(Entity entity, Room room) {
            entity._room = room;
        }
        
        public Room GetRoom() {
            return _room;
        }
    }
}