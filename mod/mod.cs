using Farmcoz_mod_tool.mod.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmcoz_mod_tool.mod
{
    internal class Mod
    {
        public List<Item> items = new List<Item>();
        public List<Drop> drops = new List<Drop>();
        public List<Recipe> recipes = new List<Recipe>();

        public string name;
        public Mod(string Iname) { 
            name = Iname;
        }
    }
}
