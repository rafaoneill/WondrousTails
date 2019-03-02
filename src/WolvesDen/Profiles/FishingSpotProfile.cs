using AetherCurrents.Database.Entities;
using AutoMapper;
using System.Collections.Generic;
using System.Globalization;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="FishingSpot" />.
    /// </summary>
    public class FishingSpotProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.FishingSpot" /> class
        /// to the <see cref="FishingSpot" /> class.
        /// </summary>
        public FishingSpotProfile()
        {
            CreateMap<SaintCoinach.Xiv.FishingSpot, FishingSpot>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.BigFishOnEnd, o => o.MapFrom(s => s.OnEndBigFish ?? string.Empty))
                .ForMember(d => d.BigFishOnReach, o => o.MapFrom(s => s.OnReachBigFish ?? string.Empty))
                .ForMember(d => d.TerritoryType, o => o.MapFrom(s => s.TerritoryType == null ? 0 : s.TerritoryType.Key))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.FishingSpotItem, o => o.ResolveUsing(s =>
                {
                    var items = new List<FishingSpotItem>();
                    for (int i = 0; i <= 9; i++)
                    {
                        var name = string.Format(CultureInfo.CurrentCulture, "Item[{0}]", i);
                        var item = s[name] == null ? 0 : ((SaintCoinach.Xiv.XivRow)s[name]).Key;
                        items.Add(new FishingSpotItem
                        {
                            FishingSpotId = s.Key,
                            Sequence = i,
                            Item = item
                        });
                    }
                    return items;
                }));
        }
    }
}