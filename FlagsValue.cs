using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmcoz_mod_tool
{
    internal class FlagsValue
    {

        public static int parse(bool unplacable, bool understructable, bool plantable, bool ununlockable, bool compostable, bool eatable, bool souund_wooden, bool sount_organic, bool collidable, bool grow_at_night, bool entitable, bool outlinable) {
            int a = unplacable ? 1 : 0;
            int b = understructable ? 2 : 0;
            int c = plantable ? 4 : 0;
            int d = ununlockable ? 8 : 0;
            int e = compostable ? 16 : 0;
            int f = eatable ? 32 : 0;
            int g = souund_wooden ? 64 : 0;
            int h = sount_organic ? 128 : 0;
            int i = collidable ? 256 : 0;
            int j = grow_at_night ? 512 : 0;
            int k = entitable ? 1024 : 0;
            int l = outlinable ? 2048 : 0;
            return a+b+c+d+f+g+h+i+j+k+l;
        }

    }
}
