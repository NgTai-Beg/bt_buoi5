using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " bitmap file|*.bmp|JPEG|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK )
            {
                Form2 form2 = new Form2(ofd.FileName);
                form2.MdiParent = this;
                form2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd / MM / yyyy HH:mm:ss");
        }
    }
}
