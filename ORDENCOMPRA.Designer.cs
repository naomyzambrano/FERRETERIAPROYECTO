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
            this.GBCOMPRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADCOMPRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOCOMPRA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBCOMPRA
            // 
            this.GBCOMPRA.Controls.Add(this.CMBESTADOCOMPRA);
            this.GBCOMPRA.Controls.Add(this.CMBPRODUCTOOCOMPRA);
            this.GBCOMPRA.Controls.Add(this.NUPCANTIDADCOMPRA);
            this.GBCOMPRA.Controls.Add(this.label4);
            this.GBCOMPRA.Controls.Add(this.BTNAGREGAROCOMPRA);
            this.GBCOMPRA.Controls.Add(this.BTNELIMINAROCOMPRA);
            this.GBCOMPRA.Controls.Add(this.BTNACTUALIZAROCOMPRA);
            this.GBCOMPRA.Controls.Add(this.TXTIDOCOMPRA);
            this.GBCOMPRA.Controls.Add(this.label7);
            this.GBCOMPRA.Controls.Add(this.label6);
            this.GBCOMPRA.Controls.Add(this.label2);
            this.GBCOMPRA.Controls.Add(this.DTPFECHACOMPRA);
            this.GBCOMPRA.Controls.Add(this.label3);
            this.GBCOMPRA.Controls.Add(this.label1);
            this.GBCOMPRA.Location = new System.Drawing.Point(33, 26);
            this.GBCOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCOMPRA.Name = "GBCOMPRA";
            this.GBCOMPRA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBCOMPRA.Size = new System.Drawing.Size(1051, 306);
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
            this.CMBESTADOCOMPRA.Location = new System.Drawing.Point(645, 109);
            this.CMBESTADOCOMPRA.Name = "CMBESTADOCOMPRA";
            this.CMBESTADOCOMPRA.Size = new System.Drawing.Size(316, 24);
            this.CMBESTADOCOMPRA.TabIndex = 5;
            // 
            // CMBPRODUCTOOCOMPRA
            // 
            this.CMBPRODUCTOOCOMPRA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBPRODUCTOOCOMPRA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBPRODUCTOOCOMPRA.FormattingEnabled = true;
            this.CMBPRODUCTOOCOMPRA.Location = new System.Drawing.Point(170, 117);
            this.CMBPRODUCTOOCOMPRA.Name = "CMBPRODUCTOOCOMPRA";
            this.CMBPRODUCTOOCOMPRA.Size = new System.Drawing.Size(316, 24);
            this.CMBPRODUCTOOCOMPRA.TabIndex = 2;
            // 
            // NUPCANTIDADCOMPRA
            // 
            this.NUPCANTIDADCOMPRA.Location = new System.Drawing.Point(169, 185);
            this.NUPCANTIDADCOMPRA.Name = "NUPCANTIDADCOMPRA";
            this.NUPCANTIDADCOMPRA.Size = new System.Drawing.Size(317, 22);
            this.NUPCANTIDADCOMPRA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "ESTADO";
            // 
            // BTNAGREGAROCOMPRA
            // 
            this.BTNAGREGAROCOMPRA.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGAROCOMPRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAGREGAROCOMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGAROCOMPRA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGAROCOMPRA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAGREGAROCOMPRA.ImageKey = "(ninguno)";
            this.BTNAGREGAROCOMPRA.Location = new System.Drawing.Point(496, 241);
            this.BTNAGREGAROCOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGAROCOMPRA.Name = "BTNAGREGAROCOMPRA";
            this.BTNAGREGAROCOMPRA.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGAROCOMPRA.TabIndex = 6;
            this.BTNAGREGAROCOMPRA.Text = "AGREGAR";
            this.BTNAGREGAROCOMPRA.UseVisualStyleBackColor = false;
            this.BTNAGREGAROCOMPRA.Click += new System.EventHandler(this.BTNAGREGAROCOMPRA_Click);
            // 
            // BTNELIMINAROCOMPRA
            // 
            this.BTNELIMINAROCOMPRA.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINAROCOMPRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAROCOMPRA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINAROCOMPRA.Location = new System.Drawing.Point(678, 241);
            this.BTNELIMINAROCOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINAROCOMPRA.Name = "BTNELIMINAROCOMPRA";
            this.BTNELIMINAROCOMPRA.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINAROCOMPRA.TabIndex = 7;
            this.BTNELIMINAROCOMPRA.Text = "ELIMINAR";
            this.BTNELIMINAROCOMPRA.UseVisualStyleBackColor = false;
            this.BTNELIMINAROCOMPRA.Click += new System.EventHandler(this.BTNELIMINAROCOMPRA_Click);
            // 
            // BTNACTUALIZAROCOMPRA
            // 
            this.BTNACTUALIZAROCOMPRA.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZAROCOMPRA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZAROCOMPRA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZAROCOMPRA.Location = new System.Drawing.Point(860, 241);
            this.BTNACTUALIZAROCOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZAROCOMPRA.Name = "BTNACTUALIZAROCOMPRA";
            this.BTNACTUALIZAROCOMPRA.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZAROCOMPRA.TabIndex = 8;
            this.BTNACTUALIZAROCOMPRA.Text = "ACTUALIZAR";
            this.BTNACTUALIZAROCOMPRA.UseVisualStyleBackColor = false;
            this.BTNACTUALIZAROCOMPRA.Click += new System.EventHandler(this.BTNACTUALIZAROCOMPRA_Click);
            // 
            // TXTIDOCOMPRA
            // 
            this.TXTIDOCOMPRA.Location = new System.Drawing.Point(169, 50);
            this.TXTIDOCOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDOCOMPRA.Name = "TXTIDOCOMPRA";
            this.TXTIDOCOMPRA.Size = new System.Drawing.Size(317, 22);
            this.TXTIDOCOMPRA.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID ORDEN COMPRA";
            // 
            // DTPFECHACOMPRA
            // 
            this.DTPFECHACOMPRA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHACOMPRA.Location = new System.Drawing.Point(644, 51);
            this.DTPFECHACOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFECHACOMPRA.Name = "DTPFECHACOMPRA";
            this.DTPFECHACOMPRA.Size = new System.Drawing.Size(317, 22);
            this.DTPFECHACOMPRA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "CANTIDAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // DGVOCOMPRA
            // 
            this.DGVOCOMPRA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOCOMPRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOCOMPRA.Location = new System.Drawing.Point(33, 353);
            this.DGVOCOMPRA.Name = "DGVOCOMPRA";
            this.DGVOCOMPRA.RowHeadersWidth = 51;
            this.DGVOCOMPRA.RowTemplate.Height = 24;
            this.DGVOCOMPRA.Size = new System.Drawing.Size(1051, 172);
            this.DGVOCOMPRA.TabIndex = 9;
            this.DGVOCOMPRA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOCOMPRA_CellClick);
            this.DGVOCOMPRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOCOMPRA_CellContentClick);
            // 
            // ORDENCOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 554);
            this.Controls.Add(this.DGVOCOMPRA);
            this.Controls.Add(this.GBCOMPRA);
            this.Name = "ORDENCOMPRA";
            this.Text = "ORDENCOMPRA";
            this.Load += new System.EventHandler(this.ORDENCOMPRA_Load);
            this.GBCOMPRA.ResumeLayout(false);
            this.GBCOMPRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCANTIDADCOMPRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOCOMPRA)).EndInit();
            this.ResumeLayout(false);

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
    }
}