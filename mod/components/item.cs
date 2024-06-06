using System;
using Newtonsoft.Json;

namespace Farmcoz_mod_tool.mod.components
{
    public class Item
    {
        //DEFAULT
        [JsonProperty("name")]
        public string Name { get; private set; }
        [JsonProperty("texture")]
        public string Texture { get; private set; }
        [JsonProperty("description")]
        public string Description { get; private set; }
        [JsonProperty("flags")]
        public int Flags { get; private set; }
        [JsonProperty("stack_size")]
        public int StackSize { get; private set; }

        //GROW
        [JsonProperty("grown_id")]
        public string GrownId { get; private set; }
        [JsonProperty("growing_time")]
        public float GrowingTime { get; private set; }

        public Item() { }

        public Item(string name, string texture, string description, int flags, int stackSize)
        {
            Name = name;
            Texture = texture;
            Description = description;
            Flags = flags;
            StackSize = stackSize;
        }

        public Item(string name, string texture, string description, int flags, int stackSize, string grownId, float growingTime)
        {
            Name = name;
            Texture = texture;
            Description = description;
            Flags = flags;
            StackSize = stackSize;
            GrownId = grownId;
            GrowingTime = growingTime;
        }
    }
}
