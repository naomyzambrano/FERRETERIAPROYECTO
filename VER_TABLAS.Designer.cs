namespace FERRETERIAPROYECTO
{
    partial class VER_TABLAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VER_TABLAS));
            this.VER = new System.Windows.Forms.TabControl();
            this.VER_PRO = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVVERLPRODUCTO = new System.Windows.Forms.DataGridView();
            this.VER_EMPLEADO = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVVEREMPLEADO = new System.Windows.Forms.DataGridView();
            this.VER_CLIENTE = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVVERCLEIENTE = new System.Windows.Forms.DataGridView();
            this.VER.SuspendLayout();
            this.VER_PRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVERLPRODUCTO)).BeginInit();
            this.VER_EMPLEADO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVEREMPLEADO)).BeginInit();
            this.VER_CLIENTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVERCLEIENTE)).BeginInit();
            this.SuspendLayout();
            // 
            // VER
            // 
            this.VER.Controls.Add(this.VER_PRO);
            this.VER.Controls.Add(this.VER_EMPLEADO);
            this.VER.Controls.Add(this.VER_CLIENTE);
            this.VER.Location = new System.Drawing.Point(3, 1);
            this.VER.Name = "VER";
            this.VER.SelectedIndex = 0;
            this.VER.Size = new System.Drawing.Size(952, 503);
            this.VER.TabIndex = 0;
            // 
            // VER_PRO
            // 
            this.VER_PRO.BackColor = System.Drawing.Color.Linen;
            this.VER_PRO.Controls.Add(this.pictureBox1);
            this.VER_PRO.Controls.Add(this.label2);
            this.VER_PRO.Controls.Add(this.label1);
            this.VER_PRO.Controls.Add(this.DGVVERLPRODUCTO);
            this.VER_PRO.Location = new System.Drawing.Point(4, 22);
            this.VER_PRO.Name = "VER_PRO";
            this.VER_PRO.Padding = new System.Windows.Forms.Padding(3);
            this.VER_PRO.Size = new System.Drawing.Size(944, 477);
            this.VER_PRO.TabIndex = 0;
            this.VER_PRO.Text = "VER PRODUCTO";
            this.VER_PRO.Click += new System.EventHandler(this.VER_PRO_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "FERRETERIA KANAVI";
            // 
            // DGVVERLPRODUCTO
            // 
            this.DGVVERLPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVERLPRODUCTO.Location = new System.Drawing.Point(6, 126);
            this.DGVVERLPRODUCTO.Name = "DGVVERLPRODUCTO";
            this.DGVVERLPRODUCTO.Size = new System.Drawing.Size(932, 335);
            this.DGVVERLPRODUCTO.TabIndex = 0;
            // 
            // VER_EMPLEADO
            // 
            this.VER_EMPLEADO.BackColor = System.Drawing.Color.Linen;
            this.VER_EMPLEADO.Controls.Add(this.pictureBox2);
            this.VER_EMPLEADO.Controls.Add(this.label3);
            this.VER_EMPLEADO.Controls.Add(this.label4);
            this.VER_EMPLEADO.Controls.Add(this.DGVVEREMPLEADO);
            this.VER_EMPLEADO.Location = new System.Drawing.Point(4, 22);
            this.VER_EMPLEADO.Name = "VER_EMPLEADO";
            this.VER_EMPLEADO.Padding = new System.Windows.Forms.Padding(3);
            this.VER_EMPLEADO.Size = new System.Drawing.Size(944, 477);
            this.VER_EMPLEADO.TabIndex = 1;
            this.VER_EMPLEADO.Text = "VER EMPLEADO";
            this.VER_EMPLEADO.Click += new System.EventHandler(this.VER_EMPLEADO_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(221, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMPLEADOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "FERRETERIA KANAVI";
            // 
            // DGVVEREMPLEADO
            // 
            this.DGVVEREMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVEREMPLEADO.Location = new System.Drawing.Point(6, 119);
            this.DGVVEREMPLEADO.Name = "DGVVEREMPLEADO";
            this.DGVVEREMPLEADO.Size = new System.Drawing.Size(932, 352);
            this.DGVVEREMPLEADO.TabIndex = 0;
            // 
            // VER_CLIENTE
            // 
            this.VER_CLIENTE.BackColor = System.Drawing.Color.Linen;
            this.VER_CLIENTE.Controls.Add(this.pictureBox3);
            this.VER_CLIENTE.Controls.Add(this.label5);
            this.VER_CLIENTE.Controls.Add(this.label6);
            this.VER_CLIENTE.Controls.Add(this.DGVVERCLEIENTE);
            this.VER_CLIENTE.Location = new System.Drawing.Point(4, 22);
            this.VER_CLIENTE.Name = "VER_CLIENTE";
            this.VER_CLIENTE.Padding = new System.Windows.Forms.Padding(3);
            this.VER_CLIENTE.Size = new System.Drawing.Size(944, 477);
            this.VER_CLIENTE.TabIndex = 2;
            this.VER_CLIENTE.Text = "VER CLIENTE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(210, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "CLIENTES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 43);
            this.label6.TabIndex = 5;
            this.label6.Text = "FERRETERIA KANAVI";
            // 
            // DGVVERCLEIENTE
            // 
            this.DGVVERCLEIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVERCLEIENTE.Location = new System.Drawing.Point(16, 130);
            this.DGVVERCLEIENTE.Name = "DGVVERCLEIENTE";
            this.DGVVERCLEIENTE.Size = new System.Drawing.Size(922, 337);
            this.DGVVERCLEIENTE.TabIndex = 0;
            // 
            // VER_TABLAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(967, 509);
            this.Controls.Add(this.VER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VER_TABLAS";
            this.Text = "VER_TABLAS";
            this.Load += new System.EventHandler(this.VER_TABLAS_Load);
            this.VER.ResumeLayout(false);
            this.VER_PRO.ResumeLayout(false);
            this.VER_PRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVERLPRODUCTO)).EndInit();
            this.VER_EMPLEADO.ResumeLayout(false);
            this.VER_EMPLEADO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVEREMPLEADO)).EndInit();
            this.VER_CLIENTE.ResumeLayout(false);
            this.VER_CLIENTE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVERCLEIENTE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl VER;
        private System.Windows.Forms.TabPage VER_PRO;
        private System.Windows.Forms.TabPage VER_EMPLEADO;
        private System.Windows.Forms.TabPage VER_CLIENTE;
        private System.Windows.Forms.DataGridView DGVVEREMPLEADO;
        private System.Windows.Forms.DataGridView DGVVERCLEIENTE;
        private System.Windows.Forms.DataGridView DGVVERLPRODUCTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}