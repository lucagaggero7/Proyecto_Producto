namespace Productos_FE
{
    partial class FrmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.CargaProductos = new System.Windows.Forms.TabPage();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.MovimientoProductos = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.lblStockMov = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.RadioButton();
            this.btnIngreso = new System.Windows.Forms.RadioButton();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcionMov = new System.Windows.Forms.Label();
            this.lblCodigoMov = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorStockInicial = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.errorCodigo1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabProductos.SuspendLayout();
            this.CargaProductos.SuspendLayout();
            this.MovimientoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(486, 120);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.CargaProductos);
            this.tabProductos.Controls.Add(this.MovimientoProductos);
            this.tabProductos.Location = new System.Drawing.Point(40, 54);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(677, 186);
            this.tabProductos.TabIndex = 4;
            // 
            // CargaProductos
            // 
            this.CargaProductos.BackColor = System.Drawing.Color.Lavender;
            this.CargaProductos.Controls.Add(this.txtStockInicial);
            this.CargaProductos.Controls.Add(this.lblStockInicial);
            this.CargaProductos.Controls.Add(this.btnBorrar);
            this.CargaProductos.Controls.Add(this.btnBuscar);
            this.CargaProductos.Controls.Add(this.txtDescripcion);
            this.CargaProductos.Controls.Add(this.txtCodigo);
            this.CargaProductos.Controls.Add(this.label1);
            this.CargaProductos.Controls.Add(this.btnCargar);
            this.CargaProductos.Controls.Add(this.label2);
            this.CargaProductos.Location = new System.Drawing.Point(4, 22);
            this.CargaProductos.Name = "CargaProductos";
            this.CargaProductos.Padding = new System.Windows.Forms.Padding(3);
            this.CargaProductos.Size = new System.Drawing.Size(669, 160);
            this.CargaProductos.TabIndex = 0;
            this.CargaProductos.Text = "Carga de Productos";
            this.CargaProductos.Click += new System.EventHandler(this.CargaProductos_Click);
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(130, 117);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(161, 20);
            this.txtStockInicial.TabIndex = 10;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(51, 120);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(65, 13);
            this.lblStockInicial.TabIndex = 9;
            this.lblStockInicial.Text = "Stock Inicial";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(567, 120);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(405, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(161, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(130, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(161, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // MovimientoProductos
            // 
            this.MovimientoProductos.BackColor = System.Drawing.Color.Lavender;
            this.MovimientoProductos.Controls.Add(this.btnBuscar1);
            this.MovimientoProductos.Controls.Add(this.label4);
            this.MovimientoProductos.Controls.Add(this.label3);
            this.MovimientoProductos.Controls.Add(this.txtCodigo1);
            this.MovimientoProductos.Controls.Add(this.lblStockMov);
            this.MovimientoProductos.Controls.Add(this.btnAceptar);
            this.MovimientoProductos.Controls.Add(this.btnSalida);
            this.MovimientoProductos.Controls.Add(this.btnIngreso);
            this.MovimientoProductos.Controls.Add(this.txtCantidad);
            this.MovimientoProductos.Controls.Add(this.lblCantidad);
            this.MovimientoProductos.Controls.Add(this.lblDescripcionMov);
            this.MovimientoProductos.Controls.Add(this.lblCodigoMov);
            this.MovimientoProductos.Location = new System.Drawing.Point(4, 22);
            this.MovimientoProductos.Name = "MovimientoProductos";
            this.MovimientoProductos.Padding = new System.Windows.Forms.Padding(3);
            this.MovimientoProductos.Size = new System.Drawing.Size(669, 160);
            this.MovimientoProductos.TabIndex = 1;
            this.MovimientoProductos.Text = "Movimiento de Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stock Actual";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(142, 29);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(53, 20);
            this.txtCodigo1.TabIndex = 8;
            this.txtCodigo1.TextChanged += new System.EventHandler(this.txtCodigo1_TextChanged);
            // 
            // lblStockMov
            // 
            this.lblStockMov.AutoSize = true;
            this.lblStockMov.Location = new System.Drawing.Point(139, 83);
            this.lblStockMov.Name = "lblStockMov";
            this.lblStockMov.Size = new System.Drawing.Size(68, 13);
            this.lblStockMov.TabIndex = 7;
            this.lblStockMov.Text = "Stock Actual";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(458, 117);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.AutoSize = true;
            this.btnSalida.Location = new System.Drawing.Point(473, 88);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(54, 17);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.TabStop = true;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            // 
            // btnIngreso
            // 
            this.btnIngreso.AutoSize = true;
            this.btnIngreso.Checked = true;
            this.btnIngreso.Location = new System.Drawing.Point(473, 65);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(60, 17);
            this.btnIngreso.TabIndex = 4;
            this.btnIngreso.TabStop = true;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(180, 120);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(56, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(125, 123);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcionMov
            // 
            this.lblDescripcionMov.AutoSize = true;
            this.lblDescripcionMov.Location = new System.Drawing.Point(139, 60);
            this.lblDescripcionMov.Name = "lblDescripcionMov";
            this.lblDescripcionMov.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionMov.TabIndex = 1;
            this.lblDescripcionMov.Text = "Descripcion";
            // 
            // lblCodigoMov
            // 
            this.lblCodigoMov.AutoSize = true;
            this.lblCodigoMov.Location = new System.Drawing.Point(60, 60);
            this.lblCodigoMov.Name = "lblCodigoMov";
            this.lblCodigoMov.Size = new System.Drawing.Size(63, 13);
            this.lblCodigoMov.TabIndex = 0;
            this.lblCodigoMov.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(40, 255);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 157);
            this.dataGridView1.TabIndex = 5;
            // 
            // errorCodigo
            // 
            this.errorCodigo.ContainerControl = this;
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // errorStockInicial
            // 
            this.errorStockInicial.ContainerControl = this;
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Location = new System.Drawing.Point(377, 117);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar1.TabIndex = 11;
            this.btnBuscar1.Text = "BUSCAR";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // errorCodigo1
            // 
            this.errorCodigo1.ContainerControl = this;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Productos_FE.Properties.Resources._4248dc2842854731abc80bee7ecb1346;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabProductos);
            this.Name = "FrmProductos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.Click += new System.EventHandler(this.FrmProductos_Click);
            this.tabProductos.ResumeLayout(false);
            this.CargaProductos.ResumeLayout(false);
            this.CargaProductos.PerformLayout();
            this.MovimientoProductos.ResumeLayout(false);
            this.MovimientoProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage CargaProductos;
        private System.Windows.Forms.TabPage MovimientoProductos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton btnSalida;
        private System.Windows.Forms.RadioButton btnIngreso;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcionMov;
        private System.Windows.Forms.Label lblCodigoMov;
        private System.Windows.Forms.Label lblStockMov;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorCodigo;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.ErrorProvider errorStockInicial;
        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.ErrorProvider errorCodigo1;
    }
}

