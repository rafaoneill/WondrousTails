using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="JournalSection" />.
    /// </summary>
    public class JournalSectionProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.JournalSection" /> class
        /// to the <see cref="JournalSection" /> class.
        /// </summary>
        public JournalSectionProfile()
        {
            CreateMap<SaintCoinach.Xiv.JournalSection, JournalSection>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}