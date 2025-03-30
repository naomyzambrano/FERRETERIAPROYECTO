namespace FERRETERIAPROYECTO
{
    partial class EMPLEADO
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
            this.BTNACTUALIZARE = new System.Windows.Forms.Button();
            this.BTNELIMINARE = new System.Windows.Forms.Button();
            this.BTNAGREGARE = new System.Windows.Forms.Button();
            this.DTPFECHAE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBEMP = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTIDEMPLEADO = new System.Windows.Forms.TextBox();
            this.TXTNOMBREE = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDOE = new System.Windows.Forms.TextBox();
            this.TXTDNIE = new System.Windows.Forms.TextBox();
            this.TXTTELEFONOE = new System.Windows.Forms.TextBox();
            this.TXTCARGOE = new System.Windows.Forms.TextBox();
            this.TXTSUELDOE = new System.Windows.Forms.TextBox();
            this.TXTCONTRAE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVEMPLEADO = new System.Windows.Forms.DataGridView();
            this.GBEMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNACTUALIZARE
            // 
            this.BTNACTUALIZARE.Location = new System.Drawing.Point(865, 394);
            this.BTNACTUALIZARE.Name = "BTNACTUALIZARE";
            this.BTNACTUALIZARE.Size = new System.Drawing.Size(158, 55);
            this.BTNACTUALIZARE.TabIndex = 1;
            this.BTNACTUALIZARE.Text = "ACTUALIZAR";
            this.BTNACTUALIZARE.UseVisualStyleBackColor = true;
            this.BTNACTUALIZARE.Click += new System.EventHandler(this.BTNACTUALIZARE_Click);
            // 
            // BTNELIMINARE
            // 
            this.BTNELIMINARE.Location = new System.Drawing.Point(683, 394);
            this.BTNELIMINARE.Name = "BTNELIMINARE";
            this.BTNELIMINARE.Size = new System.Drawing.Size(158, 55);
            this.BTNELIMINARE.TabIndex = 2;
            this.BTNELIMINARE.Text = "ELIMINAR";
            this.BTNELIMINARE.UseVisualStyleBackColor = true;
            this.BTNELIMINARE.Click += new System.EventHandler(this.BTNELIMINARE_Click);
            // 
            // BTNAGREGARE
            // 
            this.BTNAGREGARE.Location = new System.Drawing.Point(486, 394);
            this.BTNAGREGARE.Name = "BTNAGREGARE";
            this.BTNAGREGARE.Size = new System.Drawing.Size(158, 55);
            this.BTNAGREGARE.TabIndex = 3;
            this.BTNAGREGARE.Text = "AGREGAR";
            this.BTNAGREGARE.UseVisualStyleBackColor = true;
            this.BTNAGREGARE.Click += new System.EventHandler(this.BTNAGREGARE_Click);
            // 
            // DTPFECHAE
            // 
            this.DTPFECHAE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAE.Location = new System.Drawing.Point(644, 54);
            this.DTPFECHAE.Name = "DTPFECHAE";
            this.DTPFECHAE.Size = new System.Drawing.Size(317, 22);
            this.DTPFECHAE.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID EMPLEADO";
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
            // GBEMP
            // 
            this.GBEMP.Controls.Add(this.TXTCONTRAE);
            this.GBEMP.Controls.Add(this.label10);
            this.GBEMP.Controls.Add(this.TXTSUELDOE);
            this.GBEMP.Controls.Add(this.BTNAGREGARE);
            this.GBEMP.Controls.Add(this.TXTCARGOE);
            this.GBEMP.Controls.Add(this.BTNELIMINARE);
            this.GBEMP.Controls.Add(this.BTNACTUALIZARE);
            this.GBEMP.Controls.Add(this.TXTTELEFONOE);
            this.GBEMP.Controls.Add(this.TXTDNIE);
            this.GBEMP.Controls.Add(this.TXTAPELLIDOE);
            this.GBEMP.Controls.Add(this.TXTNOMBREE);
            this.GBEMP.Controls.Add(this.TXTIDEMPLEADO);
            this.GBEMP.Controls.Add(this.label9);
            this.GBEMP.Controls.Add(this.label8);
            this.GBEMP.Controls.Add(this.label7);
            this.GBEMP.Controls.Add(this.label6);
            this.GBEMP.Controls.Add(this.label5);
            this.GBEMP.Controls.Add(this.label4);
            this.GBEMP.Controls.Add(this.label2);
            this.GBEMP.Controls.Add(this.DTPFECHAE);
            this.GBEMP.Controls.Add(this.label3);
            this.GBEMP.Controls.Add(this.label1);
            this.GBEMP.Location = new System.Drawing.Point(34, 26);
            this.GBEMP.Name = "GBEMP";
            this.GBEMP.Size = new System.Drawing.Size(1050, 475);
            this.GBEMP.TabIndex = 8;
            this.GBEMP.TabStop = false;
            this.GBEMP.Text = "REGISTRO EMPLEADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CARGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "APELLIDO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "SUELDO";
            // 
            // TXTIDEMPLEADO
            // 
            this.TXTIDEMPLEADO.Location = new System.Drawing.Point(169, 53);
            this.TXTIDEMPLEADO.Name = "TXTIDEMPLEADO";
            this.TXTIDEMPLEADO.Size = new System.Drawing.Size(317, 22);
            this.TXTIDEMPLEADO.TabIndex = 14;
            // 
            // TXTNOMBREE
            // 
            this.TXTNOMBREE.Location = new System.Drawing.Point(169, 114);
            this.TXTNOMBREE.Name = "TXTNOMBREE";
            this.TXTNOMBREE.Size = new System.Drawing.Size(317, 22);
            this.TXTNOMBREE.TabIndex = 15;
            // 
            // TXTAPELLIDOE
            // 
            this.TXTAPELLIDOE.Location = new System.Drawing.Point(169, 183);
            this.TXTAPELLIDOE.Name = "TXTAPELLIDOE";
            this.TXTAPELLIDOE.Size = new System.Drawing.Size(317, 22);
            this.TXTAPELLIDOE.TabIndex = 16;
            // 
            // TXTDNIE
            // 
            this.TXTDNIE.Location = new System.Drawing.Point(169, 247);
            this.TXTDNIE.Name = "TXTDNIE";
            this.TXTDNIE.Size = new System.Drawing.Size(317, 22);
            this.TXTDNIE.TabIndex = 17;
            // 
            // TXTTELEFONOE
            // 
            this.TXTTELEFONOE.Location = new System.Drawing.Point(644, 114);
            this.TXTTELEFONOE.Name = "TXTTELEFONOE";
            this.TXTTELEFONOE.Size = new System.Drawing.Size(317, 22);
            this.TXTTELEFONOE.TabIndex = 18;
            // 
            // TXTCARGOE
            // 
            this.TXTCARGOE.Location = new System.Drawing.Point(644, 186);
            this.TXTCARGOE.Name = "TXTCARGOE";
            this.TXTCARGOE.Size = new System.Drawing.Size(317, 22);
            this.TXTCARGOE.TabIndex = 19;
            // 
            // TXTSUELDOE
            // 
            this.TXTSUELDOE.Location = new System.Drawing.Point(644, 256);
            this.TXTSUELDOE.Name = "TXTSUELDOE";
            this.TXTSUELDOE.Size = new System.Drawing.Size(317, 22);
            this.TXTSUELDOE.TabIndex = 20;
            // 
            // TXTCONTRAE
            // 
            this.TXTCONTRAE.Location = new System.Drawing.Point(169, 313);
            this.TXTCONTRAE.Name = "TXTCONTRAE";
            this.TXTCONTRAE.Size = new System.Drawing.Size(317, 22);
            this.TXTCONTRAE.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "CONTRASEÑA";
            // 
            // DGVEMPLEADO
            // 
            this.DGVEMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADO.Location = new System.Drawing.Point(44, 539);
            this.DGVEMPLEADO.Name = "DGVEMPLEADO";
            this.DGVEMPLEADO.RowHeadersWidth = 51;
            this.DGVEMPLEADO.RowTemplate.Height = 24;
            this.DGVEMPLEADO.Size = new System.Drawing.Size(1040, 150);
            this.DGVEMPLEADO.TabIndex = 9;
            this.DGVEMPLEADO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEMPLEADO_CellClick);
            // 
            // EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 732);
            this.Controls.Add(this.DGVEMPLEADO);
            this.Controls.Add(this.GBEMP);
            this.Name = "EMPLEADO";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.EMPLEADO_Load);
            this.GBEMP.ResumeLayout(false);
            this.GBEMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNACTUALIZARE;
        private System.Windows.Forms.Button BTNELIMINARE;
        private System.Windows.Forms.Button BTNAGREGARE;
        private System.Windows.Forms.DateTimePicker DTPFECHAE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBEMP;
        private System.Windows.Forms.TextBox TXTDNIE;
        private System.Windows.Forms.TextBox TXTAPELLIDOE;
        private System.Windows.Forms.TextBox TXTNOMBREE;
        private System.Windows.Forms.TextBox TXTIDEMPLEADO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTCONTRAE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTSUELDOE;
        private System.Windows.Forms.TextBox TXTCARGOE;
        private System.Windows.Forms.TextBox TXTTELEFONOE;
        private System.Windows.Forms.DataGridView DGVEMPLEADO;
    }
}