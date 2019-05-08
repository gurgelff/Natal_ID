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
    public partial class Empresarial : Form
    {
        public Empresarial()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (codEmpresaTextBox.Text != "" && nomeEmpresaTextBox.Text != "" && (ativoTextBox.Text!="0" || ativoTextBox.Text!="1"))
                {
                    this.Validate();
                    this.empresaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.natalidDataSet3);

                }
                else
                {
                    MessageBox.Show("Dados Insuficientes ou errados");
                }
               
            }
            catch (InvalidCastException x)
            {
                throw x;    
            }
            finally
            {
               
            }

        }

        private void Empresarial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSet3.AluguelPagamento' table. You can move, or remove it, as needed.
            this.aluguelPagamentoTableAdapter.Fill(this.natalidDataSet3.AluguelPagamento);
            // TODO: This line of code loads data into the 'natalidDataSet3.Empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.natalidDataSet3.Empresa);

            if(bindingNavigatorPositionItem.Text=="0"){
                bindingNavigatorAddNewItem.PerformClick();
            }

        }

        private void ruaTextBox_MouseHover(object sender, EventArgs e)
        {
        }

        private void ruaTextBox_Click(object sender, EventArgs e)
        {
            ruaTextBox.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void ativoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
