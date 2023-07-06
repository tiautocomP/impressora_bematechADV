namespace E1_Impressora
{
    partial class Impressora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancNFCe = new System.Windows.Forms.Button();
            this.ImpXmlNfce = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnxmlCancelamento = new System.Windows.Forms.Button();
            this.btnCodigodeBarras = new System.Windows.Forms.Button();
            this.btnImagemMemoria = new System.Windows.Forms.Button();
            this.btnModoPagina = new System.Windows.Forms.Button();
            this.btnCorteParcial = new System.Windows.Forms.Button();
            this.btnCorteTotal = new System.Windows.Forms.Button();
            this.txtqrcode = new System.Windows.Forms.TextBox();
            this.btnImprimirQRCode = new System.Windows.Forms.Button();
            this.txtxmlsatname = new System.Windows.Forms.TextBox();
            this.btnImprimirXMLSat = new System.Windows.Forms.Button();
            this.btnSelecionaxml = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstiloTexto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbPosicaoTextoDir = new System.Windows.Forms.CheckBox();
            this.ckbPosicaoTextoCen = new System.Windows.Forms.CheckBox();
            this.ckbPosicaoTextoEsq = new System.Windows.Forms.CheckBox();
            this.btnImpressaoTexto = new System.Windows.Forms.Button();
            this.txtImpressaoTexto = new System.Windows.Forms.TextBox();
            this.btnFecharConexao = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialogxmlsat = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirGavetaElgin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAvancaPapel = new System.Windows.Forms.Button();
            this.btnImprimeImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancNFCe
            // 
            this.btnCancNFCe.Location = new System.Drawing.Point(246, 359);
            this.btnCancNFCe.Name = "btnCancNFCe";
            this.btnCancNFCe.Size = new System.Drawing.Size(134, 56);
            this.btnCancNFCe.TabIndex = 105;
            this.btnCancNFCe.Text = "Imp XML Canc NFCe";
            this.btnCancNFCe.UseVisualStyleBackColor = true;
            this.btnCancNFCe.Click += new System.EventHandler(this.btnCancNFCe_Click);
            // 
            // ImpXmlNfce
            // 
            this.ImpXmlNfce.Location = new System.Drawing.Point(46, 359);
            this.ImpXmlNfce.Name = "ImpXmlNfce";
            this.ImpXmlNfce.Size = new System.Drawing.Size(136, 56);
            this.ImpXmlNfce.TabIndex = 104;
            this.ImpXmlNfce.Text = "Imprimir XML NFCe";
            this.ImpXmlNfce.UseVisualStyleBackColor = true;
            this.ImpXmlNfce.Click += new System.EventHandler(this.ImpXmlNfce_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(459, 77);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(88, 37);
            this.btnStatus.TabIndex = 101;
            this.btnStatus.Text = "Status Impressora";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnxmlCancelamento
            // 
            this.btnxmlCancelamento.Location = new System.Drawing.Point(246, 290);
            this.btnxmlCancelamento.Name = "btnxmlCancelamento";
            this.btnxmlCancelamento.Size = new System.Drawing.Size(136, 56);
            this.btnxmlCancelamento.TabIndex = 100;
            this.btnxmlCancelamento.Text = "Imprimir XML Canc";
            this.btnxmlCancelamento.UseVisualStyleBackColor = true;
            this.btnxmlCancelamento.Click += new System.EventHandler(this.btnxmlCancelamento_Click);
            // 
            // btnCodigodeBarras
            // 
            this.btnCodigodeBarras.Location = new System.Drawing.Point(602, 171);
            this.btnCodigodeBarras.Name = "btnCodigodeBarras";
            this.btnCodigodeBarras.Size = new System.Drawing.Size(106, 36);
            this.btnCodigodeBarras.TabIndex = 99;
            this.btnCodigodeBarras.Text = "Codigo de Barras";
            this.btnCodigodeBarras.UseVisualStyleBackColor = true;
            this.btnCodigodeBarras.Click += new System.EventHandler(this.btnCodigodeBarras_Click);
            // 
            // btnImagemMemoria
            // 
            this.btnImagemMemoria.Location = new System.Drawing.Point(602, 213);
            this.btnImagemMemoria.Name = "btnImagemMemoria";
            this.btnImagemMemoria.Size = new System.Drawing.Size(106, 37);
            this.btnImagemMemoria.TabIndex = 98;
            this.btnImagemMemoria.Text = "Imagem Memoria";
            this.btnImagemMemoria.UseVisualStyleBackColor = true;
            this.btnImagemMemoria.Click += new System.EventHandler(this.btnImagemMemoria_Click);
            // 
            // btnModoPagina
            // 
            this.btnModoPagina.Location = new System.Drawing.Point(602, 256);
            this.btnModoPagina.Name = "btnModoPagina";
            this.btnModoPagina.Size = new System.Drawing.Size(106, 34);
            this.btnModoPagina.TabIndex = 97;
            this.btnModoPagina.Text = "Modo Pagina";
            this.btnModoPagina.UseVisualStyleBackColor = true;
            this.btnModoPagina.Click += new System.EventHandler(this.btnModoPagina_Click);
            // 
            // btnCorteParcial
            // 
            this.btnCorteParcial.Location = new System.Drawing.Point(296, 167);
            this.btnCorteParcial.Name = "btnCorteParcial";
            this.btnCorteParcial.Size = new System.Drawing.Size(86, 23);
            this.btnCorteParcial.TabIndex = 96;
            this.btnCorteParcial.Text = "Corte Parcial";
            this.btnCorteParcial.UseVisualStyleBackColor = true;
            this.btnCorteParcial.Click += new System.EventHandler(this.btnCorteParcial_Click);
            // 
            // btnCorteTotal
            // 
            this.btnCorteTotal.Location = new System.Drawing.Point(222, 167);
            this.btnCorteTotal.Name = "btnCorteTotal";
            this.btnCorteTotal.Size = new System.Drawing.Size(68, 23);
            this.btnCorteTotal.TabIndex = 95;
            this.btnCorteTotal.Text = "Corte Total";
            this.btnCorteTotal.UseVisualStyleBackColor = true;
            this.btnCorteTotal.Click += new System.EventHandler(this.btnCorteTotal_Click);
            // 
            // txtqrcode
            // 
            this.txtqrcode.Location = new System.Drawing.Point(553, 137);
            this.txtqrcode.Name = "txtqrcode";
            this.txtqrcode.Size = new System.Drawing.Size(155, 20);
            this.txtqrcode.TabIndex = 94;
            this.txtqrcode.Text = "https://elgindevelopercommunity.github.io/group___m1.html#gace32a45c3d64239fc38f7" +
    "73f199ddf2e";
            // 
            // btnImprimirQRCode
            // 
            this.btnImprimirQRCode.Location = new System.Drawing.Point(459, 128);
            this.btnImprimirQRCode.Name = "btnImprimirQRCode";
            this.btnImprimirQRCode.Size = new System.Drawing.Size(88, 37);
            this.btnImprimirQRCode.TabIndex = 93;
            this.btnImprimirQRCode.Text = "Imprimir QR Code";
            this.btnImprimirQRCode.UseVisualStyleBackColor = true;
            this.btnImprimirQRCode.Click += new System.EventHandler(this.btnImprimirQRCode_Click);
            // 
            // txtxmlsatname
            // 
            this.txtxmlsatname.Location = new System.Drawing.Point(188, 248);
            this.txtxmlsatname.Name = "txtxmlsatname";
            this.txtxmlsatname.Size = new System.Drawing.Size(194, 20);
            this.txtxmlsatname.TabIndex = 92;
            this.txtxmlsatname.Text = "Selecione o XML a ser impresso";
            // 
            // btnImprimirXMLSat
            // 
            this.btnImprimirXMLSat.Location = new System.Drawing.Point(46, 290);
            this.btnImprimirXMLSat.Name = "btnImprimirXMLSat";
            this.btnImprimirXMLSat.Size = new System.Drawing.Size(136, 56);
            this.btnImprimirXMLSat.TabIndex = 91;
            this.btnImprimirXMLSat.Text = "Imprimir XML Sat";
            this.btnImprimirXMLSat.UseVisualStyleBackColor = true;
            this.btnImprimirXMLSat.Click += new System.EventHandler(this.btnImprimirXMLSat_Click);
            // 
            // btnSelecionaxml
            // 
            this.btnSelecionaxml.Location = new System.Drawing.Point(46, 248);
            this.btnSelecionaxml.Name = "btnSelecionaxml";
            this.btnSelecionaxml.Size = new System.Drawing.Size(136, 20);
            this.btnSelecionaxml.TabIndex = 90;
            this.btnSelecionaxml.Text = "Selecionar XML";
            this.btnSelecionaxml.UseVisualStyleBackColor = true;
            this.btnSelecionaxml.Click += new System.EventHandler(this.btnSelecionaxml_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Texto:";
            // 
            // cmbEstiloTexto
            // 
            this.cmbEstiloTexto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstiloTexto.FormattingEnabled = true;
            this.cmbEstiloTexto.Location = new System.Drawing.Point(123, 86);
            this.cmbEstiloTexto.Name = "cmbEstiloTexto";
            this.cmbEstiloTexto.Size = new System.Drawing.Size(259, 21);
            this.cmbEstiloTexto.TabIndex = 88;
            this.cmbEstiloTexto.SelectedIndexChanged += new System.EventHandler(this.cmbEstiloTexto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Estilo Texto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Posição Texto:";
            // 
            // ckbPosicaoTextoDir
            // 
            this.ckbPosicaoTextoDir.AutoSize = true;
            this.ckbPosicaoTextoDir.Location = new System.Drawing.Point(326, 63);
            this.ckbPosicaoTextoDir.Name = "ckbPosicaoTextoDir";
            this.ckbPosicaoTextoDir.Size = new System.Drawing.Size(56, 17);
            this.ckbPosicaoTextoDir.TabIndex = 85;
            this.ckbPosicaoTextoDir.Text = "Direita";
            this.ckbPosicaoTextoDir.UseVisualStyleBackColor = true;
            // 
            // ckbPosicaoTextoCen
            // 
            this.ckbPosicaoTextoCen.AutoSize = true;
            this.ckbPosicaoTextoCen.Location = new System.Drawing.Point(228, 63);
            this.ckbPosicaoTextoCen.Name = "ckbPosicaoTextoCen";
            this.ckbPosicaoTextoCen.Size = new System.Drawing.Size(57, 17);
            this.ckbPosicaoTextoCen.TabIndex = 84;
            this.ckbPosicaoTextoCen.Text = "Centro";
            this.ckbPosicaoTextoCen.UseVisualStyleBackColor = true;
            // 
            // ckbPosicaoTextoEsq
            // 
            this.ckbPosicaoTextoEsq.AutoSize = true;
            this.ckbPosicaoTextoEsq.Checked = true;
            this.ckbPosicaoTextoEsq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPosicaoTextoEsq.Location = new System.Drawing.Point(123, 63);
            this.ckbPosicaoTextoEsq.Name = "ckbPosicaoTextoEsq";
            this.ckbPosicaoTextoEsq.Size = new System.Drawing.Size(71, 17);
            this.ckbPosicaoTextoEsq.TabIndex = 83;
            this.ckbPosicaoTextoEsq.Text = "Esquerda";
            this.ckbPosicaoTextoEsq.UseVisualStyleBackColor = true;
            // 
            // btnImpressaoTexto
            // 
            this.btnImpressaoTexto.Location = new System.Drawing.Point(123, 167);
            this.btnImpressaoTexto.Name = "btnImpressaoTexto";
            this.btnImpressaoTexto.Size = new System.Drawing.Size(93, 23);
            this.btnImpressaoTexto.TabIndex = 82;
            this.btnImpressaoTexto.Text = "Impressão Texto";
            this.btnImpressaoTexto.UseVisualStyleBackColor = true;
            this.btnImpressaoTexto.Click += new System.EventHandler(this.btnImpressaoTexto_Click);
            // 
            // txtImpressaoTexto
            // 
            this.txtImpressaoTexto.Location = new System.Drawing.Point(123, 115);
            this.txtImpressaoTexto.Multiline = true;
            this.txtImpressaoTexto.Name = "txtImpressaoTexto";
            this.txtImpressaoTexto.Size = new System.Drawing.Size(257, 46);
            this.txtImpressaoTexto.TabIndex = 81;
            this.txtImpressaoTexto.Text = "\"Esta palavra - a versão catalã para xiita - tem um \'i\' seguido por \'ï\', que é o " +
    "tipo de coisa que me faz querer desligar o computador e ir para casa.";
            // 
            // btnFecharConexao
            // 
            this.btnFecharConexao.BackColor = System.Drawing.Color.Red;
            this.btnFecharConexao.ForeColor = System.Drawing.Color.Transparent;
            this.btnFecharConexao.Location = new System.Drawing.Point(566, 361);
            this.btnFecharConexao.Name = "btnFecharConexao";
            this.btnFecharConexao.Size = new System.Drawing.Size(142, 54);
            this.btnFecharConexao.TabIndex = 106;
            this.btnFecharConexao.Text = "Fechar Conexão";
            this.btnFecharConexao.UseVisualStyleBackColor = false;
            this.btnFecharConexao.Click += new System.EventHandler(this.btnFecharConexao_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(553, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 107;
            this.comboBox1.Text = "Selecione o Status";
            // 
            // openFileDialogxmlsat
            // 
            this.openFileDialogxmlsat.FileName = "openFileDialogxmlsat";
            // 
            // btnAbrirGavetaElgin
            // 
            this.btnAbrirGavetaElgin.Location = new System.Drawing.Point(459, 256);
            this.btnAbrirGavetaElgin.Name = "btnAbrirGavetaElgin";
            this.btnAbrirGavetaElgin.Size = new System.Drawing.Size(88, 34);
            this.btnAbrirGavetaElgin.TabIndex = 108;
            this.btnAbrirGavetaElgin.Text = "Abrir Gaveta Elgin";
            this.btnAbrirGavetaElgin.UseVisualStyleBackColor = true;
            this.btnAbrirGavetaElgin.Click += new System.EventHandler(this.btnAbrirGavetaElgin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(459, 171);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 36);
            this.btnReset.TabIndex = 109;
            this.btnReset.Text = "Inicializa Impressora";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAvancaPapel
            // 
            this.btnAvancaPapel.Location = new System.Drawing.Point(459, 213);
            this.btnAvancaPapel.Name = "btnAvancaPapel";
            this.btnAvancaPapel.Size = new System.Drawing.Size(88, 37);
            this.btnAvancaPapel.TabIndex = 110;
            this.btnAvancaPapel.Text = "Avança Papel";
            this.btnAvancaPapel.UseVisualStyleBackColor = true;
            this.btnAvancaPapel.Click += new System.EventHandler(this.btnAvancaPapel_Click);
            // 
            // btnImprimeImagem
            // 
            this.btnImprimeImagem.Location = new System.Drawing.Point(522, 301);
            this.btnImprimeImagem.Name = "btnImprimeImagem";
            this.btnImprimeImagem.Size = new System.Drawing.Size(106, 34);
            this.btnImprimeImagem.TabIndex = 111;
            this.btnImprimeImagem.Text = "Imprime Imagem";
            this.btnImprimeImagem.UseVisualStyleBackColor = true;
            this.btnImprimeImagem.Click += new System.EventHandler(this.btnImprimeImagem_Click);
            // 
            // Impressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 432);
            this.Controls.Add(this.btnImprimeImagem);
            this.Controls.Add(this.btnAvancaPapel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAbrirGavetaElgin);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFecharConexao);
            this.Controls.Add(this.btnCancNFCe);
            this.Controls.Add(this.ImpXmlNfce);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnxmlCancelamento);
            this.Controls.Add(this.btnCodigodeBarras);
            this.Controls.Add(this.btnImagemMemoria);
            this.Controls.Add(this.btnModoPagina);
            this.Controls.Add(this.btnCorteParcial);
            this.Controls.Add(this.btnCorteTotal);
            this.Controls.Add(this.txtqrcode);
            this.Controls.Add(this.btnImprimirQRCode);
            this.Controls.Add(this.txtxmlsatname);
            this.Controls.Add(this.btnImprimirXMLSat);
            this.Controls.Add(this.btnSelecionaxml);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEstiloTexto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbPosicaoTextoDir);
            this.Controls.Add(this.ckbPosicaoTextoCen);
            this.Controls.Add(this.ckbPosicaoTextoEsq);
            this.Controls.Add(this.btnImpressaoTexto);
            this.Controls.Add(this.txtImpressaoTexto);
            this.Name = "Impressora";
            this.Text = "Impressora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancNFCe;
        private System.Windows.Forms.Button ImpXmlNfce;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnxmlCancelamento;
        private System.Windows.Forms.Button btnCodigodeBarras;
        private System.Windows.Forms.Button btnImagemMemoria;
        private System.Windows.Forms.Button btnModoPagina;
        private System.Windows.Forms.Button btnCorteParcial;
        private System.Windows.Forms.Button btnCorteTotal;
        private System.Windows.Forms.TextBox txtqrcode;
        private System.Windows.Forms.Button btnImprimirQRCode;
        private System.Windows.Forms.TextBox txtxmlsatname;
        private System.Windows.Forms.Button btnImprimirXMLSat;
        private System.Windows.Forms.Button btnSelecionaxml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstiloTexto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbPosicaoTextoDir;
        private System.Windows.Forms.CheckBox ckbPosicaoTextoCen;
        private System.Windows.Forms.CheckBox ckbPosicaoTextoEsq;
        private System.Windows.Forms.Button btnImpressaoTexto;
        private System.Windows.Forms.TextBox txtImpressaoTexto;
        //private System.Windows.Forms.OpenFileDialog openFileDialogxmlsat;
        private System.Windows.Forms.Button btnFecharConexao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogxmlsat;
        private System.Windows.Forms.Button btnAbrirGavetaElgin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAvancaPapel;
        private System.Windows.Forms.Button btnImprimeImagem;
    }
}