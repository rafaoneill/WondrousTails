using AetherCurrents.Database.Entities;
using AutoMapper;
using System;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="Quest" />.
    /// </summary>
    public class QuestProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.Quest" /> class
        /// to the <see cref="Quest" /> class.
        /// </summary>
        public QuestProfile()
        {
            CreateMap<SaintCoinach.Xiv.Quest, Quest>()
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
                .ForMember(d => d.InstanceContentUnlock, o => o.MapFrom(s => s.InstanceContentUnlock.Key))
                .ForMember(d => d.TomestoneReward, o => o.MapFrom(s => s.TomestoneReward.Key))
                .ForMember(d => d.TomestoneRewardCount, o => o.MapFrom(s => s.TomestoneCountReward))
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName.Key))
                .ForMember(d => d.JournalGenre, o => o.MapFrom(s => s.JournalGenre.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex", "png", StringComparison.CurrentCulture)))
                .ForMember(d => d.IconSpecial, o => o.MapFrom(s => s.SpecialIcon.Path.Replace("tex", "png", StringComparison.CurrentCulture)))
                .ForMember(d => d.EventIconType, o => o.MapFrom(s => s[1512]))
                .ForMember(d => d.RepeatIntervalType, o => o.MapFrom(s => (byte)s.RepeatInterval))
                .ForMember(d => d.ClassJobCategoryUnlock, o => o.MapFrom(s => (byte)((SaintCoinach.Xiv.ClassJobCategory)s["ClassJobCategory[0]"]).Key))
                .ForMember(d => d.ClassJobCategoryComplete, o => o.MapFrom(s => (byte)((SaintCoinach.Xiv.ClassJobCategory)s["ClassJobCategory[1]"]).Key))
                .ForMember(d => d.ClassJobLevelUnlock, o => o.MapFrom(s => s["ClassJobLevel[0]"]))
                .ForMember(d => d.ClassJobLevelComplete, o => o.MapFrom(s => s["ClassJobLevel[1]"]))
                .ForMember(d => d.QuestStatus, o => o.Ignore());
        }
    }
}