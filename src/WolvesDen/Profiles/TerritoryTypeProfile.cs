using AutoMapper;
using SaintCoinach.Imaging;

namespace WolvesDen.Profiles
{
    public class TerritoryTypeProfile : Profile
    {
        public TerritoryTypeProfile()
        {
            CreateMap<SaintCoinach.Xiv.TerritoryType, AetherCurrents.Database.Entities.TerritoryType>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.PlaceNameRegion, o => o.MapFrom(s => s.RegionPlaceName.Key))
                .ForMember(d => d.PlaceNameZone, o => o.MapFrom(s => s.ZonePlaceName.Key))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.Map, o => o.MapFrom(s => s.Map.Key));
        }
    }
}