using AetherCurrents.Database.Entities;
using AutoMapper;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for an <see cref="Action" />.
    /// </summary>
    public class ActionProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.Action" /> class
        /// to the <see cref="Action" /> class.
        /// </summary>
        public ActionProfile()
        {
            CreateMap<SaintCoinach.Xiv.Action, Action>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex","png")))
                .ForMember(d => d.CostType, o => o.MapFrom(s => s.CostType))
                .ForMember(d => d.Category, o => o.MapFrom(s => s.ActionCategory.Key))
                .ForMember(d => d.TimelineUse, o => o.Ignore())
                .ForMember(d => d.TimelineHit, o => o.MapFrom(s => s.ActionTimelineHit.Key))
                .ForMember(d => d.ClassJob, o => o.MapFrom(s => s.ClassJob.Key))
                .ForMember(d => d.ClassJobLevel, o => o.MapFrom(s => (byte)s["ClassJobLevel"]))
                .ForMember(d => d.CanTargetArea, o => o.MapFrom(s => s.TargetArea))
                .ForMember(d => d.AttackType, o => o.MapFrom(s => s.AttackType.Key))
                .ForMember(d => d.Combo, o => o.MapFrom(s => s.ComboFrom.Key))
                .ForMember(d => d.ProcStatus, o => o.MapFrom(s => ((SaintCoinach.Xiv.ActionProcStatus)s[42]).Key))
                .ForMember(d => d.StatusGainSelf, o => o.MapFrom(s => s.GainedStatus.Key))
                .ForMember(d => d.Data, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[44]).Key))
                .ForMember(d => d.AffectsPosition, o => o.MapFrom(s => (bool)s[48]))
                .ForMember(d => d.Omen, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s[49]).Key))
                .ForMember(d => d.IsPvP, o => o.MapFrom(s => (bool)s[50]));
        }
    }
}