using AutoMapper;

namespace WolvesDen.Profiles
{
    public class AchievementCategoryProfile : Profile
    {
        public AchievementCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.AchievementCategory, AetherCurrents.Database.Entities.AchievementCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Kind, o => o.MapFrom(s => s.AchievementKind.Key))
                .ForMember(d => d.IsActive, o => o.MapFrom(s => s[2]))
                .ForMember(d => d.IsSeasonal, o => o.MapFrom(s => s[3]));
        }
    }
}