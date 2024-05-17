using System;
using System.Windows.Forms;

namespace Lib.FormsAuxiliares
{
    public partial class FrmTefMenu : Form
    {
        public string gTitulo { get; set; }
        public string[] gItens { get; set; }
        public int gSelecionado { get; set; }
        public bool VoltarSelecionado { get; set; }

        public FrmTefMenu()
        {
            InitializeComponent();
        }

        private void FrmTefMenu_Load(object sender, EventArgs e)
        {
            lblMenuTitulo.Text = gTitulo;
            foreach (string texto in gItens)
            {
                if (!string.IsNullOrWhiteSpace(texto))
                    ltbMenuItens.Items.Add(texto);
            }

            if (ltbMenuItens.Items.Count >= 0)
                ltbMenuItens.SelectedIndex = 0;
        }
        private void FrmTefMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void ltbMenuItens_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ltbMenuItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void ltbMenuItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            gSelecionado = ltbMenuItens.SelectedIndex;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarSelecionado = true;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}