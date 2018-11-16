namespace AetherCurrents.Database.Entities
{
    public partial class SpearfishingItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Item { get; set; }
        public short GatheringItemLevel { get; set; }
        public short TerritoryType { get; set; }
        public bool IsVisible { get; set; }
    }
}
