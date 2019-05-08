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
    public partial class Dependente : Form
    {
        public Dependente()
        {
            InitializeComponent();
        }

        private void dependenteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dependenteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.natalidDataSet4);

        }

        private void dependenteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dependenteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.natalidDataSet4);

        }

        private void Dependente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSet4.Dependente' table. You can move, or remove it, as needed.
            this.dependenteTableAdapter.Fill(this.natalidDataSet4.Dependente);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                dataGridView1.DataSource = AcessoBD.BD_dep(textBox1.Text, textBox2.Text);
            }
            else {
                MessageBox.Show("Dados insuficientes!");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
