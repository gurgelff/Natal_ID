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
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
        }

        private void Financeiro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSet4.Responsavel' table. You can move, or remove it, as needed.
            this.responsavelTableAdapter.Fill(this.natalidDataSet4.Responsavel);

            if(bindingNavigatorPositionItem.Text=="0"){
                bindingNavigatorAddNewItem.PerformClick();
            }

        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.natalidDataSet4);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
