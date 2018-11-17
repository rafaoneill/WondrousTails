using AutoMapper;

namespace WolvesDen.Profiles
{
    public class ActionCategoryProfile : Profile
    {
        public ActionCategoryProfile()
        {
            CreateMap<SaintCoinach.Xiv.ActionCategory, AetherCurrents.Database.Entities.ActionCategory>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}