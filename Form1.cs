using Farmcoz_mod_tool.component;
using Farmcoz_mod_tool.mod;
using Farmcoz_mod_tool.mod.components;
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

        public static Mod currentMod;

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
            currentMod = null;
            tb_loc.Text = FileManager.GetUserModsLocation();
            refreshModList();

        }

        private void selectMod(string name)
        {
            currentMod = new Mod(name);
            this.Text = "Farmcoz mod tool - " + currentMod;
        }

        private void lb_modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lb_modList.SelectedItems.Count == 0))
            {
                resetControls();
                selectMod(lb_modList.SelectedItem.ToString());
                tabControl1.Visible = true;
                pictureBox.Image = null;
                label20.Text = "Select image";
                refreshPictures();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            resetControls();
        }

        private void resetControls()
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "items.json":
                    items_ListBox.Items.Clear();
                    items_tb_name.Text = "";
                    items_cb_texture.Items.Clear();
                    items_cb_texture.Items.AddRange(FileManager.getImages(tb_loc.Text));
                    items_tb_description.Text = "";
                    items_nb_stacksize.Value = 1;
                    items_chb_collidable.Checked = false;
                    items_chb_compostable.Checked = false;
                    items_chb_eatable.Checked = false;
                    items_chb_entitable.Checked = false;
                    items_chb_grow_at_night.Checked = false;
                    items_chb_outlinable.Checked = false;
                    items_chb_plantable.Checked = false;
                    items_chb_sound_organic.Checked = false;
                    items_chb_sound_wooden.Checked = false;
                    items_chb_understructable.Checked = false;
                    items_chb_unplacable.Checked = false;
                    items_chb_ununlockable.Checked = false;
                    items_tb_grow_id.Text = "";
                    items_nb_growing_time.Value = 0;
                    break;
                case "drops.json":
                    drops_ListBox.Items.Clear();
                    drops_tb_dropID.Text = "";
                    drops_tb_fromID.Text = "";
                    drops_nb_maxCount.Value = 1;
                    drops_nb_maxCount.Value = 0;

                    break;
                case "recipes.json":
                    recipes_ListBox.Items.Clear();
                    recipes_tb_firstItem.Text = "";
                    recipes_nb_firstItemCount.Value = 1;
                    recipes_tb_result.Text = "";
                    recipes_nb_resultCount.Value = 1;
                    recipes_tb_secondItem.Text = "";
                    recipes_nb_secondItemCount.Value = 0;
                    break;
                case "Images":
                    images_ListBox.Items.Clear();
                    break;
            }
            //Items

        }

        private void btn_addImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images|*.png";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string destFile = Path.Combine(Path.Combine(tb_loc.Text, currentMod.name), Path.GetFileName(openFileDialog1.FileName));

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
            pictureBox.Load(Path.Combine(tb_loc.Text, currentMod.name, fileName));
            label20.Text = fileName;
        }


        private void items_btn_new_Click(object sender, EventArgs e)
        {
            items_ListBox.ClearSelected();
            btn_addItem.Text = "Add item";
            resetControls();
        }

        private void drops_btn_new_Click(object sender, EventArgs e)
        {
            drops_ListBox.ClearSelected();
            btn_addDrop.Text = "Add drop";
            resetControls();
        }

        private void recipes_btn_new_Click(object sender, EventArgs e)
        {
            recipes_ListBox.ClearSelected();
            btn_addRecipe.Text = "Add recipe";
            resetControls();
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

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            bool git = !(string.IsNullOrEmpty(items_tb_name.Text));
            bool git2 = !(items_ListBox.Items.Contains(items_tb_name.Text));
            bool git3 = FileManager.getImages(tb_loc.Text).Contains(items_cb_texture.Text);
            bool git4 = !(string.IsNullOrEmpty(items_tb_description.Text));
            bool git_add = !(string.IsNullOrEmpty(items_tb_grow_id.Text));

            string name = items_tb_name.Text;
            string texture = items_cb_texture.Text;
            string description = items_tb_description.Text;
            int stack_size = Decimal.ToInt32(items_nb_stacksize.Value);
            int flag = FlagsValue.parse(items_chb_unplacable.Checked, items_chb_understructable.Checked, items_chb_plantable.Checked, items_chb_ununlockable.Checked, items_chb_compostable.Checked, items_chb_eatable.Checked, items_chb_sound_wooden.Checked, items_chb_sound_organic.Checked, items_chb_collidable.Checked, items_chb_grow_at_night.Checked, items_chb_entitable.Checked, items_chb_outlinable.Checked);
            
            string grown_id = items_tb_grow_id.Text;
            float growing_time = (float)items_nb_growing_time.Value;

            if (git && git2 && git3 && git4 && git_add)
            {
                Item item = new Item(name, texture, description, stack_size, flag, grown_id, growing_time);
                currentMod.items.Add(item);
            }
            else if (git && git2 && git3 && git4)
            {
                Item item = new Item(name, texture, description, stack_size, flag);
            }
            else {
                MessageBox.Show("The form was not completed correctly.");
            }
        }

        private void btn_addDrop_Click(object sender, EventArgs e)
        {

        }

        private void btn_addRecipe_Click(object sender, EventArgs e)
        {

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
