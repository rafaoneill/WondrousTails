using AutoMapper;

namespace WolvesDen.Profiles
{
    public class JournalSectionProfile : Profile
    {
        public JournalSectionProfile()
        {
            CreateMap<SaintCoinach.Xiv.JournalSection, AetherCurrents.Database.Entities.JournalSection>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}