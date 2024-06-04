using Farmcoz_mod_tool.component;
using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Farmcoz_mod_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        public static string currentMod;

        private void OnApplicationExit(object sender, EventArgs e)
        {
            //...
        }

        private void btn_CreateMod_Click(object sender, EventArgs e)
        {
            string modName = tb_ModName.Text;
            string loc = tb_loc.Text;
            if (!string.IsNullOrEmpty(modName) && !string.IsNullOrEmpty(loc))
            {
                FileManager.createDir(loc, modName);
                tb_ModName.Text = null;
                selectMod(modName);
                refreshModList();
            }
            else
            {
                MessageBox.Show("Mod name and location cannot be empty");
            }
        }

        private void refreshModList()
        {
            string[] dirs = FileManager.getDirs(tb_loc.Text);
            lb_modList.Items.Clear();
            foreach (string dir in dirs)
            {
                Debug.WriteLine(dir);
                lb_modList.Items.Add(Path.GetFileName(dir));
            }
        }

        private void refreshPictures()
        {
            string[] images = FileManager.getImages(tb_loc.Text);
            images_ListBox.Items.Clear();
            images_ListBox.Items.AddRange(images);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentMod = "";
            tb_loc.Text = FileManager.GetUserModsLocation();
            refreshModList();
            refreshPictures();

        }

        private void selectMod(string name)
        {
            currentMod = name;
            this.Text = "Farmcoz mod tool - " + currentMod;
        }

        private void lb_modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectMod(lb_modList.SelectedItem.ToString());
        }

        private void btn_addImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images|*.png";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string destFile = Path.Combine(Path.Combine(tb_loc.Text, currentMod), Path.GetFileName(openFileDialog1.FileName));

                Image image = Image.FromFile(filename);
                int width = image.Width;
                int height = image.Height;
                if (width == 64 && height == 64)
                {
                    File.Copy(openFileDialog1.FileName, destFile, true);

                    images_ListBox.Items.Add(Path.GetFileName(filename));
                    selectImage(Path.GetFileName(filename));
                }
                else
                {
                    MessageBox.Show("This image is not 64x64!");
                }
            }
            refreshPictures();
        }

        private void images_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectImage(images_ListBox.SelectedItem.ToString());
        }

        private void selectImage(string fileName)
        {
            pictureBox.Load(Path.Combine(tb_loc.Text, fileName));
            label20.Text = fileName;
        }

    }
}
