namespace Grifindo_Toys
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.btn_version = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pb_user_dp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_mega_dashboard = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_update_stats = new System.Windows.Forms.Label();
            this.roundedPanel3 = new RoundedPanel();
            this.cpb_employees = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.lbl_employees = new System.Windows.Forms.Label();
            this.roundedPanel2 = new RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tax_rate = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_overtime_rate = new System.Windows.Forms.Label();
            this.pnl_payout = new RoundedPanel();
            this.lbl_payout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_left.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user_dp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.pnl_payout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl_left.Controls.Add(this.pnl_navigation);
            this.pnl_left.Controls.Add(this.btn_version);
            this.pnl_left.Controls.Add(this.btn_settings);
            this.pnl_left.Controls.Add(this.btn_salary);
            this.pnl_left.Controls.Add(this.btn_employee);
            this.pnl_left.Controls.Add(this.btn_dashboard);
            this.pnl_left.Controls.Add(this.panel4);
            this.pnl_left.Controls.Add(this.panel3);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(185, 723);
            this.pnl_left.TabIndex = 1;
            this.pnl_left.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_left_Paint);
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnl_navigation.BackColor = System.Drawing.Color.SpringGreen;
            this.pnl_navigation.Location = new System.Drawing.Point(1, 212);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(2, 100);
            this.pnl_navigation.TabIndex = 0;
            // 
            // btn_version
            // 
            this.btn_version.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_version.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_version.FlatAppearance.BorderSize = 0;
            this.btn_version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_version.Font = new System.Drawing.Font("Gotham", 9F);
            this.btn_version.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_version.Location = new System.Drawing.Point(2, 697);
            this.btn_version.Name = "btn_version";
            this.btn_version.Size = new System.Drawing.Size(183, 23);
            this.btn_version.TabIndex = 0;
            this.btn_version.Text = "System Version v.0.0.0.1";
            this.btn_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_version.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_version.UseVisualStyleBackColor = true;
            this.btn_version.Click += new System.EventHandler(this.btn_version_Click);
            this.btn_version.Leave += new System.EventHandler(this.btn_version_Leave);
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_settings.Image = global::Grifindo_Toys.Properties.Resources.settings_gears;
            this.btn_settings.Location = new System.Drawing.Point(0, 328);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(183, 60);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.Leave += new System.EventHandler(this.btn_settings_Leave);
            // 
            // btn_salary
            // 
            this.btn_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salary.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_salary.Image = global::Grifindo_Toys.Properties.Resources.payment;
            this.btn_salary.Location = new System.Drawing.Point(0, 268);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(183, 60);
            this.btn_salary.TabIndex = 0;
            this.btn_salary.Text = "Salary";
            this.btn_salary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            this.btn_salary.Leave += new System.EventHandler(this.btn_salary_Leave);
            // 
            // btn_employee
            // 
            this.btn_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_employee.Image = global::Grifindo_Toys.Properties.Resources.team;
            this.btn_employee.Location = new System.Drawing.Point(0, 206);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(183, 60);
            this.btn_employee.TabIndex = 0;
            this.btn_employee.Text = "Employee";
            this.btn_employee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            this.btn_employee.Leave += new System.EventHandler(this.btn_employee_Leave);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_dashboard.Image = global::Grifindo_Toys.Properties.Resources.home_icon_silhouette;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 146);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(183, 60);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            this.btn_dashboard.Leave += new System.EventHandler(this.btn_dashboard_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 1);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbl_user);
            this.panel3.Controls.Add(this.pb_user_dp);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 142);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "( System Administrator )";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_user.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_user.Location = new System.Drawing.Point(34, 95);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(120, 22);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Alex Bobbins";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_user_dp
            // 
            this.pb_user_dp.Image = global::Grifindo_Toys.Properties.Resources.man;
            this.pb_user_dp.Location = new System.Drawing.Point(51, 10);
            this.pb_user_dp.Name = "pb_user_dp";
            this.pb_user_dp.Size = new System.Drawing.Size(88, 82);
            this.pb_user_dp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_user_dp.TabIndex = 0;
            this.pb_user_dp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.pb_close);
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 50);
            this.panel2.TabIndex = 2;
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = global::Grifindo_Toys.Properties.Resources.cross__2_;
            this.pb_close.Location = new System.Drawing.Point(1134, 13);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(24, 24);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_close.TabIndex = 1;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_time.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_time.Location = new System.Drawing.Point(894, 31);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(46, 18);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_date.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_date.Location = new System.Drawing.Point(123, 31);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(45, 18);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // lbl_mega_dashboard
            // 
            this.lbl_mega_dashboard.AutoSize = true;
            this.lbl_mega_dashboard.Font = new System.Drawing.Font("Montserrat", 35F, System.Drawing.FontStyle.Bold);
            this.lbl_mega_dashboard.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_mega_dashboard.Location = new System.Drawing.Point(190, 58);
            this.lbl_mega_dashboard.Name = "lbl_mega_dashboard";
            this.lbl_mega_dashboard.Size = new System.Drawing.Size(298, 65);
            this.lbl_mega_dashboard.TabIndex = 3;
            this.lbl_mega_dashboard.Text = "Dashboard";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_update_stats
            // 
            this.lbl_update_stats.AutoSize = true;
            this.lbl_update_stats.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_update_stats.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_update_stats.Location = new System.Drawing.Point(954, 92);
            this.lbl_update_stats.Name = "lbl_update_stats";
            this.lbl_update_stats.Size = new System.Drawing.Size(202, 22);
            this.lbl_update_stats.TabIndex = 6;
            this.lbl_update_stats.Text = "update stats goes here";
            this.lbl_update_stats.Visible = false;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Controls.Add(this.cpb_employees);
            this.roundedPanel3.Controls.Add(this.lbl_employees);
            this.roundedPanel3.CornerRadius = 10;
            this.roundedPanel3.Location = new System.Drawing.Point(210, 384);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(333, 327);
            this.roundedPanel3.TabIndex = 5;
            // 
            // cpb_employees
            // 
            this.cpb_employees.Animated = false;
            this.cpb_employees.AnimationInterval = 0;
            this.cpb_employees.AnimationSpeed = 1;
            this.cpb_employees.BackColor = System.Drawing.Color.Transparent;
            this.cpb_employees.CircleMargin = 10;
            this.cpb_employees.Font = new System.Drawing.Font("Montserrat", 50F, System.Drawing.FontStyle.Bold);
            this.cpb_employees.ForeColor = System.Drawing.Color.White;
            this.cpb_employees.IsPercentage = false;
            this.cpb_employees.LineProgressThickness = 20;
            this.cpb_employees.LineThickness = 20;
            this.cpb_employees.Location = new System.Drawing.Point(43, 72);
            this.cpb_employees.MarqueeAnimationSpeed = 0;
            this.cpb_employees.Maximum = 50;
            this.cpb_employees.Name = "cpb_employees";
            this.cpb_employees.ProgressAnimationSpeed = 200;
            this.cpb_employees.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cpb_employees.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.cpb_employees.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.cpb_employees.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cpb_employees.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.cpb_employees.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.cpb_employees.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cpb_employees.Size = new System.Drawing.Size(235, 235);
            this.cpb_employees.Step = 0;
            this.cpb_employees.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpb_employees.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_employees.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.cpb_employees.SubScriptText = "";
            this.cpb_employees.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_employees.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.cpb_employees.SuperScriptText = "";
            this.cpb_employees.TabIndex = 0;
            this.cpb_employees.Text = "30";
            this.cpb_employees.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cpb_employees.Value = 30;
            this.cpb_employees.ValueByTransition = 30;
            this.cpb_employees.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // lbl_employees
            // 
            this.lbl_employees.AutoSize = true;
            this.lbl_employees.BackColor = System.Drawing.Color.Transparent;
            this.lbl_employees.Font = new System.Drawing.Font("Montserrat SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_employees.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_employees.Location = new System.Drawing.Point(15, 8);
            this.lbl_employees.Name = "lbl_employees";
            this.lbl_employees.Size = new System.Drawing.Size(212, 47);
            this.lbl_employees.TabIndex = 0;
            this.lbl_employees.Text = "Employees";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.lbl_tax_rate);
            this.roundedPanel2.CornerRadius = 10;
            this.roundedPanel2.Location = new System.Drawing.Point(985, 206);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(333, 151);
            this.roundedPanel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 75);
            this.label5.TabIndex = 1;
            this.label5.Text = "2.2%";
            // 
            // lbl_tax_rate
            // 
            this.lbl_tax_rate.AutoSize = true;
            this.lbl_tax_rate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tax_rate.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_tax_rate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_tax_rate.Location = new System.Drawing.Point(16, 13);
            this.lbl_tax_rate.Name = "lbl_tax_rate";
            this.lbl_tax_rate.Size = new System.Drawing.Size(226, 37);
            this.lbl_tax_rate.TabIndex = 0;
            this.lbl_tax_rate.Text = "Latest Tax Rate";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.lbl_overtime_rate);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.Location = new System.Drawing.Point(598, 206);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(333, 151);
            this.roundedPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 75);
            this.label3.TabIndex = 1;
            this.label3.Text = "1.5X";
            // 
            // lbl_overtime_rate
            // 
            this.lbl_overtime_rate.AutoSize = true;
            this.lbl_overtime_rate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_overtime_rate.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_overtime_rate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_overtime_rate.Location = new System.Drawing.Point(16, 13);
            this.lbl_overtime_rate.Name = "lbl_overtime_rate";
            this.lbl_overtime_rate.Size = new System.Drawing.Size(311, 37);
            this.lbl_overtime_rate.TabIndex = 0;
            this.lbl_overtime_rate.Text = "Latest Overtime Rate";
            // 
            // pnl_payout
            // 
            this.pnl_payout.Controls.Add(this.lbl_payout);
            this.pnl_payout.Controls.Add(this.label2);
            this.pnl_payout.CornerRadius = 10;
            this.pnl_payout.Location = new System.Drawing.Point(210, 206);
            this.pnl_payout.Name = "pnl_payout";
            this.pnl_payout.Size = new System.Drawing.Size(333, 151);
            this.pnl_payout.TabIndex = 4;
            // 
            // lbl_payout
            // 
            this.lbl_payout.AutoSize = true;
            this.lbl_payout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_payout.Font = new System.Drawing.Font("Montserrat", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_payout.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_payout.Location = new System.Drawing.Point(11, 62);
            this.lbl_payout.Name = "lbl_payout";
            this.lbl_payout.Size = new System.Drawing.Size(203, 75);
            this.lbl_payout.TabIndex = 1;
            this.lbl_payout.Text = "$ 1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Payout So Far";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1356, 723);
            this.Controls.Add(this.lbl_update_stats);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.pnl_payout);
            this.Controls.Add(this.lbl_mega_dashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnl_left.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user_dp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.pnl_payout.ResumeLayout(false);
            this.pnl_payout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_mega_dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_user_dp;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_version;
        private System.Windows.Forms.Panel pnl_navigation;
        private RoundedPanel pnl_payout;
        private System.Windows.Forms.Label lbl_payout;
        private System.Windows.Forms.Label label2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_overtime_rate;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tax_rate;
        private RoundedPanel roundedPanel3;
        private Bunifu.UI.WinForms.BunifuCircleProgress cpb_employees;
        private System.Windows.Forms.Label lbl_employees;
        private System.Windows.Forms.Label lbl_update_stats;
    }
}

