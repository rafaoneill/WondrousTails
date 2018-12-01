using Flurl;
using Flurl.Http;
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
        public string _url;

        /// <summary>
        /// The constructor. Sets up the API url to use.
        /// </summary>
        /// <param name="url">The URL to connect to.</param>
        public AetherCurrentsClient(string url)
        {
            _url = url;
        }

        public Task<IEnumerable<T>> Get<T>() where T : class
        {
            return _url.GetJsonAsync<IEnumerable<T>>();
        }

        public Task<IEnumerable<T>> Get<T>(string endPoint) where T : class
        {
            return _url.AppendPathSegment(endPoint).GetJsonAsync<IEnumerable<T>>();
        }

        public Task<IEnumerable<T>> Get<T>(params string[] endPoints) where T : class
        {
            return this.Get<T>(string.Join("/", endPoints));
        }
    }
}