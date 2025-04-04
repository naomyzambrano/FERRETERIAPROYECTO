namespace FERRETERIAPROYECTO
{
    partial class VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VENTAS));
            this.GBVENTA = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTDESCUENTOV = new System.Windows.Forms.TextBox();
            this.CANTIDAD = new System.Windows.Forms.Label();
            this.TXTISVVENTA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CMBIDPRODUCTOVENTA = new System.Windows.Forms.ComboBox();
            this.TXTSUBTOTALV = new System.Windows.Forms.TextBox();
            this.TXTTOTALVENTA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTPRECIOUDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTCANTIDADDV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBNO0 = new System.Windows.Forms.RadioButton();
            this.RBSI1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.CMBMETODO = new System.Windows.Forms.ComboBox();
            this.EMPLEADO = new System.Windows.Forms.Label();
            this.TXTIDVENTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBIDEMPLEADOV = new System.Windows.Forms.ComboBox();
            this.DTPVENTA = new System.Windows.Forms.DateTimePicker();
            this.CMBIDCLIENTEV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNAGREGARVENTA = new System.Windows.Forms.Button();
            this.BTNELIMINARVENTA = new System.Windows.Forms.Button();
            this.BTNACTUALIZARVENTA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVVENTA = new System.Windows.Forms.DataGridView();
            this.GBVENTA.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBVENTA
            // 
            this.GBVENTA.Controls.Add(this.groupBox2);
            this.GBVENTA.Controls.Add(this.groupBox1);
            this.GBVENTA.Controls.Add(this.BTNAGREGARVENTA);
            this.GBVENTA.Controls.Add(this.BTNELIMINARVENTA);
            this.GBVENTA.Controls.Add(this.BTNACTUALIZARVENTA);
            this.GBVENTA.Controls.Add(this.label8);
            this.GBVENTA.Controls.Add(this.label1);
            this.GBVENTA.Location = new System.Drawing.Point(20, 30);
            this.GBVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBVENTA.Name = "GBVENTA";
            this.GBVENTA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBVENTA.Size = new System.Drawing.Size(1093, 504);
            this.GBVENTA.TabIndex = 11;
            this.GBVENTA.TabStop = false;
            this.GBVENTA.Text = "REGISTRO VENTA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTDESCUENTOV);
            this.groupBox2.Controls.Add(this.CANTIDAD);
            this.groupBox2.Controls.Add(this.TXTISVVENTA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CMBIDPRODUCTOVENTA);
            this.groupBox2.Controls.Add(this.TXTSUBTOTALV);
            this.groupBox2.Controls.Add(this.TXTTOTALVENTA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TXTPRECIOUDV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXTCANTIDADDV);
            this.groupBox2.Location = new System.Drawing.Point(24, 207);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1052, 225);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMACION PRODUCTO";
            // 
            // TXTDESCUENTOV
            // 
            this.TXTDESCUENTOV.Location = new System.Drawing.Point(696, 74);
            this.TXTDESCUENTOV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTDESCUENTOV.Name = "TXTDESCUENTOV";
            this.TXTDESCUENTOV.Size = new System.Drawing.Size(317, 26);
            this.TXTDESCUENTOV.TabIndex = 12;
            this.TXTDESCUENTOV.TextChanged += new System.EventHandler(this.TXTDESCUENTOV_TextChanged);
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSize = true;
            this.CANTIDAD.Location = new System.Drawing.Point(57, 98);
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Size = new System.Drawing.Size(101, 20);
            this.CANTIDAD.TabIndex = 37;
            this.CANTIDAD.Text = "CANTIDAD";
            this.CANTIDAD.Click += new System.EventHandler(this.CANTIDAD_Click);
            // 
            // TXTISVVENTA
            // 
            this.TXTISVVENTA.Location = new System.Drawing.Point(696, 124);
            this.TXTISVVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTISVVENTA.Name = "TXTISVVENTA";
            this.TXTISVVENTA.Size = new System.Drawing.Size(317, 26);
            this.TXTISVVENTA.TabIndex = 13;
            this.TXTISVVENTA.TextChanged += new System.EventHandler(this.TXTISVVENTA_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "ISV";
            // 
            // CMBIDPRODUCTOVENTA
            // 
            this.CMBIDPRODUCTOVENTA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBIDPRODUCTOVENTA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBIDPRODUCTOVENTA.FormattingEnabled = true;
            this.CMBIDPRODUCTOVENTA.Location = new System.Drawing.Point(173, 39);
            this.CMBIDPRODUCTOVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBIDPRODUCTOVENTA.Name = "CMBIDPRODUCTOVENTA";
            this.CMBIDPRODUCTOVENTA.Size = new System.Drawing.Size(345, 26);
            this.CMBIDPRODUCTOVENTA.TabIndex = 8;
            this.CMBIDPRODUCTOVENTA.SelectedIndexChanged += new System.EventHandler(this.CMBIDPRODUCTOVENTA_SelectedIndexChanged);
            // 
            // TXTSUBTOTALV
            // 
            this.TXTSUBTOTALV.Location = new System.Drawing.Point(696, 33);
            this.TXTSUBTOTALV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSUBTOTALV.Name = "TXTSUBTOTALV";
            this.TXTSUBTOTALV.Size = new System.Drawing.Size(317, 26);
            this.TXTSUBTOTALV.TabIndex = 11;
            this.TXTSUBTOTALV.TextChanged += new System.EventHandler(this.TXTSUBTOTALV_TextChanged);
            // 
            // TXTTOTALVENTA
            // 
            this.TXTTOTALVENTA.Location = new System.Drawing.Point(692, 166);
            this.TXTTOTALVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTTOTALVENTA.Name = "TXTTOTALVENTA";
            this.TXTTOTALVENTA.Size = new System.Drawing.Size(321, 26);
            this.TXTTOTALVENTA.TabIndex = 14;
            this.TXTTOTALVENTA.TextChanged += new System.EventHandler(this.TXTTOTALVENTA_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "TOTAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "PRODUCTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "DESCUENTO";
            // 
            // TXTPRECIOUDV
            // 
            this.TXTPRECIOUDV.Location = new System.Drawing.Point(173, 143);
            this.TXTPRECIOUDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTPRECIOUDV.Name = "TXTPRECIOUDV";
            this.TXTPRECIOUDV.Size = new System.Drawing.Size(345, 26);
            this.TXTPRECIOUDV.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SUBTOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "PRECIO UNITARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 10;
            // 
            // TXTCANTIDADDV
            // 
            this.TXTCANTIDADDV.Location = new System.Drawing.Point(174, 95);
            this.TXTCANTIDADDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTCANTIDADDV.Name = "TXTCANTIDADDV";
            this.TXTCANTIDADDV.Size = new System.Drawing.Size(342, 26);
            this.TXTCANTIDADDV.TabIndex = 9;
            this.TXTCANTIDADDV.TextChanged += new System.EventHandler(this.TXTCANTIDADDV_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBNO0);
            this.groupBox1.Controls.Add(this.RBSI1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.CMBMETODO);
            this.groupBox1.Controls.Add(this.EMPLEADO);
            this.groupBox1.Controls.Add(this.TXTIDVENTA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CMBIDEMPLEADOV);
            this.groupBox1.Controls.Add(this.DTPVENTA);
            this.groupBox1.Controls.Add(this.CMBIDCLIENTEV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1053, 148);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION VENTA";
            // 
            // RBNO0
            // 
            this.RBNO0.AutoSize = true;
            this.RBNO0.Location = new System.Drawing.Point(310, 107);
            this.RBNO0.Name = "RBNO0";
            this.RBNO0.Size = new System.Drawing.Size(56, 24);
            this.RBNO0.TabIndex = 4;
            this.RBNO0.TabStop = true;
            this.RBNO0.Text = "NO";
            this.RBNO0.UseVisualStyleBackColor = true;
            // 
            // RBSI1
            // 
            this.RBSI1.AutoSize = true;
            this.RBSI1.Location = new System.Drawing.Point(224, 107);
            this.RBSI1.Name = "RBSI1";
            this.RBSI1.Size = new System.Drawing.Size(46, 24);
            this.RBSI1.TabIndex = 3;
            this.RBSI1.TabStop = true;
            this.RBSI1.Text = "SI";
            this.RBSI1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(515, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "METODO PAGO";
            // 
            // CMBMETODO
            // 
            this.CMBMETODO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBMETODO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBMETODO.FormattingEnabled = true;
            this.CMBMETODO.Location = new System.Drawing.Point(660, 101);
            this.CMBMETODO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBMETODO.Name = "CMBMETODO";
            this.CMBMETODO.Size = new System.Drawing.Size(317, 26);
            this.CMBMETODO.TabIndex = 7;
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.AutoSize = true;
            this.EMPLEADO.Location = new System.Drawing.Point(548, 63);
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.Size = new System.Drawing.Size(104, 20);
            this.EMPLEADO.TabIndex = 30;
            this.EMPLEADO.Text = "EMPLEADO";
            // 
            // TXTIDVENTA
            // 
            this.TXTIDVENTA.Location = new System.Drawing.Point(183, 25);
            this.TXTIDVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDVENTA.Name = "TXTIDVENTA";
            this.TXTIDVENTA.Size = new System.Drawing.Size(317, 26);
            this.TXTIDVENTA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID VENTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CREDITO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CMBIDEMPLEADOV
            // 
            this.CMBIDEMPLEADOV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBIDEMPLEADOV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBIDEMPLEADOV.FormattingEnabled = true;
            this.CMBIDEMPLEADOV.Location = new System.Drawing.Point(660, 60);
            this.CMBIDEMPLEADOV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBIDEMPLEADOV.Name = "CMBIDEMPLEADOV";
            this.CMBIDEMPLEADOV.Size = new System.Drawing.Size(317, 26);
            this.CMBIDEMPLEADOV.TabIndex = 6;
            // 
            // DTPVENTA
            // 
            this.DTPVENTA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVENTA.Location = new System.Drawing.Point(660, 17);
            this.DTPVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPVENTA.Name = "DTPVENTA";
            this.DTPVENTA.Size = new System.Drawing.Size(311, 26);
            this.DTPVENTA.TabIndex = 5;
            // 
            // CMBIDCLIENTEV
            // 
            this.CMBIDCLIENTEV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBIDCLIENTEV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBIDCLIENTEV.FormattingEnabled = true;
            this.CMBIDCLIENTEV.Location = new System.Drawing.Point(183, 60);
            this.CMBIDCLIENTEV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBIDCLIENTEV.Name = "CMBIDCLIENTEV";
            this.CMBIDCLIENTEV.Size = new System.Drawing.Size(317, 26);
            this.CMBIDCLIENTEV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = " CLIENTE";
            // 
            // BTNAGREGARVENTA
            // 
            this.BTNAGREGARVENTA.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGARVENTA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNAGREGARVENTA.Location = new System.Drawing.Point(497, 436);
            this.BTNAGREGARVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARVENTA.Name = "BTNAGREGARVENTA";
            this.BTNAGREGARVENTA.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARVENTA.TabIndex = 15;
            this.BTNAGREGARVENTA.Text = "AGREGAR";
            this.BTNAGREGARVENTA.UseVisualStyleBackColor = false;
            this.BTNAGREGARVENTA.Click += new System.EventHandler(this.BTNAGREGARVENTA_Click);
            // 
            // BTNELIMINARVENTA
            // 
            this.BTNELIMINARVENTA.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARVENTA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARVENTA.Location = new System.Drawing.Point(692, 436);
            this.BTNELIMINARVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARVENTA.Name = "BTNELIMINARVENTA";
            this.BTNELIMINARVENTA.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARVENTA.TabIndex = 16;
            this.BTNELIMINARVENTA.Text = "ELIMINAR";
            this.BTNELIMINARVENTA.UseVisualStyleBackColor = false;
            this.BTNELIMINARVENTA.Click += new System.EventHandler(this.BTNELIMINARVENTA_Click);
            // 
            // BTNACTUALIZARVENTA
            // 
            this.BTNACTUALIZARVENTA.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARVENTA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARVENTA.Location = new System.Drawing.Point(874, 436);
            this.BTNACTUALIZARVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARVENTA.Name = "BTNACTUALIZARVENTA";
            this.BTNACTUALIZARVENTA.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARVENTA.TabIndex = 17;
            this.BTNACTUALIZARVENTA.Text = "ACTUALIZAR";
            this.BTNACTUALIZARVENTA.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-97, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // DGVVENTA
            // 
            this.DGVVENTA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVENTA.Location = new System.Drawing.Point(20, 548);
            this.DGVVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVVENTA.Name = "DGVVENTA";
            this.DGVVENTA.RowHeadersWidth = 18;
            this.DGVVENTA.RowTemplate.Height = 24;
            this.DGVVENTA.Size = new System.Drawing.Size(1093, 141);
            this.DGVVENTA.TabIndex = 12;
            this.DGVVENTA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVENTA_CellClick);
            this.DGVVENTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVENTA_CellContentClick);
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1125, 770);
            this.Controls.Add(this.DGVVENTA);
            this.Controls.Add(this.GBVENTA);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VENTAS";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            this.GBVENTA.ResumeLayout(false);
            this.GBVENTA.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVENTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBVENTA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTPRECIOUDV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTTOTALVENTA;
        private System.Windows.Forms.Button BTNAGREGARVENTA;
        private System.Windows.Forms.Button BTNELIMINARVENTA;
        private System.Windows.Forms.Button BTNACTUALIZARVENTA;
        private System.Windows.Forms.TextBox TXTCANTIDADDV;
        private System.Windows.Forms.TextBox TXTIDVENTA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPVENTA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DGVVENTA;
        private System.Windows.Forms.ComboBox CMBIDEMPLEADOV;
        private System.Windows.Forms.ComboBox CMBIDCLIENTEV;
        private System.Windows.Forms.TextBox TXTSUBTOTALV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CMBIDPRODUCTOVENTA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EMPLEADO;
        private System.Windows.Forms.TextBox TXTDESCUENTOV;
        private System.Windows.Forms.Label CANTIDAD;
        private System.Windows.Forms.TextBox TXTISVVENTA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RBNO0;
        private System.Windows.Forms.RadioButton RBSI1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CMBMETODO;
    }
}