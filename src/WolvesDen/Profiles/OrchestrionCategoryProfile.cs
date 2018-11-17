using AutoMapper;

namespace WolvesDen.Profiles
{
    public class OrchestrionCategoryProfile : Profile
    {
        public OrchestrionCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.OrchestrionCategory, AetherCurrents.Database.Entities.OrchestrionCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}