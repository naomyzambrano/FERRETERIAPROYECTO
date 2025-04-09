namespace FERRETERIAPROYECTO
{
    partial class PLANILLA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLANILLA));
            this.GBPLANILLA = new System.Windows.Forms.GroupBox();
            this.CMBEMPLEADOSPLANI = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPFECHAFIN = new System.Windows.Forms.DateTimePicker();
            this.TXTMONTOPLANI = new System.Windows.Forms.TextBox();
            this.TXTIDPLANILLA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFECHAINICIO = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAGREGARPLANI = new System.Windows.Forms.Button();
            this.BTNELIMINARPLANI = new System.Windows.Forms.Button();
            this.BTNACTUALIZARPLANI = new System.Windows.Forms.Button();
            this.DGVPLANILLA = new System.Windows.Forms.DataGridView();
            this.btnVOLVER = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GBPLANILLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPLANILLA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPLANILLA
            // 
            this.GBPLANILLA.BackColor = System.Drawing.Color.SandyBrown;
            this.GBPLANILLA.Controls.Add(this.CMBEMPLEADOSPLANI);
            this.GBPLANILLA.Controls.Add(this.label4);
            this.GBPLANILLA.Controls.Add(this.label3);
            this.GBPLANILLA.Controls.Add(this.DTPFECHAFIN);
            this.GBPLANILLA.Controls.Add(this.TXTMONTOPLANI);
            this.GBPLANILLA.Controls.Add(this.TXTIDPLANILLA);
            this.GBPLANILLA.Controls.Add(this.label8);
            this.GBPLANILLA.Controls.Add(this.label6);
            this.GBPLANILLA.Controls.Add(this.label2);
            this.GBPLANILLA.Controls.Add(this.DTPFECHAINICIO);
            this.GBPLANILLA.Controls.Add(this.label1);
            this.GBPLANILLA.Location = new System.Drawing.Point(22, 70);
            this.GBPLANILLA.Margin = new System.Windows.Forms.Padding(2);
            this.GBPLANILLA.Name = "GBPLANILLA";
            this.GBPLANILLA.Padding = new System.Windows.Forms.Padding(2);
            this.GBPLANILLA.Size = new System.Drawing.Size(919, 202);
            this.GBPLANILLA.TabIndex = 10;
            this.GBPLANILLA.TabStop = false;
            this.GBPLANILLA.Text = "REGISTRO PLANILLA";
            // 
            // CMBEMPLEADOSPLANI
            // 
            this.CMBEMPLEADOSPLANI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBEMPLEADOSPLANI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBEMPLEADOSPLANI.FormattingEnabled = true;
            this.CMBEMPLEADOSPLANI.Location = new System.Drawing.Point(148, 103);
            this.CMBEMPLEADOSPLANI.Margin = new System.Windows.Forms.Padding(2);
            this.CMBEMPLEADOSPLANI.Name = "CMBEMPLEADOSPLANI";
            this.CMBEMPLEADOSPLANI.Size = new System.Drawing.Size(278, 23);
            this.CMBEMPLEADOSPLANI.TabIndex = 2;
            this.CMBEMPLEADOSPLANI.SelectedIndexChanged += new System.EventHandler(this.CMBEMPLEADOSPLANI_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "FECHA FINAL";
            // 
            // DTPFECHAFIN
            // 
            this.DTPFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAFIN.Location = new System.Drawing.Point(596, 104);
            this.DTPFECHAFIN.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFECHAFIN.Name = "DTPFECHAFIN";
            this.DTPFECHAFIN.Size = new System.Drawing.Size(278, 21);
            this.DTPFECHAFIN.TabIndex = 5;
            // 
            // TXTMONTOPLANI
            // 
            this.TXTMONTOPLANI.Location = new System.Drawing.Point(148, 159);
            this.TXTMONTOPLANI.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMONTOPLANI.Name = "TXTMONTOPLANI";
            this.TXTMONTOPLANI.Size = new System.Drawing.Size(278, 21);
            this.TXTMONTOPLANI.TabIndex = 3;
            // 
            // TXTIDPLANILLA
            // 
            this.TXTIDPLANILLA.Location = new System.Drawing.Point(148, 47);
            this.TXTIDPLANILLA.Margin = new System.Windows.Forms.Padding(2);
            this.TXTIDPLANILLA.Name = "TXTIDPLANILLA";
            this.TXTIDPLANILLA.Size = new System.Drawing.Size(278, 21);
            this.TXTIDPLANILLA.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "MONTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID PLANILLA";
            // 
            // DTPFECHAINICIO
            // 
            this.DTPFECHAINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAINICIO.Location = new System.Drawing.Point(596, 46);
            this.DTPFECHAINICIO.Margin = new System.Windows.Forms.Padding(2);
            this.DTPFECHAINICIO.Name = "DTPFECHAINICIO";
            this.DTPFECHAINICIO.Size = new System.Drawing.Size(278, 21);
            this.DTPFECHAINICIO.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-85, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // BTNAGREGARPLANI
            // 
            this.BTNAGREGARPLANI.BackColor = System.Drawing.Color.Chocolate;
            this.BTNAGREGARPLANI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARPLANI.Location = new System.Drawing.Point(449, 293);
            this.BTNAGREGARPLANI.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAGREGARPLANI.Name = "BTNAGREGARPLANI";
            this.BTNAGREGARPLANI.Size = new System.Drawing.Size(138, 48);
            this.BTNAGREGARPLANI.TabIndex = 6;
            this.BTNAGREGARPLANI.Text = "AGREGAR";
            this.BTNAGREGARPLANI.UseVisualStyleBackColor = false;
            this.BTNAGREGARPLANI.Click += new System.EventHandler(this.BTNAGREGARPLANI_Click);
            // 
            // BTNELIMINARPLANI
            // 
            this.BTNELIMINARPLANI.BackColor = System.Drawing.Color.Chocolate;
            this.BTNELIMINARPLANI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARPLANI.Location = new System.Drawing.Point(604, 293);
            this.BTNELIMINARPLANI.Margin = new System.Windows.Forms.Padding(2);
            this.BTNELIMINARPLANI.Name = "BTNELIMINARPLANI";
            this.BTNELIMINARPLANI.Size = new System.Drawing.Size(138, 48);
            this.BTNELIMINARPLANI.TabIndex = 7;
            this.BTNELIMINARPLANI.Text = "ELIMINAR";
            this.BTNELIMINARPLANI.UseVisualStyleBackColor = false;
            this.BTNELIMINARPLANI.Click += new System.EventHandler(this.BTNELIMINARPLANI_Click);
            // 
            // BTNACTUALIZARPLANI
            // 
            this.BTNACTUALIZARPLANI.BackColor = System.Drawing.Color.Chocolate;
            this.BTNACTUALIZARPLANI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARPLANI.Location = new System.Drawing.Point(758, 293);
            this.BTNACTUALIZARPLANI.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACTUALIZARPLANI.Name = "BTNACTUALIZARPLANI";
            this.BTNACTUALIZARPLANI.Size = new System.Drawing.Size(138, 48);
            this.BTNACTUALIZARPLANI.TabIndex = 8;
            this.BTNACTUALIZARPLANI.Text = "ACTUALIZAR";
            this.BTNACTUALIZARPLANI.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARPLANI.Click += new System.EventHandler(this.BTNACTUALIZARPLANI_Click);
            // 
            // DGVPLANILLA
            // 
            this.DGVPLANILLA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPLANILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPLANILLA.Location = new System.Drawing.Point(22, 365);
            this.DGVPLANILLA.Margin = new System.Windows.Forms.Padding(2);
            this.DGVPLANILLA.Name = "DGVPLANILLA";
            this.DGVPLANILLA.RowHeadersWidth = 51;
            this.DGVPLANILLA.RowTemplate.Height = 24;
            this.DGVPLANILLA.Size = new System.Drawing.Size(919, 153);
            this.DGVPLANILLA.TabIndex = 9;
            this.DGVPLANILLA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPLANILLA_CellClick);
            this.DGVPLANILLA.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPLANILLA_CellContentDoubleClick);
            this.DGVPLANILLA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPLANILLA_CellDoubleClick);
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
            this.btnVOLVER.Location = new System.Drawing.Point(22, 17);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(49, 39);
            this.btnVOLVER.TabIndex = 15;
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "PLANILLA";
            // 
            // PLANILLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(961, 529);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.DGVPLANILLA);
            this.Controls.Add(this.GBPLANILLA);
            this.Controls.Add(this.BTNACTUALIZARPLANI);
            this.Controls.Add(this.BTNELIMINARPLANI);
            this.Controls.Add(this.BTNAGREGARPLANI);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PLANILLA";
            this.Text = "PLANILLA";
            this.Load += new System.EventHandler(this.PLANILLA_Load);
            this.GBPLANILLA.ResumeLayout(false);
            this.GBPLANILLA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPLANILLA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBPLANILLA;
        private System.Windows.Forms.ComboBox CMBEMPLEADOSPLANI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPFECHAFIN;
        private System.Windows.Forms.Button BTNAGREGARPLANI;
        private System.Windows.Forms.Button BTNELIMINARPLANI;
        private System.Windows.Forms.Button BTNACTUALIZARPLANI;
        private System.Windows.Forms.TextBox TXTMONTOPLANI;
        private System.Windows.Forms.TextBox TXTIDPLANILLA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFECHAINICIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVPLANILLA;
        private System.Windows.Forms.Button btnVOLVER;
        private System.Windows.Forms.Label label5;
    }
}