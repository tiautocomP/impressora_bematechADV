using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_Impressora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbreConexao_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbTipo.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione o Tipo");
                    cmbTipo.Focus();
                    return;
                }

                else if (cmbModelo.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione o Modelo");
                    cmbModelo.Focus();
                    return;
                }

                int retorno;
                retorno = E1_Impressora.AbreConexaoImpressora(cmbTipo.SelectedIndex, cmbModelo.Text, txtConexao.Text, int.Parse(txtParametro.Text));


                if (retorno == 0)
                {
                    MessageBox.Show("Comunicação Aberta");
                    this.Hide();
                    Impressora frm = new Impressora();  //formulario que eu quero seguir
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("Erro ao abrir comunicação! Retorno: " + retorno.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }
    }
    }

