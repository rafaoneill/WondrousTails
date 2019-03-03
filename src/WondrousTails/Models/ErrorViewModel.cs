using System;

namespace WondrousTails.Models
{
    /// <summary>
    /// The Error View Model class.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the value of the RequestId
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not to show RequestId
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}