using AutoMapper;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    public class SpearfishingNotebookProfile : Profile
    {
        public SpearfishingNotebookProfile()
        {
            CreateMap<SaintCoinach.Xiv.XivRow, AetherCurrents.Database.Entities.SpearfishingNotebook>()
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