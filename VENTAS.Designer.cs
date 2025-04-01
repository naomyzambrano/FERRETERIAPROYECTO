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
            this.GBVENTA = new System.Windows.Forms.GroupBox();
            this.GBPRODU = new System.Windows.Forms.GroupBox();
            this.CMBIDPRODUCTOVENTA = new System.Windows.Forms.ComboBox();
            this.TXTSUBTOTALV = new System.Windows.Forms.TextBox();
            this.TXTTOTALVENTA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTISVVENTA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTDESCUENTOV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVVENTA = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTPRECIOUDV = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.Label();
            this.TXTCANTIDADDV = new System.Windows.Forms.TextBox();
            this.RBSI1 = new System.Windows.Forms.RadioButton();
            this.RBNO0 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.CMBMETODO = new System.Windows.Forms.ComboBox();
            this.GBVENTA.SuspendLayout();
            this.GBPRODU.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVENTA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBVENTA
            // 
            this.GBVENTA.Controls.Add(this.GBPRODU);
            this.GBVENTA.Controls.Add(this.groupBox1);
            this.GBVENTA.Controls.Add(this.BTNAGREGARVENTA);
            this.GBVENTA.Controls.Add(this.BTNELIMINARVENTA);
            this.GBVENTA.Controls.Add(this.BTNACTUALIZARVENTA);
            this.GBVENTA.Controls.Add(this.label8);
            this.GBVENTA.Controls.Add(this.label7);
            this.GBVENTA.Controls.Add(this.label1);
            this.GBVENTA.Location = new System.Drawing.Point(20, 32);
            this.GBVENTA.Name = "GBVENTA";
            this.GBVENTA.Size = new System.Drawing.Size(1094, 529);
            this.GBVENTA.TabIndex = 11;
            this.GBVENTA.TabStop = false;
            this.GBVENTA.Text = "REGISTRO VENTA";
            // 
            // GBPRODU
            // 
            this.GBPRODU.Controls.Add(this.TXTPRECIOUDV);
            this.GBPRODU.Controls.Add(this.B);
            this.GBPRODU.Controls.Add(this.TXTCANTIDADDV);
            this.GBPRODU.Controls.Add(this.label14);
            this.GBPRODU.Controls.Add(this.CMBIDPRODUCTOVENTA);
            this.GBPRODU.Controls.Add(this.TXTSUBTOTALV);
            this.GBPRODU.Controls.Add(this.TXTTOTALVENTA);
            this.GBPRODU.Controls.Add(this.label13);
            this.GBPRODU.Controls.Add(this.label11);
            this.GBPRODU.Controls.Add(this.TXTISVVENTA);
            this.GBPRODU.Controls.Add(this.label9);
            this.GBPRODU.Controls.Add(this.label4);
            this.GBPRODU.Controls.Add(this.label10);
            this.GBPRODU.Controls.Add(this.label6);
            this.GBPRODU.Controls.Add(this.TXTDESCUENTOV);
            this.GBPRODU.Location = new System.Drawing.Point(23, 220);
            this.GBPRODU.Name = "GBPRODU";
            this.GBPRODU.Size = new System.Drawing.Size(1052, 216);
            this.GBPRODU.TabIndex = 39;
            this.GBPRODU.TabStop = false;
            this.GBPRODU.Text = "INFORMACION PRODUCTO";
            // 
            // CMBIDPRODUCTOVENTA
            // 
            this.CMBIDPRODUCTOVENTA.FormattingEnabled = true;
            this.CMBIDPRODUCTOVENTA.Location = new System.Drawing.Point(179, 52);
            this.CMBIDPRODUCTOVENTA.Name = "CMBIDPRODUCTOVENTA";
            this.CMBIDPRODUCTOVENTA.Size = new System.Drawing.Size(317, 24);
            this.CMBIDPRODUCTOVENTA.TabIndex = 33;
            this.CMBIDPRODUCTOVENTA.SelectedIndexChanged += new System.EventHandler(this.CMBIDPRODUCTOVENTA_SelectedIndexChanged);
            // 
            // TXTSUBTOTALV
            // 
            this.TXTSUBTOTALV.Location = new System.Drawing.Point(678, 41);
            this.TXTSUBTOTALV.Name = "TXTSUBTOTALV";
            this.TXTSUBTOTALV.Size = new System.Drawing.Size(317, 22);
            this.TXTSUBTOTALV.TabIndex = 30;
            this.TXTSUBTOTALV.TextChanged += new System.EventHandler(this.TXTSUBTOTALV_TextChanged);
            // 
            // TXTTOTALVENTA
            // 
            this.TXTTOTALVENTA.Location = new System.Drawing.Point(678, 159);
            this.TXTTOTALVENTA.Name = "TXTTOTALVENTA";
            this.TXTTOTALVENTA.Size = new System.Drawing.Size(317, 22);
            this.TXTTOTALVENTA.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "PRODUCTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(573, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "DESCUENTO";
            // 
            // TXTISVVENTA
            // 
            this.TXTISVVENTA.Location = new System.Drawing.Point(678, 118);
            this.TXTISVVENTA.Name = "TXTISVVENTA";
            this.TXTISVVENTA.Size = new System.Drawing.Size(317, 22);
            this.TXTISVVENTA.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "PRECIO UNITARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "SUBTOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "ISV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            // 
            // TXTDESCUENTOV
            // 
            this.TXTDESCUENTOV.Location = new System.Drawing.Point(677, 77);
            this.TXTDESCUENTOV.Name = "TXTDESCUENTOV";
            this.TXTDESCUENTOV.Size = new System.Drawing.Size(317, 22);
            this.TXTDESCUENTOV.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMBMETODO);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.RBNO0);
            this.groupBox1.Controls.Add(this.RBSI1);
            this.groupBox1.Controls.Add(this.EMPLEADO);
            this.groupBox1.Controls.Add(this.TXTIDVENTA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CMBIDEMPLEADOV);
            this.groupBox1.Controls.Add(this.DTPVENTA);
            this.groupBox1.Controls.Add(this.CMBIDCLIENTEV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 157);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION VENTA";
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.AutoSize = true;
            this.EMPLEADO.Location = new System.Drawing.Point(564, 67);
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.Size = new System.Drawing.Size(81, 16);
            this.EMPLEADO.TabIndex = 30;
            this.EMPLEADO.Text = "EMPLEADO";
            // 
            // TXTIDVENTA
            // 
            this.TXTIDVENTA.Location = new System.Drawing.Point(177, 25);
            this.TXTIDVENTA.Name = "TXTIDVENTA";
            this.TXTIDVENTA.Size = new System.Drawing.Size(317, 22);
            this.TXTIDVENTA.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID VENTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(593, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "CREDITO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CMBIDEMPLEADOV
            // 
            this.CMBIDEMPLEADOV.FormattingEnabled = true;
            this.CMBIDEMPLEADOV.Location = new System.Drawing.Point(679, 64);
            this.CMBIDEMPLEADOV.Name = "CMBIDEMPLEADOV";
            this.CMBIDEMPLEADOV.Size = new System.Drawing.Size(311, 24);
            this.CMBIDEMPLEADOV.TabIndex = 29;
            // 
            // DTPVENTA
            // 
            this.DTPVENTA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPVENTA.Location = new System.Drawing.Point(679, 18);
            this.DTPVENTA.Name = "DTPVENTA";
            this.DTPVENTA.Size = new System.Drawing.Size(311, 22);
            this.DTPVENTA.TabIndex = 27;
            // 
            // CMBIDCLIENTEV
            // 
            this.CMBIDCLIENTEV.FormattingEnabled = true;
            this.CMBIDCLIENTEV.Location = new System.Drawing.Point(177, 69);
            this.CMBIDCLIENTEV.Name = "CMBIDCLIENTEV";
            this.CMBIDCLIENTEV.Size = new System.Drawing.Size(317, 24);
            this.CMBIDCLIENTEV.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = " CLIENTE";
            // 
            // BTNAGREGARVENTA
            // 
            this.BTNAGREGARVENTA.Location = new System.Drawing.Point(513, 458);
            this.BTNAGREGARVENTA.Name = "BTNAGREGARVENTA";
            this.BTNAGREGARVENTA.Size = new System.Drawing.Size(158, 55);
            this.BTNAGREGARVENTA.TabIndex = 3;
            this.BTNAGREGARVENTA.Text = "AGREGAR";
            this.BTNAGREGARVENTA.UseVisualStyleBackColor = true;
            this.BTNAGREGARVENTA.Click += new System.EventHandler(this.BTNAGREGARVENTA_Click);
            // 
            // BTNELIMINARVENTA
            // 
            this.BTNELIMINARVENTA.Location = new System.Drawing.Point(710, 458);
            this.BTNELIMINARVENTA.Name = "BTNELIMINARVENTA";
            this.BTNELIMINARVENTA.Size = new System.Drawing.Size(158, 55);
            this.BTNELIMINARVENTA.TabIndex = 2;
            this.BTNELIMINARVENTA.Text = "ELIMINAR";
            this.BTNELIMINARVENTA.UseVisualStyleBackColor = true;
            this.BTNELIMINARVENTA.Click += new System.EventHandler(this.BTNELIMINARVENTA_Click);
            // 
            // BTNACTUALIZARVENTA
            // 
            this.BTNACTUALIZARVENTA.Location = new System.Drawing.Point(892, 458);
            this.BTNACTUALIZARVENTA.Name = "BTNACTUALIZARVENTA";
            this.BTNACTUALIZARVENTA.Size = new System.Drawing.Size(158, 55);
            this.BTNACTUALIZARVENTA.TabIndex = 1;
            this.BTNACTUALIZARVENTA.Text = "ACTUALIZAR";
            this.BTNACTUALIZARVENTA.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = " EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-97, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // DGVVENTA
            // 
            this.DGVVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVENTA.Location = new System.Drawing.Point(20, 584);
            this.DGVVENTA.Name = "DGVVENTA";
            this.DGVVENTA.RowHeadersWidth = 51;
            this.DGVVENTA.RowTemplate.Height = 24;
            this.DGVVENTA.Size = new System.Drawing.Size(1094, 150);
            this.DGVVENTA.TabIndex = 12;
            this.DGVVENTA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVENTA_CellClick);
            this.DGVVENTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVENTA_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(605, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "TOTAL";
            // 
            // TXTPRECIOUDV
            // 
            this.TXTPRECIOUDV.Location = new System.Drawing.Point(179, 148);
            this.TXTPRECIOUDV.Name = "TXTPRECIOUDV";
            this.TXTPRECIOUDV.Size = new System.Drawing.Size(317, 22);
            this.TXTPRECIOUDV.TabIndex = 38;
            this.TXTPRECIOUDV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(80, 112);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(76, 16);
            this.B.TabIndex = 37;
            this.B.Text = "CANTIDAD";
            // 
            // TXTCANTIDADDV
            // 
            this.TXTCANTIDADDV.Location = new System.Drawing.Point(179, 101);
            this.TXTCANTIDADDV.Name = "TXTCANTIDADDV";
            this.TXTCANTIDADDV.Size = new System.Drawing.Size(317, 22);
            this.TXTCANTIDADDV.TabIndex = 36;
            // 
            // RBSI1
            // 
            this.RBSI1.AutoSize = true;
            this.RBSI1.Location = new System.Drawing.Point(205, 114);
            this.RBSI1.Name = "RBSI1";
            this.RBSI1.Size = new System.Drawing.Size(40, 20);
            this.RBSI1.TabIndex = 31;
            this.RBSI1.TabStop = true;
            this.RBSI1.Text = "SI";
            this.RBSI1.UseVisualStyleBackColor = true;
            // 
            // RBNO0
            // 
            this.RBNO0.AutoSize = true;
            this.RBNO0.Location = new System.Drawing.Point(280, 114);
            this.RBNO0.Name = "RBNO0";
            this.RBNO0.Size = new System.Drawing.Size(48, 20);
            this.RBNO0.TabIndex = 32;
            this.RBNO0.TabStop = true;
            this.RBNO0.Text = "NO";
            this.RBNO0.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(538, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "METODO PAGO";
            // 
            // CMBMETODO
            // 
            this.CMBMETODO.FormattingEnabled = true;
            this.CMBMETODO.Location = new System.Drawing.Point(679, 111);
            this.CMBMETODO.Name = "CMBMETODO";
            this.CMBMETODO.Size = new System.Drawing.Size(311, 24);
            this.CMBMETODO.TabIndex = 34;
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 770);
            this.Controls.Add(this.DGVVENTA);
            this.Controls.Add(this.GBVENTA);
            this.Name = "VENTAS";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            this.GBVENTA.ResumeLayout(false);
            this.GBVENTA.PerformLayout();
            this.GBPRODU.ResumeLayout(false);
            this.GBPRODU.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVENTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBVENTA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTISVVENTA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTTOTALVENTA;
        private System.Windows.Forms.Button BTNAGREGARVENTA;
        private System.Windows.Forms.Button BTNELIMINARVENTA;
        private System.Windows.Forms.Button BTNACTUALIZARVENTA;
        private System.Windows.Forms.TextBox TXTDESCUENTOV;
        private System.Windows.Forms.TextBox TXTIDVENTA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.GroupBox GBPRODU;
        private System.Windows.Forms.Label EMPLEADO;
        private System.Windows.Forms.TextBox TXTPRECIOUDV;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.TextBox TXTCANTIDADDV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton RBNO0;
        private System.Windows.Forms.RadioButton RBSI1;
        private System.Windows.Forms.ComboBox CMBMETODO;
        private System.Windows.Forms.Label label15;
    }
}