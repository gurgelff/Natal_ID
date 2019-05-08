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
    public partial class fisicaconsulta2 : Form
    {
        public fisicaconsulta2()
        {
            InitializeComponent();
        }


        private void fisicaconsulta2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSetOK.Responsavel' table. You can move, or remove it, as needed.
            this.responsavelTableAdapter.Fill(this.natalidDataSetOK.Responsavel);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AcessoBD.bd_senha(textBox1.Text, textBox2.Text);
            //listBox1.DataSource = AcessoBD.bd_senha(textBox1.Text, textBox2.Text);
            //listBox1.DisplayMember = "Responsavel.* ";
            //listBox1.ValueMember = "CodResponsavel";

            //listBox1.DataSource = AcessoBD.bd_senha(textBox1.Text, textBox2.Text);
            //listBox1.DisplayMember = "Responsavel.Rua ";
            //listBox1.ValueMember = "CodResponsavel";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
