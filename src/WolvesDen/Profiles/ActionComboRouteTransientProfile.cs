using AutoMapper;

namespace WolvesDen.Profiles
{
    public class ActionComboRouteTransientProfile : Profile
    {
        public ActionComboRouteTransientProfile()
        {
            CreateMap<SaintCoinach.Xiv.ActionComboRouteTransient, AetherCurrents.Database.Entities.ActionComboRouteTransient>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}