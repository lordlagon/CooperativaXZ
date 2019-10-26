using Newtonsoft.Json;
using System;

namespace CooperativaXZ
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OfferValue { get; set; }
        public string Analyze { get; set; }
        public string Hirer { get; set; }
        public ProjectDelivere[] ProjectDeliveries { get; set; }
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