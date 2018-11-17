using AutoMapper;
using AetherCurrents.Database.Entities;

namespace WolvesDen.Profiles
{
    public class TripleTriadCardResidentProfile : Profile
    {
        public TripleTriadCardResidentProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCardResident, TripleTriadCardResident>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Rarity, o => o.MapFrom(s => s.TripleTriadCardRarity.Key))
                .ForMember(d => d.Type, o => o.MapFrom(s => s.TripleTriadCardType.Key));
        }
    }
}