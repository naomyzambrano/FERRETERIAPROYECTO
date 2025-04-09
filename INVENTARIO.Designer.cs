namespace FERRETERIAPROYECTO
{
    partial class INVENTARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTARIO));
            this.GBINVENTARIO = new System.Windows.Forms.GroupBox();
            this.CMBIDPRODUINVE = new System.Windows.Forms.ComboBox();
            this.TXTSTOCKMIN = new System.Windows.Forms.TextBox();
            this.CMBSALIDAINV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NUPCANTIDADINV = new System.Windows.Forms.NumericUpDown();
            this.BTNAGREGARINV = new System.Windows.Forms.Button();
            this.BTNELIMINARINV = new System.Windows.Forms.Button();
            this.BTNACTUALIZARINV = new System.Windows.Forms.Button();
            this.TXTUBIINV = new System.Windows.Forms.TextBox();
            this.TXTIDINVENTARIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFECHAINV = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVINVENTARIO = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.GBINVENTARIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADINV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVINVENTARIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBINVENTARIO
            // 
            this.GBINVENTARIO.BackColor = System.Drawing.Color.SandyBrown;
            this.GBINVENTARIO.Controls.Add(this.CMBIDPRODUINVE);
            this.GBINVENTARIO.Controls.Add(this.TXTSTOCKMIN);
            this.GBINVENTARIO.Controls.Add(this.CMBSALIDAINV);
            this.GBINVENTARIO.Controls.Add(this.label8);
            this.GBINVENTARIO.Controls.Add(this.NUPCANTIDADINV);
            this.GBINVENTARIO.Controls.Add(this.TXTUBIINV);
            this.GBINVENTARIO.Controls.Add(this.TXTIDINVENTARIO);
            this.GBINVENTARIO.Controls.Add(this.label7);
            this.GBINVENTARIO.Controls.Add(this.label6);
            this.GBINVENTARIO.Controls.Add(this.label5);
            this.GBINVENTARIO.Controls.Add(this.label4);
            this.GBINVENTARIO.Controls.Add(this.label2);
            this.GBINVENTARIO.Controls.Add(this.DTPFECHAINV);
            this.GBINVENTARIO.Controls.Add(this.label3);
            this.GBINVENTARIO.Controls.Add(this.label1);
            this.GBINVENTARIO.Location = new System.Drawing.Point(18, 98);
            this.GBINVENTARIO.Margin = new System.Windows.Forms.Padding(2);
            this.GBINVENTARIO.Name = "GBINVENTARIO";
            this.GBINVENTARIO.Padding = new System.Windows.Forms.Padding(2);
            this.GBINVENTARIO.Size = new System.Drawing.Size(799, 235);
            this.GBINVENTARIO.TabIndex = 9;
            this.GBINVENTARIO.TabStop = false;
            this.GBINVENTARIO.Text = "REGISTRO INVENTARIO";
            this.GBINVENTARIO.Enter += new System.EventHandler(this.GBINVENTARIO_Enter);
            // 
            // CMBIDPRODUINVE
            // 
            this.CMBIDPRODUINVE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBIDPRODUINVE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBIDPRODUINVE.FormattingEnabled = true;
            this.CMBIDPRODUINVE.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO",
            "ENCARGADO DE ALMACÉN"});
            this.CMBIDPRODUINVE.Location = new System.Drawing.Point(128, 85);
            this.CMBIDPRODUINVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBIDPRODUINVE.Name = "CMBIDPRODUINVE";
            this.CMBIDPRODUINVE.Size = new System.Drawing.Size(237, 21);
            this.CMBIDPRODUINVE.TabIndex = 2;
            // 
            // TXTSTOCKMIN
            // 
            this.TXTSTOCKMIN.Location = new System.Drawing.Point(484, 85);
            this.TXTSTOCKMIN.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSTOCKMIN.Name = "TXTSTOCKMIN";
            this.TXTSTOCKMIN.Size = new System.Drawing.Size(239, 20);
            this.TXTSTOCKMIN.TabIndex = 6;
            this.TXTSTOCKMIN.TextChanged += new System.EventHandler(this.TXTSTOCKMIN_TextChanged);
            // 
            // CMBSALIDAINV
            // 
            this.CMBSALIDAINV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBSALIDAINV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBSALIDAINV.FormattingEnabled = true;
            this.CMBSALIDAINV.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO",
            "ENCARGADO DE ALMACÉN"});
            this.CMBSALIDAINV.Location = new System.Drawing.Point(484, 136);
            this.CMBSALIDAINV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBSALIDAINV.Name = "CMBSALIDAINV";
            this.CMBSALIDAINV.Size = new System.Drawing.Size(237, 21);
            this.CMBSALIDAINV.TabIndex = 7;
            this.CMBSALIDAINV.SelectedIndexChanged += new System.EventHandler(this.CMBSALIDAINV_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "SALIDAS";
            // 
            // NUPCANTIDADINV
            // 
            this.NUPCANTIDADINV.Location = new System.Drawing.Point(127, 145);
            this.NUPCANTIDADINV.Margin = new System.Windows.Forms.Padding(2);
            this.NUPCANTIDADINV.Name = "NUPCANTIDADINV";
            this.NUPCANTIDADINV.Size = new System.Drawing.Size(238, 20);
            this.NUPCANTIDADINV.TabIndex = 3;
            // 
            // BTNAGREGARINV
            // 
            this.BTNAGREGARINV.BackColor = System.Drawing.Color.Chocolate;
            this.BTNAGREGARINV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAGREGARINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGARINV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARINV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAGREGARINV.ImageKey = "(ninguno)";
            this.BTNAGREGARINV.Location = new System.Drawing.Point(400, 353);
            this.BTNAGREGARINV.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAGREGARINV.Name = "BTNAGREGARINV";
            this.BTNAGREGARINV.Size = new System.Drawing.Size(118, 42);
            this.BTNAGREGARINV.TabIndex = 9;
            this.BTNAGREGARINV.Text = "AGREGAR";
            this.BTNAGREGARINV.UseVisualStyleBackColor = false;
            this.BTNAGREGARINV.Click += new System.EventHandler(this.BTNAGREGARINV_Click);
            // 
            // BTNELIMINARINV
            // 
            this.BTNELIMINARINV.BackColor = System.Drawing.Color.Chocolate;
            this.BTNELIMINARINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINARINV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARINV.Location = new System.Drawing.Point(536, 352);
            this.BTNELIMINARINV.Margin = new System.Windows.Forms.Padding(2);
            this.BTNELIMINARINV.Name = "BTNELIMINARINV";
            this.BTNELIMINARINV.Size = new System.Drawing.Size(118, 42);
            this.BTNELIMINARINV.TabIndex = 10;
            this.BTNELIMINARINV.Text = "ELIMINAR";
            this.BTNELIMINARINV.UseVisualStyleBackColor = false;
            this.BTNELIMINARINV.Click += new System.EventHandler(this.BTNELIMINARINV_Click);
            // 
            // BTNACTUALIZARINV
            // 
            this.BTNACTUALIZARINV.BackColor = System.Drawing.Color.Chocolate;
            this.BTNACTUALIZARINV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZARINV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARINV.Location = new System.Drawing.Point(668, 352);
            this.BTNACTUALIZARINV.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACTUALIZARINV.Name = "BTNACTUALIZARINV";
            this.BTNACTUALIZARINV.Size = new System.Drawing.Size(118, 42);
            this.BTNACTUALIZARINV.TabIndex = 11;
            this.BTNACTUALIZARINV.Text = "ACTUALIZAR";
            this.BTNACTUALIZARINV.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARINV.Click += new System.EventHandler(this.BTNACTUALIZARINV_Click);
            // 
            // TXTUBIINV
            // 
            this.TXTUBIINV.Location = new System.Drawing.Point(125, 191);
            this.TXTUBIINV.Margin = new System.Windows.Forms.Padding(2);
            this.TXTUBIINV.Name = "TXTUBIINV";
            this.TXTUBIINV.Size = new System.Drawing.Size(596, 20);
            this.TXTUBIINV.TabIndex = 4;
            // 
            // TXTIDINVENTARIO
            // 
            this.TXTIDINVENTARIO.Location = new System.Drawing.Point(127, 41);
            this.TXTIDINVENTARIO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTIDINVENTARIO.Name = "TXTIDINVENTARIO";
            this.TXTIDINVENTARIO.Size = new System.Drawing.Size(239, 20);
            this.TXTIDINVENTARIO.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CANTIDAD ACTUAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "UBICACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOCK MINIMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID INVENTARIO";
            // 
            // DTPFECHAINV
            // 
            this.DTPFECHAINV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAINV.Location = new System.Drawing.Point(482, 35);
            this.DTPFECHAINV.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFECHAINV.Name = "DTPFECHAINV";
            this.DTPFECHAINV.Size = new System.Drawing.Size(239, 20);
            this.DTPFECHAINV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-73, -4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // DGVINVENTARIO
            // 
            this.DGVINVENTARIO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVINVENTARIO.Location = new System.Drawing.Point(18, 417);
            this.DGVINVENTARIO.Margin = new System.Windows.Forms.Padding(2);
            this.DGVINVENTARIO.Name = "DGVINVENTARIO";
            this.DGVINVENTARIO.RowHeadersWidth = 51;
            this.DGVINVENTARIO.RowTemplate.Height = 24;
            this.DGVINVENTARIO.Size = new System.Drawing.Size(799, 131);
            this.DGVINVENTARIO.TabIndex = 8;
            this.DGVINVENTARIO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVINVENTARIO_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(417, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "INVENTARIO";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label15.Click += new System.EventHandler(this.label15_Click);
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
            this.btnVOLVER.Location = new System.Drawing.Point(29, 30);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(49, 39);
            this.btnVOLVER.TabIndex = 20;
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // INVENTARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(833, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.DGVINVENTARIO);
            this.Controls.Add(this.GBINVENTARIO);
            this.Controls.Add(this.BTNACTUALIZARINV);
            this.Controls.Add(this.BTNELIMINARINV);
            this.Controls.Add(this.BTNAGREGARINV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "INVENTARIO";
            this.Text = "INVENTARIO";
            this.Load += new System.EventHandler(this.INVENTARIO_Load);
            this.GBINVENTARIO.ResumeLayout(false);
            this.GBINVENTARIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADINV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVINVENTARIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBINVENTARIO;
        private System.Windows.Forms.Button BTNAGREGARINV;
        private System.Windows.Forms.Button BTNELIMINARINV;
        private System.Windows.Forms.Button BTNACTUALIZARINV;
        private System.Windows.Forms.TextBox TXTUBIINV;
        private System.Windows.Forms.TextBox TXTIDINVENTARIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFECHAINV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBSALIDAINV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUPCANTIDADINV;
        private System.Windows.Forms.DataGridView DGVINVENTARIO;
        private System.Windows.Forms.TextBox TXTSTOCKMIN;
        private System.Windows.Forms.ComboBox CMBIDPRODUINVE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVOLVER;
    }
}