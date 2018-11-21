using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="GatheringType" />.
    /// </summary>
    public class GatheringTypeProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.GatheringType" /> class
        /// to the <see cref="GatheringType" /> class.
        /// </summary>
        public GatheringTypeProfile()
        {
            CreateMap<SaintCoinach.Xiv.GatheringType, GatheringType>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.IconMain, o => o.MapFrom(s => s.MainIcon.Path.Replace("tex","png")))
                .ForMember(d => d.IconOff, o => o.MapFrom(s => s.SubIcon.Path.Replace("tex","png")));
        }
    }
}