using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="Orchestrion" />.
    /// </summary>
    public class OrchestrionProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.Orchestrion" /> class
        /// to the <see cref="Orchestrion" /> class.
        /// </summary>
        public OrchestrionProfile()
        {
            CreateMap<SaintCoinach.Xiv.Orchestrion, Orchestrion>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}