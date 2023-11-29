using Lib.CliSitef.Classes;
using Lib.FormsAuxiliares;
using Lib.Utils.Classes;
using Lib.Utils.Enuns;
using Lib.Utils.Logs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Vip.Printer;

namespace App.CliSiTef_DLL
{
    public partial class FrmTelaTesteVenda : Form
    {
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        private int mStatusTefInicio { get; set; }
        private decimal gValorTotalDaTransacao { get; set; }
        private decimal gValorDasTransacoesEfetuadas { get; set; }

        private TefSoftwareExpress mTefSoftwareExpress = new TefSoftwareExpress();

        private TefConfig mTefConfig { get; set; }
        private Cupom mCupomVenda { get; set; }

        private void ForceFocus(Control _control, bool _selectAll = false)
        {
            if (!DesignMode)
            {
                ActiveControl = _control;
                if (_selectAll && _control is TextBoxBase)
                    (_control as TextBoxBase).SelectAll();
                _control.Focus();
            }
        }
        private void CarregarConfiguracao()
        {
            mTefConfig = new TefConfig
            {
                Tef_PathArquivos = Application.StartupPath,
                Tef_Ip = ConfigurationManager.AppSettings["Tef_Ip"],
                Tef_Empresa = ConfigurationManager.AppSettings["Tef_Empresa"],
                Tef_EmpresaCnpj = ConfigurationManager.AppSettings["Tef_EmpresaCnpj"],
                Tef_Terminal = ConfigurationManager.AppSettings["Tef_Terminal"],
                Tef_SoftwareHouseCnpj = ConfigurationManager.AppSettings["Tef_SoftwareHouseCnpj"],
                Tef_PinPadPorta = ConfigurationManager.AppSettings["Tef_PinPadPorta"],
                Tef_PinPadMensagem = ConfigurationManager.AppSettings["Tef_PinPadMensagem"],
                Tef_PinPadVerificar = ConfigurationManager.AppSettings["Tef_PinPadVerificar"] == "1",
                Tef_PinPadQrCode = ConfigurationManager.AppSettings["Tef_PinPadQrCode"] == "1"
            };

            string path = Application.StartupPath + "\\CliSiTef.ini";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("[Redes]");
                    sw.WriteLine("HabilitaRedeTelecheque=1");
                    sw.WriteLine("HabilitaRedeSigaCred=1");
                    sw.WriteLine("HabilitaRedeSoftWay=1");
                    sw.WriteLine("");
                    sw.WriteLine("[PinPad]");
                    sw.WriteLine("Tipo=Compartilhado");
                    sw.WriteLine("");
                    sw.WriteLine("[PinPadCompartilhado]");
                    sw.WriteLine("Porta=" + mTefConfig.Tef_PinPadPorta);
                    sw.WriteLine("");
                    sw.WriteLine("[CliSiTef]");
                    sw.WriteLine("HabilitaTrace=0");
                    sw.WriteLine("");
                    sw.WriteLine("[CliSiTefI]");
                    sw.WriteLine("HabilitaTrace=0");
                    sw.WriteLine("");
                    sw.WriteLine("[SiTef]");
                    sw.WriteLine("MantemConexaoAtiva=1");
                    sw.WriteLine("TempoEsperaConexao=10");
                    sw.WriteLine("");
                    sw.WriteLine("[Geral]");
                    sw.WriteLine("TransacoesAdicionaisHabilitadas=7;8;16;26;29;30;40;42;43;3014;3044;");
                    sw.WriteLine("");
                    sw.WriteLine("[SrvCliSiTef]");
                    sw.WriteLine("IpSiTef=" + mTefConfig.Tef_Ip);
                    sw.WriteLine("");
                    sw.WriteLine("[RecargaCelular]");
                    sw.WriteLine(";0-nao solicita/1-Pinpad/2-PDV");
                    sw.WriteLine("TipoConfirmacaoNumeroCelular=2");
                    sw.WriteLine("HabilitaRecargaMultiConcessionaria=1");
                    sw.Flush();
                }
            }
        }
        private void CarregarImpresorasInstaladas()
        {
            cmbImpressoraNome.Items.Add("");
            foreach (string impressora in PrinterSettings.InstalledPrinters)
            {
                cmbImpressoraNome.Items.Add(impressora);
            }

            cmbImpressoraNome.SelectedIndex = 0;
        }
        private void Comprovante(string _documentoVinculado, List<TefRetorno> _lstComprovante, Printer _printer)
        {
            if (_lstComprovante != null && _lstComprovante.Count > 0)
            {
                _printer.AlignCenter();
                _printer.BoldMode(Vip.Printer.Enums.PrinterModeState.On);
                _printer.WriteLine("Nome Fantasia");
                _printer.WriteLine("Razao Social da Empresa");
                _printer.WriteLine("Rua Endereco da empresa, numero");
                _printer.WriteLine("Cep - Cidade/Uf");
                _printer.WriteLine("C.N.P.J  -  Inscricao Estadual");
                _printer.WriteLine("----------------------------------------------");
                _printer.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "      Cupom: " + _documentoVinculado);
                _printer.WriteLine("----------------------------------------------");
                _printer.BoldMode(Vip.Printer.Enums.PrinterModeState.Off);
                _printer.AlignLeft();

                foreach (TefRetorno item in _lstComprovante)
                {
                    if (item != null)
                    {
                        string linha = item.Valor?.Replace("\"", "");
                        if (!string.IsNullOrWhiteSpace(linha))
                            _printer.WriteLine(linha);
                    }
                }
                _printer.BoldMode(Vip.Printer.Enums.PrinterModeState.On);
                _printer.WriteLine("----------------------------------------------");
                _printer.WriteLine("Caixa: " + mTefConfig.Tef_Terminal);
                _printer.WriteLine("----------------------------------------------");
                _printer.BoldMode(Vip.Printer.Enums.PrinterModeState.Off);
                _printer.NewLines(4);
                _printer.PartialPaperCut();
                _printer.PrintDocument();
                _printer.Clear();
            }
        }
        private void ImprimirComprovantes(string _documentoVinculado)
        {
            if (cmbImpressoraTipo.SelectedIndex <= 0)
                return;
            if (cmbImpressoraNome.SelectedIndex <= 0)
                return;

            if (mTefSoftwareExpress.gCupomVenda != null)
            {
                if (mTefSoftwareExpress.gCupomVenda.Transacoes.Count > 0)
                {
                    foreach (TefTransacao itemTransacaoItem in mTefSoftwareExpress.gCupomVenda.Transacoes)
                    {
                        List<TefRetorno> lstComprovanteCliente = itemTransacaoItem.Retornos.Where(p => p.Codigo == 713).OrderBy(p => p.Indice).ToList();
                        List<TefRetorno> lstComprovanteEstab = itemTransacaoItem.Retornos.Where(p => p.Codigo == 715).OrderBy(p => p.Indice).ToList();

                        Vip.Printer.Enums.PrinterType printerType = Vip.Printer.Enums.PrinterType.Epson;
                        if (cmbImpressoraTipo.SelectedIndex == 2)
                            printerType = Vip.Printer.Enums.PrinterType.Bematech;
                        else if (cmbImpressoraTipo.SelectedIndex == 3)
                            printerType = Vip.Printer.Enums.PrinterType.Daruma;

                        Printer printer = new Printer(cmbImpressoraNome.Text, printerType);
                        Comprovante(_documentoVinculado, lstComprovanteCliente, printer);
                        Comprovante(_documentoVinculado, lstComprovanteEstab, printer);
                    }
                }
            }
        }
        private void ExibirMensagem(string _msg, int _tempoMilisegundos = 2000)
        {
            lblMensagem.Invoke((MethodInvoker)delegate
            {
                lblMensagem.Text = _msg;
                lblMensagem.Refresh();
                Thread.Sleep(_tempoMilisegundos);
                if (_tempoMilisegundos > 0)
                {
                    lblMensagem.Text = "";
                    lblMensagem.Refresh();
                }
            });
        }
        private void LimparRetornoTef()
        {
            if (mTefSoftwareExpress.gCupomVenda != null)
                mTefSoftwareExpress.gCupomVenda.Transacoes.Clear();
            mTefSoftwareExpress.gCupomVenda = null;
            mCupomVenda = null;
        }
        private bool VerificarTeclaPressionada(Keys _tecla)
        {
            bool escapePressed = (GetAsyncKeyState((int)_tecla) & 0x8000) != 0;
            if (escapePressed)
                Log.GerarLogProcessoExecucao("ESC Precionado - Operação abortada.");
            return escapePressed;
        }

        public FrmTelaTesteVenda()
        {
            InitializeComponent();
            pnlBody.Enabled = false;
            mTefSoftwareExpress.OnMessageClient += new TefSoftwareExpress.OnMessageClientHandle(MTefSoftwareExpress_OnMessageClient);
            mTefSoftwareExpress.OnCallForm += new TefSoftwareExpress.OnCallFormtHandle(MTefSoftwareExpress_OnCallForm);
            mTefSoftwareExpress.OnCallPanelQrCode += new TefSoftwareExpress.OnCallPanelQrCodeHandle(MTefSoftwareExpress_OnCallPanelQrCode);
            mTefSoftwareExpress.OnClosePanelQrCode += new TefSoftwareExpress.OnClosePanelQrCodeHandle(MTefSoftwareExpress_OnClosePanelQrCode);
        }

        private void MTefSoftwareExpress_OnMessageClient(string _mensagem, int _tempoMiliSegundos, TefFuncaoInterativa _tefFuncaoInterativa = null)
        {
            if (_tefFuncaoInterativa != null)
                _tefFuncaoInterativa.Interromper = VerificarTeclaPressionada(Keys.Escape);

            lblMensagem.Invoke((MethodInvoker)delegate
            {
                lblMensagem.Text = _mensagem;
                lblMensagem.Refresh();
                Thread.Sleep(_tempoMiliSegundos);
            });
        }
        private void MTefSoftwareExpress_OnCallForm(TefFuncaoInterativa _tefFuncaoInterativa)
        {
            if (_tefFuncaoInterativa != null)
            {
                if (_tefFuncaoInterativa.DataType == DataTypeEnum.Await)
                {
                    using (FrmTefAguarde frm = new FrmTefAguarde())
                    {
                        frm.gMensagem = _tefFuncaoInterativa.Mensagem;
                        frm.Focus();
                        frm.ShowDialog();
                    }
                }
                else if (_tefFuncaoInterativa.DataType == DataTypeEnum.Confirmation)
                {
                    if (MessageBox.Show(_tefFuncaoInterativa.Mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        _tefFuncaoInterativa.RespostaSitef = "0";
                    if (_tefFuncaoInterativa.TipoCampo == 5013 && _tefFuncaoInterativa.RespostaSitef == "1")
                        _tefFuncaoInterativa.Interromper = false;
                }
                else if (_tefFuncaoInterativa.DataType == DataTypeEnum.Menu)
                {
                    using (FrmTefMenu frm = new FrmTefMenu())
                    {
                        frm.gTitulo = _tefFuncaoInterativa.Titulo;
                        frm.gItens = _tefFuncaoInterativa.ItensMenu;
                        frm.Focus();
                        frm.ShowDialog();
                        if (frm.DialogResult == DialogResult.OK)
                            _tefFuncaoInterativa.RespostaSitef = (frm.gSelecionado + 1).ToString();
                        else
                            _tefFuncaoInterativa.Interromper = !frm.VoltarSelecionado;
                        _tefFuncaoInterativa.Voltar = frm.VoltarSelecionado;
                    }
                }
                else if (_tefFuncaoInterativa.DataType == DataTypeEnum.Numeric)
                {
                    if (_tefFuncaoInterativa.TipoCampo != 500)
                    {
                        using (FrmTefColetaDados frm = new FrmTefColetaDados())
                        {
                            frm.gTitulo = _tefFuncaoInterativa.Titulo;
                            frm.gTamanhoMinimo = _tefFuncaoInterativa.TamanhoMinimo;
                            frm.gTamanhoMaximo = _tefFuncaoInterativa.TamanhoMaximo;
                            frm.gTipoDeDados = DataTypeEnum.Numeric;
                            frm.Focus();
                            frm.ShowDialog();
                            if (frm.DialogResult == DialogResult.OK)
                                _tefFuncaoInterativa.RespostaSitef = frm.txtDados.Text;
                            else
                                _tefFuncaoInterativa.Interromper = !frm.VoltarSelecionado;
                            _tefFuncaoInterativa.Voltar = frm.VoltarSelecionado;
                        }
                    }
                }
                else if (_tefFuncaoInterativa.DataType == DataTypeEnum.Currency)
                {
                    if (_tefFuncaoInterativa.TipoCampo == 0 || _tefFuncaoInterativa.TipoCampo == 130 || _tefFuncaoInterativa.TipoCampo == 146 || _tefFuncaoInterativa.TipoCampo == 504)
                    {
                        using (FrmTefColetaDados frm = new FrmTefColetaDados())
                        {
                            frm.gTitulo = _tefFuncaoInterativa.Titulo;
                            frm.gTamanhoMinimo = _tefFuncaoInterativa.TamanhoMinimo;
                            frm.gTamanhoMaximo = _tefFuncaoInterativa.TamanhoMaximo;
                            frm.gTipoDeDados = DataTypeEnum.Currency;
                            frm.Focus();
                            frm.ShowDialog();
                            if (frm.DialogResult == DialogResult.OK)
                            {
                                string valorReposta = "";
                                if (!string.IsNullOrWhiteSpace(frm.txtDados.Text) && Convert.ToDecimal(frm.txtDados.Text) > 0)
                                    valorReposta = Convert.ToDecimal(frm.txtDados.Text).ToString("N2");
                                _tefFuncaoInterativa.RespostaSitef = valorReposta;
                            }
                            else
                                _tefFuncaoInterativa.Interromper = !frm.VoltarSelecionado;
                            _tefFuncaoInterativa.Voltar = frm.VoltarSelecionado;
                        }
                    }
                }
                else if (_tefFuncaoInterativa.DataType == DataTypeEnum.QrCode)
                {
                    if (_tefFuncaoInterativa.TipoCampo == 584)
                    {
                        if (!string.IsNullOrWhiteSpace(_tefFuncaoInterativa.Mensagem))
                        {
                            using (FrmTefQrCode frm = new FrmTefQrCode())
                            {
                                frm.gTitulo = _tefFuncaoInterativa.Titulo;
                                frm.gStrQrCode = _tefFuncaoInterativa.Mensagem;
                                frm.Focus();
                                frm.ShowDialog();
                                if (frm.DialogResult == DialogResult.OK)
                                    _tefFuncaoInterativa.RespostaSitef = frm.lblQrCode.Text;
                                else
                                    _tefFuncaoInterativa.Interromper = true;
                            }
                        }
                    }
                }
            }
        }
        private void MTefSoftwareExpress_OnCallPanelQrCode(TefFuncaoInterativa _tefFuncaoInterativa)
        {
            if (!_tefFuncaoInterativa.FormAberto && _tefFuncaoInterativa.DataType == DataTypeEnum.QrCode && _tefFuncaoInterativa.TipoCampo == 584)
            {
                lblMenuTituloQrCode.Invoke((MethodInvoker)delegate
                {
                    lblMenuTituloQrCode.Text = _tefFuncaoInterativa.Titulo;
                    lblMenuTituloQrCode.Refresh();
                });
                lblQrCode.Invoke((MethodInvoker)delegate
                {
                    lblQrCode.ImageAlign = ContentAlignment.MiddleCenter;
                    Image qrCode = Functions.Gerar_QRCode(lblQrCode.Size.Width, lblQrCode.Size.Height, _tefFuncaoInterativa.Mensagem);
                    lblQrCode.Image = qrCode;
                    lblQrCode.Text = "";
                    lblQrCode.Refresh();
                });
                pnlQrCode.BringToFront();
                pnlQrCode.Visible = true;
                pnlQrCode.Refresh();
                _tefFuncaoInterativa.FormAberto = true;
            }
        }
        private void MTefSoftwareExpress_OnClosePanelQrCode(TefFuncaoInterativa _tefFuncaoInterativa)
        {
            if (_tefFuncaoInterativa.FormFechar)
            {
                pnlQrCode.SendToBack();
                pnlQrCode.Visible = false;
                lblMenuTituloQrCode.Text = "";
                lblQrCode.Image = null;
                lblQrCode.Text = "";
                _tefFuncaoInterativa.FormAberto = false;
                _tefFuncaoInterativa.FormFechar = false;
            }
        }

        private void FrmTelaTesteVenda_Load(object sender, EventArgs e)
        {
            CarregarConfiguracao();
            cmbImpressoraTipo.SelectedIndex = 0;
            CarregarImpresorasInstaladas();
        }
        private void FrmTelaTesteVenda_Shown(object sender, EventArgs e)
        {
            ExibirMensagem("Aguarde inicializando TEF-SiTef", 0);
            bkgInicioTef.RunWorkerAsync();
        }
        private void FrmTelaTesteVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (gValorTotalDaTransacao != gValorDasTransacoesEfetuadas)
                {
                    if (MessageBox.Show("Deseja realmente cancelar toda a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        lblMensagem.Text = "Cancelando Transações Pendentes";
                        lblMensagem.Refresh();

                        mTefSoftwareExpress.CancelarTransacaoPendente(txtDocumentoVinculado.Text);

                        LimparRetornoTef();
                        lblMensagem.Text = "";
                        lblMensagem.Refresh();
                        btnDocumentoVinculadoGerar.Enabled = true;
                        txtDocumentoVinculado.ReadOnly = false;
                        txtValorVenda.ReadOnly = false;
                        txtValorVenda.Text = "0,00";
                        txtDocumentoVinculado.Text = "";
                        gValorTotalDaTransacao = 0M;
                        gValorDasTransacoesEfetuadas = 0M;
                    }
                }
            }
        }

        private void btnDocumentoVinculadoGerar_Click(object sender, EventArgs e)
        {
            txtDocumentoVinculado.Text = new Random().Next(999999).ToString("000000");
        }
        private void btnAtv_Click(object sender, EventArgs e)
        {
            ExibirMensagem(mTefSoftwareExpress.MensagemTef(mTefSoftwareExpress.Atv()), 100);
        }
        private void btnCpfCnpj1_Click(object sender, EventArgs e)
        {
            int sts = mTefSoftwareExpress.VerificarPinpad();
            if (sts != 1)
            {
                MessageBox.Show("PinPad não responde.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool pessoaFisica = true;
            bool continua = true;
            MessageBoxManager.Yes = "&1-Cpf";
            MessageBoxManager.No = "&2-Cnpj";
            MessageBoxManager.Cancel = "&Cancelar";
            MessageBoxManager.Register();
            switch (MessageBox.Show("Selecione o Tipo", "Tipo de Captura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Cancel:
                    continua = false;
                    break;
                case DialogResult.No:
                    pessoaFisica = false;
                    break;
                case DialogResult.Yes:
                    break;
            }
            MessageBoxManager.Unregister();

            if (!continua)
                return;

            string msgTela = "Digitar o Cpf no PinPad e Depois Confirmar";
            if (!pessoaFisica)
                msgTela = "Digitar o Cnpj em 2 Partes no PinPad\r\nParte 1: 8 Primeiros Dígitos e Depois Confirmar\r\nParte 2: 6 Últimos Dígitos e Depois Confirmar";

            ExibirMensagem(msgTela, 0);

            string cpfCnpj = mTefSoftwareExpress.CpfCnpjCapturar(pessoaFisica);

            ExibirMensagem("", 0);
            if (!string.IsNullOrWhiteSpace(cpfCnpj))
                MessageBox.Show((pessoaFisica ? "Cpf" : "Cnpj") + " Capturado -> " + cpfCnpj, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCpfCnpj2_Click(object sender, EventArgs e)
        {
            int sts = mTefSoftwareExpress.VerificarPinpad();
            if (sts != 1)
            {
                MessageBox.Show("PinPad não responde.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CampoAberto obj = new CampoAberto();
            bool pessoaFisica = true;
            bool continua = true;

            MessageBoxManager.Yes = "&1-Cpf";
            MessageBoxManager.No = "&2-Cnpj";
            MessageBoxManager.Cancel = "&Cancelar";
            MessageBoxManager.Register();
            switch (MessageBox.Show("Selecione o Tipo", "Tipo de Captura", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Cancel:
                    continua = false;
                    break;
                case DialogResult.No:
                    pessoaFisica = false;
                    obj.MensagemExibidaPinPad = Lib.CliSitef.ConstantValues.MensagemExibidaEnum.DigiteCnpj;
                    obj.TamanhoMinimo = 14;
                    obj.TamanhoMaximo = 14;
                    break;
                case DialogResult.Yes:
                    obj.MensagemExibidaPinPad = Lib.CliSitef.ConstantValues.MensagemExibidaEnum.DigiteCpf;
                    obj.TamanhoMinimo = 11;
                    obj.TamanhoMaximo = 11;
                    break;
            }
            MessageBoxManager.Unregister();

            if (!continua)
                return;

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Lca",
                    DocumentoVinculado = new Random().Next(999999).ToString("000000"),
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            string cpfCnpj = mTefSoftwareExpress.LeituraCampoAberto(obj);
            LimparRetornoTef();
            ExibirMensagem("", 0);
            if (!string.IsNullOrWhiteSpace(cpfCnpj))
                MessageBox.Show((pessoaFisica ? "Cpf" : "Cnpj") + " Capturado -> " + cpfCnpj, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSenha4Dig_Click(object sender, EventArgs e)
        {
            int sts = mTefSoftwareExpress.VerificarPinpad();
            if (sts != 1)
            {
                MessageBox.Show("PinPad não responde.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string msgTela = "Senha 4 Digitos";
            ExibirMensagem(msgTela, 0);

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Lca",
                    DocumentoVinculado = new Random().Next(999999).ToString("000000"),
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            CampoAberto obj = new CampoAberto
            {
                MensagemExibidaPinPad = Lib.CliSitef.ConstantValues.MensagemExibidaEnum.DigiteCodigoSeguranca,
                TamanhoMinimo = 4,
                TamanhoMaximo = 4,
                TempoEsperaInatividade = 0
            };
            string senha = mTefSoftwareExpress.LeituraCampoAberto(obj);
            LimparRetornoTef();
            ExibirMensagem("", 0);
            if (!string.IsNullOrWhiteSpace(senha))
                MessageBox.Show(" Capturado -> " + senha, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAdm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Adm",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.Adm(txtDocumentoVinculado.Text);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
        }
        private void btnRecarga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cel",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.RecargaCelular(txtDocumentoVinculado.Text);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }
        private void btnCorrespondenteBancario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }
            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cbc",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.CorrespondenteBancario(txtDocumentoVinculado.Text);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }
        private void btnRecargaCorrespondenteBancario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }
            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cbc",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.CorrespondenteBancarioRecarga(txtDocumentoVinculado.Text);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }
        private void btnCrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }
            if (Convert.ToDecimal(txtValorVenda.Text) <= 0m)
            {
                MessageBox.Show("Digite o valor da operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorVenda.Focus();
                return;
            }

            gValorTotalDaTransacao = Convert.ToDecimal(txtValorVenda.Text);
            decimal valorParaEstaTransacao = (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas);
            using (FrmConfirmarValor frm = new FrmConfirmarValor(valorParaEstaTransacao))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Cancel)
                    return;

                valorParaEstaTransacao = frm.gValorParaEstaTransacao;
                if (gValorTotalDaTransacao < (gValorDasTransacoesEfetuadas + valorParaEstaTransacao))
                {
                    MessageBox.Show("Valor para finalizar as transações é maior que o valor total da transação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                gValorDasTransacoesEfetuadas += valorParaEstaTransacao;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Crt",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = gValorTotalDaTransacao
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            bool confirmarCnf = gValorTotalDaTransacao == gValorDasTransacoesEfetuadas;
            int sts = mTefSoftwareExpress.Crt(valorParaEstaTransacao, txtDocumentoVinculado.Text, "NomeOperador", _confirmarCnf: confirmarCnf);
            if (sts == 0)
            {
                if (confirmarCnf)
                {
                    ImprimirComprovantes(txtDocumentoVinculado.Text);
                    LimparRetornoTef();
                    lblMensagem.Text = "";
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = true;
                    txtDocumentoVinculado.ReadOnly = false;
                    txtValorVenda.ReadOnly = false;
                    txtValorVenda.Text = "0,00";
                    txtDocumentoVinculado.Text = "";
                    gValorTotalDaTransacao = 0M;
                    gValorDasTransacoesEfetuadas = 0M;
                }
                else
                {
                    lblMensagem.Text = "Falta o pagamento restante de: " + (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas).ToString("C2");
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = false;
                    txtDocumentoVinculado.ReadOnly = true;
                    txtValorVenda.ReadOnly = true;
                }
            }
            else
            {
                if (gValorTotalDaTransacao == gValorDasTransacoesEfetuadas)
                {
                    gValorDasTransacoesEfetuadas = 0M;
                    LimparRetornoTef();
                }
                else
                    gValorDasTransacoesEfetuadas -= valorParaEstaTransacao;
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            }
            txtDocumentoVinculado.Focus();
        }
        private void btnCrtDebito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }
            if (Convert.ToDecimal(txtValorVenda.Text) <= 0m)
            {
                MessageBox.Show("Digite o valor da operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorVenda.Focus();
                return;
            }

            gValorTotalDaTransacao = Convert.ToDecimal(txtValorVenda.Text);

            decimal valorParaEstaTransacao = (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas);
            using (FrmConfirmarValor frm = new FrmConfirmarValor(valorParaEstaTransacao))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Cancel)
                    return;

                valorParaEstaTransacao = frm.gValorParaEstaTransacao;
                if (gValorTotalDaTransacao < (gValorDasTransacoesEfetuadas + valorParaEstaTransacao))
                {
                    MessageBox.Show("Valor para finalizar as transações é maior que o valor total da transação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                gValorDasTransacoesEfetuadas += valorParaEstaTransacao;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Crt",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = gValorTotalDaTransacao
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            bool confirmarCnf = gValorTotalDaTransacao == gValorDasTransacoesEfetuadas;
            int sts = mTefSoftwareExpress.Crt(valorParaEstaTransacao, txtDocumentoVinculado.Text, "NomeOperador", 2, confirmarCnf);
            if (sts == 0)
            {
                if (confirmarCnf)
                {
                    ImprimirComprovantes(txtDocumentoVinculado.Text);
                    LimparRetornoTef();
                    lblMensagem.Text = "";
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = true;
                    txtDocumentoVinculado.ReadOnly = false;
                    txtValorVenda.ReadOnly = false;
                    txtValorVenda.Text = "0,00";
                    txtDocumentoVinculado.Text = "";
                    gValorTotalDaTransacao = 0M;
                    gValorDasTransacoesEfetuadas = 0M;
                }
                else
                {
                    lblMensagem.Text = "Falta o pagamento restante de: " + (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas).ToString("C2");
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = false;
                    txtDocumentoVinculado.ReadOnly = true;
                    txtValorVenda.ReadOnly = true;
                }
            }
            else
            {
                if (gValorTotalDaTransacao == gValorDasTransacoesEfetuadas)
                {
                    gValorDasTransacoesEfetuadas = 0M;
                    LimparRetornoTef();
                }
                else
                    gValorDasTransacoesEfetuadas -= valorParaEstaTransacao;
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            }
            txtDocumentoVinculado.Focus();
        }
        private void btnCrtCredito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }
            if (Convert.ToDecimal(txtValorVenda.Text) <= 0m)
            {
                MessageBox.Show("Digite o valor da operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorVenda.Focus();
                return;
            }

            gValorTotalDaTransacao = Convert.ToDecimal(txtValorVenda.Text);

            decimal valorParaEstaTransacao = (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas);

            using (FrmConfirmarValor frm = new FrmConfirmarValor(valorParaEstaTransacao))
            {
                frm.Focus();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Cancel)
                    return;

                valorParaEstaTransacao = frm.gValorParaEstaTransacao;
                if (gValorTotalDaTransacao < (gValorDasTransacoesEfetuadas + valorParaEstaTransacao))
                {
                    MessageBox.Show("Valor para finalizar as transações é maior que o valor total da transação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                gValorDasTransacoesEfetuadas += valorParaEstaTransacao;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Crt",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = gValorTotalDaTransacao
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            bool confirmarCnf = gValorTotalDaTransacao == gValorDasTransacoesEfetuadas;
            int sts = mTefSoftwareExpress.Crt(valorParaEstaTransacao, txtDocumentoVinculado.Text, "NomeOperador", 3, confirmarCnf);
            if (sts == 0)
            {
                if (confirmarCnf)
                {
                    ImprimirComprovantes(txtDocumentoVinculado.Text);
                    LimparRetornoTef();
                    lblMensagem.Text = "";
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = true;
                    txtDocumentoVinculado.ReadOnly = false;
                    txtValorVenda.ReadOnly = false;
                    txtValorVenda.Text = "0,00";
                    txtDocumentoVinculado.Text = "";
                    gValorTotalDaTransacao = 0M;
                    gValorDasTransacoesEfetuadas = 0M;
                }
                else
                {
                    lblMensagem.Text = "Falta o pagamento restante de: " + (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas).ToString("C2");
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = false;
                    txtDocumentoVinculado.ReadOnly = true;
                    txtValorVenda.ReadOnly = true;
                }
            }
            else
            {
                if (gValorTotalDaTransacao == gValorDasTransacoesEfetuadas)
                {
                    gValorDasTransacoesEfetuadas = 0M;
                    LimparRetornoTef();
                }
                else
                    gValorDasTransacoesEfetuadas -= valorParaEstaTransacao;
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            }
            txtDocumentoVinculado.Focus();
        }
        private void btnCrtCd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }
            if (Convert.ToDecimal(txtValorVenda.Text) <= 0m)
            {
                MessageBox.Show("Digite o valor da operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorVenda.Focus();
                return;
            }

            gValorTotalDaTransacao = Convert.ToDecimal(txtValorVenda.Text);

            decimal valorParaEstaTransacao = (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas);
            using (FrmConfirmarValor frm = new FrmConfirmarValor(valorParaEstaTransacao))
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Cancel)
                    return;

                valorParaEstaTransacao = frm.gValorParaEstaTransacao;
                if (gValorTotalDaTransacao < (gValorDasTransacoesEfetuadas + valorParaEstaTransacao))
                {
                    MessageBox.Show("Valor para finalizar as transações é maior que o valor total da transação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                gValorDasTransacoesEfetuadas += valorParaEstaTransacao;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Crt",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = gValorTotalDaTransacao
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            bool confirmarCnf = gValorTotalDaTransacao == gValorDasTransacoesEfetuadas;
            int sts = mTefSoftwareExpress.Crt(valorParaEstaTransacao, txtDocumentoVinculado.Text, "NomeOperador", 122, confirmarCnf);
            if (sts == 0)
            {
                if (confirmarCnf)
                {
                    ImprimirComprovantes(txtDocumentoVinculado.Text);
                    LimparRetornoTef();
                    lblMensagem.Text = "";
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = true;
                    txtDocumentoVinculado.ReadOnly = false;
                    txtValorVenda.ReadOnly = false;
                    txtValorVenda.Text = "0,00";
                    txtDocumentoVinculado.Text = "";
                    gValorTotalDaTransacao = 0M;
                    gValorDasTransacoesEfetuadas = 0M;
                }
                else
                {
                    lblMensagem.Text = "Falta o pagamento restante de: " + (gValorTotalDaTransacao - gValorDasTransacoesEfetuadas).ToString("C2");
                    lblMensagem.Refresh();
                    btnDocumentoVinculadoGerar.Enabled = false;
                    txtDocumentoVinculado.ReadOnly = true;
                    txtValorVenda.ReadOnly = true;
                }
            }
            else
            {
                if (gValorTotalDaTransacao == gValorDasTransacoesEfetuadas)
                {
                    gValorDasTransacoesEfetuadas = 0M;
                    LimparRetornoTef();
                }
                else
                    gValorDasTransacoesEfetuadas -= valorParaEstaTransacao;
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            }
            txtDocumentoVinculado.Focus();
        }
        private void btnCnc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cnc",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.Cnc(txtDocumentoVinculado.Text, "NomeOperador");
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }
        private void btnCncDebito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cnc",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.Cnc(txtDocumentoVinculado.Text, "NomeOperador", 211);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }
        private void btnCncCredito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cnc",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.Cnc(txtDocumentoVinculado.Text, "NomeOperador", 210);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }
        private void btnCncCd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumentoVinculado.Text) || Convert.ToInt32(txtDocumentoVinculado.Text) <= 0)
            {
                MessageBox.Show("Digite o número do documento vinculado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoVinculado.Focus();
                return;
            }

            if (mCupomVenda == null)
            {
                mCupomVenda = new Cupom
                {
                    TipoOperacao = "Cnc",
                    DocumentoVinculado = txtDocumentoVinculado.Text,
                    ValorTotal = 0
                };
            }
            mTefSoftwareExpress.gCupomVenda = mCupomVenda;

            int sts = mTefSoftwareExpress.Cnc(txtDocumentoVinculado.Text, "NomeOperador", 123);
            if (sts == 0)
            {
                ImprimirComprovantes(txtDocumentoVinculado.Text);
                lblMensagem.Text = "";
                lblMensagem.Refresh();
                txtValorVenda.Text = "0,00";
                txtDocumentoVinculado.Text = "";
            }
            else
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(sts));
            LimparRetornoTef();
            txtDocumentoVinculado.Focus();
        }

        private void bkgInicioTef_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            mStatusTefInicio = mTefSoftwareExpress.InicializarTef(mTefConfig);
        }
        private void bkgInicioTef_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (mStatusTefInicio > 0)
                ExibirMensagem(mTefSoftwareExpress.MensagemTef(mStatusTefInicio), 3000);
            else
                ExibirMensagem("TEF-SiTef inicializado com sucesso", 500);
            pnlBody.Enabled = mStatusTefInicio == 0;
            mStatusTefInicio = 0;
        }
    }
}