using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHMSP21_2
{
    public partial class Form1 : Form
    {
        private FormToolBox frm;
        public Form1()
        {
            InitializeComponent();
        }

        private void sSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new FormToolBox();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
    }
}
