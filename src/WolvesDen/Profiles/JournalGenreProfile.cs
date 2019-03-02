using AetherCurrents.Database.Entities;
using AutoMapper;
using System;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="JournalGenre" />.
    /// </summary>
    public class JournalGenreProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.JournalGenre" /> class
        /// to the <see cref="JournalGenre" /> class.
        /// </summary>
        public JournalGenreProfile()
        {
            CreateMap<SaintCoinach.Xiv.JournalGenre, JournalGenre>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.JournalCategory, o => o.MapFrom(s => s.JournalCategory.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex", "png", StringComparison.CurrentCulture)));
        }
    }
}