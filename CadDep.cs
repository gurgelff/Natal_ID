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
    public partial class CadDep : Form
    {
        public CadDep()
        {
            InitializeComponent();
        }

        private void dependenteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (codDependenteTextBox.Text != "" && codResponsavelTextBox.Text != "" && nomeDependenteTextBox.Text!="")
            {
                this.Validate();
                this.dependenteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.natalidDataSetOK);
            }
            else {
                MessageBox.Show("Dados Insuficientes");
            }

        }

        private void CadDep_Load(object sender, EventArgs e)
        {
            if(bindingNavigatorPositionItem.Text=="0"){
                bindingNavigatorAddNewItem.PerformClick();
            }
        }

        private void codDependenteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void codResponsavelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeDependenteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



