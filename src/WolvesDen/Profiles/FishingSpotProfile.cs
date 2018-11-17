using AutoMapper;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    public class FishingSpotProfile : Profile
    {
        public FishingSpotProfile()
        {
            CreateMap<SaintCoinach.Xiv.FishingSpot, AetherCurrents.Database.Entities.FishingSpot>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.BigFishOnEnd, o => o.MapFrom(s => s.OnEndBigFish ?? string.Empty))
                .ForMember(d => d.BigFishOnReach, o => o.MapFrom(s => s.OnReachBigFish ?? string.Empty))
                .ForMember(d => d.TerritoryType, o => o.MapFrom(s => s.TerritoryType == null ? 0 : s.TerritoryType.Key))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.FishingSpotItem, o => o.ResolveUsing(s => 
                {
                    var items = new List<AetherCurrents.Database.Entities.FishingSpotItem>();
                    for(int i = 0; i <= 9; i++)
                    {
                        var name = string.Format("Item[{0}]", i);
                        var item = s[name] == null ? 0 : ((SaintCoinach.Xiv.XivRow)s[name]).Key;
                        items.Add(new AetherCurrents.Database.Entities.FishingSpotItem
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