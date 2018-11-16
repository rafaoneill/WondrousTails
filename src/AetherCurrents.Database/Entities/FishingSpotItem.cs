namespace AetherCurrents.Database.Entities
{
    public partial class FishingSpotItem
    {
        public int FishingSpotId { get; set; }
        public int Sequence { get; set; }
        public int Item { get; set; }

        public FishingSpot FishingSpot { get; set; }
    }
}
