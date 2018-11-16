namespace AetherCurrents.Database.Entities
{
    public partial class Achievement
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Points { get; set; }
        public short? Title { get; set; }
        public string Item { get; set; }
        public string Icon { get; set; }
        public byte Type { get; set; }
        public int DataI { get; set; }
        public int DataIi { get; set; }
        public int DataIii { get; set; }
        public int DataIv { get; set; }
        public int DataV { get; set; }
        public int DataVi { get; set; }
        public int DataVii { get; set; }
        public int DataViii { get; set; }
        public int DataIx { get; set; }
        public short Order { get; set; }
    }
}
