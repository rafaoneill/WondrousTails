using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="TripleTriadRule" />.
    /// </summary>
    public class TripleTriadRuleProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TripleTriadRule" /> class
        /// to the <see cref="TripleTriadRule" /> class.
        /// </summary>
        public TripleTriadRuleProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadRule, AetherCurrents.Database.Entities.TripleTriadRule>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name ?? string.Empty));
        }
    }
}