using System.Collections.Generic;

namespace Jellyfish.Data.Entities
{
    public class Tentacle : BaseTentacle
    {
        public string Url { get; set; }


    }
    public enum TentacleStatus
    {
        Passive = 0,
        Active = 1,
    }
}