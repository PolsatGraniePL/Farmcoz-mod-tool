using System;
using System.IO;
using System.Windows.Forms;

namespace Farmcoz_mod_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CreateMod_Click(object sender, EventArgs e)
        {
            string modName = tb_ModName.Text;
            string loc = tb_loc.Text;
            if (!string.IsNullOrEmpty(modName) && !string.IsNullOrEmpty(loc))
            {
                FileManager.createDir(loc, modName);
                tb_ModName.Text = null;
                refreshTree();
            }
            else
            {
                MessageBox.Show("Nazwa moda i lokalizacja nie mog¹ byæ puste");
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
            refreshTree();
        }
    }
}
