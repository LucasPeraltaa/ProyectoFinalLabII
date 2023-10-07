namespace CapaPresentacion
{
    partial class Origen
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
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblIDorigen = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtIDorigen = new System.Windows.Forms.TextBox();
            this.btnEliminarOrigen = new System.Windows.Forms.Button();
            this.btnActualizarOrigen = new System.Windows.Forms.Button();
            this.btnAgregarOrigen = new System.Windows.Forms.Button();
            this.dgvOrigen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(72, 63);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(53, 16);
            this.lblOrigen.TabIndex = 17;
            this.lblOrigen.Text = "Origen";
            // 
            // lblIDorigen
            // 
            this.lblIDorigen.AutoSize = true;
            this.lblIDorigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDorigen.Location = new System.Drawing.Point(60, 35);
            this.lblIDorigen.Name = "lblIDorigen";
            this.lblIDorigen.Size = new System.Drawing.Size(22, 16);
            this.lblIDorigen.TabIndex = 16;
            this.lblIDorigen.Text = "ID";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(254, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 29);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(30, 82);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(144, 20);
            this.txtOrigen.TabIndex = 14;
            // 
            // txtIDorigen
            // 
            this.txtIDorigen.Enabled = false;
            this.txtIDorigen.Location = new System.Drawing.Point(88, 31);
            this.txtIDorigen.Name = "txtIDorigen";
            this.txtIDorigen.Size = new System.Drawing.Size(64, 20);
            this.txtIDorigen.TabIndex = 13;
            // 
            // btnEliminarOrigen
            // 
            this.btnEliminarOrigen.Location = new System.Drawing.Point(208, 77);
            this.btnEliminarOrigen.Name = "btnEliminarOrigen";
            this.btnEliminarOrigen.Size = new System.Drawing.Size(87, 29);
            this.btnEliminarOrigen.TabIndex = 12;
            this.btnEliminarOrigen.Text = "Eliminar";
            this.btnEliminarOrigen.UseVisualStyleBackColor = true;
            this.btnEliminarOrigen.Click += new System.EventHandler(this.btnEliminarOrigen_Click);
            // 
            // btnActualizarOrigen
            // 
            this.btnActualizarOrigen.Location = new System.Drawing.Point(208, 42);
            this.btnActualizarOrigen.Name = "btnActualizarOrigen";
            this.btnActualizarOrigen.Size = new System.Drawing.Size(87, 29);
            this.btnActualizarOrigen.TabIndex = 11;
            this.btnActualizarOrigen.Text = "Actualizar";
            this.btnActualizarOrigen.UseVisualStyleBackColor = true;
            this.btnActualizarOrigen.Click += new System.EventHandler(this.btnActualizarOrigen_Click);
            // 
            // btnAgregarOrigen
            // 
            this.btnAgregarOrigen.Location = new System.Drawing.Point(208, 7);
            this.btnAgregarOrigen.Name = "btnAgregarOrigen";
            this.btnAgregarOrigen.Size = new System.Drawing.Size(87, 29);
            this.btnAgregarOrigen.TabIndex = 10;
            this.btnAgregarOrigen.Text = "Agregar";
            this.btnAgregarOrigen.UseVisualStyleBackColor = true;
            this.btnAgregarOrigen.Click += new System.EventHandler(this.btnAgregarOrigen_Click);
            // 
            // dgvOrigen
            // 
            this.dgvOrigen.AllowUserToAddRows = false;
            this.dgvOrigen.AllowUserToDeleteRows = false;
            this.dgvOrigen.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigen.Location = new System.Drawing.Point(6, 129);
            this.dgvOrigen.Name = "dgvOrigen";
            this.dgvOrigen.Size = new System.Drawing.Size(300, 150);
            this.dgvOrigen.TabIndex = 9;
            this.dgvOrigen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrigen_CellClick);
           // this.dgvOrigen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrigen_CellContentClick);
            // 
            // Origen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(313, 321);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblIDorigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtIDorigen);
            this.Controls.Add(this.btnEliminarOrigen);
            this.Controls.Add(this.btnActualizarOrigen);
            this.Controls.Add(this.btnAgregarOrigen);
            this.Controls.Add(this.dgvOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Origen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Origen";
            this.Load += new System.EventHandler(this.Origen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblIDorigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtIDorigen;
        private System.Windows.Forms.Button btnEliminarOrigen;
        private System.Windows.Forms.Button btnActualizarOrigen;
        private System.Windows.Forms.Button btnAgregarOrigen;
        private System.Windows.Forms.DataGridView dgvOrigen;
    }
}