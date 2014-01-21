namespace UI_APLICACION.compra_productos
{
    partial class frmReciboCompra
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
            this.crvCompras = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCompras
            // 
            this.crvCompras.ActiveViewIndex = -1;
            this.crvCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCompras.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCompras.Location = new System.Drawing.Point(0, 0);
            this.crvCompras.Name = "crvCompras";
            this.crvCompras.ShowGroupTreeButton = false;
            this.crvCompras.Size = new System.Drawing.Size(472, 512);
            this.crvCompras.TabIndex = 0;
            this.crvCompras.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReciboCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 512);
            this.Controls.Add(this.crvCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmReciboCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recibo de Compra";
            this.Load += new System.EventHandler(this.frmReciboCompra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCompras;

    }
}