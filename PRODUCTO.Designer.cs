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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRODUCTO));
            this.GBPRODUCTO = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CMBCATEGORIAPRODU = new System.Windows.Forms.ComboBox();
            this.CMBPROVE = new System.Windows.Forms.ComboBox();
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
            this.DGVPRODUCTO = new System.Windows.Forms.DataGridView();
            this.GBPRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPRODUCTO)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPRODUCTO
            // 
            this.GBPRODUCTO.BackColor = System.Drawing.Color.Moccasin;
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
            this.GBPRODUCTO.Location = new System.Drawing.Point(21, 44);
            this.GBPRODUCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBPRODUCTO.Name = "GBPRODUCTO";
            this.GBPRODUCTO.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBPRODUCTO.Size = new System.Drawing.Size(1093, 434);
            this.GBPRODUCTO.TabIndex = 10;
            this.GBPRODUCTO.TabStop = false;
            this.GBPRODUCTO.Text = "REGISTRO PRODUCTO";
            this.GBPRODUCTO.Enter += new System.EventHandler(this.GBPRODUCTO_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "PRECIO COMPRA";
            // 
            // CMBCATEGORIAPRODU
            // 
            this.CMBCATEGORIAPRODU.FormattingEnabled = true;
            this.CMBCATEGORIAPRODU.Location = new System.Drawing.Point(169, 238);
            this.CMBCATEGORIAPRODU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBCATEGORIAPRODU.Name = "CMBCATEGORIAPRODU";
            this.CMBCATEGORIAPRODU.Size = new System.Drawing.Size(317, 23);
            this.CMBCATEGORIAPRODU.TabIndex = 24;
            this.CMBCATEGORIAPRODU.SelectedIndexChanged += new System.EventHandler(this.CMBCATEGORIAPRODU_SelectedIndexChanged);
            // 
            // CMBPROVE
            // 
            this.CMBPROVE.FormattingEnabled = true;
            this.CMBPROVE.Location = new System.Drawing.Point(683, 51);
            this.CMBPROVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMBPROVE.Name = "CMBPROVE";
            this.CMBPROVE.Size = new System.Drawing.Size(317, 23);
            this.CMBPROVE.TabIndex = 23;
            // 
            // TXTDESCRIPCIONPRODU
            // 
            this.TXTDESCRIPCIONPRODU.Location = new System.Drawing.Point(169, 301);
            this.TXTDESCRIPCIONPRODU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTDESCRIPCIONPRODU.Name = "TXTDESCRIPCIONPRODU";
            this.TXTDESCRIPCIONPRODU.Size = new System.Drawing.Size(831, 23);
            this.TXTDESCRIPCIONPRODU.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "DESCRIPCION";
            // 
            // TXTPRECIOVENTA
            // 
            this.TXTPRECIOVENTA.Location = new System.Drawing.Point(684, 197);
            this.TXTPRECIOVENTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTPRECIOVENTA.Name = "TXTPRECIOVENTA";
            this.TXTPRECIOVENTA.Size = new System.Drawing.Size(317, 23);
            this.TXTPRECIOVENTA.TabIndex = 20;
            // 
            // BTNAGREGARPRODU
            // 
            this.BTNAGREGARPRODU.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGARPRODU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARPRODU.Location = new System.Drawing.Point(485, 369);
            this.BTNAGREGARPRODU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARPRODU.Name = "BTNAGREGARPRODU";
            this.BTNAGREGARPRODU.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARPRODU.TabIndex = 3;
            this.BTNAGREGARPRODU.Text = "AGREGAR";
            this.BTNAGREGARPRODU.UseVisualStyleBackColor = false;
            this.BTNAGREGARPRODU.Click += new System.EventHandler(this.BTNAGREGARPRODU_Click);
            // 
            // BTNELIMINARPRODU
            // 
            this.BTNELIMINARPRODU.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARPRODU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARPRODU.Location = new System.Drawing.Point(683, 369);
            this.BTNELIMINARPRODU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARPRODU.Name = "BTNELIMINARPRODU";
            this.BTNELIMINARPRODU.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARPRODU.TabIndex = 2;
            this.BTNELIMINARPRODU.Text = "ELIMINAR";
            this.BTNELIMINARPRODU.UseVisualStyleBackColor = false;
            this.BTNELIMINARPRODU.Click += new System.EventHandler(this.BTNELIMINARPRODU_Click);
            // 
            // BTNACTUALIZARPRODU
            // 
            this.BTNACTUALIZARPRODU.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARPRODU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARPRODU.Location = new System.Drawing.Point(865, 369);
            this.BTNACTUALIZARPRODU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARPRODU.Name = "BTNACTUALIZARPRODU";
            this.BTNACTUALIZARPRODU.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARPRODU.TabIndex = 1;
            this.BTNACTUALIZARPRODU.Text = "ACTUALIZAR";
            this.BTNACTUALIZARPRODU.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARPRODU.Click += new System.EventHandler(this.BTNACTUALIZARPRODU_Click);
            // 
            // TXTPRECIOCOMPRA
            // 
            this.TXTPRECIOCOMPRA.Location = new System.Drawing.Point(684, 122);
            this.TXTPRECIOCOMPRA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTPRECIOCOMPRA.Name = "TXTPRECIOCOMPRA";
            this.TXTPRECIOCOMPRA.Size = new System.Drawing.Size(317, 23);
            this.TXTPRECIOCOMPRA.TabIndex = 17;
            // 
            // TXTSTOCK
            // 
            this.TXTSTOCK.Location = new System.Drawing.Point(169, 172);
            this.TXTSTOCK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSTOCK.Name = "TXTSTOCK";
            this.TXTSTOCK.Size = new System.Drawing.Size(317, 23);
            this.TXTSTOCK.TabIndex = 16;
            // 
            // TXTNOMBREPRODU
            // 
            this.TXTNOMBREPRODU.Location = new System.Drawing.Point(169, 107);
            this.TXTNOMBREPRODU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNOMBREPRODU.Name = "TXTNOMBREPRODU";
            this.TXTNOMBREPRODU.Size = new System.Drawing.Size(317, 23);
            this.TXTNOMBREPRODU.TabIndex = 15;
            // 
            // TXTIDPRODUCTO
            // 
            this.TXTIDPRODUCTO.Location = new System.Drawing.Point(169, 50);
            this.TXTIDPRODUCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDPRODUCTO.Name = "TXTIDPRODUCTO";
            this.TXTIDPRODUCTO.Size = new System.Drawing.Size(317, 23);
            this.TXTIDPRODUCTO.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "PRECIO VENTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "STOCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "CATEGORIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 113);
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
            // DGVPRODUCTO
            // 
            this.DGVPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPRODUCTO.Location = new System.Drawing.Point(29, 496);
            this.DGVPRODUCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVPRODUCTO.Name = "DGVPRODUCTO";
            this.DGVPRODUCTO.RowHeadersWidth = 51;
            this.DGVPRODUCTO.RowTemplate.Height = 24;
            this.DGVPRODUCTO.Size = new System.Drawing.Size(1085, 141);
            this.DGVPRODUCTO.TabIndex = 11;
            this.DGVPRODUCTO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPRODUCTO_CellClick);
            this.DGVPRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPRODUCTO_CellContentClick);
            // 
            // PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1141, 714);
            this.Controls.Add(this.DGVPRODUCTO);
            this.Controls.Add(this.GBPRODUCTO);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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