using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Farmcoz_mod_tool.mod.components
{
    public class Recipe
    {
        //DEFAULT
        [JsonProperty("first_item")]
        public string FirstItem { get; private set; }
        [JsonProperty("first_item_count")]
        public int FirstItemCount { get; private set; }
        [JsonProperty("result")]
        public string Result { get; private set; }
        [JsonProperty("result_count")]
        public int ResultCount { get; private set; }

        //DOUBLE ITEM
        [JsonProperty("second_item")]
        public string SecondItem { get; private set; }
        [JsonProperty("second_item_count")]
        public int SecondItemCount { get; private set; }

        public Recipe() { }

        public Recipe(string firstItem, int firstItemCount, string result, int resultCount)
        {
            FirstItem = firstItem;
            FirstItemCount = firstItemCount;
            Result = result;
            ResultCount = resultCount;
        }

        public Recipe(string firstItem, int firstItemCount, string secondItem, int secondItemCount, string result, int resultCount)
        {
            FirstItem = firstItem;
            FirstItemCount = firstItemCount;
            SecondItem = secondItem;
            SecondItemCount = secondItemCount;
            Result = result;
            ResultCount = resultCount;
        }
    }
}
