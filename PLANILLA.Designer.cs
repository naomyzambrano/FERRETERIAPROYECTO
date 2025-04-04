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
            this.GBPLANILLA = new System.Windows.Forms.GroupBox();
            this.CMBEMPLEADOSPLANI = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPFECHAFIN = new System.Windows.Forms.DateTimePicker();
            this.BTNAGREGARPLANI = new System.Windows.Forms.Button();
            this.BTNELIMINARPLANI = new System.Windows.Forms.Button();
            this.BTNACTUALIZARPLANI = new System.Windows.Forms.Button();
            this.TXTMONTOPLANI = new System.Windows.Forms.TextBox();
            this.TXTIDPLANILLA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFECHAINICIO = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVPLANILLA = new System.Windows.Forms.DataGridView();
            this.GBPLANILLA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPLANILLA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPLANILLA
            // 
            this.GBPLANILLA.Controls.Add(this.CMBEMPLEADOSPLANI);
            this.GBPLANILLA.Controls.Add(this.label4);
            this.GBPLANILLA.Controls.Add(this.label3);
            this.GBPLANILLA.Controls.Add(this.DTPFECHAFIN);
            this.GBPLANILLA.Controls.Add(this.BTNAGREGARPLANI);
            this.GBPLANILLA.Controls.Add(this.BTNELIMINARPLANI);
            this.GBPLANILLA.Controls.Add(this.BTNACTUALIZARPLANI);
            this.GBPLANILLA.Controls.Add(this.TXTMONTOPLANI);
            this.GBPLANILLA.Controls.Add(this.TXTIDPLANILLA);
            this.GBPLANILLA.Controls.Add(this.label8);
            this.GBPLANILLA.Controls.Add(this.label6);
            this.GBPLANILLA.Controls.Add(this.label2);
            this.GBPLANILLA.Controls.Add(this.DTPFECHAINICIO);
            this.GBPLANILLA.Controls.Add(this.label1);
            this.GBPLANILLA.Location = new System.Drawing.Point(25, 30);
            this.GBPLANILLA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBPLANILLA.Name = "GBPLANILLA";
            this.GBPLANILLA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBPLANILLA.Size = new System.Drawing.Size(1051, 297);
            this.GBPLANILLA.TabIndex = 10;
            this.GBPLANILLA.TabStop = false;
            this.GBPLANILLA.Text = "REGISTRO PLANILLA";
            // 
            // CMBEMPLEADOSPLANI
            // 
            this.CMBEMPLEADOSPLANI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBEMPLEADOSPLANI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBEMPLEADOSPLANI.FormattingEnabled = true;
            this.CMBEMPLEADOSPLANI.Location = new System.Drawing.Point(169, 109);
            this.CMBEMPLEADOSPLANI.Name = "CMBEMPLEADOSPLANI";
            this.CMBEMPLEADOSPLANI.Size = new System.Drawing.Size(317, 24);
            this.CMBEMPLEADOSPLANI.TabIndex = 2;
            this.CMBEMPLEADOSPLANI.SelectedIndexChanged += new System.EventHandler(this.CMBEMPLEADOSPLANI_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "FECHA FINAL";
            // 
            // DTPFECHAFIN
            // 
            this.DTPFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAFIN.Location = new System.Drawing.Point(681, 111);
            this.DTPFECHAFIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFECHAFIN.Name = "DTPFECHAFIN";
            this.DTPFECHAFIN.Size = new System.Drawing.Size(317, 22);
            this.DTPFECHAFIN.TabIndex = 5;
            // 
            // BTNAGREGARPLANI
            // 
            this.BTNAGREGARPLANI.BackColor = System.Drawing.Color.ForestGreen;
            this.BTNAGREGARPLANI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNAGREGARPLANI.Location = new System.Drawing.Point(493, 228);
            this.BTNAGREGARPLANI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNAGREGARPLANI.Name = "BTNAGREGARPLANI";
            this.BTNAGREGARPLANI.Size = new System.Drawing.Size(157, 52);
            this.BTNAGREGARPLANI.TabIndex = 6;
            this.BTNAGREGARPLANI.Text = "AGREGAR";
            this.BTNAGREGARPLANI.UseVisualStyleBackColor = false;
            this.BTNAGREGARPLANI.Click += new System.EventHandler(this.BTNAGREGARPLANI_Click);
            // 
            // BTNELIMINARPLANI
            // 
            this.BTNELIMINARPLANI.BackColor = System.Drawing.Color.Firebrick;
            this.BTNELIMINARPLANI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNELIMINARPLANI.Location = new System.Drawing.Point(691, 228);
            this.BTNELIMINARPLANI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNELIMINARPLANI.Name = "BTNELIMINARPLANI";
            this.BTNELIMINARPLANI.Size = new System.Drawing.Size(157, 52);
            this.BTNELIMINARPLANI.TabIndex = 7;
            this.BTNELIMINARPLANI.Text = "ELIMINAR";
            this.BTNELIMINARPLANI.UseVisualStyleBackColor = false;
            this.BTNELIMINARPLANI.Click += new System.EventHandler(this.BTNELIMINARPLANI_Click);
            // 
            // BTNACTUALIZARPLANI
            // 
            this.BTNACTUALIZARPLANI.BackColor = System.Drawing.Color.Teal;
            this.BTNACTUALIZARPLANI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNACTUALIZARPLANI.Location = new System.Drawing.Point(873, 228);
            this.BTNACTUALIZARPLANI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNACTUALIZARPLANI.Name = "BTNACTUALIZARPLANI";
            this.BTNACTUALIZARPLANI.Size = new System.Drawing.Size(157, 52);
            this.BTNACTUALIZARPLANI.TabIndex = 8;
            this.BTNACTUALIZARPLANI.Text = "ACTUALIZAR";
            this.BTNACTUALIZARPLANI.UseVisualStyleBackColor = false;
            this.BTNACTUALIZARPLANI.Click += new System.EventHandler(this.BTNACTUALIZARPLANI_Click);
            // 
            // TXTMONTOPLANI
            // 
            this.TXTMONTOPLANI.Location = new System.Drawing.Point(169, 170);
            this.TXTMONTOPLANI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTMONTOPLANI.Name = "TXTMONTOPLANI";
            this.TXTMONTOPLANI.Size = new System.Drawing.Size(317, 22);
            this.TXTMONTOPLANI.TabIndex = 3;
            // 
            // TXTIDPLANILLA
            // 
            this.TXTIDPLANILLA.Location = new System.Drawing.Point(169, 50);
            this.TXTIDPLANILLA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTIDPLANILLA.Name = "TXTIDPLANILLA";
            this.TXTIDPLANILLA.Size = new System.Drawing.Size(317, 22);
            this.TXTIDPLANILLA.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "MONTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "FECHA INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID PLANILLA";
            // 
            // DTPFECHAINICIO
            // 
            this.DTPFECHAINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFECHAINICIO.Location = new System.Drawing.Point(681, 49);
            this.DTPFECHAINICIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPFECHAINICIO.Name = "DTPFECHAINICIO";
            this.DTPFECHAINICIO.Size = new System.Drawing.Size(317, 22);
            this.DTPFECHAINICIO.TabIndex = 4;
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
            // DGVPLANILLA
            // 
            this.DGVPLANILLA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPLANILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPLANILLA.Location = new System.Drawing.Point(25, 344);
            this.DGVPLANILLA.Name = "DGVPLANILLA";
            this.DGVPLANILLA.RowHeadersWidth = 51;
            this.DGVPLANILLA.RowTemplate.Height = 24;
            this.DGVPLANILLA.Size = new System.Drawing.Size(1051, 164);
            this.DGVPLANILLA.TabIndex = 9;
            this.DGVPLANILLA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPLANILLA_CellClick);
            this.DGVPLANILLA.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPLANILLA_CellContentDoubleClick);
            this.DGVPLANILLA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPLANILLA_CellDoubleClick);
            // 
            // PLANILLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 535);
            this.Controls.Add(this.DGVPLANILLA);
            this.Controls.Add(this.GBPLANILLA);
            this.Name = "PLANILLA";
            this.Text = "PLANILLA";
            this.Load += new System.EventHandler(this.PLANILLA_Load);
            this.GBPLANILLA.ResumeLayout(false);
            this.GBPLANILLA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPLANILLA)).EndInit();
            this.ResumeLayout(false);

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
    }
}