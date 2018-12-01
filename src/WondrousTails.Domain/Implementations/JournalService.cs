using Flurl.Http;
using System;
using System.Collections.Generic;
using WondrousTails.Domain;
using WondrousTails.Domain.Interfaces;
using WondrousTails.Domain.Response;

namespace WondrousTails.Domain.Implementations
{
    /// <summary>
    /// Implementation for a IJournalService
    /// </summary>
    public class JournalService : IJournalService
    {
        private string _endPoint = "journal";
        private readonly IAetherCurrentsClient _client;

        /// <summary>
        /// The constructor, sets up the client to use.
        /// </summary>
        /// <param name="client">IAetherCurrentsClient</param>
        public JournalService(IAetherCurrentsClient client)
        {
            _client = client;
        }

        public IEnumerable<JournalResponse> GetJournalSections()
        {
            var response = _client.Get<JournalResponse>(_endPoint, "sections");
            
            return response.Result;
        }
    }
}