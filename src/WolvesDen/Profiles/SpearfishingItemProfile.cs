using AutoMapper;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    public class SpearfishingItemProfile : Profile
    {
        public SpearfishingItemProfile()
        {
            CreateMap<SaintCoinach.Xiv.SpearfishingItem, AetherCurrents.Database.Entities.SpearfishingItem>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Description, o => o.MapFrom(s => s["Description"]))
                .ForMember(d => d.Item, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[1]).Key))
                .ForMember(d => d.GatheringItemLevel, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[2]).Key))
                .ForMember(d => d.TerritoryType, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[4]).Key));
        }
    }
}