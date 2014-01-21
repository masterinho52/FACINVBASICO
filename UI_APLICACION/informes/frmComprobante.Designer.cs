namespace UI_APLICACION.informes
{
    partial class frmComprobante
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
            this.crystalDocumentos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalDocumentos
            // 
            this.crystalDocumentos.ActiveViewIndex = -1;
            this.crystalDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalDocumentos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalDocumentos.Location = new System.Drawing.Point(0, 0);
            this.crystalDocumentos.Name = "crystalDocumentos";
            this.crystalDocumentos.Size = new System.Drawing.Size(513, 481);
            this.crystalDocumentos.TabIndex = 0;
            this.crystalDocumentos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 481);
            this.Controls.Add(this.crystalDocumentos);
            this.Name = "frmComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmComprobante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalDocumentos;
    }
}