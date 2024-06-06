using Farmcoz_mod_tool.component;

namespace Farmcoz_mod_tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_CreateMod = new Button();
            tb_ModName = new TextBox();
            tb_loc = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            config_btn = new Button();
            label2 = new Label();
            config_tb_name = new TextBox();
            tabPage2 = new TabPage();
            items_btn_new = new Button();
            groupBox2 = new GroupBox();
            items_nb_growing_time = new NumericUpDown();
            label9 = new Label();
            items_tb_grow_id = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            items_chb_sound_wooden = new CheckBox();
            items_chb_outlinable = new CheckBox();
            items_chb_entitable = new CheckBox();
            items_chb_grow_at_night = new CheckBox();
            items_chb_collidable = new CheckBox();
            items_chb_sound_organic = new CheckBox();
            items_chb_eatable = new CheckBox();
            items_chb_compostable = new CheckBox();
            items_chb_ununlockable = new CheckBox();
            items_chb_plantable = new CheckBox();
            items_chb_understructable = new CheckBox();
            items_chb_unplacable = new CheckBox();
            items_nb_stacksize = new NumericUpDown();
            items_tb_description = new TextBox();
            items_cb_texture = new ComboBox();
            items_tb_name = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            items_ListBox = new ListBox();
            btn_addItem = new Button();
            tabPage3 = new TabPage();
            drops_btn_new = new Button();
            btn_addDrop = new Button();
            groupBox3 = new GroupBox();
            drops_nb_maxCount = new NumericUpDown();
            drops_nb_probability = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            drops_tb_dropID = new TextBox();
            label11 = new Label();
            drops_tb_fromID = new TextBox();
            label10 = new Label();
            drops_ListBox = new ListBox();
            tabPage4 = new TabPage();
            recipes_btn_new = new Button();
            groupBox5 = new GroupBox();
            label18 = new Label();
            recipes_tb_secondItem = new TextBox();
            recipes_nb_secondItemCount = new NumericUpDown();
            label19 = new Label();
            btn_addRecipe = new Button();
            groupBox4 = new GroupBox();
            label17 = new Label();
            recipes_nb_resultCount = new NumericUpDown();
            recipes_tb_result = new TextBox();
            label16 = new Label();
            label15 = new Label();
            recipes_nb_firstItemCount = new NumericUpDown();
            recipes_tb_firstItem = new TextBox();
            label14 = new Label();
            recipes_ListBox = new ListBox();
            tabPage5 = new TabPage();
            label20 = new Label();
            btn_addImage = new Button();
            pictureBox = new PixelBox();
            images_ListBox = new ListBox();
            lb_modList = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)items_nb_growing_time).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)items_nb_stacksize).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drops_nb_maxCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drops_nb_probability).BeginInit();
            tabPage4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipes_nb_secondItemCount).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipes_nb_resultCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipes_nb_firstItemCount).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btn_CreateMod
            // 
            btn_CreateMod.Location = new Point(12, 45);
            btn_CreateMod.Name = "btn_CreateMod";
            btn_CreateMod.Size = new Size(171, 23);
            btn_CreateMod.TabIndex = 0;
            btn_CreateMod.Text = "Create mod";
            btn_CreateMod.UseVisualStyleBackColor = true;
            btn_CreateMod.Click += btn_CreateMod_Click;
            // 
            // tb_ModName
            // 
            tb_ModName.Location = new Point(12, 74);
            tb_ModName.Name = "tb_ModName";
            tb_ModName.PlaceholderText = "Mod name";
            tb_ModName.Size = new Size(171, 23);
            tb_ModName.TabIndex = 2;
            // 
            // tb_loc
            // 
            tb_loc.Location = new Point(104, 12);
            tb_loc.Name = "tb_loc";
            tb_loc.PlaceholderText = "Mods folder location";
            tb_loc.Size = new Size(595, 23);
            tb_loc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Mods location:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(189, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(514, 483);
            tabControl1.TabIndex = 5;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(config_btn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(config_tb_name);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(506, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "config.json";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // config_btn
            // 
            config_btn.Location = new Point(6, 6);
            config_btn.Name = "config_btn";
            config_btn.Size = new Size(494, 23);
            config_btn.TabIndex = 2;
            config_btn.Text = "Save";
            config_btn.UseVisualStyleBackColor = true;
            config_btn.Click += config_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Mod name:";
            // 
            // config_tb_name
            // 
            config_tb_name.Location = new Point(80, 35);
            config_tb_name.Name = "config_tb_name";
            config_tb_name.Size = new Size(420, 23);
            config_tb_name.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(items_btn_new);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(items_ListBox);
            tabPage2.Controls.Add(btn_addItem);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(506, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "items.json";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // items_btn_new
            // 
            items_btn_new.Location = new Point(6, 5);
            items_btn_new.Name = "items_btn_new";
            items_btn_new.Size = new Size(149, 23);
            items_btn_new.TabIndex = 10;
            items_btn_new.Text = "New item";
            items_btn_new.UseVisualStyleBackColor = true;
            items_btn_new.Click += items_btn_new_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(items_nb_growing_time);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(items_tb_grow_id);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(161, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 87);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grow";
            // 
            // items_nb_growing_time
            // 
            items_nb_growing_time.DecimalPlaces = 1;
            items_nb_growing_time.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            items_nb_growing_time.Location = new Point(94, 52);
            items_nb_growing_time.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            items_nb_growing_time.Name = "items_nb_growing_time";
            items_nb_growing_time.Size = new Size(232, 23);
            items_nb_growing_time.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 54);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 11;
            label9.Text = "Growing time:";
            // 
            // items_tb_grow_id
            // 
            items_tb_grow_id.Location = new Point(70, 22);
            items_tb_grow_id.MaxLength = 255;
            items_tb_grow_id.Name = "items_tb_grow_id";
            items_tb_grow_id.Size = new Size(256, 23);
            items_tb_grow_id.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 25);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 9;
            label8.Text = "Grown id:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(items_chb_sound_wooden);
            groupBox1.Controls.Add(items_chb_outlinable);
            groupBox1.Controls.Add(items_chb_entitable);
            groupBox1.Controls.Add(items_chb_grow_at_night);
            groupBox1.Controls.Add(items_chb_collidable);
            groupBox1.Controls.Add(items_chb_sound_organic);
            groupBox1.Controls.Add(items_chb_eatable);
            groupBox1.Controls.Add(items_chb_compostable);
            groupBox1.Controls.Add(items_chb_ununlockable);
            groupBox1.Controls.Add(items_chb_plantable);
            groupBox1.Controls.Add(items_chb_understructable);
            groupBox1.Controls.Add(items_chb_unplacable);
            groupBox1.Controls.Add(items_nb_stacksize);
            groupBox1.Controls.Add(items_tb_description);
            groupBox1.Controls.Add(items_cb_texture);
            groupBox1.Controls.Add(items_tb_name);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(161, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 306);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Default";
            // 
            // items_chb_sound_wooden
            // 
            items_chb_sound_wooden.AutoSize = true;
            items_chb_sound_wooden.Location = new Point(182, 154);
            items_chb_sound_wooden.Name = "items_chb_sound_wooden";
            items_chb_sound_wooden.Size = new Size(105, 19);
            items_chb_sound_wooden.TabIndex = 22;
            items_chb_sound_wooden.Text = "sound wooden";
            items_chb_sound_wooden.UseVisualStyleBackColor = true;
            // 
            // items_chb_outlinable
            // 
            items_chb_outlinable.AutoSize = true;
            items_chb_outlinable.Location = new Point(182, 279);
            items_chb_outlinable.Name = "items_chb_outlinable";
            items_chb_outlinable.Size = new Size(79, 19);
            items_chb_outlinable.TabIndex = 21;
            items_chb_outlinable.Text = "outlinable";
            items_chb_outlinable.UseVisualStyleBackColor = true;
            // 
            // items_chb_entitable
            // 
            items_chb_entitable.AutoSize = true;
            items_chb_entitable.Location = new Point(182, 254);
            items_chb_entitable.Name = "items_chb_entitable";
            items_chb_entitable.Size = new Size(72, 19);
            items_chb_entitable.TabIndex = 20;
            items_chb_entitable.Text = "entitable";
            items_chb_entitable.UseVisualStyleBackColor = true;
            // 
            // items_chb_grow_at_night
            // 
            items_chb_grow_at_night.AutoSize = true;
            items_chb_grow_at_night.Location = new Point(182, 229);
            items_chb_grow_at_night.Name = "items_chb_grow_at_night";
            items_chb_grow_at_night.Size = new Size(97, 19);
            items_chb_grow_at_night.TabIndex = 19;
            items_chb_grow_at_night.Text = "grow at night";
            items_chb_grow_at_night.UseVisualStyleBackColor = true;
            // 
            // items_chb_collidable
            // 
            items_chb_collidable.AutoSize = true;
            items_chb_collidable.Location = new Point(182, 204);
            items_chb_collidable.Name = "items_chb_collidable";
            items_chb_collidable.Size = new Size(77, 19);
            items_chb_collidable.TabIndex = 18;
            items_chb_collidable.Text = "collidable";
            items_chb_collidable.UseVisualStyleBackColor = true;
            // 
            // items_chb_sound_organic
            // 
            items_chb_sound_organic.AutoSize = true;
            items_chb_sound_organic.Location = new Point(182, 179);
            items_chb_sound_organic.Name = "items_chb_sound_organic";
            items_chb_sound_organic.Size = new Size(102, 19);
            items_chb_sound_organic.TabIndex = 17;
            items_chb_sound_organic.Text = "sound organic";
            items_chb_sound_organic.UseVisualStyleBackColor = true;
            // 
            // items_chb_eatable
            // 
            items_chb_eatable.AutoSize = true;
            items_chb_eatable.Location = new Point(54, 279);
            items_chb_eatable.Name = "items_chb_eatable";
            items_chb_eatable.Size = new Size(64, 19);
            items_chb_eatable.TabIndex = 16;
            items_chb_eatable.Text = "eatable";
            items_chb_eatable.UseVisualStyleBackColor = true;
            // 
            // items_chb_compostable
            // 
            items_chb_compostable.AutoSize = true;
            items_chb_compostable.Location = new Point(54, 254);
            items_chb_compostable.Name = "items_chb_compostable";
            items_chb_compostable.Size = new Size(95, 19);
            items_chb_compostable.TabIndex = 15;
            items_chb_compostable.Text = "compostable";
            items_chb_compostable.UseVisualStyleBackColor = true;
            // 
            // items_chb_ununlockable
            // 
            items_chb_ununlockable.AutoSize = true;
            items_chb_ununlockable.Location = new Point(54, 229);
            items_chb_ununlockable.Name = "items_chb_ununlockable";
            items_chb_ununlockable.Size = new Size(98, 19);
            items_chb_ununlockable.TabIndex = 14;
            items_chb_ununlockable.Text = "ununlockable";
            items_chb_ununlockable.UseVisualStyleBackColor = true;
            // 
            // items_chb_plantable
            // 
            items_chb_plantable.AutoSize = true;
            items_chb_plantable.Location = new Point(54, 204);
            items_chb_plantable.Name = "items_chb_plantable";
            items_chb_plantable.Size = new Size(75, 19);
            items_chb_plantable.TabIndex = 13;
            items_chb_plantable.Text = "plantable";
            items_chb_plantable.UseVisualStyleBackColor = true;
            // 
            // items_chb_understructable
            // 
            items_chb_understructable.AutoSize = true;
            items_chb_understructable.Location = new Point(54, 179);
            items_chb_understructable.Name = "items_chb_understructable";
            items_chb_understructable.Size = new Size(109, 19);
            items_chb_understructable.TabIndex = 12;
            items_chb_understructable.Text = "understructable";
            items_chb_understructable.UseVisualStyleBackColor = true;
            // 
            // items_chb_unplacable
            // 
            items_chb_unplacable.AutoSize = true;
            items_chb_unplacable.Location = new Point(54, 154);
            items_chb_unplacable.Name = "items_chb_unplacable";
            items_chb_unplacable.Size = new Size(84, 19);
            items_chb_unplacable.TabIndex = 11;
            items_chb_unplacable.Text = "unplacable";
            items_chb_unplacable.UseVisualStyleBackColor = true;
            // 
            // items_nb_stacksize
            // 
            items_nb_stacksize.Location = new Point(72, 110);
            items_nb_stacksize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            items_nb_stacksize.Name = "items_nb_stacksize";
            items_nb_stacksize.Size = new Size(254, 23);
            items_nb_stacksize.TabIndex = 10;
            items_nb_stacksize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // items_tb_description
            // 
            items_tb_description.Location = new Point(82, 81);
            items_tb_description.Name = "items_tb_description";
            items_tb_description.Size = new Size(244, 23);
            items_tb_description.TabIndex = 9;
            // 
            // items_cb_texture
            // 
            items_cb_texture.DropDownStyle = ComboBoxStyle.DropDownList;
            items_cb_texture.FormattingEnabled = true;
            items_cb_texture.Location = new Point(60, 51);
            items_cb_texture.Name = "items_cb_texture";
            items_cb_texture.Size = new Size(266, 23);
            items_cb_texture.TabIndex = 8;
            // 
            // items_tb_name
            // 
            items_tb_name.Location = new Point(54, 22);
            items_tb_name.MaxLength = 255;
            items_tb_name.Name = "items_tb_name";
            items_tb_name.Size = new Size(272, 23);
            items_tb_name.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 112);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 7;
            label7.Text = "Stack size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 140);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 6;
            label6.Text = "Flags:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Texture:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 84);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "Description:";
            // 
            // items_ListBox
            // 
            items_ListBox.FormattingEnabled = true;
            items_ListBox.ItemHeight = 15;
            items_ListBox.Location = new Point(6, 36);
            items_ListBox.Name = "items_ListBox";
            items_ListBox.Size = new Size(149, 409);
            items_ListBox.TabIndex = 1;
            items_ListBox.SelectedIndexChanged += items_ListBox_SelectedIndexChanged;
            // 
            // btn_addItem
            // 
            btn_addItem.Location = new Point(161, 413);
            btn_addItem.Name = "btn_addItem";
            btn_addItem.Size = new Size(332, 34);
            btn_addItem.TabIndex = 0;
            btn_addItem.Text = "Add item";
            btn_addItem.UseVisualStyleBackColor = true;
            btn_addItem.Click += btn_addItem_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(drops_btn_new);
            tabPage3.Controls.Add(btn_addDrop);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(drops_ListBox);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(506, 455);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "drops.json";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // drops_btn_new
            // 
            drops_btn_new.Location = new Point(6, 5);
            drops_btn_new.Name = "drops_btn_new";
            drops_btn_new.Size = new Size(149, 23);
            drops_btn_new.TabIndex = 3;
            drops_btn_new.Text = "New drop";
            drops_btn_new.UseVisualStyleBackColor = true;
            drops_btn_new.Click += drops_btn_new_Click;
            // 
            // btn_addDrop
            // 
            btn_addDrop.Location = new Point(161, 411);
            btn_addDrop.Name = "btn_addDrop";
            btn_addDrop.Size = new Size(332, 34);
            btn_addDrop.TabIndex = 2;
            btn_addDrop.Text = "Add drop";
            btn_addDrop.UseVisualStyleBackColor = true;
            btn_addDrop.Click += btn_addDrop_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(drops_nb_maxCount);
            groupBox3.Controls.Add(drops_nb_probability);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(drops_tb_dropID);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(drops_tb_fromID);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(161, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(332, 399);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Default";
            // 
            // drops_nb_maxCount
            // 
            drops_nb_maxCount.Location = new Point(79, 80);
            drops_nb_maxCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            drops_nb_maxCount.Name = "drops_nb_maxCount";
            drops_nb_maxCount.Size = new Size(247, 23);
            drops_nb_maxCount.TabIndex = 8;
            drops_nb_maxCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // drops_nb_probability
            // 
            drops_nb_probability.DecimalPlaces = 1;
            drops_nb_probability.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            drops_nb_probability.Location = new Point(79, 110);
            drops_nb_probability.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            drops_nb_probability.Name = "drops_nb_probability";
            drops_nb_probability.Size = new Size(247, 23);
            drops_nb_probability.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 112);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 6;
            label13.Text = "Probability:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 83);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 4;
            label12.Text = "Max count:";
            // 
            // drops_tb_dropID
            // 
            drops_tb_dropID.Location = new Point(63, 51);
            drops_tb_dropID.MaxLength = 255;
            drops_tb_dropID.Name = "drops_tb_dropID";
            drops_tb_dropID.Size = new Size(263, 23);
            drops_tb_dropID.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 54);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 2;
            label11.Text = "Drop id:";
            // 
            // drops_tb_fromID
            // 
            drops_tb_fromID.Location = new Point(63, 22);
            drops_tb_fromID.MaxLength = 255;
            drops_tb_fromID.Name = "drops_tb_fromID";
            drops_tb_fromID.Size = new Size(263, 23);
            drops_tb_fromID.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 25);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 0;
            label10.Text = "From id:";
            // 
            // drops_ListBox
            // 
            drops_ListBox.FormattingEnabled = true;
            drops_ListBox.ItemHeight = 15;
            drops_ListBox.Location = new Point(6, 36);
            drops_ListBox.Name = "drops_ListBox";
            drops_ListBox.Size = new Size(149, 409);
            drops_ListBox.TabIndex = 0;
            drops_ListBox.SelectedIndexChanged += drops_ListBox_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(recipes_btn_new);
            tabPage4.Controls.Add(groupBox5);
            tabPage4.Controls.Add(btn_addRecipe);
            tabPage4.Controls.Add(groupBox4);
            tabPage4.Controls.Add(recipes_ListBox);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(506, 455);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "recipes.json";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // recipes_btn_new
            // 
            recipes_btn_new.Location = new Point(6, 5);
            recipes_btn_new.Name = "recipes_btn_new";
            recipes_btn_new.Size = new Size(149, 23);
            recipes_btn_new.TabIndex = 4;
            recipes_btn_new.Text = "New recipe";
            recipes_btn_new.UseVisualStyleBackColor = true;
            recipes_btn_new.Click += recipes_btn_new_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(recipes_tb_secondItem);
            groupBox5.Controls.Add(recipes_nb_secondItemCount);
            groupBox5.Controls.Add(label19);
            groupBox5.Location = new Point(161, 191);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(332, 214);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Second slot";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 53);
            label18.Name = "label18";
            label18.Size = new Size(110, 15);
            label18.TabIndex = 11;
            label18.Text = "Second item count:";
            // 
            // recipes_tb_secondItem
            // 
            recipes_tb_secondItem.Location = new Point(88, 22);
            recipes_tb_secondItem.MaxLength = 255;
            recipes_tb_secondItem.Name = "recipes_tb_secondItem";
            recipes_tb_secondItem.Size = new Size(238, 23);
            recipes_tb_secondItem.TabIndex = 9;
            // 
            // recipes_nb_secondItemCount
            // 
            recipes_nb_secondItemCount.Location = new Point(122, 51);
            recipes_nb_secondItemCount.Name = "recipes_nb_secondItemCount";
            recipes_nb_secondItemCount.Size = new Size(204, 23);
            recipes_nb_secondItemCount.TabIndex = 10;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 25);
            label19.Name = "label19";
            label19.Size = new Size(76, 15);
            label19.TabIndex = 8;
            label19.Text = "Second item:";
            // 
            // btn_addRecipe
            // 
            btn_addRecipe.Location = new Point(161, 411);
            btn_addRecipe.Name = "btn_addRecipe";
            btn_addRecipe.Size = new Size(332, 34);
            btn_addRecipe.TabIndex = 2;
            btn_addRecipe.Text = "Add recipe";
            btn_addRecipe.UseVisualStyleBackColor = true;
            btn_addRecipe.Click += btn_addRecipe_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(recipes_nb_resultCount);
            groupBox4.Controls.Add(recipes_tb_result);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(recipes_nb_firstItemCount);
            groupBox4.Controls.Add(recipes_tb_firstItem);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(161, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(332, 179);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Default";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 111);
            label17.Name = "label17";
            label17.Size = new Size(76, 15);
            label17.TabIndex = 7;
            label17.Text = "Result count:";
            // 
            // recipes_nb_resultCount
            // 
            recipes_nb_resultCount.Location = new Point(88, 109);
            recipes_nb_resultCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recipes_nb_resultCount.Name = "recipes_nb_resultCount";
            recipes_nb_resultCount.Size = new Size(238, 23);
            recipes_nb_resultCount.TabIndex = 6;
            recipes_nb_resultCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // recipes_tb_result
            // 
            recipes_tb_result.Location = new Point(54, 80);
            recipes_tb_result.MaxLength = 255;
            recipes_tb_result.Name = "recipes_tb_result";
            recipes_tb_result.Size = new Size(272, 23);
            recipes_tb_result.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 83);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 4;
            label16.Text = "Result:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 53);
            label15.Name = "label15";
            label15.Size = new Size(93, 15);
            label15.TabIndex = 3;
            label15.Text = "First item count:";
            // 
            // recipes_nb_firstItemCount
            // 
            recipes_nb_firstItemCount.Location = new Point(105, 51);
            recipes_nb_firstItemCount.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            recipes_nb_firstItemCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            recipes_nb_firstItemCount.Name = "recipes_nb_firstItemCount";
            recipes_nb_firstItemCount.Size = new Size(221, 23);
            recipes_nb_firstItemCount.TabIndex = 2;
            recipes_nb_firstItemCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // recipes_tb_firstItem
            // 
            recipes_tb_firstItem.Location = new Point(71, 22);
            recipes_tb_firstItem.MaxLength = 255;
            recipes_tb_firstItem.Name = "recipes_tb_firstItem";
            recipes_tb_firstItem.Size = new Size(255, 23);
            recipes_tb_firstItem.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 25);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 0;
            label14.Text = "First item:";
            // 
            // recipes_ListBox
            // 
            recipes_ListBox.FormattingEnabled = true;
            recipes_ListBox.ItemHeight = 15;
            recipes_ListBox.Location = new Point(6, 36);
            recipes_ListBox.Name = "recipes_ListBox";
            recipes_ListBox.Size = new Size(149, 409);
            recipes_ListBox.TabIndex = 0;
            recipes_ListBox.SelectedIndexChanged += recipes_ListBox_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(btn_addImage);
            tabPage5.Controls.Add(pictureBox);
            tabPage5.Controls.Add(images_ListBox);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(506, 455);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Images";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label20.Location = new Point(166, 101);
            label20.Name = "label20";
            label20.Size = new Size(98, 21);
            label20.TabIndex = 4;
            label20.Text = "Select image";
            // 
            // btn_addImage
            // 
            btn_addImage.Location = new Point(166, 6);
            btn_addImage.Name = "btn_addImage";
            btn_addImage.Size = new Size(320, 40);
            btn_addImage.TabIndex = 2;
            btn_addImage.Text = "Add image";
            btn_addImage.UseVisualStyleBackColor = true;
            btn_addImage.Click += btn_addImage_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Gray;
            pictureBox.Location = new Point(166, 125);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(320, 320);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // images_ListBox
            // 
            images_ListBox.FormattingEnabled = true;
            images_ListBox.ItemHeight = 15;
            images_ListBox.Location = new Point(6, 6);
            images_ListBox.Name = "images_ListBox";
            images_ListBox.Size = new Size(154, 439);
            images_ListBox.TabIndex = 0;
            images_ListBox.SelectedIndexChanged += images_ListBox_SelectedIndexChanged;
            // 
            // lb_modList
            // 
            lb_modList.FormattingEnabled = true;
            lb_modList.ItemHeight = 15;
            lb_modList.Location = new Point(12, 104);
            lb_modList.Name = "lb_modList";
            lb_modList.Size = new Size(171, 424);
            lb_modList.TabIndex = 6;
            lb_modList.SelectedIndexChanged += lb_modList_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 540);
            Controls.Add(lb_modList);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(tb_loc);
            Controls.Add(tb_ModName);
            Controls.Add(btn_CreateMod);
            Name = "Form1";
            Text = "Farmcoz mod tool - SELECT MOD";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)items_nb_growing_time).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)items_nb_stacksize).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drops_nb_maxCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)drops_nb_probability).EndInit();
            tabPage4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipes_nb_secondItemCount).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipes_nb_resultCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipes_nb_firstItemCount).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CreateMod;
        private TextBox tb_ModName;
        private TextBox tb_loc;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private TextBox config_tb_name;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button btn_addItem;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox items_tb_name;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private ListBox items_ListBox;
        private Label label9;
        private TextBox items_tb_grow_id;
        private Label label8;
        private NumericUpDown items_nb_stacksize;
        private TextBox items_tb_description;
        private ComboBox items_cb_texture;
        private NumericUpDown items_nb_growing_time;
        private CheckBox items_chb_unplacable;
        private CheckBox items_chb_sound_wooden;
        private CheckBox items_chb_outlinable;
        private CheckBox items_chb_entitable;
        private CheckBox items_chb_grow_at_night;
        private CheckBox items_chb_collidable;
        private CheckBox items_chb_sound_organic;
        private CheckBox items_chb_eatable;
        private CheckBox items_chb_compostable;
        private CheckBox items_chb_ununlockable;
        private CheckBox items_chb_plantable;
        private CheckBox items_chb_understructable;
        private Button btn_addDrop;
        private GroupBox groupBox3;
        private TextBox drops_tb_fromID;
        private Label label10;
        private ListBox drops_ListBox;
        private NumericUpDown drops_nb_maxCount;
        private NumericUpDown drops_nb_probability;
        private Label label13;
        private Label label12;
        private TextBox drops_tb_dropID;
        private Label label11;
        private Button btn_addRecipe;
        private GroupBox groupBox4;
        private NumericUpDown recipes_nb_firstItemCount;
        private TextBox recipes_tb_firstItem;
        private Label label14;
        private ListBox recipes_ListBox;
        private GroupBox groupBox5;
        private Label label18;
        private TextBox recipes_tb_secondItem;
        private NumericUpDown recipes_nb_secondItemCount;
        private Label label19;
        private Label label17;
        private NumericUpDown recipes_nb_resultCount;
        private TextBox recipes_tb_result;
        private Label label16;
        private Label label15;
        private Button btn_addImage;
        private ListBox images_ListBox;
        private ListBox lb_modList;
        private Label label20;
        private OpenFileDialog openFileDialog1;
        private PixelBox pictureBox;
        private Button items_btn_new;
        private Button drops_btn_new;
        private Button recipes_btn_new;
        private Button config_btn;
    }
}
