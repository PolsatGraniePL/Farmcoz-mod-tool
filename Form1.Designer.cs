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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            textBox1 = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            treeViewModList.Size = new Size(263, 397);
            treeViewModList.TabIndex = 1;
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
            tb_loc.Location = new Point(129, 12);
            tb_loc.Name = "tb_loc";
            tb_loc.PlaceholderText = "Mods folder location";
            tb_loc.Size = new Size(659, 23);
            tb_loc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 4;
            label1.Text = "Lokalizacja modów:";
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
            tabControl1.Size = new Size(507, 426);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(499, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "config.json";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(499, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "items.json";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(499, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "drops.json";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(499, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "recipes.json";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(499, 398);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Images";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 23);
            textBox1.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
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
    }
}
