using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="TripleTriadCardRarity" />.
    /// </summary>
    public class TripleTriadCardRarityProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TripleTriadCardRarity" /> class
        /// to the <see cref="TripleTriadCardRarity" /> class.
        /// </summary>
        public TripleTriadCardRarityProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCardRarity, TripleTriadCardRarity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}