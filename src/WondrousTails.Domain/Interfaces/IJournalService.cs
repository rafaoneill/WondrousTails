using System.Collections.Generic;
using WondrousTails.Domain.Response;

namespace WondrousTails.Domain.Interfaces
{
    /// <summary>
    /// Interface for a Journal Service
    /// </summary>
    public interface IJournalService
    {
        /// <summary>
        /// Gets all Journal sections.
        /// </summary>
        /// <returns>A list of Journal sections.</returns>
        IEnumerable<JournalResponse> GetJournalSections();
    }
}