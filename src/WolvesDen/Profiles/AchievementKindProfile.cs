using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.AchievementKind" />.
    /// </summary>
    public class AchievementKindProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.AchievementKind" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.AchievementKind" /> class.
        /// </summary>
        public AchievementKindProfile()
        {
            CreateMap<SaintCoinach.Xiv.AchievementKind, AchievementKind>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}