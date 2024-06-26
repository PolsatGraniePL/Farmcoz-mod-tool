﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmcoz_mod_tool
{
    internal class FileManager
    {

        public static void createDir(string loc, string name) {
            Directory.CreateDirectory(Path.Combine(loc, name));
        }


        public static string[] getDirs(string loc)
        {
            return Directory.GetDirectories(loc);
        }

        public static string[] getImages(string loc)
        {
            var files = Directory.EnumerateFiles(Path.Combine(loc, Form1.currentMod.name), "*.png");
            return files.Select(Path.GetFileName).ToArray();
        }

        public static string GetUserModsLocation()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "farmcoz", "mods");
        }
    }
}
