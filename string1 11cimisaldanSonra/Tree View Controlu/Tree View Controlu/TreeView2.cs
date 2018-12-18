using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tree_View_Controlu
{
    public partial class TreeView2 : Form
    {
        public TreeView2()
        {
            InitializeComponent();
        }

        private void TreeView2_Load(object sender, EventArgs e)
        {
            string[] altPapkalar = Directory.GetDirectories("D:\\");
            treeView1.Nodes.Add("D:\\");
            TreeNode ana = treeView1.Nodes[0];
            foreach (string altPapka in altPapkalar)
            {
                TreeNode alt = new TreeNode(altPapka);
                ana.Nodes.Add(alt);
            }


















            //string[] altPapkalar = Directory.GetDirectories("D:\\");
            //treeView1.Nodes.Add("D:\\");
            //TreeNode ana = treeView1.Nodes[0];
            //foreach (string papkaAdi in altPapkalar)
            //{
            //    TreeNode alt = new TreeNode(papkaAdi);
            //    ana.Nodes.Add(alt);
            //}
        }
    }
}
