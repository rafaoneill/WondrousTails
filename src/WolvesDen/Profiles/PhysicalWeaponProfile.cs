using AetherCurrents.Database.Entities;
using AutoMapper;
using System;

namespace WolvesDen.Profiles
{
    /// <summary>
    /// Profile for a <see cref="AetherCurrents.Database.Entities.Item" />.
    /// </summary>
    public class PhysicalWeaponProfile : Profile
    {
        /// <summary>
        /// Mapping from the <see cref="SaintCoinach.Xiv.Items.PhysicalWeapon" /> class
        /// to the <see cref="AetherCurrents.Database.Entities.Item" /> class.
        /// </summary>
        public PhysicalWeaponProfile()
        {
            CreateMap<SaintCoinach.Xiv.Items.PhysicalWeapon, Item>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Key))
                .ForMember(d => d.Icon, o => o.MapFrom(s => s.Icon.Path.Replace("tex", "png", StringComparison.CurrentCulture)))
                .ForMember(d => d.LevelItem, o => o.MapFrom(s => s.ItemLevel))
                .ForMember(d => d.FilterGroup, o => o.MapFrom(s => s["FilterGroup"]))
                .ForMember(d => d.ItemUicategory, o => o.MapFrom(s => s.ItemUICategory.Key))
                .ForMember(d => d.ItemSearchCategory, o => o.MapFrom(s => s.ItemSearchCategory))
                .ForMember(d => d.EquipSlotCategory, o => o.MapFrom(s => ((SaintCoinach.Xiv.EquipSlotCategory)s["EquipSlotCategory"]).Key))
                .ForMember(d => d.StackSize, o => o.MapFrom(s => s["StackSize"]))
                .ForMember(d => d.PriceMid, o => o.MapFrom(s => s.Ask))
                .ForMember(d => d.PriceLow, o => o.MapFrom(s => s.Bid))
                .ForMember(d => d.IsCrestWorthy, o => o.MapFrom(s => s["IsCrestWorthy"]))
                .ForMember(d => d.ItemAction, o => o.MapFrom(s => s.ItemAction.Key))
                .ForMember(d => d.CooldownSeconds, o => o.MapFrom(s => s["Cooldown<s>"]))
                .ForMember(d => d.ClassJobRepair, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["ClassJob{Repair}"]).Key))
                .ForMember(d => d.ItemRepair, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["Item{Repair}"]).Key))
                .ForMember(d => d.ItemGlamour, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["Item{Glamour}"]).Key))
                .ForMember(d => d.Salvage, o => o.MapFrom(s => s.Salvage.Key))
                .ForMember(d => d.AetherialReduce, o => o.MapFrom(s => s.IsAetherialReducible))
                .ForMember(d => d.LevelEquip, o => o.MapFrom(s => s["Level{Equip}"]))
                .ForMember(d => d.EquipRestriction, o => o.MapFrom(s => s["EquipRestriction"]))
                .ForMember(d => d.ClassJobCategory, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["ClassJobCategory"]).Key))
                .ForMember(d => d.GrandCompany, o => o.MapFrom(s => s.GrandCompany.Key))
                .ForMember(d => d.ItemSeries, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["ItemSeries"]).Key))
                .ForMember(d => d.BaseParamModifier, o => o.MapFrom(s => s["BaseParamModifier"]))
                .ForMember(d => d.ClassJobUse, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["ClassJob{Use}"]).Key))
                .ForMember(d => d.DamagePhysical, o => o.MapFrom(s => s["Damage{Phys}"]))
                .ForMember(d => d.DamageMagical, o => o.MapFrom(s => s["Damage{Mag}"]))
                .ForMember(d => d.DelayMiliseconds, o => o.MapFrom(s => s["Delay<ms>"]))
                .ForMember(d => d.BlockRate, o => o.MapFrom(s => s["BlockRate"]))
                .ForMember(d => d.Block, o => o.MapFrom(s => s["Block"]))
                .ForMember(d => d.DefensePhysical, o => o.MapFrom(s => s["Defense{Phys}"]))
                .ForMember(d => d.DefenseMagical, o => o.MapFrom(s => s["Defense{Mag}"]))
                .ForMember(d => d.ItemSpecialBonus, o => o.MapFrom(s => ((SaintCoinach.Xiv.XivRow)s["ItemSpecialBonus"]).Key))
                .ForMember(d => d.ItemSpecialBonusParam, o => o.MapFrom(s => s["ItemSpecialBonus{Param}"]))
                .ForMember(d => d.MaterializeType, o => o.MapFrom(s => s["MaterializeType"]))
                .ForMember(d => d.MateriaSlotCount, o => o.MapFrom(s => s["MateriaSlotCount"]))
                .ForMember(d => d.IsPvp, o => o.MapFrom(s => s[86]));
        }
    }
}