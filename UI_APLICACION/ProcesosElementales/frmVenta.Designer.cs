namespace UI_APLICACION.ProcesosElementales
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductosAgregados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetallesPago = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnRetirarProductoAgregado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelarProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTipoProceso = new System.Windows.Forms.Label();
            this.chkDetallesPago = new System.Windows.Forms.CheckBox();
            this.chkProductosAgregados = new System.Windows.Forms.CheckBox();
            this.chkPedidoRegistrado = new System.Windows.Forms.CheckBox();
            this.chkClienteRegistrado = new System.Windows.Forms.CheckBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductosAgregados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 366);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Agregados:";
            // 
            // dgvProductosAgregados
            // 
            this.dgvProductosAgregados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAgregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosAgregados.Location = new System.Drawing.Point(3, 16);
            this.dgvProductosAgregados.Name = "dgvProductosAgregados";
            this.dgvProductosAgregados.Size = new System.Drawing.Size(1062, 347);
            this.dgvProductosAgregados.TabIndex = 0;
            this.dgvProductosAgregados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosAgregados_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarProducto,
            this.btnRegistrarCliente,
            this.btnDetallesPago});
            this.menuStrip1.Location = new System.Drawing.Point(3, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.ShortcutKeyDisplayString = "F1";
            this.btnAgregarProducto.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnAgregarProducto.Size = new System.Drawing.Size(137, 28);
            this.btnAgregarProducto.Text = "PRODUCTO [F1]";
            this.btnAgregarProducto.Click += new System.EventHandler(this.productoF1ToolStripMenuItem_Click);
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.btnRegistrarCliente.Size = new System.Drawing.Size(214, 28);
            this.btnRegistrarCliente.Text = "REGISTRO DE CLIENTE [F2]";
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnDetallesPago
            // 
            this.btnDetallesPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDetallesPago.Name = "btnDetallesPago";
            this.btnDetallesPago.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.btnDetallesPago.Size = new System.Drawing.Size(172, 28);
            this.btnDetallesPago.Text = "DETALLES PAGO [F3]";
            this.btnDetallesPago.Click += new System.EventHandler(this.btnDetallesPago_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.menuStrip2);
            this.groupBox3.Location = new System.Drawing.Point(18, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 58);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRetirarProductoAgregado,
            this.btnCancelarProceso,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(539, 39);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnRetirarProductoAgregado
            // 
            this.btnRetirarProductoAgregado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRetirarProductoAgregado.Name = "btnRetirarProductoAgregado";
            this.btnRetirarProductoAgregado.Size = new System.Drawing.Size(262, 35);
            this.btnRetirarProductoAgregado.Text = "RETIRAR PRODUCTO AGREGADO";
            this.btnRetirarProductoAgregado.Click += new System.EventHandler(this.btnRetirarProductoAgregado_Click);
            // 
            // btnCancelarProceso
            // 
            this.btnCancelarProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelarProceso.Name = "btnCancelarProceso";
            this.btnCancelarProceso.Size = new System.Drawing.Size(102, 35);
            this.btnCancelarProceso.Text = "CANCELAR";
            this.btnCancelarProceso.Click += new System.EventHandler(this.btnCancelarProceso_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 35);
            this.toolStripMenuItem1.Text = "REFERENCIA";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 35);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 35);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 35);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPagar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(731, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 114);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(19, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Q. ";
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPagar.Location = new System.Drawing.Point(71, 53);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(64, 20);
            this.lblPagar.TabIndex = 1;
            this.lblPagar.Text = "0.0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "TOTAL A CANCELAR:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTipoProceso);
            this.groupBox5.Controls.Add(this.chkDetallesPago);
            this.groupBox5.Controls.Add(this.chkProductosAgregados);
            this.groupBox5.Controls.Add(this.chkPedidoRegistrado);
            this.groupBox5.Controls.Add(this.chkClienteRegistrado);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 502);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1065, 48);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalles del Proceso";
            // 
            // lblTipoProceso
            // 
            this.lblTipoProceso.AutoSize = true;
            this.lblTipoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoProceso.Location = new System.Drawing.Point(701, 16);
            this.lblTipoProceso.Name = "lblTipoProceso";
            this.lblTipoProceso.Size = new System.Drawing.Size(57, 20);
            this.lblTipoProceso.TabIndex = 11;
            this.lblTipoProceso.Text = "label1";
            this.lblTipoProceso.Visible = false;
            // 
            // chkDetallesPago
            // 
            this.chkDetallesPago.AutoSize = true;
            this.chkDetallesPago.Enabled = false;
            this.chkDetallesPago.Location = new System.Drawing.Point(540, 19);
            this.chkDetallesPago.Name = "chkDetallesPago";
            this.chkDetallesPago.Size = new System.Drawing.Size(122, 17);
            this.chkDetallesPago.TabIndex = 10;
            this.chkDetallesPago.Text = "Detalles de pago";
            this.chkDetallesPago.UseVisualStyleBackColor = true;
            // 
            // chkProductosAgregados
            // 
            this.chkProductosAgregados.AutoSize = true;
            this.chkProductosAgregados.Enabled = false;
            this.chkProductosAgregados.Location = new System.Drawing.Point(152, 19);
            this.chkProductosAgregados.Name = "chkProductosAgregados";
            this.chkProductosAgregados.Size = new System.Drawing.Size(146, 17);
            this.chkProductosAgregados.TabIndex = 3;
            this.chkProductosAgregados.Text = "Productos agregados";
            this.chkProductosAgregados.UseVisualStyleBackColor = true;
            // 
            // chkPedidoRegistrado
            // 
            this.chkPedidoRegistrado.AutoSize = true;
            this.chkPedidoRegistrado.Enabled = false;
            this.chkPedidoRegistrado.Location = new System.Drawing.Point(304, 20);
            this.chkPedidoRegistrado.Name = "chkPedidoRegistrado";
            this.chkPedidoRegistrado.Size = new System.Drawing.Size(209, 17);
            this.chkPedidoRegistrado.TabIndex = 2;
            this.chkPedidoRegistrado.Text = "Referencia de Pedido registrado";
            this.chkPedidoRegistrado.UseVisualStyleBackColor = true;
            this.chkPedidoRegistrado.Visible = false;
            // 
            // chkClienteRegistrado
            // 
            this.chkClienteRegistrado.AutoSize = true;
            this.chkClienteRegistrado.Enabled = false;
            this.chkClienteRegistrado.Location = new System.Drawing.Point(9, 19);
            this.chkClienteRegistrado.Name = "chkClienteRegistrado";
            this.chkClienteRegistrado.Size = new System.Drawing.Size(125, 17);
            this.chkClienteRegistrado.TabIndex = 1;
            this.chkClienteRegistrado.Text = "Cliente registrado";
            this.chkClienteRegistrado.UseVisualStyleBackColor = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistar.Image")));
            this.btnRegistar.Location = new System.Drawing.Point(957, 21);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(120, 102);
            this.btnRegistar.TabIndex = 10;
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNoDocumento);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSerie);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(569, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 115);
            this.panel2.TabIndex = 9;
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Enabled = false;
            this.txtNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNoDocumento.Location = new System.Drawing.Point(26, 74);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(100, 22);
            this.txtNoDocumento.TabIndex = 3;
            this.txtNoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. DOCUMENTO";
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSerie.Location = new System.Drawing.Point(26, 30);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 22);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERIE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(986, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registrar";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PROCESO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVenta_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVenta_FormClosed);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem btnRegistrarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnRetirarProductoAgregado;
        private System.Windows.Forms.ToolStripMenuItem btnCancelarProceso;
        private System.Windows.Forms.ToolStripMenuItem btnDetallesPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRegistar;
        public System.Windows.Forms.DataGridView dgvProductosAgregados;
        public System.Windows.Forms.Label lblPagar;
        public System.Windows.Forms.Label lblTipoProceso;
        public System.Windows.Forms.CheckBox chkClienteRegistrado;
        public System.Windows.Forms.CheckBox chkPedidoRegistrado;
        public System.Windows.Forms.CheckBox chkProductosAgregados;
        public System.Windows.Forms.CheckBox chkDetallesPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNoDocumento;
        public System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label5;
    }
}