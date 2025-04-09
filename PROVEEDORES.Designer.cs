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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPROVEEDORES)).BeginInit();
            this.GBCLIENTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPROVEEDORES
            // 
            this.DGVPROVEEDORES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPROVEEDORES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPROVEEDORES.Location = new System.Drawing.Point(36, 339);
            this.DGVPROVEEDORES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVPROVEEDORES.Name = "DGVPROVEEDORES";
            this.DGVPROVEEDORES.RowHeadersWidth = 51;
            this.DGVPROVEEDORES.RowTemplate.Height = 24;
            this.DGVPROVEEDORES.Size = new System.Drawing.Size(752, 170);
            this.DGVPROVEEDORES.TabIndex = 7;
            this.DGVPROVEEDORES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPROVEEDORES_CellClick);
            // 
            // GBCLIENTE
            // 
            this.GBCLIENTE.BackColor = System.Drawing.Color.SandyBrown;
            this.GBCLIENTE.Controls.Add(this.TXTTELEFONOPROVE);
            this.GBCLIENTE.Controls.Add(this.TXTNOMBREPROVE);
            this.GBCLIENTE.Controls.Add(this.TXTIDPROVEEDOR);
            this.GBCLIENTE.Controls.Add(this.label7);
            this.GBCLIENTE.Controls.Add(this.label5);
            this.GBCLIENTE.Controls.Add(this.label2);
            this.GBCLIENTE.Controls.Add(this.label3);
            this.GBCLIENTE.Controls.Add(this.label1);
            this.GBCLIENTE.Location = new System.Drawing.Point(36, 93);
            this.GBCLIENTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCLIENTE.Name = "GBCLIENTE";
            this.GBCLIENTE.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCLIENTE.Size = new System.Drawing.Size(543, 209);
            this.GBCLIENTE.TabIndex = 10;
            this.GBCLIENTE.TabStop = false;
            this.GBCLIENTE.Text = "REGISTRO PROVEEDOR";
            this.GBCLIENTE.Enter += new System.EventHandler(this.GBCLIENTE_Enter);
            // 
            // BTNAGREGARPROVE
            // 
            this.BTNAGREGARPROVE.BackColor = System.Drawing.Color.Chocolate;
            this.BTNAGREGARPROVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARPROVE.Location = new System.Drawing.Point(631, 93);
            this.BTNAGREGARPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARPROVE.Name = "BTNAGREGARPROVE";
            this.BTNAGREGARPROVE.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARPROVE.TabIndex = 4;
            this.BTNAGREGARPROVE.Text = "AGREGAR";
            this.BTNAGREGARPROVE.UseVisualStyleBackColor = false;
            this.BTNAGREGARPROVE.Click += new System.EventHandler(this.BTNAGREGARPROVE_Click);
            // 
            // BTNELIMINARPROVE
            // 
            this.BTNELIMINARPROVE.BackColor = System.Drawing.Color.Chocolate;
            this.BTNELIMINARPROVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARPROVE.Location = new System.Drawing.Point(631, 171);
            this.BTNELIMINARPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARPROVE.Name = "BTNELIMINARPROVE";
            this.BTNELIMINARPROVE.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARPROVE.TabIndex = 5;
            this.BTNELIMINARPROVE.Text = "ELIMINAR";
            this.BTNELIMINARPROVE.UseVisualStyleBackColor = false;
            this.BTNELIMINARPROVE.Click += new System.EventHandler(this.BTNELIMINARPROVE_Click);
            // 
            // BTNACTUALIZARPROVE
            // 
            this.BTNACTUALIZARPROVE.BackColor = System.Drawing.Color.Chocolate;
            this.BTNACTUALIZARPROVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARPROVE.Location = new System.Drawing.Point(631, 250);
            this.BTNACTUALIZARPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARPROVE.Name = "BTNACTUALIZARPROVE";
            this.BTNACTUALIZARPROVE.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARPROVE.TabIndex = 6;
            this.BTNACTUALIZARPROVE.Text = "ACTUALIZAR";
            this.BTNACTUALIZARPROVE.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARPROVE.Click += new System.EventHandler(this.BTNACTUALIZARPROVE_Click);
            // 
            // TXTTELEFONOPROVE
            // 
            this.TXTTELEFONOPROVE.Location = new System.Drawing.Point(190, 168);
            this.TXTTELEFONOPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTTELEFONOPROVE.Name = "TXTTELEFONOPROVE";
            this.TXTTELEFONOPROVE.Size = new System.Drawing.Size(317, 23);
            this.TXTTELEFONOPROVE.TabIndex = 3;
            // 
            // TXTNOMBREPROVE
            // 
            this.TXTNOMBREPROVE.Location = new System.Drawing.Point(190, 109);
            this.TXTNOMBREPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNOMBREPROVE.Name = "TXTNOMBREPROVE";
            this.TXTNOMBREPROVE.Size = new System.Drawing.Size(317, 23);
            this.TXTNOMBREPROVE.TabIndex = 2;
            // 
            // TXTIDPROVEEDOR
            // 
            this.TXTIDPROVEEDOR.Location = new System.Drawing.Point(190, 55);
            this.TXTIDPROVEEDOR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDPROVEEDOR.Name = "TXTIDPROVEEDOR";
            this.TXTIDPROVEEDOR.Size = new System.Drawing.Size(317, 23);
            this.TXTIDPROVEEDOR.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID PROVEEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(285, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(375, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "REGISTRO DE PROVEEDORES ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnVOLVER
            // 
            this.btnVOLVER.BackColor = System.Drawing.Color.Transparent;
            this.btnVOLVER.BackgroundImage = global::FERRETERIAPROYECTO.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btnVOLVER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVOLVER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVOLVER.FlatAppearance.BorderSize = 0;
            this.btnVOLVER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVOLVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOLVER.ForeColor = System.Drawing.Color.Red;
            this.btnVOLVER.Location = new System.Drawing.Point(65, 29);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(49, 39);
            this.btnVOLVER.TabIndex = 20;
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // PROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(813, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.BTNACTUALIZARPROVE);
            this.Controls.Add(this.BTNELIMINARPROVE);
            this.Controls.Add(this.BTNAGREGARPROVE);
            this.Controls.Add(this.GBCLIENTE);
            this.Controls.Add(this.DGVPROVEEDORES);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVOLVER;
    }
}