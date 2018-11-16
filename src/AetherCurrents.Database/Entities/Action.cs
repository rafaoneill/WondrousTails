namespace AetherCurrents.Database.Entities
{
    public partial class Action
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public byte? Category { get; set; }
        public short? TimelineUse { get; set; }
        public short? TimelineHit { get; set; }
        public byte? ClassJob { get; set; }
        public int? ClassJobLevel { get; set; }
        public bool? IsRoleAction { get; set; }
        public int? Range { get; set; }
        public bool? CanTargetSelf { get; set; }
        public bool? CanTargetParty { get; set; }
        public bool? CanTargetFriendly { get; set; }
        public bool? CanTargetHostile { get; set; }
        public bool? CanTargetArea { get; set; }
        public bool? CanTargetDead { get; set; }
        public byte? CastType { get; set; }
        public byte? EffectRange { get; set; }
        public byte? XaxisModifier { get; set; }
        public byte? CostType { get; set; }
        public int? Cost { get; set; }
        public short? Combo { get; set; }
        public bool? PreservesCombo { get; set; }
        public short? Cast { get; set; }
        public short? Recast { get; set; }
        public byte? CooldownGroup { get; set; }
        public byte? AttackType { get; set; }
        public byte? Aspect { get; set; }
        public byte? ProcStatus { get; set; }
        public short? StatusGainSelf { get; set; }
        public int? Data { get; set; }
        public byte? ClassJobCategory { get; set; }
        public bool? AffectsPosition { get; set; }
        public byte? Omen { get; set; }
        public bool? IsPvP { get; set; }
    }
}
