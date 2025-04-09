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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.GBEMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNACTUALIZARE
            // 
            this.BTNACTUALIZARE.BackColor = System.Drawing.Color.Chocolate;
            this.BTNACTUALIZARE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZARE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARE.Location = new System.Drawing.Point(760, 456);
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
            this.BTNELIMINARE.BackColor = System.Drawing.Color.Chocolate;
            this.BTNELIMINARE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARE.Location = new System.Drawing.Point(549, 456);
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
            this.DTPFECHAE.Location = new System.Drawing.Point(602, 52);
            this.DTPFECHAE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFECHAE.Name = "DTPFECHAE";
            this.DTPFECHAE.Size = new System.Drawing.Size(244, 23);
            this.DTPFECHAE.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
            // 
            // GBEMP
            // 
            this.GBEMP.BackColor = System.Drawing.Color.SandyBrown;
            this.GBEMP.Controls.Add(this.cmbcargo);
            this.GBEMP.Controls.Add(this.TXTCONTRAE);
            this.GBEMP.Controls.Add(this.label10);
            this.GBEMP.Controls.Add(this.TXTSUELDOE);
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
            this.GBEMP.Location = new System.Drawing.Point(35, 125);
            this.GBEMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEMP.Name = "GBEMP";
            this.GBEMP.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBEMP.Size = new System.Drawing.Size(882, 327);
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
            this.cmbcargo.Location = new System.Drawing.Point(602, 172);
            this.cmbcargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(244, 23);
            this.cmbcargo.TabIndex = 8;
            // 
            // TXTCONTRAE
            // 
            this.TXTCONTRAE.Location = new System.Drawing.Point(169, 293);
            this.TXTCONTRAE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTCONTRAE.Name = "TXTCONTRAE";
            this.TXTCONTRAE.Size = new System.Drawing.Size(272, 23);
            this.TXTCONTRAE.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "CONTRASEÑA";
            // 
            // TXTSUELDOE
            // 
            this.TXTSUELDOE.Location = new System.Drawing.Point(602, 240);
            this.TXTSUELDOE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSUELDOE.Name = "TXTSUELDOE";
            this.TXTSUELDOE.Size = new System.Drawing.Size(244, 23);
            this.TXTSUELDOE.TabIndex = 9;
            // 
            // BTNAGREGARE
            // 
            this.BTNAGREGARE.BackColor = System.Drawing.Color.Chocolate;
            this.BTNAGREGARE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNAGREGARE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAGREGARE.ImageKey = "(ninguno)";
            this.BTNAGREGARE.Location = new System.Drawing.Point(359, 456);
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
            this.TXTTELEFONOE.Location = new System.Drawing.Point(602, 107);
            this.TXTTELEFONOE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTTELEFONOE.Name = "TXTTELEFONOE";
            this.TXTTELEFONOE.Size = new System.Drawing.Size(244, 23);
            this.TXTTELEFONOE.TabIndex = 7;
            // 
            // TXTDNIE
            // 
            this.TXTDNIE.Location = new System.Drawing.Point(169, 232);
            this.TXTDNIE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTDNIE.Name = "TXTDNIE";
            this.TXTDNIE.Size = new System.Drawing.Size(272, 23);
            this.TXTDNIE.TabIndex = 4;
            // 
            // TXTAPELLIDOE
            // 
            this.TXTAPELLIDOE.Location = new System.Drawing.Point(169, 172);
            this.TXTAPELLIDOE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTAPELLIDOE.Name = "TXTAPELLIDOE";
            this.TXTAPELLIDOE.Size = new System.Drawing.Size(272, 23);
            this.TXTAPELLIDOE.TabIndex = 3;
            // 
            // TXTNOMBREE
            // 
            this.TXTNOMBREE.Location = new System.Drawing.Point(169, 107);
            this.TXTNOMBREE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNOMBREE.Name = "TXTNOMBREE";
            this.TXTNOMBREE.Size = new System.Drawing.Size(272, 23);
            this.TXTNOMBREE.TabIndex = 2;
            // 
            // TXTIDEMPLEADO
            // 
            this.TXTIDEMPLEADO.Location = new System.Drawing.Point(169, 50);
            this.TXTIDEMPLEADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDEMPLEADO.Name = "TXTIDEMPLEADO";
            this.TXTIDEMPLEADO.Size = new System.Drawing.Size(272, 23);
            this.TXTIDEMPLEADO.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(511, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "SUELDO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "APELLIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CARGO";
            // 
            // DGVEMPLEADO
            // 
            this.DGVEMPLEADO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADO.Location = new System.Drawing.Point(35, 512);
            this.DGVEMPLEADO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVEMPLEADO.Name = "DGVEMPLEADO";
            this.DGVEMPLEADO.RowHeadersWidth = 51;
            this.DGVEMPLEADO.RowTemplate.Height = 24;
            this.DGVEMPLEADO.Size = new System.Drawing.Size(882, 220);
            this.DGVEMPLEADO.TabIndex = 13;
            this.DGVEMPLEADO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEMPLEADO_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(343, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(375, 29);
            this.label15.TabIndex = 24;
            this.label15.Text = "REGISTRO DE PROVEEDORES ";
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
            this.btnVOLVER.Location = new System.Drawing.Point(72, 33);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(49, 39);
            this.btnVOLVER.TabIndex = 23;
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(954, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.DGVEMPLEADO);
            this.Controls.Add(this.GBEMP);
            this.Controls.Add(this.BTNACTUALIZARE);
            this.Controls.Add(this.BTNELIMINARE);
            this.Controls.Add(this.BTNAGREGARE);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EMPLEADO";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.EMPLEADO_Load);
            this.GBEMP.ResumeLayout(false);
            this.GBEMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnVOLVER;
    }
}