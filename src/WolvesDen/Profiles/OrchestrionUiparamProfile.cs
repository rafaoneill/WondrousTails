using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.OrchestrionUiparam" />.
    /// </summary>
    public class OrchestrionUiparamProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.OrchestrionUiparam" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.OrchestrionUiparam" /> class.
        /// </summary>
        public OrchestrionUiparamProfile()
        {
            CreateMap<SaintCoinach.Xiv.OrchestrionUiparam, AetherCurrents.Database.Entities.OrchestrionUiparam>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Category, o => o.MapFrom(s => s.OrchestrionCategory.Key))
                .ForMember(d => d.PositionInCategory, o => o.MapFrom(s => s.Order));
        }
    }
}