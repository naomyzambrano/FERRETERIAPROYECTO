﻿namespace FERRETERIAPROYECTO
{
    partial class VER_EMPLEADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VER_EMPLEADO));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVVEREMPLEADO = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVOLVER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVEREMPLEADO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "EMPLEADOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "FERRETERIA KANAVI";
            // 
            // DGVVEREMPLEADO
            // 
            this.DGVVEREMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVEREMPLEADO.Location = new System.Drawing.Point(24, 123);
            this.DGVVEREMPLEADO.Name = "DGVVEREMPLEADO";
            this.DGVVEREMPLEADO.Size = new System.Drawing.Size(886, 340);
            this.DGVVEREMPLEADO.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
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
            this.btnVOLVER.Location = new System.Drawing.Point(24, 12);
            this.btnVOLVER.Name = "btnVOLVER";
            this.btnVOLVER.Size = new System.Drawing.Size(49, 39);
            this.btnVOLVER.TabIndex = 15;
            this.btnVOLVER.UseVisualStyleBackColor = false;
            this.btnVOLVER.Click += new System.EventHandler(this.btnVOLVER_Click);
            // 
            // VER_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.ControlBox = false;
            this.Controls.Add(this.btnVOLVER);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVVEREMPLEADO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VER_EMPLEADO";
            this.Text = "VER_EMPLEADO";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VER_EMPLEADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVEREMPLEADO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVVEREMPLEADO;
        private System.Windows.Forms.Button btnVOLVER;
    }
}