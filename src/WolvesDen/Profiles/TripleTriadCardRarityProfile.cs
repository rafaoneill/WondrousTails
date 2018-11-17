using AutoMapper;

namespace WolvesDen.Profiles
{
    public class TripleTriadCardRarityProfile : Profile
    {
        public TripleTriadCardRarityProfile()
        {
            CreateMap<SaintCoinach.Xiv.TripleTriadCardRarity, AetherCurrents.Database.Entities.TripleTriadCardRarity>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key));
        }
    }
}