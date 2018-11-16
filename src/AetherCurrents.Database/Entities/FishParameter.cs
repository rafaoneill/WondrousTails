namespace AetherCurrents.Database.Entities
{
    public partial class FishParameter
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Item { get; set; }
        public short GatheringItemLevel { get; set; }
        public int TerritoryType { get; set; }
        public bool IsFish { get; set; }
        public short GatheringSubCategory { get; set; }
    }
}
