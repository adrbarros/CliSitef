namespace App.CliSiTef_DLL
{
    partial class FrmTefQrCode
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
            this.lblQrCode = new System.Windows.Forms.Label();
            this.lblMenuTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQrCode
            // 
            this.lblQrCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblQrCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQrCode.Location = new System.Drawing.Point(0, 50);
            this.lblQrCode.Name = "lblQrCode";
            this.lblQrCode.Size = new System.Drawing.Size(180, 180);
            this.lblQrCode.TabIndex = 0;
            this.lblQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenuTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(180, 50);
            this.lblMenuTitulo.TabIndex = 1;
            this.lblMenuTitulo.Text = "[lblMenuTitulo]";
            this.lblMenuTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTefQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 230);
            this.ControlBox = false;
            this.Controls.Add(this.lblQrCode);
            this.Controls.Add(this.lblMenuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmTefQrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteiras Digitais (QrCode)";
            this.Load += new System.EventHandler(this.FrmTefQrCode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTefQrCode_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblQrCode;
        private System.Windows.Forms.Label lblMenuTitulo;
    }
}