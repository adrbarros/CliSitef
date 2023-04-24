namespace App.CliSiTef_DLL
{
    partial class FrmTelaTesteVenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaTesteVenda));
            this.txtValorVenda = new TextBoxCurrency.TextBoxCurrency();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnCpfCnpj = new System.Windows.Forms.Button();
            this.btnRecargaCorrespondenteBancario = new System.Windows.Forms.Button();
            this.btnCorrespondenteBancario = new System.Windows.Forms.Button();
            this.btnRecarga = new System.Windows.Forms.Button();
            this.btnCrtCd = new System.Windows.Forms.Button();
            this.btnCncCredito = new System.Windows.Forms.Button();
            this.btnCncDebito = new System.Windows.Forms.Button();
            this.btnCncCd = new System.Windows.Forms.Button();
            this.btnDocumentoVinculadoGerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentoVinculado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbImpressoraTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbImpressoraNome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCnc = new System.Windows.Forms.Button();
            this.btnCrtCredito = new System.Windows.Forms.Button();
            this.btnCrtDebito = new System.Windows.Forms.Button();
            this.btnCrt = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnAtv = new System.Windows.Forms.Button();
            this.pnlQrCode = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQrCode = new System.Windows.Forms.Label();
            this.lblMenuTituloQrCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.TextBox();
            this.bkgInicioTef = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBody.SuspendLayout();
            this.pnlQrCode.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtValorVenda.DecimalPlaces = 2;
            this.txtValorVenda.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.ForeColorDefined = System.Drawing.Color.Empty;
            this.txtValorVenda.Location = new System.Drawing.Point(168, 304);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(115, 26);
            this.txtValorVenda.TabIndex = 14;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnCpfCnpj);
            this.pnlBody.Controls.Add(this.btnRecargaCorrespondenteBancario);
            this.pnlBody.Controls.Add(this.btnCorrespondenteBancario);
            this.pnlBody.Controls.Add(this.btnRecarga);
            this.pnlBody.Controls.Add(this.btnCrtCd);
            this.pnlBody.Controls.Add(this.btnCncCredito);
            this.pnlBody.Controls.Add(this.btnCncDebito);
            this.pnlBody.Controls.Add(this.btnCncCd);
            this.pnlBody.Controls.Add(this.btnDocumentoVinculadoGerar);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.txtDocumentoVinculado);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.cmbImpressoraTipo);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.cmbImpressoraNome);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.btnCnc);
            this.pnlBody.Controls.Add(this.btnCrtCredito);
            this.pnlBody.Controls.Add(this.btnCrtDebito);
            this.pnlBody.Controls.Add(this.btnCrt);
            this.pnlBody.Controls.Add(this.btnAdm);
            this.pnlBody.Controls.Add(this.btnAtv);
            this.pnlBody.Controls.Add(this.txtValorVenda);
            this.pnlBody.Controls.Add(this.pnlQrCode);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(567, 336);
            this.pnlBody.TabIndex = 1;
            // 
            // btnCpfCnpj
            // 
            this.btnCpfCnpj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCpfCnpj.Location = new System.Drawing.Point(6, 130);
            this.btnCpfCnpj.Name = "btnCpfCnpj";
            this.btnCpfCnpj.Size = new System.Drawing.Size(75, 23);
            this.btnCpfCnpj.TabIndex = 24;
            this.btnCpfCnpj.Text = "Cpf / Cnpj";
            this.toolTip1.SetToolTip(this.btnCpfCnpj, "Capturar Cpf / Cnpj no PinPad");
            this.btnCpfCnpj.UseVisualStyleBackColor = true;
            this.btnCpfCnpj.Click += new System.EventHandler(this.btnCpfCnpj_Click);
            // 
            // btnRecargaCorrespondenteBancario
            // 
            this.btnRecargaCorrespondenteBancario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargaCorrespondenteBancario.Location = new System.Drawing.Point(87, 188);
            this.btnRecargaCorrespondenteBancario.Name = "btnRecargaCorrespondenteBancario";
            this.btnRecargaCorrespondenteBancario.Size = new System.Drawing.Size(75, 23);
            this.btnRecargaCorrespondenteBancario.TabIndex = 23;
            this.btnRecargaCorrespondenteBancario.Text = "REC. CBC";
            this.toolTip1.SetToolTip(this.btnRecargaCorrespondenteBancario, "Correspondente Bancario Recarga Pré-Pago TRICARD");
            this.btnRecargaCorrespondenteBancario.UseVisualStyleBackColor = true;
            this.btnRecargaCorrespondenteBancario.Click += new System.EventHandler(this.btnRecargaCorrespondenteBancario_Click);
            // 
            // btnCorrespondenteBancario
            // 
            this.btnCorrespondenteBancario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrespondenteBancario.Location = new System.Drawing.Point(87, 159);
            this.btnCorrespondenteBancario.Name = "btnCorrespondenteBancario";
            this.btnCorrespondenteBancario.Size = new System.Drawing.Size(75, 23);
            this.btnCorrespondenteBancario.TabIndex = 22;
            this.btnCorrespondenteBancario.Text = "C. BANC";
            this.toolTip1.SetToolTip(this.btnCorrespondenteBancario, "Correspondente Bancario TRICARD");
            this.btnCorrespondenteBancario.UseVisualStyleBackColor = true;
            this.btnCorrespondenteBancario.Click += new System.EventHandler(this.btnCorrespondenteBancario_Click);
            // 
            // btnRecarga
            // 
            this.btnRecarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecarga.Location = new System.Drawing.Point(87, 130);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(75, 23);
            this.btnRecarga.TabIndex = 20;
            this.btnRecarga.Text = "REC. CEL";
            this.toolTip1.SetToolTip(this.btnRecarga, "Recarga de Celular");
            this.btnRecarga.UseVisualStyleBackColor = true;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // btnCrtCd
            // 
            this.btnCrtCd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrtCd.Location = new System.Drawing.Point(168, 188);
            this.btnCrtCd.Name = "btnCrtCd";
            this.btnCrtCd.Size = new System.Drawing.Size(75, 23);
            this.btnCrtCd.TabIndex = 19;
            this.btnCrtCd.Text = "CRT CD";
            this.toolTip1.SetToolTip(this.btnCrtCd, "Ação para Transação em Carteira Digital");
            this.btnCrtCd.UseVisualStyleBackColor = true;
            this.btnCrtCd.Click += new System.EventHandler(this.btnCrtCd_Click);
            // 
            // btnCncCredito
            // 
            this.btnCncCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCncCredito.Location = new System.Drawing.Point(249, 159);
            this.btnCncCredito.Name = "btnCncCredito";
            this.btnCncCredito.Size = new System.Drawing.Size(75, 23);
            this.btnCncCredito.TabIndex = 18;
            this.btnCncCredito.Text = "CNC CRED";
            this.toolTip1.SetToolTip(this.btnCncCredito, "Ação para Cancelamento de Transação em Cartão Crédito");
            this.btnCncCredito.UseVisualStyleBackColor = true;
            this.btnCncCredito.Click += new System.EventHandler(this.btnCncCredito_Click);
            // 
            // btnCncDebito
            // 
            this.btnCncDebito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCncDebito.Location = new System.Drawing.Point(249, 130);
            this.btnCncDebito.Name = "btnCncDebito";
            this.btnCncDebito.Size = new System.Drawing.Size(75, 23);
            this.btnCncDebito.TabIndex = 17;
            this.btnCncDebito.Text = "CNC DEB";
            this.toolTip1.SetToolTip(this.btnCncDebito, "Ação para Cancelamento de Transação em Cartão Débito");
            this.btnCncDebito.UseVisualStyleBackColor = true;
            this.btnCncDebito.Click += new System.EventHandler(this.btnCncDebito_Click);
            // 
            // btnCncCd
            // 
            this.btnCncCd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCncCd.Location = new System.Drawing.Point(249, 188);
            this.btnCncCd.Name = "btnCncCd";
            this.btnCncCd.Size = new System.Drawing.Size(75, 23);
            this.btnCncCd.TabIndex = 16;
            this.btnCncCd.Text = "CNC CD";
            this.toolTip1.SetToolTip(this.btnCncCd, "Ação para Cancelamento de Transação em Carteira Digital");
            this.btnCncCd.UseVisualStyleBackColor = true;
            this.btnCncCd.Click += new System.EventHandler(this.btnCncCd_Click);
            // 
            // btnDocumentoVinculadoGerar
            // 
            this.btnDocumentoVinculadoGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentoVinculadoGerar.Location = new System.Drawing.Point(122, 303);
            this.btnDocumentoVinculadoGerar.Name = "btnDocumentoVinculadoGerar";
            this.btnDocumentoVinculadoGerar.Size = new System.Drawing.Size(26, 28);
            this.btnDocumentoVinculadoGerar.TabIndex = 12;
            this.btnDocumentoVinculadoGerar.TabStop = false;
            this.btnDocumentoVinculadoGerar.Text = "{ }";
            this.toolTip1.SetToolTip(this.btnDocumentoVinculadoGerar, "Gerar Número do Documento Vinculado");
            this.btnDocumentoVinculadoGerar.UseVisualStyleBackColor = true;
            this.btnDocumentoVinculadoGerar.Click += new System.EventHandler(this.btnDocumentoVinculadoGerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doc. Vinculado";
            // 
            // txtDocumentoVinculado
            // 
            this.txtDocumentoVinculado.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.txtDocumentoVinculado.Location = new System.Drawing.Point(6, 304);
            this.txtDocumentoVinculado.MaxLength = 6;
            this.txtDocumentoVinculado.Name = "txtDocumentoVinculado";
            this.txtDocumentoVinculado.Size = new System.Drawing.Size(115, 26);
            this.txtDocumentoVinculado.TabIndex = 11;
            this.txtDocumentoVinculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modelo Impressão";
            // 
            // cmbImpressoraTipo
            // 
            this.cmbImpressoraTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpressoraTipo.FormattingEnabled = true;
            this.cmbImpressoraTipo.Items.AddRange(new object[] {
            "",
            "1-EscPos",
            "2-EscBematech",
            "3-EscDaruma"});
            this.cmbImpressoraTipo.Location = new System.Drawing.Point(6, 19);
            this.cmbImpressoraTipo.Name = "cmbImpressoraTipo";
            this.cmbImpressoraTipo.Size = new System.Drawing.Size(555, 21);
            this.cmbImpressoraTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Impressora Selecionada para Impressão dos Comprovantes";
            // 
            // cmbImpressoraNome
            // 
            this.cmbImpressoraNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpressoraNome.FormattingEnabled = true;
            this.cmbImpressoraNome.Location = new System.Drawing.Point(6, 59);
            this.cmbImpressoraNome.Name = "cmbImpressoraNome";
            this.cmbImpressoraNome.Size = new System.Drawing.Size(555, 21);
            this.cmbImpressoraNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor da Transação";
            // 
            // btnCnc
            // 
            this.btnCnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCnc.Location = new System.Drawing.Point(249, 101);
            this.btnCnc.Name = "btnCnc";
            this.btnCnc.Size = new System.Drawing.Size(75, 23);
            this.btnCnc.TabIndex = 9;
            this.btnCnc.Text = "CNC";
            this.toolTip1.SetToolTip(this.btnCnc, "Ação para Cancelamento de Transação em Cartão");
            this.btnCnc.UseVisualStyleBackColor = true;
            this.btnCnc.Click += new System.EventHandler(this.btnCnc_Click);
            // 
            // btnCrtCredito
            // 
            this.btnCrtCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrtCredito.Location = new System.Drawing.Point(168, 159);
            this.btnCrtCredito.Name = "btnCrtCredito";
            this.btnCrtCredito.Size = new System.Drawing.Size(75, 23);
            this.btnCrtCredito.TabIndex = 8;
            this.btnCrtCredito.Text = "CRT CRED";
            this.toolTip1.SetToolTip(this.btnCrtCredito, "Ação para Transação em Cartão Crédito");
            this.btnCrtCredito.UseVisualStyleBackColor = true;
            this.btnCrtCredito.Click += new System.EventHandler(this.btnCrtCredito_Click);
            // 
            // btnCrtDebito
            // 
            this.btnCrtDebito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrtDebito.Location = new System.Drawing.Point(168, 130);
            this.btnCrtDebito.Name = "btnCrtDebito";
            this.btnCrtDebito.Size = new System.Drawing.Size(75, 23);
            this.btnCrtDebito.TabIndex = 7;
            this.btnCrtDebito.Text = "CRT DEB";
            this.toolTip1.SetToolTip(this.btnCrtDebito, "Ação para Transação em Cartão Débito");
            this.btnCrtDebito.UseVisualStyleBackColor = true;
            this.btnCrtDebito.Click += new System.EventHandler(this.btnCrtDebito_Click);
            // 
            // btnCrt
            // 
            this.btnCrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrt.Location = new System.Drawing.Point(168, 101);
            this.btnCrt.Name = "btnCrt";
            this.btnCrt.Size = new System.Drawing.Size(75, 23);
            this.btnCrt.TabIndex = 6;
            this.btnCrt.Text = "CRT";
            this.toolTip1.SetToolTip(this.btnCrt, "Ação para Transação em Cartão");
            this.btnCrt.UseVisualStyleBackColor = true;
            this.btnCrt.Click += new System.EventHandler(this.btnCrt_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.Location = new System.Drawing.Point(87, 101);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(75, 23);
            this.btnAdm.TabIndex = 5;
            this.btnAdm.Text = "ADM";
            this.toolTip1.SetToolTip(this.btnAdm, "Funções Administrativas");
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnAtv
            // 
            this.btnAtv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtv.Location = new System.Drawing.Point(6, 101);
            this.btnAtv.Name = "btnAtv";
            this.btnAtv.Size = new System.Drawing.Size(75, 23);
            this.btnAtv.TabIndex = 4;
            this.btnAtv.Text = "ATV";
            this.toolTip1.SetToolTip(this.btnAtv, "Verificar Servidor (Ativo/Inativo)");
            this.btnAtv.UseVisualStyleBackColor = true;
            this.btnAtv.Click += new System.EventHandler(this.btnAtv_Click);
            // 
            // pnlQrCode
            // 
            this.pnlQrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQrCode.Controls.Add(this.label7);
            this.pnlQrCode.Controls.Add(this.lblQrCode);
            this.pnlQrCode.Controls.Add(this.lblMenuTituloQrCode);
            this.pnlQrCode.Location = new System.Drawing.Point(329, 86);
            this.pnlQrCode.Name = "pnlQrCode";
            this.pnlQrCode.Size = new System.Drawing.Size(231, 245);
            this.pnlQrCode.TabIndex = 21;
            this.pnlQrCode.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Carteira Digital";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQrCode
            // 
            this.lblQrCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblQrCode.Location = new System.Drawing.Point(25, 58);
            this.lblQrCode.Name = "lblQrCode";
            this.lblQrCode.Size = new System.Drawing.Size(180, 180);
            this.lblQrCode.TabIndex = 4;
            this.lblQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenuTituloQrCode
            // 
            this.lblMenuTituloQrCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMenuTituloQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTituloQrCode.Location = new System.Drawing.Point(4, 25);
            this.lblMenuTituloQrCode.Name = "lblMenuTituloQrCode";
            this.lblMenuTituloQrCode.Size = new System.Drawing.Size(221, 27);
            this.lblMenuTituloQrCode.TabIndex = 2;
            this.lblMenuTituloQrCode.Text = "[lblMenuTituloQrCode]";
            this.lblMenuTituloQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(329, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 246);
            this.label5.TabIndex = 15;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(567, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(567, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exemplo TEF Dedicado (CliSiTef SofwareExpress) via DLL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblMensagem);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 396);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(567, 60);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(0, 0);
            this.lblMensagem.Multiline = true;
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.ReadOnly = true;
            this.lblMensagem.Size = new System.Drawing.Size(567, 60);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.TabStop = false;
            this.lblMensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bkgInicioTef
            // 
            this.bkgInicioTef.WorkerReportsProgress = true;
            this.bkgInicioTef.WorkerSupportsCancellation = true;
            this.bkgInicioTef.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgInicioTef_DoWork);
            this.bkgInicioTef.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgInicioTef_RunWorkerCompleted);
            // 
            // FrmTelaTesteVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 456);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelaTesteVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Venda";
            this.Load += new System.EventHandler(this.FrmTelaTesteVenda_Load);
            this.Shown += new System.EventHandler(this.FrmTelaTesteVenda_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTelaTesteVenda_KeyDown);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlQrCode.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxCurrency.TextBoxCurrency txtValorVenda;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnAtv;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnCrt;
        private System.Windows.Forms.Button btnCrtCredito;
        private System.Windows.Forms.Button btnCrtDebito;
        private System.Windows.Forms.Button btnCnc;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbImpressoraTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbImpressoraNome;
        private System.ComponentModel.BackgroundWorker bkgInicioTef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoVinculado;
        private System.Windows.Forms.Button btnDocumentoVinculadoGerar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCncCd;
        private System.Windows.Forms.Button btnCncCredito;
        private System.Windows.Forms.Button btnCncDebito;
        private System.Windows.Forms.Button btnCrtCd;
        private System.Windows.Forms.Button btnRecarga;
        private System.Windows.Forms.Panel pnlQrCode;
        public System.Windows.Forms.Label lblQrCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMenuTituloQrCode;
        private System.Windows.Forms.Button btnCorrespondenteBancario;
        private System.Windows.Forms.Button btnRecargaCorrespondenteBancario;
        private System.Windows.Forms.Button btnCpfCnpj;
    }
}

