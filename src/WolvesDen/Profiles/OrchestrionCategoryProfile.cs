using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.OrchestrionCategory" />.
    /// </summary>
    public class OrchestrionCategoryProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.OrchestrionCategory" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.OrchestrionCategory" /> class.
        /// </summary>
        public OrchestrionCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.OrchestrionCategory, OrchestrionCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}