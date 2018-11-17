using AutoMapper;

namespace WolvesDen.Profiles
{
    public class OrchestrionUiparamProfile : Profile
    {
        public OrchestrionUiparamProfile()
        {
            CreateMap<SaintCoinach.Xiv.OrchestrionUiparam, AetherCurrents.Database.Entities.OrchestrionUiparam>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Category, o => o.MapFrom(s => s.OrchestrionCategory.Key))
                .ForMember(d => d.PositionInCategory, o => o.MapFrom(s => s.Order));
        }
    }
}