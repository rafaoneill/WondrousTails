namespace AetherCurrents.Database.Entities
{
    public partial class Item
    {
        public int Id { get; set; }
        public string Singular { get; set; }
        public string Plural { get; set; }
        public bool StartsWithVowel { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public short LevelItem { get; set; }
        public byte Rarity { get; set; }
        public byte FilterGroup { get; set; }
        public int Stain { get; set; }
        public int ItemUicategory { get; set; }
        public byte ItemSearchCategory { get; set; }
        public byte EquipSlotCategory { get; set; }
        public int StackSize { get; set; }
        public bool IsUnique { get; set; }
        public bool IsUntradable { get; set; }
        public bool IsIndisposable { get; set; }
        public int PriceMid { get; set; }
        public int PriceLow { get; set; }
        public bool CanBeHq { get; set; }
        public bool IsDyeable { get; set; }
        public bool IsCrestWorthy { get; set; }
        public short ItemAction { get; set; }
        public short CooldownSeconds { get; set; }
        public byte ClassJobRepair { get; set; }
        public int ItemRepair { get; set; }
        public int ItemGlamour { get; set; }
        public short Salvage { get; set; }
        public bool IsCollectable { get; set; }
        public short AetherialReduce { get; set; }
        public byte LevelEquip { get; set; }
        public byte EquipRestriction { get; set; }
        public byte ClassJobCategory { get; set; }
        public byte GrandCompany { get; set; }
        public byte ItemSeries { get; set; }
        public byte BaseParamModifier { get; set; }
        public byte ClassJobUse { get; set; }
        public short DamagePhysical { get; set; }
        public short DamageMagical { get; set; }
        public short DelayMiliseconds { get; set; }
        public short BlockRate { get; set; }
        public short Block { get; set; }
        public short DefensePhysical { get; set; }
        public short DefenseMagical { get; set; }
        public byte ItemSpecialBonus { get; set; }
        public byte ItemSpecialBonusParam { get; set; }
        public byte MaterializeType { get; set; }
        public byte MateriaSlotCount { get; set; }
        public bool IsAdvancedMeldingPermitted { get; set; }
        public bool IsPvp { get; set; }
    }
}
