using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="AetherCurrents.Database.Entities.ActionComboRoute" />.
    /// </summary>
    public class ActionComboRouteProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.ActionComboRoute" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.ActionComboRoute" /> class.
        /// </summary>
        public ActionComboRouteProfile()
        {
            CreateMap<SaintCoinach.Xiv.ActionComboRoute, ActionComboRoute>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}