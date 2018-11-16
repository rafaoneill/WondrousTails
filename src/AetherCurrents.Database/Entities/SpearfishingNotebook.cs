namespace AetherCurrents.Database.Entities
{
    public partial class SpearfishingNotebook
    {
        public int Id { get; set; }
        public byte GatheringLevel { get; set; }
        public int TerritoryType { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short Radius { get; set; }
        public short PlaceName { get; set; }
        public short GatheringPointBase { get; set; }
    }
}
