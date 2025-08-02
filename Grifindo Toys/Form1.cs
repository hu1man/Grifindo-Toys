using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Dashboard : Form
    {
        private int rowcount;
        private Timer animateTimer;
        private Timer startDelayTimer;
        private int currentValue = 0;
        public Dashboard()
        {            
            InitializeTimers();
            LoadData();
            InitializeComponent();
            lbl_update_stats.Visible = false;


        }

        private void InitializeTimers()
        {
            // Timer to handle the animation
            animateTimer = new Timer();
            animateTimer.Interval = 20; // Interval in milliseconds
            animateTimer.Tick += animateTimer_Tick;

            // Timer to handle the initial delay
            startDelayTimer = new Timer();
            startDelayTimer.Interval = 1500; // 2 seconds delay
            startDelayTimer.Tick += StartDelayTimer_Tick;
        }

        private void LoadData()
        {
            // Database connection and query
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123"))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM EmpTable", sqlConnection))
                {
                    sqlConnection.Open();
                    rowcount = (int)sqlCommand.ExecuteScalar();
                    sqlConnection.Close();
                }
            }

            // Start delay timer
            startDelayTimer.Start();
        }

        private void StartDelayTimer_Tick(object sender, EventArgs e)
        {
            startDelayTimer.Stop();
            // Start animation
            animateTimer.Start();
        }

        private void animateTimer_Tick(object sender, EventArgs e)
        {
            // Increase current value
            if (currentValue < rowcount)
            {
                currentValue += 1; // Increment value (adjust step for smoothness)
                cpb_employees.Value = currentValue;
                cpb_employees.Text = currentValue.ToString();
            }
            else
            {
                // Stop the animation timer once the final value is reached
                animateTimer.Stop();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pnl_navigation.Height = btn_dashboard.Height;
            pnl_navigation.Top = btn_dashboard.Top;
            pnl_navigation.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);
            lbl_mega_dashboard.Text = "Dashboard";
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_update_stats.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnl_navigation.Height = btn_dashboard.Height;
            pnl_navigation.Top = btn_dashboard.Top;
            pnl_navigation.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);
            lbl_mega_dashboard.Text = "Dashboard";
            LoadData();
            InitializeTimers();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            lbl_update_stats.Visible = false;
            pnl_navigation.Height = btn_employee.Height;
            pnl_navigation.Top = btn_employee.Top;
            btn_employee.BackColor = Color.FromArgb(46, 51, 73);
            lbl_mega_dashboard.Text = "Employee";
            Employee employee = new Employee();
            employee.Show();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            lbl_update_stats.Visible = false;
            pnl_navigation.Height = btn_salary.Height;
            pnl_navigation.Top = btn_salary.Top;
            btn_salary.BackColor = Color.FromArgb(46, 51, 73);
            lbl_mega_dashboard.Text = "Salary";
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            lbl_update_stats.Visible = true;
            try
            {
                string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
                string query = "SELECT TOP 1 last_updated FROM SettingsTable ORDER BY last_updated DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        DateTime lastUpdated = Convert.ToDateTime(result);
                        TimeSpan timeDiff = DateTime.Now - lastUpdated;

                        string message;

                        if (timeDiff.TotalMinutes < 1)
                        {
                            message = "Last update 1 minute ago";
                        }
                        else if (timeDiff.TotalMinutes < 60)
                        {
                            message = $"Last update {(int)timeDiff.TotalMinutes} minutes ago";
                        }
                        else if (timeDiff.TotalHours < 24)
                        {
                            message = $"Last update {(int)timeDiff.TotalHours} hour{(timeDiff.TotalHours >= 2 ? "s" : "")} ago";
                        }
                        else
                        {
                            message = $"Last update {(int)timeDiff.TotalDays} day{(timeDiff.TotalDays >= 2 ? "s" : "")} ago";
                        }

                        lbl_update_stats.Text = message;
                    }
                    else
                    {
                        lbl_update_stats.Text = "No previous update found.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve update status:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnl_navigation.Height = btn_settings.Height;
            pnl_navigation.Top = btn_settings.Top;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);
            lbl_mega_dashboard.Text = "Settings";
            settings setting = new settings();
            setting.Show();
        }

        private void btn_version_Click(object sender, EventArgs e)
        {
            lbl_update_stats.Visible = false;
            pnl_navigation.Height = btn_version.Height;
            pnl_navigation.Top = btn_version.Top;
            btn_version.BackColor = Color.FromArgb(46, 51, 73);
            MessageBox.Show("You Are Using the Latest Version of this System", "V 0.0.0.1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_employee_Leave(object sender, EventArgs e)
        {
            btn_employee.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_salary_Leave(object sender, EventArgs e)
        {
            btn_salary.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(24, 30, 54);
            lbl_update_stats.Visible = false;
        }

        private void btn_version_Leave(object sender, EventArgs e)
        {
            btn_version.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pnl_left_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
