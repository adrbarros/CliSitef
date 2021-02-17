using System;
using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    public partial class FrmTefAguarde : Form
    {
        public string gMensagem { get; set; }

        public FrmTefAguarde()
        {
            InitializeComponent();
        }

        private void FrmTefAguarde_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = gMensagem;
        }
        private void FrmTefAguarde_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
