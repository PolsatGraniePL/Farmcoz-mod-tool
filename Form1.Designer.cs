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
            // 
            // tb_ModName
            // 
            tb_ModName.Location = new Point(120, 45);
            tb_ModName.Name = "tb_ModName";
            tb_ModName.Size = new Size(155, 23);
            tb_ModName.TabIndex = 2;
            // 
            // tb_loc
            // 
            tb_loc.Location = new Point(129, 12);
            tb_loc.Name = "tb_loc";
            tb_loc.Size = new Size(659, 23);
            tb_loc.TabIndex = 3;
            tb_loc.Text = "C:\\Users\\kksia\\AppData\\Roaming\\farmcoz\\mods";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 483);
            Controls.Add(label1);
            Controls.Add(tb_loc);
            Controls.Add(tb_ModName);
            Controls.Add(treeViewModList);
            Controls.Add(btn_CreateMod);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CreateMod;
        private TreeView treeViewModList;
        private TextBox tb_ModName;
        private TextBox tb_loc;
        private Label label1;
    }
}
