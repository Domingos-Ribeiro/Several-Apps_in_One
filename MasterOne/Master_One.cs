using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterOne
{
    public partial class Master_One : Form
    {
        public Master_One()
        {
            InitializeComponent();
        }

        private void app1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            App1 App_One = new App1();
            App_One.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void app3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            App3 App_Tree = new App3();
            App_Tree.ShowDialog();
        }

        private void app2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            App2 App_Two = new App2();
            App_Two.ShowDialog();
        }
    }
}
