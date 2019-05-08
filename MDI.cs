using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoPulseira
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dependente dep = new Dependente();
            dep.Show();
        }

       
    }
}
