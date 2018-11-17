using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvesDen.Profiles
{
    public class QuestDetailProfile : Profile
    {
        public QuestDetailProfile()
        {
            CreateMap<SaintCoinach.Xiv.XivRow, AetherCurrents.Database.Entities.QuestDetail>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.SheetFullName, o => o.MapFrom(s => s.Sheet.Name))
                // .ForMember(d => d.QuestTextId, o => o.MapFrom(s => s[0].ToString().Length == 0 ? string.Empty : s[0].ToString().Split('_').ToList().GetRange(1,2).Join('_', this)))
                .ForMember(d => d.QuestTextId, o => o.ResolveUsing(s => {
                    if(s[0].ToString().Length == 0)
                    {
                        return string.Empty;
                    }
                    var parsed = s[0].ToString().Split('_').ToList().GetRange(1,2);
                    // Console.WriteLine("Text " + s[0].ToString());
                    // foreach(var item in parsed.Select((d,i) => new { Data = d, Index = i}))
                    // {
                    //     Console.WriteLine(string.Format("Item #{0} is {1}",item.Index, item.Data));
                    // }
                    // Console.WriteLine("Parsed count " + parsed.Count);
                    // Console.Read();
                    return string.Join("_",parsed.ToArray());
                }))
                .ForMember(d => d.DetailKey, o => o.MapFrom(s => s[0]))
                .ForMember(d => d.DetailDescription, o => o.MapFrom(s => s[1]));
        }
    }
}