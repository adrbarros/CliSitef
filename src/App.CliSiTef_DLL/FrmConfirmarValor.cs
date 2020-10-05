using System;
using System.Windows.Forms;

namespace App.CliSiTef_DLL
{
    public partial class FrmConfirmarValor : Form
    {
        public decimal gValorParaEstaTransacao { get; set; }

        public FrmConfirmarValor(decimal _valorTransacao)
        {
            InitializeComponent();
            txtValorVenda.Text = _valorTransacao.ToString("N2");
        }

        private void FrmConfirmarValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToDecimal(txtValorVenda.Text) <= 0)
                    return;

                gValorParaEstaTransacao = Convert.ToDecimal(txtValorVenda.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
