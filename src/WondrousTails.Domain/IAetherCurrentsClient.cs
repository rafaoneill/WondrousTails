using System.Collections.Generic;
using System.Threading.Tasks;

namespace WondrousTails.Domain
{
    /// <summary>
    /// Interface for an IAetherCurrentsClient
    /// </summary>
    public interface IAetherCurrentsClient
    {
        /// <summary>
        /// Gets response from the API.
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <returns>A result of generic type.</returns>
        Task<IEnumerable<T>> GetResponse<T>() where T : class;

        /// <summary>
        /// Gets response from the API using the specified <see paramref="endPoint" />.
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <param name="endPoint">The end point to use for the request.</param>
        /// <returns>A result of generic type.</returns>
        Task<IEnumerable<T>> GetResponse<T>(string endPoint) where T : class;

        /// <summary>
        /// Gets response from the API using the specified <see paramref="endPoints" />.
        /// </summary>
        /// <typeparam name="T">The generic type.</typeparam>
        /// <param name="endPoints">The end points to use for the request.</param>
        /// <returns>A result of generic type.</returns>
        Task<IEnumerable<T>> GetResponse<T>(params string[] endPoints) where T : class;
    }
}