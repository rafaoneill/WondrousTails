using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.OrchestrionPath" />.
    /// </summary>
    public class OrchestrionPathProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.OrchestrionPath" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.OrchestrionPath" /> class.
        /// </summary>
        public OrchestrionPathProfile()
        {
            CreateMap<SaintCoinach.Xiv.OrchestrionPath, AetherCurrents.Database.Entities.OrchestrionPath>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.FilePath, o => o.MapFrom(s => s.File));
        }
    }
}