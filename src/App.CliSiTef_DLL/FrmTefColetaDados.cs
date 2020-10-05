using App.CliSiTef_DLL.Classes;
using System;
using System.Windows.Forms;

namespace App.CliSiTef_DLL
{
    public partial class FrmTefColetaDados : Form
    {
        public string gTitulo { get; set; }
        public int gTamanhoMinimo { get; set; }
        public int gTamanhoMaximo { get; set; }
        public DataTypeEnum gTipoDeDados { get; set; }

        public FrmTefColetaDados()
        {
            InitializeComponent();
        }

        private void TxtDadosNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }
        private void TxtDadosCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
                e.Handled = true;
        }

        private void FrmTefColetaDados_Load(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = gTitulo;
            txtDados.MaxLength = gTamanhoMaximo;
            if (gTipoDeDados == DataTypeEnum.Numeric)
                txtDados.KeyPress += TxtDadosNumeric_KeyPress;
            else if (gTipoDeDados == DataTypeEnum.Currency)
                txtDados.KeyPress += TxtDadosCurrency_KeyPress;
        }
        private void FrmTefColetaDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void txtDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDados.Text.Length < gTamanhoMinimo || txtDados.Text.Length > gTamanhoMinimo)
                return;
            if (gTipoDeDados == DataTypeEnum.Currency && !string.IsNullOrWhiteSpace(txtDados.Text))
            {
                if (!decimal.TryParse(txtDados.Text, out _))
                    return;
            }
        }
    }
}
