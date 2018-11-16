namespace AetherCurrents.Database.Entities
{
    public partial class Map
    {
        public int Id { get; set; }
        public string SmallMap { get; set; }
        public string MediumMap { get; set; }
        public byte Hierarchy { get; set; }
        public short MapMarkerRange { get; set; }
        public string MapId { get; set; }
        public short SizeFactor { get; set; }
        public short OffsetX { get; set; }
        public short OffsetY { get; set; }
        public short PlaceNameRegion { get; set; }
        public short PlaceName { get; set; }
        public short PlaceNameSub { get; set; }
        public short DiscoveryIndex { get; set; }
        public short TerritoryType { get; set; }
        public bool DiscoveryArrayByte { get; set; }
    }
}
