namespace Grifindo_Toys
{
    partial class settings
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
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.lbl_cycle_days = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txt_cycle_days = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_annual_leaves = new System.Windows.Forms.TextBox();
            this.lbl_annual_leaves = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_tax_rate = new System.Windows.Forms.TextBox();
            this.lbl_tax_rate = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start_date.ForeColor = System.Drawing.Color.White;
            this.lbl_start_date.Location = new System.Drawing.Point(109, 57);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(225, 22);
            this.lbl_start_date.TabIndex = 0;
            this.lbl_start_date.Text = "Salary Cycle Start Date:";
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start_date.Location = new System.Drawing.Point(377, 59);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_start_date.TabIndex = 1;
            // 
            // dt_end_date
            // 
            this.dt_end_date.CalendarFont = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end_date.Location = new System.Drawing.Point(377, 118);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.Size = new System.Drawing.Size(200, 23);
            this.dt_end_date.TabIndex = 3;
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end_date.ForeColor = System.Drawing.Color.White;
            this.lbl_end_date.Location = new System.Drawing.Point(119, 117);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(215, 22);
            this.lbl_end_date.TabIndex = 2;
            this.lbl_end_date.Text = "Salary Cycle End Date:";
            // 
            // lbl_cycle_days
            // 
            this.lbl_cycle_days.AutoSize = true;
            this.lbl_cycle_days.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cycle_days.ForeColor = System.Drawing.Color.White;
            this.lbl_cycle_days.Location = new System.Drawing.Point(623, 57);
            this.lbl_cycle_days.Name = "lbl_cycle_days";
            this.lbl_cycle_days.Size = new System.Drawing.Size(174, 22);
            this.lbl_cycle_days.TabIndex = 4;
            this.lbl_cycle_days.Text = "Salary Cycle Days:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(803, 78);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 1);
            this.panel11.TabIndex = 91;
            // 
            // txt_cycle_days
            // 
            this.txt_cycle_days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_cycle_days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cycle_days.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_cycle_days.ForeColor = System.Drawing.Color.Silver;
            this.txt_cycle_days.Location = new System.Drawing.Point(803, 59);
            this.txt_cycle_days.Name = "txt_cycle_days";
            this.txt_cycle_days.Size = new System.Drawing.Size(292, 20);
            this.txt_cycle_days.TabIndex = 90;
            this.txt_cycle_days.Text = "e.g. 30";
            this.txt_cycle_days.Enter += new System.EventHandler(this.txt_cycle_days_Enter);
            this.txt_cycle_days.Leave += new System.EventHandler(this.txt_cycle_days_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(803, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 1);
            this.panel1.TabIndex = 94;
            // 
            // txt_annual_leaves
            // 
            this.txt_annual_leaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_annual_leaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_annual_leaves.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_annual_leaves.ForeColor = System.Drawing.Color.Silver;
            this.txt_annual_leaves.Location = new System.Drawing.Point(803, 118);
            this.txt_annual_leaves.Name = "txt_annual_leaves";
            this.txt_annual_leaves.Size = new System.Drawing.Size(292, 20);
            this.txt_annual_leaves.TabIndex = 93;
            this.txt_annual_leaves.Text = "e.g. 12";
            this.txt_annual_leaves.Enter += new System.EventHandler(this.txt_annual_leaves_Enter);
            this.txt_annual_leaves.Leave += new System.EventHandler(this.txt_annual_leaves_Leave);
            // 
            // lbl_annual_leaves
            // 
            this.lbl_annual_leaves.AutoSize = true;
            this.lbl_annual_leaves.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_annual_leaves.ForeColor = System.Drawing.Color.White;
            this.lbl_annual_leaves.Location = new System.Drawing.Point(649, 116);
            this.lbl_annual_leaves.Name = "lbl_annual_leaves";
            this.lbl_annual_leaves.Size = new System.Drawing.Size(148, 22);
            this.lbl_annual_leaves.TabIndex = 92;
            this.lbl_annual_leaves.Text = "Annual Leaves:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(377, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 97;
            // 
            // txt_tax_rate
            // 
            this.txt_tax_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_tax_rate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tax_rate.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txt_tax_rate.ForeColor = System.Drawing.Color.Silver;
            this.txt_tax_rate.Location = new System.Drawing.Point(377, 164);
            this.txt_tax_rate.Name = "txt_tax_rate";
            this.txt_tax_rate.Size = new System.Drawing.Size(200, 20);
            this.txt_tax_rate.TabIndex = 96;
            this.txt_tax_rate.Text = "\'8\' for 8%";
            this.txt_tax_rate.Enter += new System.EventHandler(this.txt_tax_rate_Enter);
            this.txt_tax_rate.Leave += new System.EventHandler(this.txt_tax_rate_Leave);
            // 
            // lbl_tax_rate
            // 
            this.lbl_tax_rate.AutoSize = true;
            this.lbl_tax_rate.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax_rate.ForeColor = System.Drawing.Color.White;
            this.lbl_tax_rate.Location = new System.Drawing.Point(90, 164);
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(244, 22);
            this.lbl_tax_rate.TabIndex = 95;
            this.lbl_tax_rate.Text = "Government Tax Rate (%):";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_save.Location = new System.Drawing.Point(991, 183);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 39);
            this.btn_save.TabIndex = 98;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1184, 625);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_tax_rate);
            this.Controls.Add(this.lbl_tax_rate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_annual_leaves);
            this.Controls.Add(this.lbl_annual_leaves);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txt_cycle_days);
            this.Controls.Add(this.lbl_cycle_days);
            this.Controls.Add(this.dt_end_date);
            this.Controls.Add(this.lbl_end_date);
            this.Controls.Add(this.dtp_start_date);
            this.Controls.Add(this.lbl_start_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(186, 144);
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_start_date;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.DateTimePicker dt_end_date;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.Label lbl_cycle_days;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txt_cycle_days;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_annual_leaves;
        private System.Windows.Forms.Label lbl_annual_leaves;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_tax_rate;
        private System.Windows.Forms.Label lbl_tax_rate;
        private System.Windows.Forms.Button btn_save;
    }
}