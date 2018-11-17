using AutoMapper;

namespace WolvesDen.Profiles
{
    public class JournalCategoryProfile : Profile
    {
        public JournalCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.JournalCategory, AetherCurrents.Database.Entities.JournalCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.JournalSectionId, o => o.MapFrom(s => s.JournalSection.Key));
        }
    }
}