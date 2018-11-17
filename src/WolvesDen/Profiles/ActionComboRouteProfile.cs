using AutoMapper;

namespace WolvesDen.Profiles
{
    public class ActionComboRouteProfile : Profile
    {
        public ActionComboRouteProfile()
        {
            CreateMap<SaintCoinach.Xiv.ActionComboRoute, AetherCurrents.Database.Entities.ActionComboRoute>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}