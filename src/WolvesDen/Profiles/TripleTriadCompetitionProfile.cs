using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="AetherCurrents.Database.Entities.TripleTriadCompetition" />.
    /// </summary>
    public class TripleTriadCompetitionProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.TripleTriadCompetition" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.TripleTriadCompetition" /> class.
        /// </summary>
        public TripleTriadCompetitionProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCompetition, TripleTriadCompetition>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}