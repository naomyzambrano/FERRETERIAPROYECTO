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
            this.TXTDESCRIPCIONGASTO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNAGREGARGASTO = new System.Windows.Forms.Button();
            this.BTNELIMINARGASTO = new System.Windows.Forms.Button();
            this.BTNACTUALIZARGASTO = new System.Windows.Forms.Button();
            this.TXTMONTOGASTO = new System.Windows.Forms.TextBox();
            this.TXTIDEGRESOS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPGASTOS = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVGASTO = new System.Windows.Forms.DataGridView();
            this.GBEGRESOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGASTO)).BeginInit();
            this.SuspendLayout();
            // 
            // GBEGRESOS
            // 
            this.GBEGRESOS.Controls.Add(this.CMBTIPOGASTO);
            this.GBEGRESOS.Controls.Add(this.TXTDESCRIPCIONGASTO);
            this.GBEGRESOS.Controls.Add(this.label10);
            this.GBEGRESOS.Controls.Add(this.BTNAGREGARGASTO);
            this.GBEGRESOS.Controls.Add(this.BTNELIMINARGASTO);
            this.GBEGRESOS.Controls.Add(this.BTNACTUALIZARGASTO);
            this.GBEGRESOS.Controls.Add(this.TXTMONTOGASTO);
            this.GBEGRESOS.Controls.Add(this.TXTIDEGRESOS);
            this.GBEGRESOS.Controls.Add(this.label7);
            this.GBEGRESOS.Controls.Add(this.label6);
            this.GBEGRESOS.Controls.Add(this.label5);
            this.GBEGRESOS.Controls.Add(this.label2);
            this.GBEGRESOS.Controls.Add(this.DTPGASTOS);
            this.GBEGRESOS.Controls.Add(this.label1);
            this.GBEGRESOS.Location = new System.Drawing.Point(21, 23);
            this.GBEGRESOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEGRESOS.Name = "GBEGRESOS";
            this.GBEGRESOS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEGRESOS.Size = new System.Drawing.Size(1017, 303);
            this.GBEGRESOS.TabIndex = 10;
            this.GBEGRESOS.TabStop = false;
            this.GBEGRESOS.Text = "REGISTRO CLIENTE";
            // 
            // CMBTIPOGASTO
            // 
            this.CMBTIPOGASTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBTIPOGASTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBTIPOGASTO.FormattingEnabled = true;
            this.CMBTIPOGASTO.Location = new System.Drawing.Point(169, 113);
            this.CMBTIPOGASTO.Name = "CMBTIPOGASTO";
            this.CMBTIPOGASTO.Size = new System.Drawing.Size(317, 24);
            this.CMBTIPOGASTO.TabIndex = 2;
            // 
            // TXTDESCRIPCIONGASTO
            // 
            this.TXTDESCRIPCIONGASTO.Location = new System.Drawing.Point(169, 184);
            this.TXTDESCRIPCIONGASTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTDESCRIPCIONGASTO.Name = "TXTDESCRIPCIONGASTO";
            this.TXTDESCRIPCIONGASTO.Size = new System.Drawing.Size(831, 22);
            this.TXTDESCRIPCIONGASTO.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "DESCRIPCION";
            // 
            // BTNAGREGARGASTO
            // 
            this.BTNAGREGARGASTO.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGARGASTO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGARGASTO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARGASTO.Location = new System.Drawing.Point(463, 236);
            this.BTNAGREGARGASTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARGASTO.Name = "BTNAGREGARGASTO";
            this.BTNAGREGARGASTO.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARGASTO.TabIndex = 6;
            this.BTNAGREGARGASTO.Text = "AGREGAR";
            this.BTNAGREGARGASTO.UseVisualStyleBackColor = false;
            this.BTNAGREGARGASTO.Click += new System.EventHandler(this.BTNAGREGARGASTO_Click);
            // 
            // BTNELIMINARGASTO
            // 
            this.BTNELIMINARGASTO.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARGASTO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINARGASTO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARGASTO.Location = new System.Drawing.Point(652, 235);
            this.BTNELIMINARGASTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARGASTO.Name = "BTNELIMINARGASTO";
            this.BTNELIMINARGASTO.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARGASTO.TabIndex = 7;
            this.BTNELIMINARGASTO.Text = "ELIMINAR";
            this.BTNELIMINARGASTO.UseVisualStyleBackColor = false;
            this.BTNELIMINARGASTO.Click += new System.EventHandler(this.BTNELIMINARGASTO_Click);
            // 
            // BTNACTUALIZARGASTO
            // 
            this.BTNACTUALIZARGASTO.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARGASTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZARGASTO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARGASTO.Location = new System.Drawing.Point(843, 236);
            this.BTNACTUALIZARGASTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARGASTO.Name = "BTNACTUALIZARGASTO";
            this.BTNACTUALIZARGASTO.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARGASTO.TabIndex = 8;
            this.BTNACTUALIZARGASTO.Text = "ACTUALIZAR";
            this.BTNACTUALIZARGASTO.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARGASTO.Click += new System.EventHandler(this.BTNACTUALIZARGASTO_Click);
            // 
            // TXTMONTOGASTO
            // 
            this.TXTMONTOGASTO.Location = new System.Drawing.Point(683, 112);
            this.TXTMONTOGASTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTMONTOGASTO.Name = "TXTMONTOGASTO";
            this.TXTMONTOGASTO.Size = new System.Drawing.Size(317, 22);
            this.TXTMONTOGASTO.TabIndex = 5;
            // 
            // TXTIDEGRESOS
            // 
            this.TXTIDEGRESOS.Location = new System.Drawing.Point(169, 50);
            this.TXTIDEGRESOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDEGRESOS.Name = "TXTIDEGRESOS";
            this.TXTIDEGRESOS.Size = new System.Drawing.Size(317, 22);
            this.TXTIDEGRESOS.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "TIPO DE GASTO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(612, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "MONTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID EMPLEADO";
            // 
            // DTPGASTOS
            // 
            this.DTPGASTOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPGASTOS.Location = new System.Drawing.Point(683, 47);
            this.DTPGASTOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPGASTOS.Name = "DTPGASTOS";
            this.DTPGASTOS.Size = new System.Drawing.Size(317, 22);
            this.DTPGASTOS.TabIndex = 4;
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
            this.DGVGASTO.Location = new System.Drawing.Point(21, 340);
            this.DGVGASTO.Name = "DGVGASTO";
            this.DGVGASTO.RowHeadersWidth = 51;
            this.DGVGASTO.RowTemplate.Height = 24;
            this.DGVGASTO.Size = new System.Drawing.Size(1017, 203);
            this.DGVGASTO.TabIndex = 9;
            this.DGVGASTO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVGASTO_CellClick);
            // 
            // EGRESOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 570);
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
        private System.Windows.Forms.TextBox TXTDESCRIPCIONGASTO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTNAGREGARGASTO;
        private System.Windows.Forms.Button BTNELIMINARGASTO;
        private System.Windows.Forms.Button BTNACTUALIZARGASTO;
        private System.Windows.Forms.TextBox TXTMONTOGASTO;
        private System.Windows.Forms.TextBox TXTIDEGRESOS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPGASTOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVGASTO;
        private System.Windows.Forms.ComboBox CMBTIPOGASTO;
    }
}