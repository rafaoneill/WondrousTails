namespace WondrousTails.Domain.Response
{
    /// <summary>
    /// Represents a response for a Section from the Journal API
    /// </summary>
    public class JournalResponse
    {
        /// <summary>
        /// Journal Section Id
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Journal Section Name
        /// </summary>
        public string Name { get; set; }
    }
}