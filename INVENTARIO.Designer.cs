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
            this.GBINVENTARIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADINV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVINVENTARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // GBINVENTARIO
            // 
            this.GBINVENTARIO.Controls.Add(this.CMBIDPRODUINVE);
            this.GBINVENTARIO.Controls.Add(this.TXTSTOCKMIN);
            this.GBINVENTARIO.Controls.Add(this.CMBSALIDAINV);
            this.GBINVENTARIO.Controls.Add(this.label8);
            this.GBINVENTARIO.Controls.Add(this.NUPCANTIDADINV);
            this.GBINVENTARIO.Controls.Add(this.BTNAGREGARINV);
            this.GBINVENTARIO.Controls.Add(this.BTNELIMINARINV);
            this.GBINVENTARIO.Controls.Add(this.BTNACTUALIZARINV);
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
            this.GBINVENTARIO.Location = new System.Drawing.Point(24, 24);
            this.GBINVENTARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBINVENTARIO.Name = "GBINVENTARIO";
            this.GBINVENTARIO.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBINVENTARIO.Size = new System.Drawing.Size(1065, 352);
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
            this.CMBIDPRODUINVE.Location = new System.Drawing.Point(171, 105);
            this.CMBIDPRODUINVE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMBIDPRODUINVE.Name = "CMBIDPRODUINVE";
            this.CMBIDPRODUINVE.Size = new System.Drawing.Size(315, 24);
            this.CMBIDPRODUINVE.TabIndex = 2;
            // 
            // TXTSTOCKMIN
            // 
            this.TXTSTOCKMIN.Location = new System.Drawing.Point(645, 105);
            this.TXTSTOCKMIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSTOCKMIN.Name = "TXTSTOCKMIN";
            this.TXTSTOCKMIN.Size = new System.Drawing.Size(317, 22);
            this.TXTSTOCKMIN.TabIndex = 6;
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
            this.CMBSALIDAINV.Location = new System.Drawing.Point(645, 167);
            this.CMBSALIDAINV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMBSALIDAINV.Name = "CMBSALIDAINV";
            this.CMBSALIDAINV.Size = new System.Drawing.Size(315, 24);
            this.CMBSALIDAINV.TabIndex = 7;
            this.CMBSALIDAINV.SelectedIndexChanged += new System.EventHandler(this.CMBSALIDAINV_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "SALIDAS";
            // 
            // NUPCANTIDADINV
            // 
            this.NUPCANTIDADINV.Location = new System.Drawing.Point(169, 178);
            this.NUPCANTIDADINV.Name = "NUPCANTIDADINV";
            this.NUPCANTIDADINV.Size = new System.Drawing.Size(317, 22);
            this.NUPCANTIDADINV.TabIndex = 3;
            // 
            // BTNAGREGARINV
            // 
            this.BTNAGREGARINV.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGARINV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAGREGARINV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARINV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAGREGARINV.ImageKey = "(ninguno)";
            this.BTNAGREGARINV.Location = new System.Drawing.Point(511, 283);
            this.BTNAGREGARINV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARINV.Name = "BTNAGREGARINV";
            this.BTNAGREGARINV.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARINV.TabIndex = 9;
            this.BTNAGREGARINV.Text = "AGREGAR";
            this.BTNAGREGARINV.UseVisualStyleBackColor = false;
            this.BTNAGREGARINV.Click += new System.EventHandler(this.BTNAGREGARINV_Click);
            // 
            // BTNELIMINARINV
            // 
            this.BTNELIMINARINV.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARINV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARINV.Location = new System.Drawing.Point(687, 283);
            this.BTNELIMINARINV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARINV.Name = "BTNELIMINARINV";
            this.BTNELIMINARINV.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARINV.TabIndex = 10;
            this.BTNELIMINARINV.Text = "ELIMINAR";
            this.BTNELIMINARINV.UseVisualStyleBackColor = false;
            this.BTNELIMINARINV.Click += new System.EventHandler(this.BTNELIMINARINV_Click);
            // 
            // BTNACTUALIZARINV
            // 
            this.BTNACTUALIZARINV.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARINV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZARINV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARINV.Location = new System.Drawing.Point(869, 283);
            this.BTNACTUALIZARINV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARINV.Name = "BTNACTUALIZARINV";
            this.BTNACTUALIZARINV.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARINV.TabIndex = 11;
            this.BTNACTUALIZARINV.Text = "ACTUALIZAR";
            this.BTNACTUALIZARINV.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARINV.Click += new System.EventHandler(this.BTNACTUALIZARINV_Click);
            // 
            // TXTUBIINV
            // 
            this.TXTUBIINV.Location = new System.Drawing.Point(167, 235);
            this.TXTUBIINV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTUBIINV.Name = "TXTUBIINV";
            this.TXTUBIINV.Size = new System.Drawing.Size(793, 22);
            this.TXTUBIINV.TabIndex = 4;
            // 
            // TXTIDINVENTARIO
            // 
            this.TXTIDINVENTARIO.Location = new System.Drawing.Point(169, 50);
            this.TXTIDINVENTARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDINVENTARIO.Name = "TXTIDINVENTARIO";
            this.TXTIDINVENTARIO.Size = new System.Drawing.Size(317, 22);
            this.TXTIDINVENTARIO.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "CANTIDAD ACTUAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "UBICACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOCK MINIMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID INVENTARIO";
            // 
            // DTPFECHAINV
            // 
            this.DTPFECHAINV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAINV.Location = new System.Drawing.Point(643, 43);
            this.DTPFECHAINV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFECHAINV.Name = "DTPFECHAINV";
            this.DTPFECHAINV.Size = new System.Drawing.Size(317, 22);
            this.DTPFECHAINV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID PRODUCTO";
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
            // DGVINVENTARIO
            // 
            this.DGVINVENTARIO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVINVENTARIO.Location = new System.Drawing.Point(24, 390);
            this.DGVINVENTARIO.Name = "DGVINVENTARIO";
            this.DGVINVENTARIO.RowHeadersWidth = 51;
            this.DGVINVENTARIO.RowTemplate.Height = 24;
            this.DGVINVENTARIO.Size = new System.Drawing.Size(1065, 161);
            this.DGVINVENTARIO.TabIndex = 8;
            this.DGVINVENTARIO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVINVENTARIO_CellClick);
            // 
            // INVENTARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 563);
            this.Controls.Add(this.DGVINVENTARIO);
            this.Controls.Add(this.GBINVENTARIO);
            this.Name = "INVENTARIO";
            this.Text = "INVENTARIO";
            this.Load += new System.EventHandler(this.INVENTARIO_Load);
            this.GBINVENTARIO.ResumeLayout(false);
            this.GBINVENTARIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADINV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVINVENTARIO)).EndInit();
            this.ResumeLayout(false);

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
    }
}