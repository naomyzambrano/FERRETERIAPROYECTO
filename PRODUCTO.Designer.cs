namespace FERRETERIAPROYECTO
{
    partial class PRODUCTO
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
            this.GBPRODUCTO = new System.Windows.Forms.GroupBox();
            this.TXTDESCRIPCIONPRODU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTPRECIOVENTA = new System.Windows.Forms.TextBox();
            this.BTNAGREGARPRODU = new System.Windows.Forms.Button();
            this.BTNELIMINARPRODU = new System.Windows.Forms.Button();
            this.BTNACTUALIZARPRODU = new System.Windows.Forms.Button();
            this.TXTPRECIOCOMPRA = new System.Windows.Forms.TextBox();
            this.TXTSTOCK = new System.Windows.Forms.TextBox();
            this.TXTNOMBREPRODU = new System.Windows.Forms.TextBox();
            this.TXTIDPRODUCTO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBPROVE = new System.Windows.Forms.ComboBox();
            this.CMBCATEGORIAPRODU = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DGVPRODUCTO = new System.Windows.Forms.DataGridView();
            this.GBPRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRODUCTO)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPRODUCTO
            // 
            this.GBPRODUCTO.Controls.Add(this.label11);
            this.GBPRODUCTO.Controls.Add(this.CMBCATEGORIAPRODU);
            this.GBPRODUCTO.Controls.Add(this.CMBPROVE);
            this.GBPRODUCTO.Controls.Add(this.TXTDESCRIPCIONPRODU);
            this.GBPRODUCTO.Controls.Add(this.label10);
            this.GBPRODUCTO.Controls.Add(this.TXTPRECIOVENTA);
            this.GBPRODUCTO.Controls.Add(this.BTNAGREGARPRODU);
            this.GBPRODUCTO.Controls.Add(this.BTNELIMINARPRODU);
            this.GBPRODUCTO.Controls.Add(this.BTNACTUALIZARPRODU);
            this.GBPRODUCTO.Controls.Add(this.TXTPRECIOCOMPRA);
            this.GBPRODUCTO.Controls.Add(this.TXTSTOCK);
            this.GBPRODUCTO.Controls.Add(this.TXTNOMBREPRODU);
            this.GBPRODUCTO.Controls.Add(this.TXTIDPRODUCTO);
            this.GBPRODUCTO.Controls.Add(this.label9);
            this.GBPRODUCTO.Controls.Add(this.label8);
            this.GBPRODUCTO.Controls.Add(this.label7);
            this.GBPRODUCTO.Controls.Add(this.label6);
            this.GBPRODUCTO.Controls.Add(this.label5);
            this.GBPRODUCTO.Controls.Add(this.label4);
            this.GBPRODUCTO.Controls.Add(this.label2);
            this.GBPRODUCTO.Controls.Add(this.label3);
            this.GBPRODUCTO.Controls.Add(this.label1);
            this.GBPRODUCTO.Location = new System.Drawing.Point(21, 47);
            this.GBPRODUCTO.Name = "GBPRODUCTO";
            this.GBPRODUCTO.Size = new System.Drawing.Size(1094, 463);
            this.GBPRODUCTO.TabIndex = 10;
            this.GBPRODUCTO.TabStop = false;
            this.GBPRODUCTO.Text = "REGISTRO PRODUCTO";
            this.GBPRODUCTO.Enter += new System.EventHandler(this.GBPRODUCTO_Enter);
            // 
            // TXTDESCRIPCIONPRODU
            // 
            this.TXTDESCRIPCIONPRODU.Location = new System.Drawing.Point(169, 321);
            this.TXTDESCRIPCIONPRODU.Name = "TXTDESCRIPCIONPRODU";
            this.TXTDESCRIPCIONPRODU.Size = new System.Drawing.Size(831, 22);
            this.TXTDESCRIPCIONPRODU.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "DESCRIPCION";
            // 
            // TXTPRECIOVENTA
            // 
            this.TXTPRECIOVENTA.Location = new System.Drawing.Point(684, 211);
            this.TXTPRECIOVENTA.Name = "TXTPRECIOVENTA";
            this.TXTPRECIOVENTA.Size = new System.Drawing.Size(317, 22);
            this.TXTPRECIOVENTA.TabIndex = 20;
            // 
            // BTNAGREGARPRODU
            // 
            this.BTNAGREGARPRODU.Location = new System.Drawing.Point(486, 394);
            this.BTNAGREGARPRODU.Name = "BTNAGREGARPRODU";
            this.BTNAGREGARPRODU.Size = new System.Drawing.Size(158, 55);
            this.BTNAGREGARPRODU.TabIndex = 3;
            this.BTNAGREGARPRODU.Text = "AGREGAR";
            this.BTNAGREGARPRODU.UseVisualStyleBackColor = true;
            this.BTNAGREGARPRODU.Click += new System.EventHandler(this.BTNAGREGARPRODU_Click);
            // 
            // BTNELIMINARPRODU
            // 
            this.BTNELIMINARPRODU.Location = new System.Drawing.Point(683, 394);
            this.BTNELIMINARPRODU.Name = "BTNELIMINARPRODU";
            this.BTNELIMINARPRODU.Size = new System.Drawing.Size(158, 55);
            this.BTNELIMINARPRODU.TabIndex = 2;
            this.BTNELIMINARPRODU.Text = "ELIMINAR";
            this.BTNELIMINARPRODU.UseVisualStyleBackColor = true;
            this.BTNELIMINARPRODU.Click += new System.EventHandler(this.BTNELIMINARPRODU_Click);
            // 
            // BTNACTUALIZARPRODU
            // 
            this.BTNACTUALIZARPRODU.Location = new System.Drawing.Point(865, 394);
            this.BTNACTUALIZARPRODU.Name = "BTNACTUALIZARPRODU";
            this.BTNACTUALIZARPRODU.Size = new System.Drawing.Size(158, 55);
            this.BTNACTUALIZARPRODU.TabIndex = 1;
            this.BTNACTUALIZARPRODU.Text = "ACTUALIZAR";
            this.BTNACTUALIZARPRODU.UseVisualStyleBackColor = true;
            this.BTNACTUALIZARPRODU.Click += new System.EventHandler(this.BTNACTUALIZARPRODU_Click);
            // 
            // TXTPRECIOCOMPRA
            // 
            this.TXTPRECIOCOMPRA.Location = new System.Drawing.Point(684, 130);
            this.TXTPRECIOCOMPRA.Name = "TXTPRECIOCOMPRA";
            this.TXTPRECIOCOMPRA.Size = new System.Drawing.Size(317, 22);
            this.TXTPRECIOCOMPRA.TabIndex = 17;
            // 
            // TXTSTOCK
            // 
            this.TXTSTOCK.Location = new System.Drawing.Point(169, 183);
            this.TXTSTOCK.Name = "TXTSTOCK";
            this.TXTSTOCK.Size = new System.Drawing.Size(317, 22);
            this.TXTSTOCK.TabIndex = 16;
            // 
            // TXTNOMBREPRODU
            // 
            this.TXTNOMBREPRODU.Location = new System.Drawing.Point(169, 114);
            this.TXTNOMBREPRODU.Name = "TXTNOMBREPRODU";
            this.TXTNOMBREPRODU.Size = new System.Drawing.Size(317, 22);
            this.TXTNOMBREPRODU.TabIndex = 15;
            // 
            // TXTIDPRODUCTO
            // 
            this.TXTIDPRODUCTO.Location = new System.Drawing.Point(169, 53);
            this.TXTIDPRODUCTO.Name = "TXTIDPRODUCTO";
            this.TXTIDPRODUCTO.Size = new System.Drawing.Size(317, 22);
            this.TXTIDPRODUCTO.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "PRECIO VENTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "STOCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "CATEGORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
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
            // CMBPROVE
            // 
            this.CMBPROVE.FormattingEnabled = true;
            this.CMBPROVE.Location = new System.Drawing.Point(683, 54);
            this.CMBPROVE.Name = "CMBPROVE";
            this.CMBPROVE.Size = new System.Drawing.Size(317, 24);
            this.CMBPROVE.TabIndex = 23;
            // 
            // CMBCATEGORIAPRODU
            // 
            this.CMBCATEGORIAPRODU.FormattingEnabled = true;
            this.CMBCATEGORIAPRODU.Location = new System.Drawing.Point(169, 253);
            this.CMBCATEGORIAPRODU.Name = "CMBCATEGORIAPRODU";
            this.CMBCATEGORIAPRODU.Size = new System.Drawing.Size(317, 24);
            this.CMBCATEGORIAPRODU.TabIndex = 24;
            this.CMBCATEGORIAPRODU.SelectedIndexChanged += new System.EventHandler(this.CMBCATEGORIAPRODU_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "PRECIO COMPRA";
            // 
            // DGVPRODUCTO
            // 
            this.DGVPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPRODUCTO.Location = new System.Drawing.Point(30, 529);
            this.DGVPRODUCTO.Name = "DGVPRODUCTO";
            this.DGVPRODUCTO.RowHeadersWidth = 51;
            this.DGVPRODUCTO.RowTemplate.Height = 24;
            this.DGVPRODUCTO.Size = new System.Drawing.Size(1085, 150);
            this.DGVPRODUCTO.TabIndex = 11;
            this.DGVPRODUCTO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPRODUCTO_CellClick);
            this.DGVPRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPRODUCTO_CellContentClick);
            // 
            // PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 673);
            this.Controls.Add(this.DGVPRODUCTO);
            this.Controls.Add(this.GBPRODUCTO);
            this.Name = "PRODUCTO";
            this.Text = "PRODUCTO";
            this.Load += new System.EventHandler(this.PRODUCTO_Load);
            this.GBPRODUCTO.ResumeLayout(false);
            this.GBPRODUCTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRODUCTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBPRODUCTO;
        private System.Windows.Forms.ComboBox CMBCATEGORIAPRODU;
        private System.Windows.Forms.ComboBox CMBPROVE;
        private System.Windows.Forms.TextBox TXTDESCRIPCIONPRODU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTPRECIOVENTA;
        private System.Windows.Forms.Button BTNAGREGARPRODU;
        private System.Windows.Forms.Button BTNELIMINARPRODU;
        private System.Windows.Forms.Button BTNACTUALIZARPRODU;
        private System.Windows.Forms.TextBox TXTPRECIOCOMPRA;
        private System.Windows.Forms.TextBox TXTSTOCK;
        private System.Windows.Forms.TextBox TXTNOMBREPRODU;
        private System.Windows.Forms.TextBox TXTIDPRODUCTO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGVPRODUCTO;
    }
}