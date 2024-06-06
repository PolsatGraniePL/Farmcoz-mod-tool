using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Farmcoz_mod_tool.mod.components
{
    public class Drop
    {
        //DEFAULT
        [JsonProperty("from_id")]
        public string FromId { get; private set; }
        [JsonProperty("drop_id")]
        public string DropId { get; private set; }
        [JsonProperty("max_count")]
        public int MaxCount { get; private set; }
        [JsonProperty("probability")]
        public float Probability { get; private set; }

        public Drop() { }

        public Drop(string fromId, string dropId, int maxCount, float probability)
        {
            FromId = fromId;
            DropId = dropId;
            MaxCount = maxCount;
            Probability = probability;
        }
    }
}
