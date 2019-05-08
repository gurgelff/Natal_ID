using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Configuration;


using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoPulseira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // AcessoBD.bd_senha();    
            //MDI formMDI = new MDI();
            //formMDI.Show();    

            Usuario us = new Usuario();
            if (us.Autenticar(textBox1.Text, textBox2.Text) == 1)
            {



                if (radioButton1.Checked)
                {
                    Empresarial emp = new Empresarial();
                    //  emp.MdiParent = this;
                    emp.Show();

                }
                if (radioButton2.Checked)
                {
                    Financeiro fin = new Financeiro();
                    // fin.MdiParent = this;
                    fin.Show();
                }
                if (radioButtonConsultarDadosDependente.Checked)
                {
                    Dependente dep = new Dependente();
                    //   dep.MdiParent = this;
                    dep.Show();
                }
                if (radioButtonConsultarDadosPessoais.Checked)
                {
                    DadosPessoais pes = new DadosPessoais();
                    //   pes.MdiParent = this;
                    pes.Show();
                }

                if (radioButtonRealizarCadastroDependente.Checked)
                {
                    CadDep dep = new CadDep();
                    //   pes.MdiParent = this;
                    dep.Show();
                }

            }
            else {
                MessageBox.Show("Usuário ou Senha Incorretos");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SA sa = new SA();
            sa.Show();
        }

       
    }
}
