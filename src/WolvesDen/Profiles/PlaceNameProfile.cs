using AutoMapper;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    public class PlaceNameProfile : Profile
    {
        public PlaceNameProfile()
        {
            CreateMap<SaintCoinach.Xiv.PlaceName, AetherCurrents.Database.Entities.PlaceName>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.NameNoArticle, o => o.MapFrom(s => s.NameWithoutArticle));
        }
    }
}