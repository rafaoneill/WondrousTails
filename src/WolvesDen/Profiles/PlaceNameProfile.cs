using AutoMapper;
using System.Collections.Generic;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="AetherCurrents.Database.Entities.PlaceName" />.
    /// </summary>
    public class PlaceNameProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.PlaceName" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.PlaceName" /> class.
        /// </summary>
        public PlaceNameProfile()
        {
            CreateMap<SaintCoinach.Xiv.PlaceName, AetherCurrents.Database.Entities.PlaceName>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.NameNoArticle, o => o.MapFrom(s => s.NameWithoutArticle));
        }
    }
}