using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_Impressora
{
    public partial class Impressora : Form
    {

        private int statusSelecionado = 0;

        public Impressora()
        {
            InitializeComponent();

            PreencherComboBoxEstiloTexto();
        }

        private void btnImprimirQRCode_Click(object sender, EventArgs e)
        {
            int retorno = E1_Impressora.ImpressaoQRCode(txtqrcode.Text, 5, 4);
            E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, string.Concat("Impressão de QRCode OK! Retorno: ", retorno.ToString()));
        }

        private void btnCodigodeBarras_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Impressora.ImpressaoCodigoBarras(8, "{A012345678912", 100, 2, 3);
            E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, "Impressão de Codigo de Barras OK! Retorno " + retorno);
        }

        private void btnImagemMemoria_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Impressora.ImprimeImagemMemoria("00", 1);
            E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, "Impressão de Imagem na Memoria OK! Retorno: " + retorno);
        }

        private void btnModoPagina_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = E1_Impressora.ModoPagina();
            E1_Impressora.LimpaBufferModoPagina();
            //  E1.E1_Impressora.DirecaoImpressao(0);
            E1_Impressora.InicializaImpressora();
            E1_Impressora.DefineAreaImpressao(0, 0, 580, 1000);

            // E1.E1_Impressora.PosicaoImpressaoHorizontal(95);
            E1_Impressora.ImpressaoTexto("Teste de Cupom Fiscal", 1, 8, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("Travessa Julia Gonzaga", 1, 0, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("CEP: 12345-678  Capitão Prudencio - TB", 1, 0, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("CNPJ: 16.716.114/0001-72", 1, 0, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("IE: 111.111111.1111", 1, 0, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("IM: 1.111.111/111-1", 1, 0, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("------------------------------------------------", 1, 8, 0);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("21/09/2022 12:54:25V   CCF:000001   COO:000001", 1, 0, 0);            

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("CUPOM FISCAL", 1, 0, 17);

            E1_Impressora.AvancaPapel(1);
            E1_Impressora.ImpressaoTexto("ITEM     CODIGO     DESCRICAO", 1, 0, 0);

            E1_Impressora.ImprimeModoPagina();
            E1_Impressora.ModoPadrao();
            E1_Impressora.CorteTotal(10);
            MessageBox.Show("Impressão modo página Ok! Retorno: " + retorno);
        }

        private void btnSelecionaxml_Click(object sender, System.EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialogxmlsat.Multiselect = false;
            this.openFileDialogxmlsat.Title = "Selecionar XML Sat";
            //filtra para exibir somente arquivos de imagens
            openFileDialogxmlsat.Filter = "XML Files (*.xml)|*.xml";

            DialogResult dr = this.openFileDialogxmlsat.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtxmlsatname.Text = openFileDialogxmlsat.FileName;

            }
        }

        private void btnImprimirXMLSat_Click(object sender, EventArgs e)
        {
            string conteudoXML;
            conteudoXML = File.ReadAllText(txtxmlsatname.Text);
            if (conteudoXML == "")
            {
                MessageBox.Show("Anexe o arquivo para impressão");
            }
            else
            {
                int retorno = E1_Impressora.ImprimeXMLSAT(conteudoXML, 6);
                E1_Impressora.CorteTotal(10);
                MessageBox.Show(this, string.Concat("Impressão de XML SAT OK! Retorno: ", retorno.ToString()));
            }
        }

        private void btnxmlCancelamento_Click(object sender, EventArgs e)
        {
            string conteudoXMLcancelamento = File.ReadAllText(txtxmlsatname.Text);
            int retorno = E1_Impressora.ImprimeXMLCancelamentoSAT(conteudoXMLcancelamento,
            "Q5DLkpdRijIRGY6YSSNsTWK1TztHL1vD0V1Jc4spo/CEUqICEb9SFy82ym8EhBRZjbh3btsZhF+sjHqEMR159i4agru9x6KsepK/q0E2e5xlU5cv3m1woYfgHyOkWDNcSdMsS6bBh2Bpq6s89yJ9Q6qh/J8YHi306ce9Tqb/drKvN2XdE5noRSS32TAWuaQEVd7u+TrvXlOQsE3fHR1D5f1saUwQLPSdIv01NF6Ny7jZwjCwv1uNDgGZONJdlTJ6p0ccqnZvuE70aHOI09elpjEO6Cd+orI7XHHrFCwhFhAcbalc+ZfO5b/+vkyAHS6CYVFCDtYR9Hi5qgdk31v23w==", 1);
            E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, string.Concat("Impressão de XML Cancelamento SAT Ok! Retorno: ", retorno.ToString()));
        }

        private void ImpXmlNfce_Click(object sender, EventArgs e)
        {
            string conteudoXMLNFCe = File.ReadAllText(txtxmlsatname.Text);
            int retorno = E1_Impressora.ImprimeXMLNFCe(conteudoXMLNFCe, 33800, "123123123", 0);
            E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, string.Concat("Impressão de XML NFCe Ok! Retorno: ", retorno.ToString()));
        }

        private void btnCancNFCe_Click(object sender, EventArgs e)
        {
            string conteudoXMLCancelNFCe = File.ReadAllText(txtxmlsatname.Text);
            int retorno = E1_Impressora.ImprimeXMLCancelamentoNFCe(conteudoXMLCancelNFCe, 0);
            E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, string.Concat("Impressão de XML de Cancelamento NFCe Ok! Retorno: ", retorno.ToString()));
        }

        private void btnImpressaoTexto_Click(object sender, EventArgs e)
        {
            //Verificando qual a posição do texto para imprimir
            var posicao = 0;
            if (ckbPosicaoTextoEsq.Checked) posicao = 0;
            if (ckbPosicaoTextoCen.Checked) posicao = 1;
            if (ckbPosicaoTextoDir.Checked) posicao = 2;


            //Tratar caracteres especiais
            byte[] encodedBytes = (new UTF8Encoding()).GetBytes(txtImpressaoTexto.Text);
            string String = Encoding.Default.GetString(encodedBytes);

            int retorno = E1_Impressora.ImpressaoTexto(String, posicao, statusSelecionado, 0);
            retorno = E1_Impressora.CorteTotal(10);
            MessageBox.Show(this, string.Concat("Impressão de Caracteres Especiais Ok! Retorno: ", retorno.ToString()));
        }

        private void btnCorteTotal_Click(object sender, EventArgs e)
        {
            var CorteTotal = E1_Impressora.CorteTotal(5);
            MessageBox.Show(this, string.Concat("Corte Total Ok! Retorno: ", CorteTotal));
        }

        private void btnCorteParcial_Click(object sender, EventArgs e)
        {
            //var CorteParcial = E1_Impressora.Corte(5);
            MessageBox.Show(this, string.Concat("Corte Parcial Ok! Retorno: ", E1_Impressora.Corte(5)));
        }

        private void btnFecharConexao_Click(object sender, EventArgs e)
        {
            var retorno = E1_Impressora.FechaConexaoImpressora();

            MessageBox.Show(retorno == 0 ? "Sucesso" : "Erro! Código: " + retorno.ToString());
            //Application.Run(new Menu());
            this.Hide();
            Form1 frm = new Form1();  //formulario que eu quero seguir
            frm.Closed += (s, args) => Close();
            frm.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            //int status;
            //string selecao = cbStatus.Text; 
            //status = E1_Impressora.StatusImpressora(Convert.ToInt32(cbStatus.Text));
            //E1.E1_Impressora.CorteTotal(10);
            //MessageBox.Show(this, "Status = " + status);


            try
            {

                if (comboBox1.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione o Status que deseja verificar!");
                    comboBox1.Focus();
                    return;
                }

                int retorno;
                retorno = E1_Impressora.StatusImpressora(int.Parse(comboBox1.Text));


                if (retorno == 1)
                {
                    MessageBox.Show("Gaveta Aberta");                    
                }

                else if (retorno == 2)
                {
                    MessageBox.Show("Gaveta Fechada");
                }

                else if (retorno == 3)
                {
                    MessageBox.Show("Tampa Aberta");
                }

                else if (retorno == 4)
                {
                    MessageBox.Show("Tampa Fechada");
                }

                else if (retorno == 5)
                {
                    MessageBox.Show("Papel está presente e não está próximo do fim");
                }

                else if (retorno == 6)
                {
                    MessageBox.Show("Papel está próximo do fim");
                }

                else if (retorno == 7)
                {
                    MessageBox.Show("Sem Papel");
                }

                else if (retorno == 8)
                {
                    MessageBox.Show("Sem papel no ejetor");
                }

                else if (retorno == 9)
                {
                    MessageBox.Show("Com papel no ejetor");
                }

                else if (retorno == 0)
                {
                    MessageBox.Show("Retorna status geral! Retorno: " + retorno.ToString());
                }

                else
                {
                    MessageBox.Show("Erro ao identificar o status da impressora! Retorno: " + retorno.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAbrirGavetaElgin_Click(object sender, EventArgs e)
        {
            var retorno = E1_Impressora.AbreGavetaElgin();

            if(retorno == 0)
            {
                MessageBox.Show(this, string.Concat("Gaveta Aberta com Sucesso"));
            }
            else
            {
                MessageBox.Show(this, string.Concat("Erro ao abrir gaveta! Retorno "+ retorno));
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var retorno = E1_Impressora.InicializaImpressora();

            if (retorno == 0)
            {
                MessageBox.Show(this, string.Concat("Reset realizado com Sucesso"));
            }
            else
            {
                MessageBox.Show(this, string.Concat("Erro ao resetar a impressora! Retorno " + retorno));
            }
        }

        private void btnAvancaPapel_Click(object sender, EventArgs e)
        {
            var retorno = E1_Impressora.AvancaPapel(7);
            //MessageBox.Show("Teste OK");
        }

        private void btnImprimeImagem_Click(object sender, EventArgs e)
        {
            int retorno;
            // Exibe o diálogo para seleção da imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Todos os arquivos|*.*";
            openFileDialog.Title = "Selecionar Imagem";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Define o tamanho da área de impressão para 100mm de largura e 0mm de altura
                E1_Impressora.DefineAreaImpressao(100, 0, 0, 0);
                // Imprime a imagem especificando o caminho do arquivo selecionado no OpenFileDialog
                retorno = E1_Impressora.ImprimeImagem(openFileDialog.FileName);
                // Realiza o corte total do papel
                E1_Impressora.CorteTotal(10);
                // Exibe uma mensagem informando que a impressão foi realizada com sucesso
                MessageBox.Show(this, "Impressão de Imagem OK! Retorno: " + retorno);
            }
        }


        private void PreencherComboBoxEstiloTexto()
        {
            var listaEstilo = new List<string>()
            {
              "0-Fonte A",
              "1-Fonte B",
              "2-Sublinhado",
              "4-Modo Reverso",
              "8-Negrito"
            };

            cmbEstiloTexto.Items.AddRange(listaEstilo.ToArray());
        }

        private void cmbEstiloTexto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var textoSelecionado = cmbEstiloTexto.SelectedItem.ToString();

            var valorSelecionado = textoSelecionado.Substring(0, 1);

            statusSelecionado = int.Parse(valorSelecionado);
        }
    }
}
