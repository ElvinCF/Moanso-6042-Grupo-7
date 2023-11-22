namespace Minimarket
{
    partial class MantenedorCategoriaProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbkCategoria = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dgCategoria
            // 
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Location = new System.Drawing.Point(473, 196);
            this.dgCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.RowHeadersWidth = 51;
            this.dgCategoria.RowTemplate.Height = 24;
            this.dgCategoria.Size = new System.Drawing.Size(617, 418);
            this.dgCategoria.TabIndex = 1;
            this.dgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 155);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(202, 250);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(202, 22);
            this.txtDescripcion.TabIndex = 12;
            // 
            // cbkCategoria
            // 
            this.cbkCategoria.AutoSize = true;
            this.cbkCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkCategoria.Location = new System.Drawing.Point(308, 377);
            this.cbkCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkCategoria.Name = "cbkCategoria";
            this.cbkCategoria.Size = new System.Drawing.Size(86, 27);
            this.cbkCategoria.TabIndex = 13;
            this.cbkCategoria.Text = "Estado";
            this.cbkCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(14, 493);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(152, 493);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 32);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(786, 139);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(136, 29);
            this.btnDeshabilitar.TabIndex = 16;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(644, 139);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 29);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(968, 139);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 29);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(308, 490);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(494, 139);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 29);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(202, 53);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(202, 22);
            this.txtCategoria.TabIndex = 23;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.txtCategoria);
            this.groupBoxDatos.Controls.Add(this.cbkCategoria);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.btnCancelar);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.txtDescripcion);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.btnModificar);
            this.groupBoxDatos.Location = new System.Drawing.Point(3, 78);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDatos.Size = new System.Drawing.Size(434, 550);
            this.groupBoxDatos.TabIndex = 24;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "DATOS";
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_titulo.Controls.Add(this.label13);
            this.Pnl_titulo.Controls.Add(this.label5);
            this.Pnl_titulo.Controls.Add(this.label8);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1120, 62);
            this.Pnl_titulo.TabIndex = 268;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label13.Location = new System.Drawing.Point(0, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1120, 4);
            this.label13.TabIndex = 557;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1120, 1);
            this.label5.TabIndex = 262;
            this.label5.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(395, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 33);
            this.label8.TabIndex = 258;
            this.label8.Text = "CATEGORIA PRODUCTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MantenedorCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1120, 639);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.dgCategoria);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorCategoriaProducto";
            this.Text = "CATEGORÍAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbkCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        internal System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label8;
    }
}