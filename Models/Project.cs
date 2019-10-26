using Newtonsoft.Json;
using System;

namespace CooperativaXZ
{
    public class Project
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
        [JsonProperty("offer_value")]
        public string OfferValue { get; set; }
        [JsonProperty("analyze")]
        public string Analyze { get; set; }
        [JsonProperty("hirer")]
        public string Hirer { get; set; }
        [JsonProperty("project_deliveries")]
        public ProjectDelivere[] ProjectDeliveries { get; set; }
        [JsonProperty("project_evaluations")]
        public ProjectEvaluation[] ProjectEvaluations { get; set; }
    }

    public class ProjectDelivere
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }

    public class ProjectEvaluation
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}