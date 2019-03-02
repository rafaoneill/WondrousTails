using AetherCurrents.Database.Entities;
using AutoMapper;
using SaintCoinach.Xiv;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="AetherCurrents.Database.Entities.SpearfishingEcology" />.
    /// </summary>
    public class SpearfishingEcologyProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.XivRow" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.SpearfishingEcology" /> class.
        /// </summary>
        public SpearfishingEcologyProfile()
        {
            CreateMap<XivRow, SpearfishingEcology>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.ShadowsDescription, o => o.MapFrom(s => s[0]))
                .ForMember(d => d.IntensifyDescription, o => o.MapFrom(s => s[1]))
                .ForMember(d => d.ShapeDescription, o => o.MapFrom(s => s[2]))
                .ForMember(d => d.NearbyDescription, o => o.MapFrom(s => s[3]));
        }
    }
}