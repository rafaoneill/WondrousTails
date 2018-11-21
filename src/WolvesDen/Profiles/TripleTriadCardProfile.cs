using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="TripleTriadCard" />.
    /// </summary>
    public class TripleTriadCardProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TripleTriadCard" /> class
        /// to the <see cref="TripleTriadCard" />.
        /// </summary>
        public TripleTriadCardProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCard, TripleTriadCard>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.StartsWithVowel, o => o.MapFrom(s => (sbyte)s[4] == 1));
        }
    }
}