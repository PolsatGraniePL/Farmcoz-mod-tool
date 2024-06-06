using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Farmcoz_mod_tool {

    public class JsonManager<T>
    {
        private string filePath;

        public JsonManager(string filePath)
        {
            this.filePath = filePath;
        }

        public List<T> LoadItems()
        {
            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public void SaveItems(List<T> items)
        {
            string json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void AddItem(T item)
        {
            var items = LoadItems();
            items.Add(item);
            SaveItems(items);
        }

        public void UpdateItem(T item, Predicate<T> match)
        {
            var items = LoadItems();
            var index = items.FindIndex(match);
            if (index != -1)
            {
                items[index] = item;
                SaveItems(items);
            }
        }

        public void DeleteItem(Predicate<T> match)
        {
            var items = LoadItems();
            var item = items.Find(match);
            if (item != null)
            {
                items.Remove(item);
                SaveItems(items);
            }
        }
    }
}