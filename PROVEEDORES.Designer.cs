namespace FERRETERIAPROYECTO
{
    partial class PROVEEDORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PROVEEDORES));
            this.DGVPROVEEDORES = new System.Windows.Forms.DataGridView();
            this.GBCLIENTE = new System.Windows.Forms.GroupBox();
            this.BTNAGREGARPROVE = new System.Windows.Forms.Button();
            this.BTNELIMINARPROVE = new System.Windows.Forms.Button();
            this.BTNACTUALIZARPROVE = new System.Windows.Forms.Button();
            this.TXTTELEFONOPROVE = new System.Windows.Forms.TextBox();
            this.TXTNOMBREPROVE = new System.Windows.Forms.TextBox();
            this.TXTIDPROVEEDOR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).BeginInit();
            this.GBCLIENTE.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVPROVEEDORES
            // 
            this.DGVPROVEEDORES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPROVEEDORES.Location = new System.Drawing.Point(29, 292);
            this.DGVPROVEEDORES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVPROVEEDORES.Name = "DGVPROVEEDORES";
            this.DGVPROVEEDORES.RowHeadersWidth = 51;
            this.DGVPROVEEDORES.RowTemplate.Height = 24;
            this.DGVPROVEEDORES.Size = new System.Drawing.Size(1085, 170);
            this.DGVPROVEEDORES.TabIndex = 0;
            this.DGVPROVEEDORES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPROVEEDORES_CellClick);
            // 
            // GBCLIENTE
            // 
            this.GBCLIENTE.Controls.Add(this.BTNAGREGARPROVE);
            this.GBCLIENTE.Controls.Add(this.BTNELIMINARPROVE);
            this.GBCLIENTE.Controls.Add(this.BTNACTUALIZARPROVE);
            this.GBCLIENTE.Controls.Add(this.TXTTELEFONOPROVE);
            this.GBCLIENTE.Controls.Add(this.TXTNOMBREPROVE);
            this.GBCLIENTE.Controls.Add(this.TXTIDPROVEEDOR);
            this.GBCLIENTE.Controls.Add(this.label7);
            this.GBCLIENTE.Controls.Add(this.label5);
            this.GBCLIENTE.Controls.Add(this.label2);
            this.GBCLIENTE.Controls.Add(this.label3);
            this.GBCLIENTE.Controls.Add(this.label1);
            this.GBCLIENTE.Location = new System.Drawing.Point(29, 27);
            this.GBCLIENTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCLIENTE.Name = "GBCLIENTE";
            this.GBCLIENTE.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCLIENTE.Size = new System.Drawing.Size(1085, 249);
            this.GBCLIENTE.TabIndex = 10;
            this.GBCLIENTE.TabStop = false;
            this.GBCLIENTE.Text = "REGISTRO PROVEEDOR";
            this.GBCLIENTE.Enter += new System.EventHandler(this.GBCLIENTE_Enter);
            // 
            // BTNAGREGARPROVE
            // 
            this.BTNAGREGARPROVE.BackColor = System.Drawing.Color.DarkGreen;
            this.BTNAGREGARPROVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARPROVE.Location = new System.Drawing.Point(543, 110);
            this.BTNAGREGARPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARPROVE.Name = "BTNAGREGARPROVE";
            this.BTNAGREGARPROVE.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARPROVE.TabIndex = 3;
            this.BTNAGREGARPROVE.Text = "AGREGAR";
            this.BTNAGREGARPROVE.UseVisualStyleBackColor = false;
            this.BTNAGREGARPROVE.Click += new System.EventHandler(this.BTNAGREGARPROVE_Click);
            // 
            // BTNELIMINARPROVE
            // 
            this.BTNELIMINARPROVE.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARPROVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARPROVE.Location = new System.Drawing.Point(723, 110);
            this.BTNELIMINARPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARPROVE.Name = "BTNELIMINARPROVE";
            this.BTNELIMINARPROVE.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARPROVE.TabIndex = 2;
            this.BTNELIMINARPROVE.Text = "ELIMINAR";
            this.BTNELIMINARPROVE.UseVisualStyleBackColor = false;
            this.BTNELIMINARPROVE.Click += new System.EventHandler(this.BTNELIMINARPROVE_Click);
            // 
            // BTNACTUALIZARPROVE
            // 
            this.BTNACTUALIZARPROVE.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARPROVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARPROVE.Location = new System.Drawing.Point(909, 110);
            this.BTNACTUALIZARPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARPROVE.Name = "BTNACTUALIZARPROVE";
            this.BTNACTUALIZARPROVE.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARPROVE.TabIndex = 1;
            this.BTNACTUALIZARPROVE.Text = "ACTUALIZAR";
            this.BTNACTUALIZARPROVE.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARPROVE.Click += new System.EventHandler(this.BTNACTUALIZARPROVE_Click);
            // 
            // TXTTELEFONOPROVE
            // 
            this.TXTTELEFONOPROVE.Location = new System.Drawing.Point(152, 174);
            this.TXTTELEFONOPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTTELEFONOPROVE.Name = "TXTTELEFONOPROVE";
            this.TXTTELEFONOPROVE.Size = new System.Drawing.Size(317, 23);
            this.TXTTELEFONOPROVE.TabIndex = 18;
            // 
            // TXTNOMBREPROVE
            // 
            this.TXTNOMBREPROVE.Location = new System.Drawing.Point(152, 110);
            this.TXTNOMBREPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNOMBREPROVE.Name = "TXTNOMBREPROVE";
            this.TXTNOMBREPROVE.Size = new System.Drawing.Size(317, 23);
            this.TXTNOMBREPROVE.TabIndex = 15;
            // 
            // TXTIDPROVEEDOR
            // 
            this.TXTIDPROVEEDOR.Location = new System.Drawing.Point(152, 53);
            this.TXTIDPROVEEDOR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDPROVEEDOR.Name = "TXTIDPROVEEDOR";
            this.TXTIDPROVEEDOR.Size = new System.Drawing.Size(317, 23);
            this.TXTIDPROVEEDOR.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID PROVEEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-97, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // PROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1147, 492);
            this.Controls.Add(this.GBCLIENTE);
            this.Controls.Add(this.DGVPROVEEDORES);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PROVEEDORES";
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.PROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).EndInit();
            this.GBCLIENTE.ResumeLayout(false);
            this.GBCLIENTE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPROVEEDORES;
        private System.Windows.Forms.GroupBox GBCLIENTE;
        private System.Windows.Forms.Button BTNAGREGARPROVE;
        private System.Windows.Forms.Button BTNELIMINARPROVE;
        private System.Windows.Forms.Button BTNACTUALIZARPROVE;
        private System.Windows.Forms.TextBox TXTTELEFONOPROVE;
        private System.Windows.Forms.TextBox TXTNOMBREPROVE;
        private System.Windows.Forms.TextBox TXTIDPROVEEDOR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}