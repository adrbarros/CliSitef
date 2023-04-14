namespace Lib.FormsAuxiliares
{
    partial class FrmTefMenu
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
            this.ltbMenuItens = new System.Windows.Forms.ListBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuTitulo
            // 
            this.lblMenuTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblMenuTitulo.Name = "lblMenuTitulo";
            this.lblMenuTitulo.Size = new System.Drawing.Size(483, 65);
            this.lblMenuTitulo.TabIndex = 1;
            this.lblMenuTitulo.Text = "[lblMenuTitulo]";
            this.lblMenuTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ltbMenuItens
            // 
            this.ltbMenuItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbMenuItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbMenuItens.FormattingEnabled = true;
            this.ltbMenuItens.ItemHeight = 16;
            this.ltbMenuItens.Location = new System.Drawing.Point(0, 65);
            this.ltbMenuItens.Name = "ltbMenuItens";
            this.ltbMenuItens.Size = new System.Drawing.Size(483, 326);
            this.ltbMenuItens.TabIndex = 0;
            this.ltbMenuItens.SelectedIndexChanged += new System.EventHandler(this.ltbMenuItens_SelectedIndexChanged);
            this.ltbMenuItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltbMenuItens_KeyDown);
            this.ltbMenuItens.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltbMenuItens_MouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnVoltar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 391);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(483, 48);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(74, 24);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmTefMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 439);
            this.ControlBox = false;
            this.Controls.Add(this.ltbMenuItens);
            this.Controls.Add(this.lblMenuTitulo);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmTefMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu TEF";
            this.Load += new System.EventHandler(this.FrmTefMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTefMenu_KeyDown);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitulo;
        private System.Windows.Forms.ListBox ltbMenuItens;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnVoltar;
    }
}