using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHChan.APIs
{
    internal abstract class BaseAPI
    {
        /// <summary>
        /// TimeOut
        /// </summary>
        protected virtual int TimeOut => 3000;

        /// <summary>
        /// Base URL
        /// </summary>
        protected abstract string BaseURL { get; }

        /// <summary>
        /// Middle
        /// </summary>
        protected abstract string[] MiddleURL { get; }

        /// <summary>
        /// API URL
        /// </summary>
        protected virtual string[] APIURL { get; set; }

        /// <summary>
        /// Content-Type
        /// </summary>
        protected virtual string ContentType { get; set; }

        /// <summary>
        /// Aceept
        /// </summary>
        protected virtual string Accept { get; set; }

        /// <summary>
        /// UserAgent
        /// </summary>
        protected virtual string UserAgent { get; set; }

        /// <summary>
        /// Headers
        /// </summary>
        protected Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Queary string parameters
        /// </summary>
        protected Dictionary<string, string> RequestParams { get; set; }

        /// <summary>
        /// Body parameters
        /// </summary>
        protected Dictionary<string, string> Body { get; set; }

        /// <summary>
        /// Full path URL
        /// </summary>
        public string URL
        {
            get
            {
                if (APIURL is null)
                    return string.Join("/", Enumerable.Concat(new string[] { BaseURL }, MiddleURL));
                else
                    return string.Join("/", Enumerable.Concat(new string[] { BaseURL }, MiddleURL).Concat(APIURL));
            }
        }

        /// <summary>
        /// Full path Request URL
        /// </summary>
        public string RequestURL
        {
            get
            {
                if (RequestParams is null)
                    return URL;
                else
                    return $"{URL}?{string.Join("&", RequestParams.Select(pa => $"{pa.Key}={pa.Value}"))}"; 
            }
        }
    }
}
