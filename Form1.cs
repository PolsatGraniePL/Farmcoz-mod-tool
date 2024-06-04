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
            tabControl1.Visible = false;
            currentMod = "";
            tb_loc.Text = FileManager.GetUserModsLocation();
            refreshModList();

        }

        private void selectMod(string name)
        {
            currentMod = name;
            this.Text = "Farmcoz mod tool - " + currentMod;
        }

        private void lb_modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lb_modList.SelectedItems.Count == 0))
            {
                selectMod(lb_modList.SelectedItem.ToString());
                tabControl1.Visible = true;
                pictureBox.Image = null;
                label20.Text = "Select image";
                refreshPictures();
            }
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
                    File.Copy(filename, destFile, true);

                    images_ListBox.Items.Add(Path.GetFileName(filename));
                    selectImage(Path.GetFileName(filename));
                }
                else
                {
                    MessageBox.Show("This image is not 64x64!");
                }
            }
            refreshPictures();
            if (!(images_ListBox.SelectedItems.Count == 0))
                selectImage(images_ListBox.SelectedItems[images_ListBox.SelectedItems.Count].ToString());
        }

        private void images_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(images_ListBox.SelectedItems.Count == 0))
            {
                string selectedItem = images_ListBox.SelectedItem.ToString();
                selectImage(selectedItem);
            }
        }


        private void selectImage(string fileName)
        {
            pictureBox.Load(Path.Combine(tb_loc.Text, currentMod, fileName));
            label20.Text = fileName;
        }


        private void items_btn_new_Click(object sender, EventArgs e)
        {
            items_ListBox.ClearSelected();
            btn_addItem.Text = "Add item";
        }

        private void drops_btn_new_Click(object sender, EventArgs e)
        {
            drops_ListBox.ClearSelected();
            btn_addDrop.Text = "Add drop";
        }

        private void recipes_btn_new_Click(object sender, EventArgs e)
        {
            recipes_ListBox.ClearSelected();
            btn_addRecipe.Text = "Add recipe";
        }
        
        //TODO:
        // Uzupe³nianie wartoœci z textbox na new item()


        private void items_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addItem.Text = "Edit item";
        }

        private void drops_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addDrop.Text = "Edit drop";
        }

        private void recipes_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addRecipe.Text = "Edit recipe";
        }

        //private void btn_deleteImage_Click(object sender, EventArgs e)
        //{
        //    if (images_ListBox.SelectedItem != null)
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure you want to delete: " + images_ListBox.SelectedItem.ToString(), "Confirmation of deletion", MessageBoxButtons.OKCancel);
        //
        //        if (result == DialogResult.OK)
        //        {
        //            try
        //            {
        //                string destFile = Path.Combine(Path.Combine(tb_loc.Text, currentMod), images_ListBox.SelectedItem.ToString());
        //                if (File.Exists(destFile))
        //                {
        //                    MessageBox.Show("Funkcja usuwania jest tymczasowo niedostêpna.");
        //                    images_ListBox.Items.Remove(images_ListBox.SelectedItem);
        //                    pictureBox.Image = null;
        //                    label20.Text = "Select image";
        //                    File.Delete(destFile);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("File does not exist:" + destFile);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error deleting file: " + ex.Message);
        //            }
        //        }
        //    }
        //}

    }
}
