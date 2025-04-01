namespace FERRETERIAPROYECTO
{
    partial class EGRESOS
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
            this.GBEGRESOS = new System.Windows.Forms.GroupBox();
            this.CMBTIPOGASTO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPGASTOS = new System.Windows.Forms.DateTimePicker();
            this.TXTMONTOGASTO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNAGREGARGASTO = new System.Windows.Forms.Button();
            this.BTNELIMINARGASTO = new System.Windows.Forms.Button();
            this.BTNACTUALIZARGASTO = new System.Windows.Forms.Button();
            this.TXTDESCRIPCIONGASTO = new System.Windows.Forms.TextBox();
            this.TXTIDEGRESOS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVGASTO = new System.Windows.Forms.DataGridView();
            this.GBEGRESOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGASTO)).BeginInit();
            this.SuspendLayout();
            // 
            // GBEGRESOS
            // 
            this.GBEGRESOS.Controls.Add(this.CMBTIPOGASTO);
            this.GBEGRESOS.Controls.Add(this.label5);
            this.GBEGRESOS.Controls.Add(this.DTPGASTOS);
            this.GBEGRESOS.Controls.Add(this.TXTMONTOGASTO);
            this.GBEGRESOS.Controls.Add(this.label9);
            this.GBEGRESOS.Controls.Add(this.label8);
            this.GBEGRESOS.Controls.Add(this.label4);
            this.GBEGRESOS.Controls.Add(this.BTNAGREGARGASTO);
            this.GBEGRESOS.Controls.Add(this.BTNELIMINARGASTO);
            this.GBEGRESOS.Controls.Add(this.BTNACTUALIZARGASTO);
            this.GBEGRESOS.Controls.Add(this.TXTDESCRIPCIONGASTO);
            this.GBEGRESOS.Controls.Add(this.TXTIDEGRESOS);
            this.GBEGRESOS.Controls.Add(this.label2);
            this.GBEGRESOS.Controls.Add(this.label3);
            this.GBEGRESOS.Controls.Add(this.label1);
            this.GBEGRESOS.Location = new System.Drawing.Point(12, 43);
            this.GBEGRESOS.Name = "GBEGRESOS";
            this.GBEGRESOS.Size = new System.Drawing.Size(1075, 323);
            this.GBEGRESOS.TabIndex = 11;
            this.GBEGRESOS.TabStop = false;
            this.GBEGRESOS.Text = "REGISTRO EGRESOS";
            // 
            // CMBTIPOGASTO
            // 
            this.CMBTIPOGASTO.FormattingEnabled = true;
            this.CMBTIPOGASTO.Location = new System.Drawing.Point(152, 115);
            this.CMBTIPOGASTO.Name = "CMBTIPOGASTO";
            this.CMBTIPOGASTO.Size = new System.Drawing.Size(317, 24);
            this.CMBTIPOGASTO.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "TIPO DE GASTO";
            // 
            // DTPGASTOS
            // 
            this.DTPGASTOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPGASTOS.Location = new System.Drawing.Point(642, 62);
            this.DTPGASTOS.Name = "DTPGASTOS";
            this.DTPGASTOS.Size = new System.Drawing.Size(317, 22);
            this.DTPGASTOS.TabIndex = 25;
            // 
            // TXTMONTOGASTO
            // 
            this.TXTMONTOGASTO.Location = new System.Drawing.Point(642, 117);
            this.TXTMONTOGASTO.Name = "TXTMONTOGASTO";
            this.TXTMONTOGASTO.Size = new System.Drawing.Size(317, 22);
            this.TXTMONTOGASTO.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "MONTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "FECHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 20;
            // 
            // BTNAGREGARGASTO
            // 
            this.BTNAGREGARGASTO.Location = new System.Drawing.Point(501, 249);
            this.BTNAGREGARGASTO.Name = "BTNAGREGARGASTO";
            this.BTNAGREGARGASTO.Size = new System.Drawing.Size(158, 55);
            this.BTNAGREGARGASTO.TabIndex = 3;
            this.BTNAGREGARGASTO.Text = "AGREGAR";
            this.BTNAGREGARGASTO.UseVisualStyleBackColor = true;
            this.BTNAGREGARGASTO.Click += new System.EventHandler(this.BTNAGREGARGASTO_Click);
            // 
            // BTNELIMINARGASTO
            // 
            this.BTNELIMINARGASTO.Location = new System.Drawing.Point(680, 249);
            this.BTNELIMINARGASTO.Name = "BTNELIMINARGASTO";
            this.BTNELIMINARGASTO.Size = new System.Drawing.Size(158, 55);
            this.BTNELIMINARGASTO.TabIndex = 2;
            this.BTNELIMINARGASTO.Text = "ELIMINAR";
            this.BTNELIMINARGASTO.UseVisualStyleBackColor = true;
            this.BTNELIMINARGASTO.Click += new System.EventHandler(this.BTNELIMINARGASTO_Click);
            // 
            // BTNACTUALIZARGASTO
            // 
            this.BTNACTUALIZARGASTO.Location = new System.Drawing.Point(868, 249);
            this.BTNACTUALIZARGASTO.Name = "BTNACTUALIZARGASTO";
            this.BTNACTUALIZARGASTO.Size = new System.Drawing.Size(158, 55);
            this.BTNACTUALIZARGASTO.TabIndex = 1;
            this.BTNACTUALIZARGASTO.Text = "ACTUALIZAR";
            this.BTNACTUALIZARGASTO.UseVisualStyleBackColor = true;
            this.BTNACTUALIZARGASTO.Click += new System.EventHandler(this.BTNACTUALIZARGASTO_Click);
            // 
            // TXTDESCRIPCIONGASTO
            // 
            this.TXTDESCRIPCIONGASTO.Location = new System.Drawing.Point(152, 183);
            this.TXTDESCRIPCIONGASTO.Name = "TXTDESCRIPCIONGASTO";
            this.TXTDESCRIPCIONGASTO.Size = new System.Drawing.Size(807, 22);
            this.TXTDESCRIPCIONGASTO.TabIndex = 15;
            // 
            // TXTIDEGRESOS
            // 
            this.TXTIDEGRESOS.Location = new System.Drawing.Point(152, 56);
            this.TXTIDEGRESOS.Name = "TXTIDEGRESOS";
            this.TXTIDEGRESOS.Size = new System.Drawing.Size(317, 22);
            this.TXTIDEGRESOS.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID EGRESOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DESCRIPCION";
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
            // DGVGASTO
            // 
            this.DGVGASTO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGASTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGASTO.Location = new System.Drawing.Point(13, 389);
            this.DGVGASTO.Name = "DGVGASTO";
            this.DGVGASTO.RowHeadersWidth = 51;
            this.DGVGASTO.RowTemplate.Height = 24;
            this.DGVGASTO.Size = new System.Drawing.Size(1074, 150);
            this.DGVGASTO.TabIndex = 12;
            this.DGVGASTO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGASTO_CellClick);
            // 
            // EGRESOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 551);
            this.Controls.Add(this.DGVGASTO);
            this.Controls.Add(this.GBEGRESOS);
            this.Name = "EGRESOS";
            this.Text = "EGRESOS";
            this.Load += new System.EventHandler(this.EGRESOS_Load);
            this.GBEGRESOS.ResumeLayout(false);
            this.GBEGRESOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGASTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBEGRESOS;
        private System.Windows.Forms.Button BTNAGREGARGASTO;
        private System.Windows.Forms.Button BTNELIMINARGASTO;
        private System.Windows.Forms.Button BTNACTUALIZARGASTO;
        private System.Windows.Forms.TextBox TXTDESCRIPCIONGASTO;
        private System.Windows.Forms.TextBox TXTIDEGRESOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPGASTOS;
        private System.Windows.Forms.TextBox TXTMONTOGASTO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMBTIPOGASTO;
        private System.Windows.Forms.DataGridView DGVGASTO;
    }
}