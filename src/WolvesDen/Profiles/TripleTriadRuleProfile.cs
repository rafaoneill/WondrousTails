using AutoMapper;

namespace WolvesDen.Profiles
{
    public class TripleTriadRuleProfile : Profile
    {
        public TripleTriadRuleProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadRule, AetherCurrents.Database.Entities.TripleTriadRule>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name ?? string.Empty));
        }
    }
}
    