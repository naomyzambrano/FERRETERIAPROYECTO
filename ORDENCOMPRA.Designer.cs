namespace FERRETERIAPROYECTO
{
    partial class ORDENCOMPRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDENCOMPRA));
            this.GBCOMPRA = new System.Windows.Forms.GroupBox();
            this.CMBESTADOCOMPRA = new System.Windows.Forms.ComboBox();
            this.CMBPRODUCTOOCOMPRA = new System.Windows.Forms.ComboBox();
            this.NUPCANTIDADCOMPRA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNAGREGAROCOMPRA = new System.Windows.Forms.Button();
            this.BTNELIMINAROCOMPRA = new System.Windows.Forms.Button();
            this.BTNACTUALIZAROCOMPRA = new System.Windows.Forms.Button();
            this.TXTIDOCOMPRA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFECHACOMPRA = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVOCOMPRA = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.GBCOMPRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADCOMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOCOMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBCOMPRA
            // 
            this.GBCOMPRA.BackColor = System.Drawing.Color.SandyBrown;
            this.GBCOMPRA.Controls.Add(this.CMBESTADOCOMPRA);
            this.GBCOMPRA.Controls.Add(this.CMBPRODUCTOOCOMPRA);
            this.GBCOMPRA.Controls.Add(this.NUPCANTIDADCOMPRA);
            this.GBCOMPRA.Controls.Add(this.label4);
            this.GBCOMPRA.Controls.Add(this.TXTIDOCOMPRA);
            this.GBCOMPRA.Controls.Add(this.label7);
            this.GBCOMPRA.Controls.Add(this.label6);
            this.GBCOMPRA.Controls.Add(this.label2);
            this.GBCOMPRA.Controls.Add(this.DTPFECHACOMPRA);
            this.GBCOMPRA.Controls.Add(this.label3);
            this.GBCOMPRA.Controls.Add(this.label1);
            this.GBCOMPRA.Location = new System.Drawing.Point(25, 108);
            this.GBCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBCOMPRA.Name = "GBCOMPRA";
            this.GBCOMPRA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBCOMPRA.Size = new System.Drawing.Size(788, 192);
            this.GBCOMPRA.TabIndex = 9;
            this.GBCOMPRA.TabStop = false;
            this.GBCOMPRA.Text = "REGISTRO ORDEN COMPRA";
            // 
            // CMBESTADOCOMPRA
            // 
            this.CMBESTADOCOMPRA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBESTADOCOMPRA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBESTADOCOMPRA.FormattingEnabled = true;
            this.CMBESTADOCOMPRA.Items.AddRange(new object[] {
            "PENDIENTE",
            "ENTREGADO",
            "CANCELADA"});
            this.CMBESTADOCOMPRA.Location = new System.Drawing.Point(484, 89);
            this.CMBESTADOCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMBESTADOCOMPRA.Name = "CMBESTADOCOMPRA";
            this.CMBESTADOCOMPRA.Size = new System.Drawing.Size(238, 21);
            this.CMBESTADOCOMPRA.TabIndex = 5;
            // 
            // CMBPRODUCTOOCOMPRA
            // 
            this.CMBPRODUCTOOCOMPRA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBPRODUCTOOCOMPRA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBPRODUCTOOCOMPRA.FormattingEnabled = true;
            this.CMBPRODUCTOOCOMPRA.Location = new System.Drawing.Point(128, 95);
            this.CMBPRODUCTOOCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMBPRODUCTOOCOMPRA.Name = "CMBPRODUCTOOCOMPRA";
            this.CMBPRODUCTOOCOMPRA.Size = new System.Drawing.Size(238, 21);
            this.CMBPRODUCTOOCOMPRA.TabIndex = 2;
            // 
            // NUPCANTIDADCOMPRA
            // 
            this.NUPCANTIDADCOMPRA.Location = new System.Drawing.Point(127, 150);
            this.NUPCANTIDADCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NUPCANTIDADCOMPRA.Name = "NUPCANTIDADCOMPRA";
            this.NUPCANTIDADCOMPRA.Size = new System.Drawing.Size(238, 20);
            this.NUPCANTIDADCOMPRA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ESTADO";
            // 
            // BTNAGREGAROCOMPRA
            // 
            this.BTNAGREGAROCOMPRA.BackColor = System.Drawing.Color.Chocolate;
            this.BTNAGREGAROCOMPRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAGREGAROCOMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGAROCOMPRA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGAROCOMPRA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAGREGAROCOMPRA.ImageKey = "(ninguno)";
            this.BTNAGREGAROCOMPRA.Location = new System.Drawing.Point(380, 316);
            this.BTNAGREGAROCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNAGREGAROCOMPRA.Name = "BTNAGREGAROCOMPRA";
            this.BTNAGREGAROCOMPRA.Size = new System.Drawing.Size(118, 42);
            this.BTNAGREGAROCOMPRA.TabIndex = 6;
            this.BTNAGREGAROCOMPRA.Text = "AGREGAR";
            this.BTNAGREGAROCOMPRA.UseVisualStyleBackColor = false;
            this.BTNAGREGAROCOMPRA.Click += new System.EventHandler(this.BTNAGREGAROCOMPRA_Click);
            // 
            // BTNELIMINAROCOMPRA
            // 
            this.BTNELIMINAROCOMPRA.BackColor = System.Drawing.Color.Chocolate;
            this.BTNELIMINAROCOMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAROCOMPRA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINAROCOMPRA.Location = new System.Drawing.Point(509, 316);
            this.BTNELIMINAROCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNELIMINAROCOMPRA.Name = "BTNELIMINAROCOMPRA";
            this.BTNELIMINAROCOMPRA.Size = new System.Drawing.Size(118, 42);
            this.BTNELIMINAROCOMPRA.TabIndex = 7;
            this.BTNELIMINAROCOMPRA.Text = "ELIMINAR";
            this.BTNELIMINAROCOMPRA.UseVisualStyleBackColor = false;
            this.BTNELIMINAROCOMPRA.Click += new System.EventHandler(this.BTNELIMINAROCOMPRA_Click);
            // 
            // BTNACTUALIZAROCOMPRA
            // 
            this.BTNACTUALIZAROCOMPRA.BackColor = System.Drawing.Color.Chocolate;
            this.BTNACTUALIZAROCOMPRA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZAROCOMPRA.ForeColor = System.Drawing.Color.White;
            this.BTNACTUALIZAROCOMPRA.Location = new System.Drawing.Point(649, 316);
            this.BTNACTUALIZAROCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNACTUALIZAROCOMPRA.Name = "BTNACTUALIZAROCOMPRA";
            this.BTNACTUALIZAROCOMPRA.Size = new System.Drawing.Size(118, 42);
            this.BTNACTUALIZAROCOMPRA.TabIndex = 8;
            this.BTNACTUALIZAROCOMPRA.Text = "ACTUALIZAR";
            this.BTNACTUALIZAROCOMPRA.UseVisualStyleBackColor = false;
            this.BTNACTUALIZAROCOMPRA.Click += new System.EventHandler(this.BTNACTUALIZAROCOMPRA_Click);
            // 
            // TXTIDOCOMPRA
            // 
            this.TXTIDOCOMPRA.Location = new System.Drawing.Point(127, 41);
            this.TXTIDOCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTIDOCOMPRA.Name = "TXTIDOCOMPRA";
            this.TXTIDOCOMPRA.Size = new System.Drawing.Size(239, 20);
            this.TXTIDOCOMPRA.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID ORDEN COMPRA";
            // 
            // DTPFECHACOMPRA
            // 
            this.DTPFECHACOMPRA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHACOMPRA.Location = new System.Drawing.Point(483, 41);
            this.DTPFECHACOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTPFECHACOMPRA.Name = "DTPFECHACOMPRA";
            this.DTPFECHACOMPRA.Size = new System.Drawing.Size(239, 20);
            this.DTPFECHACOMPRA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CANTIDAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // DGVOCOMPRA
            // 
            this.DGVOCOMPRA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOCOMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOCOMPRA.Location = new System.Drawing.Point(25, 383);
            this.DGVOCOMPRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVOCOMPRA.Name = "DGVOCOMPRA";
            this.DGVOCOMPRA.RowHeadersWidth = 51;
            this.DGVOCOMPRA.RowTemplate.Height = 24;
            this.DGVOCOMPRA.Size = new System.Drawing.Size(788, 140);
            this.DGVOCOMPRA.TabIndex = 9;
            this.DGVOCOMPRA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOCOMPRA_CellClick);
            this.DGVOCOMPRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOCOMPRA_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 28);
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
            this.label15.Location = new System.Drawing.Point(303, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(332, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "PEDIDOS A PROVEEDORES";
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
            this.btnVOLVER.Location = new System.Drawing.Point(25, 31);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(49, 39);
            this.btnVOLVER.TabIndex = 20;
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // ORDENCOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(830, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.DGVOCOMPRA);
            this.Controls.Add(this.GBCOMPRA);
            this.Controls.Add(this.BTNAGREGAROCOMPRA);
            this.Controls.Add(this.BTNELIMINAROCOMPRA);
            this.Controls.Add(this.BTNACTUALIZAROCOMPRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ORDENCOMPRA";
            this.Text = "ORDENCOMPRA";
            this.Load += new System.EventHandler(this.ORDENCOMPRA_Load);
            this.GBCOMPRA.ResumeLayout(false);
            this.GBCOMPRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADCOMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOCOMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCOMPRA;
        private System.Windows.Forms.Button BTNAGREGAROCOMPRA;
        private System.Windows.Forms.Button BTNELIMINAROCOMPRA;
        private System.Windows.Forms.Button BTNACTUALIZAROCOMPRA;
        private System.Windows.Forms.TextBox TXTIDOCOMPRA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFECHACOMPRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVOCOMPRA;
        private System.Windows.Forms.NumericUpDown NUPCANTIDADCOMPRA;
        private System.Windows.Forms.ComboBox CMBESTADOCOMPRA;
        private System.Windows.Forms.ComboBox CMBPRODUCTOOCOMPRA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVOLVER;
    }
}