using System.Collections.Generic;

namespace AetherCurrents.Database.Entities
{
    public partial class FishingSpot
    {
        public FishingSpot()
        {
            FishingSpotItem = new HashSet<FishingSpotItem>();
        }

        public int Id { get; set; }
        public byte GatheringLevel { get; set; }
        public string BigFishOnReach { get; set; }
        public string BigFishOnEnd { get; set; }
        public byte FishingSpotCategory { get; set; }
        public short TerritoryType { get; set; }
        public short X { get; set; }
        public short Z { get; set; }
        public short Radius { get; set; }
        public short PlaceName { get; set; }

        public ICollection<FishingSpotItem> FishingSpotItem { get; set; }
    }
}
