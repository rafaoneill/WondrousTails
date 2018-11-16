namespace AetherCurrents.Database.Entities
{
    public partial class TripleTriadCardResident
    {
        public int Id { get; set; }
        public byte Top { get; set; }
        public byte Bottom { get; set; }
        public byte Left { get; set; }
        public byte Right { get; set; }
        public byte Rarity { get; set; }
        public byte Type { get; set; }
        public int SaleValue { get; set; }
        public byte SortKey { get; set; }
    }
}