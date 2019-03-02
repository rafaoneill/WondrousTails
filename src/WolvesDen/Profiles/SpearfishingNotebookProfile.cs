using AetherCurrents.Database.Entities;
using AutoMapper;
using SaintCoinach.Xiv;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="AetherCurrents.Database.Entities.SpearfishingNotebook" />.
    /// </summary>
    public class SpearfishingNotebookProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.XivRow" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.SpearfishingNotebook" /> class.
        /// </summary>
        public SpearfishingNotebookProfile()
        {
            CreateMap<XivRow, SpearfishingNotebook>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.GatheringLevel, o => o.MapFrom(s => s[0]))
                .ForMember(d => d.TerritoryType, o => o.MapFrom(s => s[2]))
                .ForMember(d => d.X, o => o.MapFrom(s => s[3]))
                .ForMember(d => d.Y, o => o.MapFrom(s => s[4]))
                .ForMember(d => d.Radius, o => o.MapFrom(s => s[5]))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s[7]))
                .ForMember(d => d.GatheringPointBase, o => o.MapFrom(s => s[9]));
        }
    }
}