using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.JournalCategory" />.
    /// </summary>
    public class JournalCategoryProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.JournalCategory" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.JournalCategory" /> class.
        /// </summary>
        public JournalCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.JournalCategory, JournalCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.JournalSectionId, o => o.MapFrom(s => s.JournalSection.Key));
        }
    }
}