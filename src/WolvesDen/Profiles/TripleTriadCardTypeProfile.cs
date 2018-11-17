using AutoMapper;

namespace WolvesDen.Profiles
{
    public class TripleTriadCardTypeProfile : Profile
    {
        public TripleTriadCardTypeProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCardType, AetherCurrents.Database.Entities.TripleTriadCardType>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}