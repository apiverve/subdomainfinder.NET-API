using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// RootDomain data
    /// </summary>
    public class RootDomain
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("records")]
        public string[] Records { get; set; }

    }
    /// <summary>
    /// SubDomains data
    /// </summary>
    public class SubDomains
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("records")]
        public string[] Records { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("rootDomain")]
        public RootDomain RootDomain { get; set; }

        [JsonProperty("subDomains")]
        public SubDomains[] SubDomains { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
