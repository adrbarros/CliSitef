namespace Lib.FormsAuxiliares
{
    partial class FrmConfirmarValor
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
            this.txtValorVenda = new TextBoxCurrency.TextBoxCurrency();
            this.SuspendLayout();
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtValorVenda.DecimalPlaces = 2;
            this.txtValorVenda.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.ForeColorDefined = System.Drawing.Color.Empty;
            this.txtValorVenda.Location = new System.Drawing.Point(30, 14);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(115, 26);
            this.txtValorVenda.TabIndex = 0;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmConfirmarValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 52);
            this.ControlBox = false;
            this.Controls.Add(this.txtValorVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmConfirmarValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Valor para esta transação";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConfirmarValor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxCurrency.TextBoxCurrency txtValorVenda;
    }
}