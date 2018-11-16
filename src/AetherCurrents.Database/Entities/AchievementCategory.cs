namespace AetherCurrents.Database.Entities
{
    public partial class AchievementCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Kind { get; set; }
        public bool IsActive { get; set; }
        public bool IsSeasonal { get; set; }
    }
}
