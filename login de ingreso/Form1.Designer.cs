namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblFecha = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            lblPrecio = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtCantidad = new TextBox();
            cboTipo = new ComboBox();
            cboProducto = new ComboBox();
            lvVenta = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btmSalir = new Button();
            btmCancelar = new Button();
            btmRegistrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Cascadia Code SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(896, 58);
            label1.TabIndex = 0;
            label1.Text = "Control Registro de Ventas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(583, 78);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 1;
            label2.Text = "Fecha Actual";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(710, 78);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 18);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lblFecha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(cboProducto);
            groupBox1.Location = new Point(12, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(865, 153);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "CONTROL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 19);
            label5.Name = "label5";
            label5.Size = new Size(185, 19);
            label5.TabIndex = 13;
            label5.Text = "Seleccionar Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(571, 53);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(190, 62);
            lblPrecio.TabIndex = 12;
            lblPrecio.Text = "lblPrecio";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(324, 19);
            label7.Name = "label7";
            label7.Size = new Size(77, 18);
            label7.TabIndex = 11;
            label7.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(571, 20);
            label6.Name = "label6";
            label6.Size = new Size(160, 18);
            label6.TabIndex = 10;
            label6.Text = "Precio del Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 79);
            label4.Name = "label4";
            label4.Size = new Size(199, 18);
            label4.TabIndex = 8;
            label4.Text = "Seleccionar tipo de Pago";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(324, 40);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Efectivo ", "Transferencia" });
            cboTipo.Location = new Point(39, 100);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(254, 23);
            cboTipo.TabIndex = 1;
            cboTipo.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Aguardiente 375ml", "Aguardiente 750ml", "Aguardiente 1L", "Ron Caldas 375ml", "Ron Caldas 750ml", "Ron Caldas 1L", "jhonny Walker whisky", "Black and White carterita", "Black and white 1L", "Smirnoff 375ml", "Baileys 700ml", "Passport Scotch 1L", "Something Special 700ml", "Coronita 210ml", "Corona 355ml", "Aguila 1L", "Aguila Ligth", "Aguila ligth 1L", "Poker 1L", "Poker 750ml", "Poker lata", "Aguila lata", "Aguila ligth lata", "Coronita en lata", "Cola y Pola lata", "Botella de agua", "Botella de jugo", "Speed Max lata", "Amper lata", "Coca Cola lata", "Coca Cola botella", "Gateorade botella", "Gaseosa postobon 1L", "Gaseosa postobon medio litro", "Coca Cola 3L", "Pony Malta 1L", "Pony Malta 350ml", "Mr Tea", "Electrolit" });
            cboProducto.Location = new Point(39, 42);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(254, 23);
            cboProducto.TabIndex = 0;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // lvVenta
            // 
            lvVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvVenta.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvVenta.GridLines = true;
            lvVenta.Location = new Point(166, 290);
            lvVenta.Name = "lvVenta";
            lvVenta.Size = new Size(587, 235);
            lvVenta.TabIndex = 4;
            lvVenta.UseCompatibleStateImageBehavior = false;
            lvVenta.View = View.Details;
            lvVenta.SelectedIndexChanged += lvVenta_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PRODUCTO";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CANTIDAD";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PRECIO";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TIPO DE PAGO";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "DESCUENTO";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "RECARGO";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "PRECIO FINAL ";
            columnHeader7.Width = 90;
            // 
            // btmSalir
            // 
            btmSalir.Location = new Point(771, 502);
            btmSalir.Name = "btmSalir";
            btmSalir.Size = new Size(75, 23);
            btmSalir.TabIndex = 5;
            btmSalir.Text = "Salir";
            btmSalir.UseVisualStyleBackColor = true;
            btmSalir.Click += btmSalir_Click;
            // 
            // btmCancelar
            // 
            btmCancelar.Location = new Point(345, 261);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(84, 23);
            btmCancelar.TabIndex = 6;
            btmCancelar.Text = "Cancelar";
            btmCancelar.UseVisualStyleBackColor = true;
            btmCancelar.Click += btmCancelar_Click;
            // 
            // btmRegistrar
            // 
            btmRegistrar.Location = new Point(447, 261);
            btmRegistrar.Name = "btmRegistrar";
            btmRegistrar.Size = new Size(84, 23);
            btmRegistrar.TabIndex = 7;
            btmRegistrar.Text = "Registrar";
            btmRegistrar.UseVisualStyleBackColor = true;
            btmRegistrar.Click += btmRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 532);
            Controls.Add(btmRegistrar);
            Controls.Add(btmCancelar);
            Controls.Add(btmSalir);
            Controls.Add(lvVenta);
            Controls.Add(groupBox1);
            Controls.Add(lblFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Control Registro de Ventas";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private GroupBox groupBox1;
        private TextBox txtCantidad;
        private ComboBox cboTipo;
        private ComboBox cboProducto;
        private ListView lvVenta;
        private Button btmSalir;
        private Button btmCancelar;
        private Label lblPrecio;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button btmRegistrar;
        private Label label5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}