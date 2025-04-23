using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class rootDomain
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("records")]
    public string[] records { get; set; }

}

public class subDomains
{
    [JsonProperty("host")]
    public string host { get; set; }

    [JsonProperty("records")]
    public string[] records { get; set; }

}

public class data
{
    [JsonProperty("rootDomain")]
    public rootDomain rootDomain { get; set; }

    [JsonProperty("subDomains")]
    public subDomains[] subDomains { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
