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
    public partial class DadosPessoais : Form
    {
        public DadosPessoais()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.natalidDataSet3);

        }

        private void DadosPessoais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSet3.Empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.natalidDataSet3.Empresa);
            // TODO: This line of code loads data into the 'natalidDataSet3.Responsavel' table. You can move, or remove it, as needed.
            this.responsavelTableAdapter.Fill(this.natalidDataSet3.Responsavel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fisicaconsulta2 fc = new fisicaconsulta2();
               // fc.MdiParent = this;
                fc.Show();
            }
            if (radioButton2.Checked)
            {
                juridicaconsultacs jc = new juridicaconsultacs();
               // jc.MdiParent = this;
                jc.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
