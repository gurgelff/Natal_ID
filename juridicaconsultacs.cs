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
    public partial class juridicaconsultacs : Form
    {
        public juridicaconsultacs()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.natalidDataSet3);

        }

        private void juridicaconsultacs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSet3.Empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.natalidDataSet3.Empresa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AcessoBD.BD_juridico(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
