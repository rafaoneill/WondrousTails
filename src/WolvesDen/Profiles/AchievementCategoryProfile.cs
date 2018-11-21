using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AchievementCategory" />.
    /// </summary>
    public class AchievementCategoryProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.AchievementCategory" /> class
        /// to the <see cref="AchievementCategory" /> class.
        /// </summary>
        public AchievementCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.AchievementCategory, AchievementCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Kind, o => o.MapFrom(s => s.AchievementKind.Key))
                .ForMember(d => d.IsActive, o => o.MapFrom(s => s[2]))
                .ForMember(d => d.IsSeasonal, o => o.MapFrom(s => s[3]));
        }
    }
}