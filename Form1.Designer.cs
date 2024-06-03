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
            treeViewModList = new TreeView();
            tb_ModName = new TextBox();
            tb_loc = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            X = new ListBox();
            button1 = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btn_CreateMod
            // 
            btn_CreateMod.Location = new Point(12, 45);
            btn_CreateMod.Name = "btn_CreateMod";
            btn_CreateMod.Size = new Size(102, 23);
            btn_CreateMod.TabIndex = 0;
            btn_CreateMod.Text = "Create mod";
            btn_CreateMod.UseVisualStyleBackColor = true;
            btn_CreateMod.Click += btn_CreateMod_Click;
            // 
            // treeViewModList
            // 
            treeViewModList.Location = new Point(12, 74);
            treeViewModList.Name = "treeViewModList";
            treeViewModList.Size = new Size(263, 454);
            treeViewModList.TabIndex = 1;
            treeViewModList.AfterSelect += treeViewModList_AfterSelect;
            treeViewModList.NodeMouseClick += treeViewModList_NodeMouseClick;
            // 
            // tb_ModName
            // 
            tb_ModName.Location = new Point(120, 45);
            tb_ModName.Name = "tb_ModName";
            tb_ModName.PlaceholderText = "Mod name";
            tb_ModName.Size = new Size(155, 23);
            tb_ModName.TabIndex = 2;
            // 
            // tb_loc
            // 
            tb_loc.Location = new Point(104, 12);
            tb_loc.Name = "tb_loc";
            tb_loc.PlaceholderText = "Mods folder location";
            tb_loc.Size = new Size(684, 23);
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
            tabControl1.Location = new Point(281, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(507, 483);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(499, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "config.json";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(X);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(499, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "items.json";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(161, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 87);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grow";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(94, 52);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(232, 23);
            numericUpDown2.TabIndex = 11;
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
            // textBox3
            // 
            textBox3.Location = new Point(70, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 8;
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
            groupBox1.Controls.Add(checkBox12);
            groupBox1.Controls.Add(checkBox11);
            groupBox1.Controls.Add(checkBox10);
            groupBox1.Controls.Add(checkBox9);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
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
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(182, 154);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(105, 19);
            checkBox12.TabIndex = 22;
            checkBox12.Text = "sound wooden";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(182, 279);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(79, 19);
            checkBox11.TabIndex = 21;
            checkBox11.Text = "outlinable";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(182, 254);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(72, 19);
            checkBox10.TabIndex = 20;
            checkBox10.Text = "entitable";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(182, 229);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(97, 19);
            checkBox9.TabIndex = 19;
            checkBox9.Text = "grow at night";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(182, 204);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(77, 19);
            checkBox8.TabIndex = 18;
            checkBox8.Text = "collidable";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(182, 179);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(102, 19);
            checkBox7.TabIndex = 17;
            checkBox7.Text = "sound organic";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(54, 279);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(64, 19);
            checkBox6.TabIndex = 16;
            checkBox6.Text = "eatable";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(54, 254);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(95, 19);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "compostable";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(54, 229);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 19);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "ununlockable";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(54, 204);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(75, 19);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "plantable";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(54, 179);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(109, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "understructable";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(54, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "unplacable";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(72, 110);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(254, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(82, 81);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(244, 23);
            textBox5.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 23);
            comboBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 23);
            textBox2.TabIndex = 2;
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
            // X
            // 
            X.FormattingEnabled = true;
            X.ItemHeight = 15;
            X.Location = new Point(6, 8);
            X.Name = "X";
            X.Size = new Size(149, 439);
            X.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(161, 413);
            button1.Name = "button1";
            button1.Size = new Size(332, 34);
            button1.TabIndex = 0;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(499, 455);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "drops.json";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(499, 455);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "recipes.json";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(499, 455);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Images";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(tb_loc);
            Controls.Add(tb_ModName);
            Controls.Add(treeViewModList);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CreateMod;
        private TreeView treeViewModList;
        private TextBox tb_ModName;
        private TextBox tb_loc;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private ListBox X;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown2;
        private CheckBox checkBox1;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
    }
}
