namespace Lib.FormsAuxiliares
{
    partial class FrmTefColetaDados
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
            this.lblMenuTitulo = new System.Windows.Forms.Label();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(466, 65);
            this.lblMenuTitulo.TabIndex = 1;
            this.lblMenuTitulo.Text = "[lblMenuTitulo]";
            this.lblMenuTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDados
            // 
            this.txtDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDados.Location = new System.Drawing.Point(6, 84);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(454, 49);
            this.txtDados.TabIndex = 0;
            this.txtDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDados_KeyDown);
            // 
            // FrmTefColetaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 145);
            this.ControlBox = false;
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.lblMenuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmTefColetaDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coleta de Dados";
            this.Load += new System.EventHandler(this.FrmTefColetaDados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTefColetaDados_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitulo;
        public System.Windows.Forms.TextBox txtDados;
    }
}