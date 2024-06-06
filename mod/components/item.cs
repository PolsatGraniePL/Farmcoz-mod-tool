using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmcoz_mod_tool.mod.components
{
    internal class Item
    {

        //DEFAULT
        private string name;
        private string texture;
        private string description;
        private int flags;
        private int stack_size;

        //GROW
        private string grown_id;
        private float growing_time;

        public Item(string Iname, string Itexture, string Idescription, int Iflags, int Istack_size) { 
            name = Iname;
            texture = Itexture;
            description = Idescription; 
            flags = Iflags;
            stack_size = Istack_size;
        }
        public Item(string Iname, string Itexture, string Idescription, int Iflags, int Istack_size, string Igrown_id, float Igrowing_time) { 
            name = Iname;
            texture = Itexture;
            description = Idescription; 
            flags = Iflags;
            stack_size = Istack_size;
            grown_id = Igrown_id;
            growing_time = Igrowing_time;
        }

    }
}
