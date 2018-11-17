using AutoMapper;

namespace WolvesDen.Profiles
{
    public class OrchestrionProfile : Profile
    {
        public OrchestrionProfile()
        {
            CreateMap<SaintCoinach.Xiv.Orchestrion, AetherCurrents.Database.Entities.Orchestrion>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}