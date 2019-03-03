using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WondrousTails.Domain
{
    /// <summary>
    /// Implementation for an AetherCurrentsClient
    /// </summary>
    public class AetherCurrentsClient : IAetherCurrentsClient
    {
        private readonly Uri _uri;

        /// <summary>
        /// The constructor. Sets up the API url to use.
        /// </summary>
        /// <param name="uri">The URI use to connect to API.</param>
        public AetherCurrentsClient(Uri uri)
        {
            _uri = uri;
        }

        /// <inheritdoc/>
        public Task<IEnumerable<T>> GetResponse<T>() where T : class
        {
            return _uri.AbsoluteUri.GetJsonAsync<IEnumerable<T>>();
        }

        /// <inheritdoc/>
        public Task<IEnumerable<T>> GetResponse<T>(string endPoint) where T : class
        {
            return _uri.AbsoluteUri.AppendPathSegment(endPoint).GetJsonAsync<IEnumerable<T>>();
        }

        /// <inheritdoc/>
        public Task<IEnumerable<T>> GetResponse<T>(params string[] endPoints) where T : class
        {
            return this.GetResponse<T>(string.Join("/", endPoints));
        }
    }
}