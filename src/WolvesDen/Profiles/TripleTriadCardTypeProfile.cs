using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="TripleTriadCardType" />.
    /// </summary>
    public class TripleTriadCardTypeProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TripleTriadCardType" /> class
        /// to the <see cref="TripleTriadCardType" /> class.
        /// </summary>
        public TripleTriadCardTypeProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCardType, TripleTriadCardType>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}