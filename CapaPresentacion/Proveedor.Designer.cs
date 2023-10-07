namespace CapaPresentacion
{
    partial class Proveedor
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
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnCerrarProductos = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtnombreProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lvlNombreVendedor = new System.Windows.Forms.Label();
            this.txtID_proveedor = new System.Windows.Forms.TextBox();
            this.lvlID = new System.Windows.Forms.Label();
            this.btnLimpiartxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(525, 131);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(134, 40);
            this.btnEliminarProveedor.TabIndex = 8;
            this.btnEliminarProveedor.Text = "ELIMINAR";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarProveedor.BackColor = System.Drawing.Color.Firebrick;
            this.btnActualizarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProveedor.Location = new System.Drawing.Point(525, 72);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(134, 40);
            this.btnActualizarProveedor.TabIndex = 7;
            this.btnActualizarProveedor.Text = "ACTUALIZAR";
            this.btnActualizarProveedor.UseVisualStyleBackColor = false;
            this.btnActualizarProveedor.Click += new System.EventHandler(this.btnActualizarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgregarProveedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(525, 12);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(134, 40);
            this.btnAgregarProveedor.TabIndex = 6;
            this.btnAgregarProveedor.Text = "AGREGAR";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnCerrarProductos
            // 
            this.btnCerrarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProductos.Location = new System.Drawing.Point(631, 389);
            this.btnCerrarProductos.Name = "btnCerrarProductos";
            this.btnCerrarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarProductos.TabIndex = 5;
            this.btnCerrarProductos.Text = "Salir";
            this.btnCerrarProductos.UseVisualStyleBackColor = true;
            this.btnCerrarProductos.Click += new System.EventHandler(this.btnCerrarProductos_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 12);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(449, 400);
            this.dgvProveedores.TabIndex = 9;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // txtnombreProveedor
            // 
            this.txtnombreProveedor.Location = new System.Drawing.Point(504, 235);
            this.txtnombreProveedor.Name = "txtnombreProveedor";
            this.txtnombreProveedor.Size = new System.Drawing.Size(177, 20);
            this.txtnombreProveedor.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(504, 282);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(177, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(504, 325);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(177, 20);
            this.txtNombreVendedor.TabIndex = 12;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.BackColor = System.Drawing.Color.LightCoral;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(523, 216);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(139, 16);
            this.lblNombreProveedor.TabIndex = 13;
            this.lblNombreProveedor.Text = "Nombre Proveedor";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.LightCoral;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(558, 263);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 16);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // lvlNombreVendedor
            // 
            this.lvlNombreVendedor.AutoSize = true;
            this.lvlNombreVendedor.BackColor = System.Drawing.Color.LightCoral;
            this.lvlNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNombreVendedor.Location = new System.Drawing.Point(525, 306);
            this.lvlNombreVendedor.Name = "lvlNombreVendedor";
            this.lvlNombreVendedor.Size = new System.Drawing.Size(134, 16);
            this.lvlNombreVendedor.TabIndex = 15;
            this.lvlNombreVendedor.Text = "Nombre Vendedor";
            // 
            // txtID_proveedor
            // 
            this.txtID_proveedor.Enabled = false;
            this.txtID_proveedor.Location = new System.Drawing.Point(572, 186);
            this.txtID_proveedor.Name = "txtID_proveedor";
            this.txtID_proveedor.Size = new System.Drawing.Size(75, 20);
            this.txtID_proveedor.TabIndex = 16;
            // 
            // lvlID
            // 
            this.lvlID.AutoSize = true;
            this.lvlID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlID.Location = new System.Drawing.Point(543, 187);
            this.lvlID.Name = "lvlID";
            this.lvlID.Size = new System.Drawing.Size(22, 16);
            this.lvlID.TabIndex = 17;
            this.lvlID.Text = "ID";
            // 
            // btnLimpiartxt
            // 
            this.btnLimpiartxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiartxt.Location = new System.Drawing.Point(555, 351);
            this.btnLimpiartxt.Name = "btnLimpiartxt";
            this.btnLimpiartxt.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiartxt.TabIndex = 19;
            this.btnLimpiartxt.Text = "Limpiar";
            this.btnLimpiartxt.UseVisualStyleBackColor = true;
            this.btnLimpiartxt.Click += new System.EventHandler(this.btnLimpiartxt_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(718, 424);
            this.Controls.Add(this.btnLimpiartxt);
            this.Controls.Add(this.lvlID);
            this.Controls.Add(this.txtID_proveedor);
            this.Controls.Add(this.lvlNombreVendedor);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtnombreProveedor);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnActualizarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnCerrarProductos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnActualizarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnCerrarProductos;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtnombreProveedor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lvlNombreVendedor;
        private System.Windows.Forms.TextBox txtID_proveedor;
        private System.Windows.Forms.Label lvlID;
        private System.Windows.Forms.Button btnLimpiartxt;
    }
}