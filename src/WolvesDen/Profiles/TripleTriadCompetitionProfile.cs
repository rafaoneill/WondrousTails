using AutoMapper;

namespace WolvesDen.Profiles
{
    public class TripleTriadCompetitionProfile : Profile
    {
        public TripleTriadCompetitionProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCompetition, AetherCurrents.Database.Entities.TripleTriadCompetition>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}