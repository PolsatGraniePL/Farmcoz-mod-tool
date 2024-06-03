using System;
using System.Drawing.Printing;
using System.IO;
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
                refreshTree();
            }
            else
            {
                MessageBox.Show("Mod name and location cannot be empty");
            }
        }

        private void refreshTree()
        {
            string[] dirs = FileManager.getDirs(tb_loc.Text);
            treeViewModList.Nodes.Clear();
            foreach (string dir in dirs)
            {
                treeViewModList.Nodes.Add(Path.GetFileName(dir));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_loc.Text = FileManager.GetUserModsLocation();
            refreshTree();
        }

        private void treeViewModList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                selectMod(e.Node.Text);
            }
        }

        private void selectMod(string name)
        {
            this.Text = "Farmcoz mod tool - " + name;
        }

        private void treeViewModList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            refreshTree();
        }
    }
}
