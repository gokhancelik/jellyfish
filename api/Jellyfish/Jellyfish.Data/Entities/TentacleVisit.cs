using System;

namespace Jellyfish.Data.Entities
{
    public class TentacleVisit
    {
        public string UserAgent { get; set; }
        public string VisitedBy { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
    }
}