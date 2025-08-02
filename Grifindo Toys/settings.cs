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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        

        private void txt_cycle_days_Leave(object sender, EventArgs e)
        {
            if (txt_cycle_days.Text=="")
            {
                txt_cycle_days.Text = "e.g. 30";
                txt_cycle_days.ForeColor = Color.Silver;
            }
        }

        private void txt_cycle_days_Enter(object sender, EventArgs e)
        {
            txt_cycle_days.Clear();
            txt_cycle_days.ForeColor = Color.White;

        }

        private void txt_annual_leaves_Leave(object sender, EventArgs e)
        {
            if (txt_annual_leaves.Text == "")
            {
                txt_annual_leaves.Text = "e.g. 12";
                txt_annual_leaves.ForeColor = Color.Silver;
            }
        }

        private void txt_annual_leaves_Enter(object sender, EventArgs e)
        {
            txt_annual_leaves.Clear();
            txt_annual_leaves.ForeColor = Color.White;
        }

        private void txt_tax_rate_Leave(object sender, EventArgs e)
        {
            if (txt_tax_rate.Text == "")
            {
                txt_tax_rate.Text = "'8' for 8%";
                txt_tax_rate.ForeColor = Color.Silver;
            }
        }

        private void txt_tax_rate_Enter(object sender, EventArgs e)
        {
            txt_tax_rate.Clear();
            txt_tax_rate.ForeColor = Color.White;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txt_cycle_days.Text) ||
                string.IsNullOrWhiteSpace(txt_annual_leaves.Text) ||
                string.IsNullOrWhiteSpace(txt_tax_rate.Text))
            {
                MessageBox.Show("Please fill in all the fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm with the user
            DialogResult result = MessageBox.Show(
                "Are you sure you want to save these settings?",
                "Confirm Save",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                try
                {
                    // Parse values
                    DateTime start = dtp_start_date.Value;
                    DateTime end = dt_end_date.Value;
                    int cycleDays = int.Parse(txt_cycle_days.Text);
                    int leaveDays = int.Parse(txt_annual_leaves.Text);
                    decimal taxRate = decimal.Parse(txt_tax_rate.Text) / 100;

                    // Database update
                    string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
                    string query = "UPDATE SettingsTable SET salary_cycle_start = @start, salary_cycle_end = @end, salary_cycle_days = @days, annual_leave_days = @leaves, government_tax_rate = @tax, last_updated = GETDATE()";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@start", start);
                        cmd.Parameters.AddWithValue("@end", end);
                        cmd.Parameters.AddWithValue("@days", cycleDays);
                        cmd.Parameters.AddWithValue("@leaves", leaveDays);
                        cmd.Parameters.AddWithValue("@tax", taxRate);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Settings updated successfully. All salary records will recalculate now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear all fields after success
                            txt_cycle_days.Clear();
                            txt_annual_leaves.Clear();
                            txt_tax_rate.Clear();
                            dtp_start_date.Value = DateTime.Now;
                            dt_end_date.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check the input.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numbers in Cycle Days, Annual Leaves, and Tax Rate fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving settings:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Save operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }

}
