using AutoMapper;

namespace WolvesDen.Profiles
{
    public class OrchestrionPathProfile : Profile
    {
        public OrchestrionPathProfile()
        {
            CreateMap<SaintCoinach.Xiv.OrchestrionPath, AetherCurrents.Database.Entities.OrchestrionPath>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.FilePath, o => o.MapFrom(s => s.File));
        }
    }
}