namespace Dungeon
{
    public enum EncounterKind {
        Common,
        Elite,
        Boss
    }
    class Encounter
    {
        public void EncounterEngine()
        {
            var Encounterchance = StaticRandom.Instance.Next(1, 101);
            if (Encounterchance > 75) {}

        }
    }
}
