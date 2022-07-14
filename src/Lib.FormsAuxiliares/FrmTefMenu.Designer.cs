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
            this.ltbMenuItens.Size = new System.Drawing.Size(483, 374);
            this.ltbMenuItens.TabIndex = 0;
            this.ltbMenuItens.SelectedIndexChanged += new System.EventHandler(this.ltbMenuItens_SelectedIndexChanged);
            this.ltbMenuItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltbMenuItens_KeyDown);
            this.ltbMenuItens.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltbMenuItens_MouseDoubleClick);
            // 
            // FrmTefMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 439);
            this.ControlBox = false;
            this.Controls.Add(this.ltbMenuItens);
            this.Controls.Add(this.lblMenuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmTefMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu TEF";
            this.Load += new System.EventHandler(this.FrmTefMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTefMenu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitulo;
        private System.Windows.Forms.ListBox ltbMenuItens;
    }
}