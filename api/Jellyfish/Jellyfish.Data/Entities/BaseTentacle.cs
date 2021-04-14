using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Jellyfish.Data.Entities
{
    public abstract class BaseTentacle
    {
        public virtual Portfolio Portfolio { get; set; }
        [MaxLength(140)]
        public string Title { get; set; }
        public TentacleStatus Status { get; set; }
        public int Order { get; set; }
    }
}
