using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Collections.Specialized;
using System.Net.Http;
using Tweetsharp.PCL;

namespace TweetSharp
{
    public class TwitterResponse<T> where T : class
    {
        private readonly HttpResponseMessage _response;
        private readonly Exception _exception;

        internal TwitterResponse(HttpResponseMessage response, Exception exception = null)
        {
            _exception = exception;
            _response = response;

            Headers = new NameValueCollection();

            foreach (var header in response.Headers)
                Headers.Add(header.Key, header.Value);

            var stringReadTask = _response.Content.ReadAsStringAsync();
            stringReadTask.RunSynchronously();

            Response = stringReadTask.Result; // I don't like it, but it doesn't break how things work.
        }

        private TwitterRateLimitStatus _rateLimitStatus = null;
        public virtual TwitterRateLimitStatus RateLimitStatus
        {
            get
            {
                if (_rateLimitStatus == null)
                    _rateLimitStatus = CreateRateLimitStatus();
                return _rateLimitStatus;
            }
        }

        private TwitterRateLimitStatus CreateRateLimitStatus()
        {
            /*
            X-Rate-Limit-Limit: 15
            X-Rate-Limit-Remaining: 14
            X-Rate-Limit-Reset: 1360991702
            */

            var limit = Headers["X-Rate-Limit-Limit"];
            var remaining = Headers["X-Rate-Limit-Remaining"];
            var reset = Headers["X-Rate-Limit-Reset"];

            limit = IsStringANumber(!string.IsNullOrEmpty(limit) ? limit.Trim() : "-1") ? limit : "-1";
            remaining = IsStringANumber(!string.IsNullOrEmpty(remaining) ? remaining.Trim() : "-1") ? remaining : "-1";
            reset = IsStringANumber(!string.IsNullOrEmpty(reset) ? reset.Trim() : "-1") ? reset : "0";

            return !(new[] { limit, remaining, reset }).AreNullOrBlank()
                       ? new TwitterRateLimitStatus
                       {
                           HourlyLimit = Convert.ToInt32(limit, CultureInfo.InvariantCulture),
                           RemainingHits = Convert.ToInt32(remaining, CultureInfo.InvariantCulture),
                           ResetTimeInSeconds = Convert.ToInt64(reset, CultureInfo.InvariantCulture),
                           ResetTime = Convert.ToInt64(reset, CultureInfo.InvariantCulture).FromUnixTime()
                       }
                       : null;
        }

        private static bool IsStringANumber(IEnumerable<char> limit)
        {
            return limit.All(char.IsNumber);
        }
        public virtual TwitterError Error { get; set; }
        public virtual NameValueCollection Headers { get; set; }

        public virtual HttpStatusCode StatusCode
        {
            get { return _response.StatusCode; }
            set { _response.StatusCode = value; }
        }

        public virtual bool SkippedDueToRateLimitingRule { get { return RateLimitStatus.RemainingHits <= 0; } }

        public virtual string Response { get; set; }
        public virtual HttpMethod RequestMethod
        {
            get { return _response.RequestMessage.Method; }
        }

        public virtual Uri RequestUri
        {
            get { return _response.RequestMessage.RequestUri; }
        }

        public virtual Exception InnerException { get; private set; }

        public T Content { get; set; }

        public bool RequestSucceeded
        {
            get { return _response.IsSuccessStatusCode && Content != null; }
        }
    }
}