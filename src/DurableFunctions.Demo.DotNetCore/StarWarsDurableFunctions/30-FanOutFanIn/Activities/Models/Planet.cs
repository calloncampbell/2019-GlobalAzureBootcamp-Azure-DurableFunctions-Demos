using Newtonsoft.Json;


namespace DurableFunctions.Demo.DotNetCore.FanOutFanIn.Orchestrators.Models
{
    public sealed class Planet
    {
        public string Name { get; set; }

        [JsonProperty("residents")]
        public string[] ResidentUrls { get; set; }
    }
}