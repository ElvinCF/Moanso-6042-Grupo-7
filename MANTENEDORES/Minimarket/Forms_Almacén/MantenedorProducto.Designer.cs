namespace Minimarket
{
    partial class MantenedorProducto
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
            this.components = new System.ComponentModel.Container();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cbkProducto = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupBoxProducto.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(447, 161);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.Size = new System.Drawing.Size(804, 390);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(479, 105);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 33);
            this.btnNuevo.TabIndex = 558;
            this.btnNuevo.Text = "Nuevo Producto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(671, 105);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 33);
            this.button4.TabIndex = 559;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(862, 105);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 33);
            this.button5.TabIndex = 560;
            this.button5.Text = "Deshabilitar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 437);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 41);
            this.btnAgregar.TabIndex = 562;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(135, 437);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 41);
            this.btnModificar.TabIndex = 563;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(293, 436);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 42);
            this.btnCancelar.TabIndex = 564;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.label9);
            this.groupBoxProducto.Controls.Add(this.cbkProducto);
            this.groupBoxProducto.Controls.Add(this.txtStock);
            this.groupBoxProducto.Controls.Add(this.txtCategoria);
            this.groupBoxProducto.Controls.Add(this.dtpFecha);
            this.groupBoxProducto.Controls.Add(this.txtPrecio);
            this.groupBoxProducto.Controls.Add(this.txtDescripcion);
            this.groupBoxProducto.Controls.Add(this.txtNombre);
            this.groupBoxProducto.Controls.Add(this.txtProducto);
            this.groupBoxProducto.Controls.Add(this.label7);
            this.groupBoxProducto.Controls.Add(this.label6);
            this.groupBoxProducto.Controls.Add(this.label10);
            this.groupBoxProducto.Controls.Add(this.label3);
            this.groupBoxProducto.Controls.Add(this.label4);
            this.groupBoxProducto.Controls.Add(this.label1);
            this.groupBoxProducto.Controls.Add(this.label2);
            this.groupBoxProducto.Controls.Add(this.btnCancelar);
            this.groupBoxProducto.Controls.Add(this.btnModificar);
            this.groupBoxProducto.Controls.Add(this.btnAgregar);
            this.groupBoxProducto.Location = new System.Drawing.Point(12, 69);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProducto.Size = new System.Drawing.Size(413, 482);
            this.groupBoxProducto.TabIndex = 565;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Datos del Producto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(25, 360);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(379, 22);
            this.dtpFecha.TabIndex = 576;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(157, 209);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(195, 38);
            this.txtPrecio.TabIndex = 574;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 166);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(195, 22);
            this.txtDescripcion.TabIndex = 573;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 121);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 572;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(157, 36);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(195, 22);
            this.txtProducto.TabIndex = 571;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 570;
            this.label7.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 569;
            this.label6.Text = "Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 25);
            this.label10.TabIndex = 568;
            this.label10.Text = "Fecha Vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 568;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 567;
            this.label4.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 566;
            this.label1.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(448, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 32);
            this.label8.TabIndex = 258;
            this.label8.Text = "ADMINISTRAR PRODUCTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1251, 1);
            this.label5.TabIndex = 262;
            this.label5.Text = "label5";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Location = new System.Drawing.Point(0, 59);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1251, 4);
            this.label13.TabIndex = 557;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pnl_titulo.Controls.Add(this.label8);
            this.Pnl_titulo.Controls.Add(this.label13);
            this.Pnl_titulo.Controls.Add(this.label5);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1251, 63);
            this.Pnl_titulo.TabIndex = 268;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1053, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 69);
            this.button1.TabIndex = 566;
            this.button1.Text = "Administrar Categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(157, 79);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(195, 22);
            this.txtCategoria.TabIndex = 577;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(157, 272);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(195, 22);
            this.txtStock.TabIndex = 578;
            // 
            // cbkProducto
            // 
            this.cbkProducto.AutoSize = true;
            this.cbkProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkProducto.Location = new System.Drawing.Point(308, 310);
            this.cbkProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkProducto.Name = "cbkProducto";
            this.cbkProducto.Size = new System.Drawing.Size(96, 26);
            this.cbkProducto.TabIndex = 579;
            this.cbkProducto.Text = "Estado";
            this.cbkProducto.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(171, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 24);
            this.label9.TabIndex = 580;
            this.label9.Text = "s/.";
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.Pnl_titulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorProducto";
            this.Text = "PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtProducto;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.CheckBox cbkProducto;
        internal System.Windows.Forms.Label label9;
    }
}

