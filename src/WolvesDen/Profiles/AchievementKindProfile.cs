using AutoMapper;

namespace WolvesDen.Profiles
{
    public class AchievementKindProfile : Profile
    {
        public AchievementKindProfile()
        {
            CreateMap<SaintCoinach.Xiv.AchievementKind, AetherCurrents.Database.Entities.AchievementKind>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}