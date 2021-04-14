using System;
using System.Collections.Generic;
using System.Text;

namespace Jellyfish.Data.Entities
{
    public class PortfolioVisit
    {
        public string UserAgent { get; set; }
        public string VisitedBy { get; set; }
        public int PortfolioId { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
