using Lib.Utils.Classes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    public partial class FrmTefQrCode : Form
    {
        public string gTitulo { get; set; }
        public string gStrQrCode { get; set; }

        bool EnterOuEscPrecionado { get; set; }

        async void ControlarTempoParaFechamento()
        {
            if (!EnterOuEscPrecionado)
            {
                int count = 30;
                while (count > 0)
                {
                    try
                    {
                        lblTempoTela.Invoke((MethodInvoker)delegate
                        {
                            lblTempoTela.Text = count.ToString() + " segundos";
                            lblTempoTela.Refresh();
                        });
                    }
                    catch { }
                    count--;
                    await Task.Delay(1000);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public FrmTefQrCode()
        {
            InitializeComponent();
        }

        private void FrmTefQrCode_Load(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = gTitulo;
            lblQrCode.ImageAlign = ContentAlignment.MiddleCenter;
            Image qrCode = Functions.Gerar_QRCode(lblQrCode.Size.Width - 2, lblQrCode.Size.Height - 2, gStrQrCode);
            lblQrCode.Image = qrCode;
            lblQrCode.Text = "";
            ControlarTempoParaFechamento();
        }
        private void FrmTefQrCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterOuEscPrecionado = true;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                EnterOuEscPrecionado = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}