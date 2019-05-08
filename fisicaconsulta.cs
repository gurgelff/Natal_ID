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
    public partial class fisicaconsulta : Form
    {
        public fisicaconsulta()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.natalidDataSet3);

        }

        private void fisicaconsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'natalidDataSetOK.Responsavel' table. You can move, or remove it, as needed.
            this.responsavelTableAdapter2.Fill(this.natalidDataSetOK.Responsavel);
   
            // TODO: This line of code loads data into the 'natalidDataSet4.Responsavel' table. You can move, or remove it, as needed.
            this.responsavelTableAdapter1.Fill(this.natalidDataSet4.Responsavel);
            // TODO: This line of code loads data into the 'natalidDataSet4.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.natalidDataSet4.user);
            // TODO: This line of code loads data into the 'natalidDataSet3.Responsavel' table. You can move, or remove it, as needed.
            this.responsavelTableAdapter.Fill(this.natalidDataSet3.Responsavel);
          //  AcessoBD.bd_senha(,);

        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void responsavelBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
