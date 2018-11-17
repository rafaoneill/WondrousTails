using AutoMapper;
using System;

namespace WolvesDen.Profiles
{
    public class JournalGenreProfile : Profile
    {
        public JournalGenreProfile()
        {
            CreateMap<SaintCoinach.Xiv.JournalGenre, AetherCurrents.Database.Entities.JournalGenre>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.JournalCategory, o => o.MapFrom(s => s.JournalCategory.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex","png")));
        }
    }
}