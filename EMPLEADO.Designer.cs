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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLEADO));
            this.BTNACTUALIZARE = new System.Windows.Forms.Button();
            this.BTNELIMINARE = new System.Windows.Forms.Button();
            this.DTPFECHAE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBEMP = new System.Windows.Forms.GroupBox();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            this.TXTCONTRAE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTSUELDOE = new System.Windows.Forms.TextBox();
            this.BTNAGREGARE = new System.Windows.Forms.Button();
            this.TXTTELEFONOE = new System.Windows.Forms.TextBox();
            this.TXTDNIE = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDOE = new System.Windows.Forms.TextBox();
            this.TXTNOMBREE = new System.Windows.Forms.TextBox();
            this.TXTIDEMPLEADO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVEMPLEADO = new System.Windows.Forms.DataGridView();
            this.GBEMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNACTUALIZARE
            // 
            this.BTNACTUALIZARE.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZARE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARE.Location = new System.Drawing.Point(860, 347);
            this.BTNACTUALIZARE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARE.Name = "BTNACTUALIZARE";
            this.BTNACTUALIZARE.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARE.TabIndex = 12;
            this.BTNACTUALIZARE.Text = "ACTUALIZAR";
            this.BTNACTUALIZARE.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARE.Click += new System.EventHandler(this.BTNACTUALIZARE_Click);
            // 
            // BTNELIMINARE
            // 
            this.BTNELIMINARE.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARE.Location = new System.Drawing.Point(678, 347);
            this.BTNELIMINARE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARE.Name = "BTNELIMINARE";
            this.BTNELIMINARE.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARE.TabIndex = 11;
            this.BTNELIMINARE.Text = "ELIMINAR";
            this.BTNELIMINARE.UseVisualStyleBackColor = false;
            this.BTNELIMINARE.Click += new System.EventHandler(this.BTNELIMINARE_Click);
            // 
            // DTPFECHAE
            // 
            this.DTPFECHAE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAE.Location = new System.Drawing.Point(644, 51);
            this.DTPFECHAE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFECHAE.Name = "DTPFECHAE";
            this.DTPFECHAE.Size = new System.Drawing.Size(317, 26);
            this.DTPFECHAE.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-97, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
            // 
            // GBEMP
            // 
            this.GBEMP.Controls.Add(this.cmbcargo);
            this.GBEMP.Controls.Add(this.TXTCONTRAE);
            this.GBEMP.Controls.Add(this.label10);
            this.GBEMP.Controls.Add(this.TXTSUELDOE);
            this.GBEMP.Controls.Add(this.BTNAGREGARE);
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
            this.GBEMP.Location = new System.Drawing.Point(35, 25);
            this.GBEMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEMP.Name = "GBEMP";
            this.GBEMP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEMP.Size = new System.Drawing.Size(1051, 416);
            this.GBEMP.TabIndex = 8;
            this.GBEMP.TabStop = false;
            this.GBEMP.Text = "REGISTRO EMPLEADO";
            this.GBEMP.Enter += new System.EventHandler(this.GBEMP_Enter);
            // 
            // cmbcargo
            // 
            this.cmbcargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbcargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO",
            "ENCARGADO DE ALMACÉN"});
            this.cmbcargo.Location = new System.Drawing.Point(647, 171);
            this.cmbcargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(315, 26);
            this.cmbcargo.TabIndex = 8;
            // 
            // TXTCONTRAE
            // 
            this.TXTCONTRAE.Location = new System.Drawing.Point(169, 293);
            this.TXTCONTRAE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTCONTRAE.Name = "TXTCONTRAE";
            this.TXTCONTRAE.Size = new System.Drawing.Size(317, 26);
            this.TXTCONTRAE.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "CONTRASEÑA";
            // 
            // TXTSUELDOE
            // 
            this.TXTSUELDOE.Location = new System.Drawing.Point(644, 240);
            this.TXTSUELDOE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSUELDOE.Name = "TXTSUELDOE";
            this.TXTSUELDOE.Size = new System.Drawing.Size(317, 26);
            this.TXTSUELDOE.TabIndex = 9;
            // 
            // BTNAGREGARE
            // 
            this.BTNAGREGARE.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGARE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAGREGARE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAGREGARE.ImageKey = "(ninguno)";
            this.BTNAGREGARE.Location = new System.Drawing.Point(502, 347);
            this.BTNAGREGARE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARE.Name = "BTNAGREGARE";
            this.BTNAGREGARE.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARE.TabIndex = 10;
            this.BTNAGREGARE.Text = "AGREGAR";
            this.BTNAGREGARE.UseVisualStyleBackColor = false;
            this.BTNAGREGARE.Click += new System.EventHandler(this.BTNAGREGARE_Click);
            // 
            // TXTTELEFONOE
            // 
            this.TXTTELEFONOE.Location = new System.Drawing.Point(644, 107);
            this.TXTTELEFONOE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTTELEFONOE.Name = "TXTTELEFONOE";
            this.TXTTELEFONOE.Size = new System.Drawing.Size(317, 26);
            this.TXTTELEFONOE.TabIndex = 7;
            // 
            // TXTDNIE
            // 
            this.TXTDNIE.Location = new System.Drawing.Point(169, 232);
            this.TXTDNIE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTDNIE.Name = "TXTDNIE";
            this.TXTDNIE.Size = new System.Drawing.Size(317, 26);
            this.TXTDNIE.TabIndex = 4;
            // 
            // TXTAPELLIDOE
            // 
            this.TXTAPELLIDOE.Location = new System.Drawing.Point(169, 172);
            this.TXTAPELLIDOE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTAPELLIDOE.Name = "TXTAPELLIDOE";
            this.TXTAPELLIDOE.Size = new System.Drawing.Size(317, 26);
            this.TXTAPELLIDOE.TabIndex = 3;
            // 
            // TXTNOMBREE
            // 
            this.TXTNOMBREE.Location = new System.Drawing.Point(169, 107);
            this.TXTNOMBREE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNOMBREE.Name = "TXTNOMBREE";
            this.TXTNOMBREE.Size = new System.Drawing.Size(317, 26);
            this.TXTNOMBREE.TabIndex = 2;
            // 
            // TXTIDEMPLEADO
            // 
            this.TXTIDEMPLEADO.Location = new System.Drawing.Point(169, 50);
            this.TXTIDEMPLEADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDEMPLEADO.Name = "TXTIDEMPLEADO";
            this.TXTIDEMPLEADO.Size = new System.Drawing.Size(317, 26);
            this.TXTIDEMPLEADO.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "SUELDO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "APELLIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CARGO";
            // 
            // DGVEMPLEADO
            // 
            this.DGVEMPLEADO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADO.Location = new System.Drawing.Point(35, 456);
            this.DGVEMPLEADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVEMPLEADO.Name = "DGVEMPLEADO";
            this.DGVEMPLEADO.RowHeadersWidth = 51;
            this.DGVEMPLEADO.RowTemplate.Height = 24;
            this.DGVEMPLEADO.Size = new System.Drawing.Size(1051, 220);
            this.DGVEMPLEADO.TabIndex = 13;
            this.DGVEMPLEADO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEMPLEADO_CellClick);
            // 
            // EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1117, 687);
            this.Controls.Add(this.DGVEMPLEADO);
            this.Controls.Add(this.GBEMP);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.TextBox TXTTELEFONOE;
        private System.Windows.Forms.DataGridView DGVEMPLEADO;
        private System.Windows.Forms.ComboBox cmbcargo;
    }
}