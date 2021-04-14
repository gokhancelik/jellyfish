using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jellyfish.Data.Entities
{
    public class Portfolio
    {
        public string Slug { get; set; }
        public string ThumbPhoto { get; set; }
        public string BackgroundPhoto { get; set; }
        [MaxLength(256)]
        public string UserId { get; set; }
        public virtual ICollection<Tentacle> Tentacles { get; set; }
        public virtual ICollection<PortfolioVisit> PortfolioVisits { get; set; }
    }
}
