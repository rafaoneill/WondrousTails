using AetherCurrents.Database.Entities;
using AutoMapper;
using System;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="Achievement" />.
    /// </summary>
    public class AchievementProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.Achievement" /> class
        /// to the <see cref="Achievement" /> class.
        /// </summary>
        public AchievementProfile()
        {
            CreateMap<SaintCoinach.Xiv.Achievement, Achievement>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name ?? string.Empty))
                .ForMember(d => d.Category, o => o.MapFrom(s => s.AchievementCategory.Key))
                .ForMember(d => d.Title, o => o.MapFrom(s => s.Title.Key))
                .ForMember(d => d.Item, o => o.MapFrom(s => s.Item.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex", "png", StringComparison.CurrentCulture)))
                .ForMember(d => d.DataI, o => o.MapFrom(s => s[9]))
                .ForMember(d => d.DataIi, o => o.MapFrom(s => s[10]))
                .ForMember(d => d.DataIii, o => o.MapFrom(s => s[11]))
                .ForMember(d => d.DataIv, o => o.MapFrom(s => s[12]))
                .ForMember(d => d.DataV, o => o.MapFrom(s => s[13]))
                .ForMember(d => d.DataVi, o => o.MapFrom(s => s[14]))
                .ForMember(d => d.DataVii, o => o.MapFrom(s => s[15]))
                .ForMember(d => d.DataViii, o => o.MapFrom(s => s[16]))
                .ForMember(d => d.DataIx, o => o.MapFrom(s => s[17]));
        }
    }
}