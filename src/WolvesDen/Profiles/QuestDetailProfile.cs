using AetherCurrents.Database.Entities;
using AutoMapper;
using SaintCoinach.Xiv;
using System.Linq;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="QuestDetail" />.
    /// </summary>
    public class QuestDetailProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="XivRow" /> class
        /// to the <see cref="QuestDetail" /> class.
        /// </summary>
        public QuestDetailProfile()
        {
            CreateMap<XivRow, QuestDetail>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.SheetFullName, o => o.MapFrom(s => s.Sheet.Name))
                .ForMember(d => d.QuestTextId, o => o.ResolveUsing(s =>
                {
                    if (s[0].ToString().Length == 0)
                    {
                        return string.Empty;
                    }
                    var parsed = s[0].ToString().Split('_').ToList().GetRange(1, 2);
                    return string.Join("_", parsed.ToArray());
                }))
                .ForMember(d => d.DetailKey, o => o.MapFrom(s => s[0]))
                .ForMember(d => d.DetailDescription, o => o.MapFrom(s => s[1]));
        }
    }
}