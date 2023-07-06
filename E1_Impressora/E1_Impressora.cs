using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E1_Impressora
{
    internal class E1_Impressora
    {
        public Func<object, object, object> Closed { get; internal set; }

        public E1_Impressora()
        { }

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int AbreConexaoImpressora(int tipo, string modelo, string conexao, int parametro);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int AvancaPapel(int linhas);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int CorteTotal(int avanco);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int DefineAreaImpressao(int oHorizontal, int oVertical, int dHorizontal, int dVertical);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int DirecaoImpressao(int direcao);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int FechaConexaoImpressora();

        internal void Show()
        {
            throw new NotImplementedException();
        }

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImpressaoCodigoBarras(int tipo, string dados, int altura, int largura, int HRI);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImpressaoQRCode(string dados, int tamanho, int nivelCorrecao);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImpressaoTexto(string dados, int posicao, int stilo, int tamanho);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeImagemMemoria(string key, int scala);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeModoPagina();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeMPeRetornaPadrao();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeXMLCancelamentoSAT(string dados, string assQRCode, int param);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeXMLSAT(string dados, int param);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int InicializaImpressora();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int AbreGavetaElgin();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int SinalSonoro(int qtd, int tempoInicio, int tempoFim);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int LimpaBufferModoPagina();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ModoPadrao();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ModoPagina();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int PosicaoImpressaoHorizontal(int nLnH);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int PosicaoImpressaoVertical(int nLnH);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int Corte(int avanco);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int StatusImpressora(int parametro);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImpressaoPDF417(int numCols,
            int numRows,
            int width,
            int height,
            int errCorLvl,
            int options,
            string dados
        );

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int GetVersaoDLL();

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeXMLNFCe(string dados, int indexcsc, string csc, int param);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeXMLCancelamentoNFCe(string dados, int param);

        [DllImport("E1_Impressora01.dll", CharSet = CharSet.None, ExactSpelling = false)]
        public static extern int ImprimeImagem(string path);

        
    }
}
