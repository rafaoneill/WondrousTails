using AutoMapper;

namespace WolvesDen.Profiles
{
    public class TripleTriadCardProfile : Profile
    {
        public TripleTriadCardProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCard, AetherCurrents.Database.Entities.TripleTriadCard>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.StartsWithVowel, o => o.MapFrom(s => (sbyte)s[4] == 1));
        }
    }
}