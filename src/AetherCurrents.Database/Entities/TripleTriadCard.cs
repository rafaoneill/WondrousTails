namespace AetherCurrents.Database.Entities
{
    public partial class TripleTriadCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool StartsWithVowel { get; set; }
        public string Description { get; set; }
    }
}
