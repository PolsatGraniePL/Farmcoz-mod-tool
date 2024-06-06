using Farmcoz_mod_tool.mod;
using Farmcoz_mod_tool.mod.components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmcoz_mod_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Mod currentMod;
        private JsonManager<Item> jsonManagerItem;
        private JsonManager<Drop> jsonManagerDrop;
        private JsonManager<Recipe> jsonManagerRecipe;

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
            try
            {
                string[] dirs = FileManager.getDirs(tb_loc.Text);
                lb_modList.Items.Clear();
                foreach (string dir in dirs)
                {
                    lb_modList.Items.Add(Path.GetFileName(dir));
                }
            }
            catch { lb_modList.Items.Clear(); }
            
        }

        private void refreshPictures()
        {
            string[] images = FileManager.getImages(tb_loc.Text);
            images_ListBox.Items.Clear();
            images_ListBox.Items.AddRange(images);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "farmcoz", "MoodTool.json")));
                tb_loc.Text = data.location;
            }
            catch
            {
                tb_loc.Text = FileManager.GetUserModsLocation();
                var data = new
                {
                    location = tb_loc.Text
                };

                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "farmcoz", "MoodTool.json"), json);
            }

            tabControl1.Visible = false;
            currentMod = null;

            refreshModList();
        }

        private void selectMod(string name)
        {
            currentMod = new Mod(name);
            this.Text = "Farmcoz mod tool - " + currentMod.name;

            jsonManagerItem = new JsonManager<Item>(Path.Combine(tb_loc.Text, currentMod.name, "items.json"));
            jsonManagerDrop = new JsonManager<Drop>(Path.Combine(tb_loc.Text, currentMod.name, "drops.json"));
            jsonManagerRecipe = new JsonManager<Recipe>(Path.Combine(tb_loc.Text, currentMod.name, "recipes.json"));

            try
            {
                var data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Path.Combine(tb_loc.Text, currentMod.name, "config.json")));
                config_tb_name.Text = data.name;
            }
            catch
            {
                config_tb_name.Text = currentMod.name;
                var data = new
                {
                    name = config_tb_name.Text
                };

                string json = JsonConvert.SerializeObject(data, Formatting.Indented);

                File.WriteAllText(Path.Combine(tb_loc.Text, currentMod.name, "config.json"), json);
            }


        }

        private void lb_modList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_modList.SelectedItems.Count != 0)
            {
                resetControls();
                selectMod(lb_modList.SelectedItem.ToString());
                tabControl1.Visible = true;
                pictureBox.Image = null;
                label20.Text = "Select image";
                refreshPictures();
                refresh_item_list();
                refresh_drop_list();
                refresh_recipe_list();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            resetControls();
            refreshPictures();
            refresh_item_list();
            refresh_drop_list();
            refresh_recipe_list();
            btn_addItem.Text = "Add item";
            btn_addDrop.Text = "Add drop";
            btn_addRecipe.Text = "Add recipe";
        }

        private void resetControls()
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "items.json":
                    items_ListBox.Items.Clear();
                    items_tb_name.Text = "";
                    items_cb_texture.Text = "";
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
                    refresh_item_list();
                    break;
                case "drops.json":
                    drops_ListBox.Items.Clear();
                    drops_tb_dropID.Text = "";
                    drops_tb_fromID.Text = "";
                    drops_nb_maxCount.Value = 1;
                    drops_nb_probability.Value = 0;
                    refresh_drop_list();
                    break;
                case "recipes.json":
                    recipes_ListBox.Items.Clear();
                    recipes_tb_firstItem.Text = "";
                    recipes_nb_firstItemCount.Value = 1;
                    recipes_tb_result.Text = "";
                    recipes_nb_resultCount.Value = 1;
                    recipes_tb_secondItem.Text = "";
                    recipes_nb_secondItemCount.Value = 0;
                    refresh_recipe_list();
                    break;
                case "Images":
                    images_ListBox.Items.Clear();
                    refreshPictures();
                    break;
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
                string destFile = Path.Combine(tb_loc.Text, currentMod.name, Path.GetFileName(filename));

                Image image = Image.FromFile(filename);
                if (image.Width == 64 && image.Height == 64)
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
            if (images_ListBox.SelectedItems.Count != 0)
            {
                selectImage(images_ListBox.SelectedItems[images_ListBox.SelectedItems.Count - 1].ToString());
            }
        }

        private void images_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (images_ListBox.SelectedItems.Count != 0)
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

        public void refresh_item_list()
        {
            items_ListBox.Items.Clear();
            List<Item> items = jsonManagerItem.LoadItems();
            foreach (var item in items)
            {
                items_ListBox.Items.Add(item.Name);
            }
        }

        private void refresh_drop_list()
        {
            drops_ListBox.Items.Clear();
            List<Drop> drops = jsonManagerDrop.LoadItems();
            foreach (var drop in drops)
            {
                drops_ListBox.Items.Add($"{drop.FromId} -> {drop.DropId}");
            }
        }

        private void refresh_recipe_list()
        {
            recipes_ListBox.Items.Clear();
            List<Recipe> recipes = jsonManagerRecipe.LoadItems();
            foreach (var recipe in recipes)
            {
                recipes_ListBox.Items.Add($"{recipe.FirstItem} + {recipe.SecondItem} -> {recipe.Result}");
            }
        }

        private void updateControlsForSelectedItem(Item selectedItem)
        {
            items_tb_name.Text = selectedItem.Name;
            items_cb_texture.SelectedItem = selectedItem.Texture;
            items_tb_description.Text = selectedItem.Description;
            items_nb_stacksize.Value = selectedItem.StackSize;
            items_chb_unplacable.Checked = (selectedItem.Flags & 1) != 0;
            items_chb_understructable.Checked = (selectedItem.Flags & 2) != 0;
            items_chb_plantable.Checked = (selectedItem.Flags & 4) != 0;
            items_chb_ununlockable.Checked = (selectedItem.Flags & 8) != 0;
            items_chb_compostable.Checked = (selectedItem.Flags & 16) != 0;
            items_chb_eatable.Checked = (selectedItem.Flags & 32) != 0;
            items_chb_sound_wooden.Checked = (selectedItem.Flags & 64) != 0;
            items_chb_sound_organic.Checked = (selectedItem.Flags & 128) != 0;
            items_chb_collidable.Checked = (selectedItem.Flags & 256) != 0;
            items_chb_grow_at_night.Checked = (selectedItem.Flags & 512) != 0;
            items_chb_entitable.Checked = (selectedItem.Flags & 1024) != 0;
            items_chb_outlinable.Checked = (selectedItem.Flags & 2048) != 0;
            items_tb_grow_id.Text = selectedItem.GrownId;
            items_nb_growing_time.Value = (decimal)selectedItem.GrowingTime;
        }

        private void items_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addItem.Text = "Edit item";

            if (items_ListBox.SelectedItem != null)
            {
                var selectedItemName = items_ListBox.SelectedItem.ToString();
                var selectedItem = jsonManagerItem.LoadItems().Find(item => item.Name == selectedItemName);
                if (selectedItem != null)
                {
                    updateControlsForSelectedItem(selectedItem);
                }
            }
        }

        private void updateControlsForSelectedDrop(Drop selectedDrop)
        {
            drops_tb_fromID.Text = selectedDrop.FromId;
            drops_tb_dropID.Text = selectedDrop.DropId;
            drops_nb_maxCount.Value = selectedDrop.MaxCount;
            drops_nb_probability.Value = (decimal)selectedDrop.Probability;
        }

        private void drops_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addDrop.Text = "Edit drop";

            if (drops_ListBox.SelectedItem != null)
            {
                var selectedDropIds = drops_ListBox.SelectedItem.ToString().Split(new string[] { " -> " }, StringSplitOptions.None);
                if (selectedDropIds.Length == 2)
                {
                    var selectedDrop = jsonManagerDrop.LoadItems().Find(drop => drop.FromId == selectedDropIds[0] && drop.DropId == selectedDropIds[1]);
                    if (selectedDrop != null)
                    {
                        updateControlsForSelectedDrop(selectedDrop);
                    }
                }
            }
        }

        private void updateControlsForSelectedRecipe(Recipe selectedRecipe)
        {
            recipes_tb_firstItem.Text = selectedRecipe.FirstItem;
            recipes_nb_firstItemCount.Value = selectedRecipe.FirstItemCount;
            recipes_tb_result.Text = selectedRecipe.Result;
            recipes_nb_resultCount.Value = selectedRecipe.ResultCount;
            recipes_tb_secondItem.Text = selectedRecipe.SecondItem;
            recipes_nb_secondItemCount.Value = selectedRecipe.SecondItemCount;
        }

        private void recipes_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_addRecipe.Text = "Edit recipe";

            if (recipes_ListBox.SelectedItem != null)
            {
                var selectedRecipeParts = recipes_ListBox.SelectedItem.ToString().Split(new string[] { " + ", " -> " }, StringSplitOptions.None);
                if (selectedRecipeParts.Length >= 2)
                {
                    string firstItem = selectedRecipeParts[0];
                    string result = selectedRecipeParts.Last();

                    string secondItem = string.Empty;
                    string secondItemCount = "1";

                    if (selectedRecipeParts.Length == 3)
                    {
                        secondItem = selectedRecipeParts[1];
                    }

                    var selectedRecipe = jsonManagerRecipe.LoadItems().Find(recipe =>
                        recipe.FirstItem == firstItem &&
                        (string.IsNullOrEmpty(recipe.SecondItem) || recipe.SecondItem == secondItem) &&
                        recipe.Result == result);

                    if (selectedRecipe != null)
                    {
                        updateControlsForSelectedRecipe(selectedRecipe);

                        if (!string.IsNullOrEmpty(secondItem))
                        {
                            recipes_tb_secondItem.Text = secondItem;
                        }
                    }
                }
            }
        }




        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(items_tb_name.Text) && items_cb_texture.SelectedItem != null && !string.IsNullOrEmpty(items_tb_description.Text))
            {
                string name = items_tb_name.Text;
                string texture = items_cb_texture.SelectedItem.ToString();
                string description = items_tb_description.Text;
                int stack_size = Decimal.ToInt32(items_nb_stacksize.Value);
                int flag = FlagsValue.parse(items_chb_unplacable.Checked, items_chb_understructable.Checked, items_chb_plantable.Checked, items_chb_ununlockable.Checked, items_chb_compostable.Checked, items_chb_eatable.Checked, items_chb_sound_wooden.Checked, items_chb_sound_organic.Checked, items_chb_collidable.Checked, items_chb_grow_at_night.Checked, items_chb_entitable.Checked, items_chb_outlinable.Checked);

                string grown_id = items_tb_grow_id.Text;
                float growing_time = (float)items_nb_growing_time.Value;

                Item item;
                if (!string.IsNullOrEmpty(grown_id))
                {
                    item = new Item(name, texture, description, flag, stack_size, grown_id, growing_time);
                }
                else
                {
                    item = new Item(name, texture, description, flag, stack_size);
                }

                if (items_ListBox.SelectedItem != null)
                {
                    jsonManagerItem.UpdateItem(item, i => i.Name == items_ListBox.SelectedItem.ToString());
                }
                else
                {
                    jsonManagerItem.AddItem(item);
                }

                refresh_item_list();
            }
            else
            {
                MessageBox.Show("The form was not completed correctly.");
            }
        }

        private void btn_addDrop_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(drops_tb_fromID.Text) && !string.IsNullOrEmpty(drops_tb_dropID.Text))
            {
                string fromId = drops_tb_fromID.Text;
                string dropId = drops_tb_dropID.Text;
                int maxCount = Decimal.ToInt32(drops_nb_maxCount.Value);
                float probability = (float)drops_nb_probability.Value;

                Drop drop = new Drop(fromId, dropId, maxCount, probability);

                if (drops_ListBox.SelectedItem != null)
                {
                    jsonManagerDrop.UpdateItem(drop, d => d.FromId == drops_ListBox.SelectedItem.ToString().Split(new string[] { " -> " }, StringSplitOptions.None)[0]);
                }
                else
                {
                    jsonManagerDrop.AddItem(drop);
                }

                refresh_drop_list();
            }
            else
            {
                MessageBox.Show("The form was not completed correctly.");
            }
        }

        private void btn_addRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(recipes_tb_firstItem.Text) && !string.IsNullOrEmpty(recipes_tb_result.Text))
            {
                string firstItem = recipes_tb_firstItem.Text;
                int firstItemCount = Decimal.ToInt32(recipes_nb_firstItemCount.Value);
                string result = recipes_tb_result.Text;
                int resultCount = Decimal.ToInt32(recipes_nb_resultCount.Value);

                Recipe recipe;
                if (!string.IsNullOrEmpty(recipes_tb_secondItem.Text))
                {
                    string secondItem = recipes_tb_secondItem.Text;
                    int secondItemCount = Decimal.ToInt32(recipes_nb_secondItemCount.Value);
                    recipe = new Recipe(firstItem, firstItemCount, secondItem, secondItemCount, result, resultCount);
                }
                else
                {
                    recipe = new Recipe(firstItem, firstItemCount, result, resultCount);
                }

                if (recipes_ListBox.SelectedItem != null)
                {
                    jsonManagerRecipe.UpdateItem(recipe, r => r.FirstItem == recipes_ListBox.SelectedItem.ToString().Split(new string[] { " + " }, StringSplitOptions.None)[0]);
                }
                else
                {
                    jsonManagerRecipe.AddItem(recipe);
                }

                refresh_recipe_list();
            }
            else
            {
                MessageBox.Show("The form was not completed correctly.");
            }
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            var data = new
            {
                name = config_tb_name.Text
            };

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(Path.Combine(tb_loc.Text, currentMod.name, "config.json"), json);
        }

        private void tb_loc_TextChanged(object sender, EventArgs e)
        {
            var data = new
            {
                location = tb_loc.Text
            };

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "farmcoz", "MoodTool.json"), json);
            refreshModList();
        }
    }
}
