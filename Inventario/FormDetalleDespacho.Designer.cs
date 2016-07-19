namespace Inventario
{
    partial class FormDetalleDespacho
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.labelNombreDocumento = new System.Windows.Forms.Label();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionProducto,
            this.Codigo,
            this.Cantidad,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(39, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo Cliente:";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.Location = new System.Drawing.Point(172, 35);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(0, 13);
            this.labelNumeroDocumento.TabIndex = 4;
            // 
            // labelNombreDocumento
            // 
            this.labelNombreDocumento.AutoSize = true;
            this.labelNombreDocumento.Location = new System.Drawing.Point(175, 68);
            this.labelNombreDocumento.Name = "labelNombreDocumento";
            this.labelNombreDocumento.Size = new System.Drawing.Size(0, 13);
            this.labelNombreDocumento.TabIndex = 5;
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Location = new System.Drawing.Point(175, 106);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(0, 13);
            this.labelCodigoCliente.TabIndex = 6;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(385, 35);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(79, 13);
            this.labelN.TabIndex = 7;
            this.labelN.Text = "Nombre Cliente";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(483, 35);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(0, 13);
            this.labelNombreCliente.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(604, 329);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(130, 32);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionProducto.HeaderText = "Descripción Producto";
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // FormDetalleDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 373);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelCodigoCliente);
            this.Controls.Add(this.labelNombreDocumento);
            this.Controls.Add(this.labelNumeroDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDetalleDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Despacho";
            this.Load += new System.EventHandler(this.FormDetalleDespacho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.Label labelNombreDocumento;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}