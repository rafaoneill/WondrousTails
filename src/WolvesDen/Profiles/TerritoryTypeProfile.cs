using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="TerritoryType" />.
    /// </summary>
    public class TerritoryTypeProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TerritoryType" /> class
        /// to the <see cref="TerritoryType" /> class.
        /// </summary>
        public TerritoryTypeProfile()
        {
            CreateMap<SaintCoinach.Xiv.TerritoryType, TerritoryType>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.PlaceNameRegion, o => o.MapFrom(s => s.RegionPlaceName.Key))
                .ForMember(d => d.PlaceNameZone, o => o.MapFrom(s => s.ZonePlaceName.Key))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.Map, o => o.MapFrom(s => s.Map.Key));
        }
    }
}