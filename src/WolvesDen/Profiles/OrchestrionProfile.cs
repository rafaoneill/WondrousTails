using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.Orchestrion" />.
    /// </summary>
    public class OrchestrionProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.Orchestrion" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.Orchestrion" /> class.
        /// </summary>
        public OrchestrionProfile()
        {
            CreateMap<SaintCoinach.Xiv.Orchestrion, Orchestrion>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}