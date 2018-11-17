using AutoMapper;

namespace WolvesDen.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<SaintCoinach.Xiv.Map, AetherCurrents.Database.Entities.Map>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.SmallMap, o => o.MapFrom(s => s.SmallImagePath.Replace("tex","png")))
                .ForMember(d => d.MediumMap, o => o.MapFrom(s => s.MediumImagePath.Replace("tex","png")))
                .ForMember(d => d.MapId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.PlaceNameRegion, o => o.MapFrom(s => s.RegionPlaceName.Key))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.PlaceNameSub, o => o.MapFrom(s => s.LocationPlaceName.Key))
                .ForMember(d => d.DiscoveryIndex, o => o.MapFrom(s => s["DiscoveryIndex"]))
                .ForMember(d => d.TerritoryType, o => o.MapFrom(s => s.TerritoryType.Key))
                .ForMember(d => d.DiscoveryArrayByte, o => o.MapFrom(s => s["DiscoveryArrayByte"]));
        }
    }
}