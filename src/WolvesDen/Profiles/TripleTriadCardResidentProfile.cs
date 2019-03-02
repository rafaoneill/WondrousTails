using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="AetherCurrents.Database.Entities.TripleTriadCardResident" />.
    /// </summary>
    public class TripleTriadCardResidentProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TripleTriadCardResident" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.TripleTriadCardResident" /> class.
        /// </summary>
        public TripleTriadCardResidentProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCardResident, TripleTriadCardResident>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Rarity, o => o.MapFrom(s => s.TripleTriadCardRarity.Key))
                .ForMember(d => d.Type, o => o.MapFrom(s => s.TripleTriadCardType.Key));
        }
    }
}