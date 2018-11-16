namespace AetherCurrents.Database.Entities
{
    public partial class QuestDetail
    {
        public int Id { get; set; }
        public string SheetFullName { get; set; }
        public string QuestTextId { get; set; }
        public string DetailKey { get; set; }
        public string DetailDescription { get; set; }
    }
}
