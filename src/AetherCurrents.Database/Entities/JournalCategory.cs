namespace AetherCurrents.Database.Entities
{
    public partial class JournalCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JournalSectionId { get; set; }
    }
}
