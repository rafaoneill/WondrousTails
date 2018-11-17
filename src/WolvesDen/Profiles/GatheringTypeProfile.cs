using AutoMapper;

namespace WolvesDen.Profiles
{
    public class GatheringTypeProfile : Profile
    {
        public GatheringTypeProfile()
        {
            CreateMap<SaintCoinach.Xiv.GatheringType, AetherCurrents.Database.Entities.GatheringType>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.IconMain, o => o.MapFrom(s => s.MainIcon.Path.Replace("tex","png")))
                .ForMember(d => d.IconOff, o => o.MapFrom(s => s.SubIcon.Path.Replace("tex","png")));
        }
    }
}