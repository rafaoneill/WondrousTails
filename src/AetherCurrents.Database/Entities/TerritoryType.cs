namespace AetherCurrents.Database.Entities
{
    public partial class TerritoryType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bg { get; set; }
        public short PlaceNameRegion { get; set; }
        public short PlaceNameZone { get; set; }
        public short PlaceName { get; set; }
        public short Map { get; set; }
        public byte TerritoryIntendedUse { get; set; }
        public byte WeatherRate { get; set; }
        public int ArrayEventHandler { get; set; }
        public int Aetheryte { get; set; }
    }
}
