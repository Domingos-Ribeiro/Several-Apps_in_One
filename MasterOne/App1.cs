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
    public partial class App1 : Form
    {
        public App1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master_One master = new Master_One();
            master.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pic_Happy.Visible = true;
            pic_Sad.Visible = false;
        }

        private void rdb_Sad_CheckedChanged(object sender, EventArgs e)
        {
            pic_Happy.Visible = false;
            pic_Sad.Visible = true;
        }

        private void rdb_None_CheckedChanged(object sender, EventArgs e)
        {
            pic_Happy.Visible = false;
            pic_Sad.Visible = false;
        }
    }
}
