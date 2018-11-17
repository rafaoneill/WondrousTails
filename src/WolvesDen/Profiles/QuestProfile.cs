using AutoMapper;
using SaintCoinach.Xiv;
using System.Collections.Generic;
using System;

namespace WolvesDen.Profiles
{
    public class QuestProfile : Profile
    {
        public QuestProfile()
        {
            CreateMap<Quest, AetherCurrents.Database.Entities.Quest>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.QuestId, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Expansion, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["Expansion"]).Key))
                .ForMember(d => d.ClassJobUnlock, o => o.MapFrom(s => s.ClassJobUnlock.Key))
                .ForMember(d => d.GrandCompany, o => o.MapFrom(s => s.GrandCompany.Key))
                .ForMember(d => d.GrandCompanyRank, o => o.MapFrom(s => s.GrandCompanyRank.Key))
                .ForMember(d => d.BeastTribe, o => o.MapFrom(s => s.BeastTribe.Key))
                .ForMember(d => d.BeastReputationRank, o => o.MapFrom(s => s.BeastReputationRank.Key))
                .ForMember(d => d.MountRequired, o => o.MapFrom(s => s.MountRequired.Key))
                .ForMember(d => d.EnpcResidentStart, o => o.MapFrom(s => s.ENpcResidentStart.Key))
                .ForMember(d => d.EnpcResidentEnd, o => o.MapFrom(s => s.ENpcResidentEnd.Key))
                .ForMember(d => d.ClassJobRequired, o => o.MapFrom(s => s.ClassJobRequired.Key))
                .ForMember(d => d.ExpFactor, o => o.MapFrom(s => s["ExpFactor"]))
                .ForMember(d => d.GilReward, o => o.MapFrom(s => s["GilReward"]))
                .ForMember(d => d.GrandCompanySeals, o => o.MapFrom(s => s[1442]))
                // .ForMember(d => d.GilReward, o => o.MapFrom(s => s.GilReward))
                // .ForMember(d => d.EmoteReward, o => o.MapFrom(s => s.EmoteReward.Key))
                // .ForMember(d => d.ActionReward, o => o.MapFrom(s => s.ActionReward.Key))
                // .ForMember(d => d.OtherReward, o => o.MapFrom(s => s.OtherReward.Key))
                .ForMember(d => d.InstanceContentUnlock, o => o.MapFrom(s => s.InstanceContentUnlock.Key))
                .ForMember(d => d.TomestoneReward, o => o.MapFrom(s => s.TomestoneReward.Key))
                .ForMember(d => d.TomestoneRewardCount, o => o.MapFrom(s => s.TomestoneCountReward))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.JournalGenre, o => o.MapFrom(s => s.JournalGenre.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex","png")))
                .ForMember(d => d.IconSpecial, o => o.MapFrom(s => s.SpecialIcon.Path.Replace("tex","png")))
                // .ForMember(d => d.EventIconType, o => o.MapFrom(s => ((XivRow)s[1512]).Key))
                .ForMember(d => d.EventIconType, o => o.MapFrom(s => s[1512]))
                .ForMember(d => d.RepeatIntervalType, o => o.MapFrom(s => (byte)s.RepeatInterval))
                .ForMember(d => d.ClassJobCategoryUnlock, o => o.MapFrom(s => (byte)((ClassJobCategory)s["ClassJobCategory[0]"]).Key))
                .ForMember(d => d.ClassJobCategoryComplete, o => o.MapFrom(s => (byte)((ClassJobCategory)s["ClassJobCategory[1]"]).Key))
                .ForMember(d => d.ClassJobLevelUnlock, o => o.MapFrom(s => s["ClassJobLevel[0]"]))
                .ForMember(d => d.ClassJobLevelComplete, o => o.MapFrom(s => s["ClassJobLevel[1]"]))
                // .ForMember(d => d.ClassJobLevel, o => o.ResolveUsing(s =>
                // {
                //     return new List<ushort> 
                //     { 
                //         (ushort)(s["ClassJobLevel[0]"]),
                //         (ushort)(s["ClassJobLevel[1]"])
                //     };
                // }))
                // .ForMember(d => d.PreviousQuest, o => o.ResolveUsing(s => 
                // {
                //     return new List<uint>
                //     {
                //         s["PreviousQuest[0]"] == null ? 0 : (uint)(((Quest)s["PreviousQuest[0]"]).Key),
                //         s["PreviousQuest[1]"] == null ? 0 : (uint)(((Quest)s["PreviousQuest[1]"]).Key),
                //         s["PreviousQuest[2]"] == null ? 0 : (uint)(((Quest)s["PreviousQuest[2]"]).Key)
                //     };
                // }))
                // .ForMember(d => d.QuestLock, o => o.ResolveUsing(s =>
                // {
                //     return new List<uint>
                //     {

                //         s["QuestLock[0]"] == null ? 0 : (uint)(((Quest)s["QuestLock[0]"]).Key),
                //         s["QuestLock[1]"] == null ? 0 : (uint)(((Quest)s["QuestLock[1]"]).Key)
                //     };
                // }))
                // .ForMember(d => d.InstanceContent, o => o.ResolveUsing(s => {
                //     return new List<uint>
                //     {
                //         s["InstanceContent[0]"] == null ? 0 : (uint)(((InstanceContent)s["InstanceContent[0]"]).Key),
                //         s["InstanceContent[1]"] == null ? 0 : (uint)(((InstanceContent)s["InstanceContent[1]"]).Key),
                //         s["InstanceContent[2]"] == null ? 0 : (uint)(((InstanceContent)s["InstanceContent[2]"]).Key)
                //     };
                // }))
                // .ForMember(d => d.ScriptInstruction, o => o.ResolveUsing(s => { // 49 to 98, 0 to 49
                //     var scriptInstructions = new List<string>();
                //     for(int i = 0; i <= 49; i++)
                //     {
                //         var scriptInstruction = s[string.Format("Script{{Instruction}}[{0}]", i)] == null ? string.Empty : s[string.Format("Script{{Instruction}}[{0}]", i)].ToString();
                //         scriptInstructions.Add(scriptInstruction);
                //     }
                //     return scriptInstructions;
                // }))
                // .ForMember(d => d.ScriptArg, o => o.ResolveUsing(s => // 99 to 149, 0 to 49
                // { 
                //     var scriptArgs = new List<uint>();
                //     for(int i = 0; i <= 49; i++)
                //     {
                //         //var scriptArg = s[i] == null ? 0 : (uint)s[i];
                //         var scriptArg = s[string.Format("Script{{Arg}}[{0}]", i)] == null ? 0 : (uint)s[string.Format("Script{{Arg}}[{0}]", i)];
                //         scriptArgs.Add(scriptArg);
                //     }
                //     return scriptArgs;
                // }))
                // .ForMember(d => d.Level, o => o.ResolveUsing(s => {
                //     var levels = new List<uint>();
                //     for(int i = 0; i <= 170; i++)
                //     {
                //         var level = s[string.Format("Level[{0}]",i)] == null ? 0 : (uint)((Level)s[string.Format("Level[{0}]",i)]).Key;
                //         levels.Add(level);
                //     }
                //     return levels;
                // }))
                // .ForMember(d => d.ItemCatalyst, o => o.ResolveUsing(s => {
                //     return new List<int>
                //     {
                //         s["Item{Catalyst}[0]"] == null ? 0 : ((Item)s["Item{Catalyst}[0]"]).Key,
                //         s["Item{Catalyst}[1]"] == null ? 0 : ((Item)s["Item{Catalyst}[0]"]).Key,
                //         s["Item{Catalyst}[2]"] == null ? 0 : ((Item)s["Item{Catalyst}[0]"]).Key
                //     };
                // }))
                // .ForMember(d => d.ItemCountCatalyst, o => o.ResolveUsing(s => {
                //     return new List<byte>
                //     {
                //         (byte)s["ItemCount{Catalyst}[0]"],
                //         (byte)(s["ItemCount{Catalyst}[1]"]),
                //         (byte)(s["ItemCount{Catalyst}[2]"])
                //     };
                // }))
                // .ForMember(d => d.ItemReward, o => o.ResolveUsing(s => {
                //     return new List<List<uint>>
                //     {
                //         new List<uint> 
                //         {
                //             (uint)(((Item)s["Item{Reward}[0][0]"]).Key),
                //             (uint)((Item)s["Item{Reward}[0][1]"]).Key,
                //             (uint)((Item)s["Item{Reward}[0][2]"]).Key,
                //             (uint)((Item)s["Item{Reward}[0][3]"]).Key,
                //             (uint)((Item)s["Item{Reward}[0][4]"]).Key,
                //             (uint)((Item)s["Item{Reward}[0][5]"]).Key
                //         },
                //         new List<uint> 
                //         {
                //             (uint)(((Item)s["Item{Reward}[1][0]"]).Key),
                //             (uint)((Item)s["Item{Reward}[1][1]"]).Key,
                //             (uint)((Item)s["Item{Reward}[1][2]"]).Key,
                //             (uint)((Item)s["Item{Reward}[1][3]"]).Key,
                //             (uint)((Item)s["Item{Reward}[1][4]"]).Key
                //         }
                //     };
                // }))
                // .ForMember(d => d.ItemCountReward, o => o.ResolveUsing(s => {
                //     return new List<List<byte>>
                //     {
                //         new List<byte>
                //         {
                //             (byte)s["ItemCount{Reward}[0][0]"],
                //             (byte)s["ItemCount{Reward}[0][1]"],
                //             (byte)s["ItemCount{Reward}[0][2]"],
                //             (byte)s["ItemCount{Reward}[0][3]"],
                //             (byte)s["ItemCount{Reward}[0][4]"],
                //             (byte)s["ItemCount{Reward}[0][5]"]
                //         },
                //         new List<byte>
                //         {
                //             (byte)s["ItemCount{Reward}[1][0]"],
                //             (byte)s["ItemCount{Reward}[1][1]"],
                //             (byte)s["ItemCount{Reward}[1][2]"],
                //             (byte)s["ItemCount{Reward}[1][3]"],
                //             (byte)s["ItemCount{Reward}[1][4]"]
                //         }
                //     };
                // }))
                // .ForMember(d => d.StainReward, o => o.ResolveUsing(s => {
                //     return new List<List<uint>>
                //     {
                //         new List<uint>
                //         {
                //             (uint)(((Stain)s["Stain{Reward}[0][0]"]).Key),
                //             (uint)((Stain)s["Stain{Reward}[0][1]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[0][2]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[0][3]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[0][4]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[0][5]"]).Key
                //         },
                //         new List<uint>
                //         {
                //             (uint)(((Stain)s["Stain{Reward}[1][0]"]).Key),
                //             (uint)((Stain)s["Stain{Reward}[1][1]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[1][2]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[1][3]"]).Key,
                //             (uint)((Stain)s["Stain{Reward}[1][4]"]).Key
                //         }
                //     };
                // }))
                // .ForMember(d => d.GeneralActionReward, o => o.ResolveUsing(s =>
                // {
                //     return new List<byte>
                //     {
                //         (byte)((XivRow)s["GeneralAction{Reward}[0]"]).Key,
                //         (byte)((XivRow)s["GeneralAction{Reward}[1]"]).Key
                //     };
                // }))
                // .ForMember(d => d.IsHighQualityReward, o => o.ResolveUsing(s => {
                //     return new List<List<bool>>
                //     {
                //         new List<bool>
                //         {
                //             (bool)s["IsHQ{Reward}[1][0]"],
                //             (bool)s["IsHQ{Reward}[1][1]"],
                //             (bool)s["IsHQ{Reward}[1][2]"],
                //             (bool)s["IsHQ{Reward}[1][3]"],
                //             (bool)s["IsHQ{Reward}[1][4]"],
                //         }
                //     };
                // }));
                ;
        }
    }
}