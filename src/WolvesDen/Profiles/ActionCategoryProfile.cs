using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="ActionCategory" />.
    /// </summary>
    public class ActionCategoryProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.ActionCategory" /> class
        /// to the <see cref="ActionCategory" /> class.
        /// </summary>
        public ActionCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.ActionCategory, ActionCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}