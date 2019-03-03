namespace WondrousTails.Domain.Response
{
    /// <summary>
    /// Represents a response for a Section from the Journal API
    /// </summary>
    public class JournalResponse
    {
        /// <summary>
        /// Gets or sets the Journal Section Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Journal Section Name
        /// </summary>
        public string Name { get; set; }
    }
}