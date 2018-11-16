namespace AetherCurrents.Database.Entities
{
    public partial class JournalGenre
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public byte JournalCategory { get; set; }
        public string Name { get; set; }
    }
}
