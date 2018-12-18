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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to get all information about my Program  then please look at TreeView");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] altPapkalar = Directory.GetDirectories("D:\\");
            treeView2.Nodes.Add("D:\\");
            TreeNode ana1 = treeView2.Nodes[0];
            foreach (string altPapka in altPapkalar)
            {
                TreeNode alt = new TreeNode(altPapka);
                ana1.Nodes.Add(alt);
            }
            string[] altpapkalar = Directory.GetDirectories("C:\\");
            treeView2.Nodes.Add("C:\\");
            TreeNode ana2 = treeView2.Nodes[1];
            foreach (string altpapka2 in altPapkalar)
            {
                TreeNode alt2 = new TreeNode(altpapka2);
                ana2.Nodes.Add(alt2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) ;
            this.Font = fontDialog1.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                treeView1.BackColor = colorDialog1.Color;
                treeView2.BackColor = colorDialog1.Color;
            }       
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
