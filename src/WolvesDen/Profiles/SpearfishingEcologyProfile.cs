using AutoMapper;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    public class SpearfishingEcologyProfile : Profile
    {
        public SpearfishingEcologyProfile()
        {
            CreateMap<SaintCoinach.Xiv.XivRow, AetherCurrents.Database.Entities.SpearfishingEcology>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.ShadowsDescription, o => o.MapFrom(s => s[0]))
                .ForMember(d => d.IntensifyDescription, o => o.MapFrom(s => s[1]))
                .ForMember(d => d.ShapeDescription, o => o.MapFrom(s => s[2]))
                .ForMember(d => d.NearbyDescription, o => o.MapFrom(s => s[3]));
        }
    }
}