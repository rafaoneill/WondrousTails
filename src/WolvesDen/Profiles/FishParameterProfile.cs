using AutoMapper;

namespace WolvesDen.Profiles
{
    public class FishParameterProfile : Profile
    {
        public FishParameterProfile()
        {
            CreateMap<SaintCoinach.Xiv.FishParameter, AetherCurrents.Database.Entities.FishParameter>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Item, o => o.MapFrom(s => s.Item.Key))
                .ForMember(d => d.GatheringItemLevel, o => o.MapFrom(s => s[2]))
                .ForMember(d => d.TerritoryType, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[4]).Key))
                .ForMember(d => d.IsFish, o => o.MapFrom(s => s[5]))
                .ForMember(d => d.GatheringSubCategory, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[6]).Key));
        }
    }
}