using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="ActionComboRouteTransient" />.
    /// </summary>
    public class ActionComboRouteTransientProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.ActionComboRouteTransient" /> class
        /// to the <see cref="ActionComboRouteTransient" /> class.
        /// </summary>
        public ActionComboRouteTransientProfile()
        {
            CreateMap<SaintCoinach.Xiv.ActionComboRouteTransient, ActionComboRouteTransient>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}