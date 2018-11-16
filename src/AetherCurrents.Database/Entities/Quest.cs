namespace AetherCurrents.Database.Entities
{
    public partial class Quest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QuestId { get; set; }
        public byte Expansion { get; set; }
        public byte QuestLevelOffset { get; set; }
        public byte PreviousQuestJoin { get; set; }
        public byte QuestLockJoin { get; set; }
        public byte ClassJobUnlock { get; set; }
        public byte GrandCompany { get; set; }
        public byte GrandCompanyRank { get; set; }
        public byte InstanceContentJoin { get; set; }
        public short BellStart { get; set; }
        public short BellEnd { get; set; }
        public byte BeastTribe { get; set; }
        public byte BeastReputationRank { get; set; }
        public int? MountRequired { get; set; }
        public bool IsHouseRequired { get; set; }
        public int EnpcResidentStart { get; set; }
        public int EnpcResidentEnd { get; set; }
        public bool IsRepeatable { get; set; }
        public byte RepeatIntervalType { get; set; }
        public byte ClassJobRequired { get; set; }
        public int ExpFactor { get; set; }
        public int GilReward { get; set; }
        public short GrandCompanySeals { get; set; }
        public byte ItemRewardType { get; set; }
        public int InstanceContentUnlock { get; set; }
        public byte TomestoneReward { get; set; }
        public byte TomestoneRewardCount { get; set; }
        public byte ReputationReward { get; set; }
        public short? PlaceName { get; set; }
        public short JournalGenre { get; set; }
        public string Icon { get; set; }
        public string IconSpecial { get; set; }
        public short EventIconType { get; set; }
        public short SortKey { get; set; }
        public int ClassJobLevelUnlock { get; set; }
        public int ClassJobLevelComplete { get; set; }
        public short ClassJobCategoryUnlock { get; set; }
        public short ClassJobCategoryComplete { get; set; }
        public byte QuestStatus { get; set; }
    }
}
