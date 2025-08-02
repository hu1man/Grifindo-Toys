using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class addemployee : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        
        public addemployee()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_title.SelectedItem = "-Select Title-";
            txt_first_name.Clear();
            txt_last_name.Clear();
            txt_full_name.Clear();
            txt_name_init.Clear();
            cmb_id_type.SelectedItem = "-Select ID Type-";
            txt_id_number.Clear();
            dt_birthday.ResetText();
            cmb_relationship.SelectedItem = "-Select Relationship-";
            cmb_family_members.SelectedItem = "-Select Family Members-";
            cmb_gender.SelectedItem = "-Select Your Gender-";
            cmb_education_level.SelectedItem = "-Select Your Education Level-";
            cmb_job_done_before.SelectedItem = "-Select Your Choice-";
            cmb_nationality.SelectedItem = "-Select Your Nationality-";
            dt_join_date.ResetText();
            cmb_position.SelectedItem = "-Select Your Position-";
            cmb_department.SelectedItem = "-Select Your Department-";
            txt_email.Clear();
            txt_mobile_number.Clear();
            cmb_social_media.SelectedItem = "-Select Social Media Type-";
            pnl_social_media.Hide();
            txt_address.Clear();
            txt_salary.Clear();
            txt_ot_rate.Clear();
            txt_allowances.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txt_id_number.Text) ||
                string.IsNullOrWhiteSpace(txt_first_name.Text) ||
                string.IsNullOrWhiteSpace(txt_last_name.Text) ||
                string.IsNullOrWhiteSpace(txt_mobile_number.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_salary.Text) ||
                string.IsNullOrWhiteSpace(txt_ot_rate.Text) ||
                string.IsNullOrWhiteSpace(txt_allowances.Text) ||
                dt_birthday.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Please fill in all required fields:\n- ID Number\n- First Name\n- Last Name\n- Birthday (Not today)\n- Mobile Number\n- Email\n- Salary\n- OT Rate\n- Allowances",
                                "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you Sure You Want to Save these Details???", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int newEmpId = -1;
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123"))
                {
                    string empInsertQuery = @"INSERT INTO EmpTable (title, firstname, lastname, fullname, namewithinitials, idtype, idnumber, birthday, relationship, familymembers, gender, educationlevel, jobdonebefore, nationality, joindate, position, department, email, mobilenumber, socialmedia, socialid, address)
                                      OUTPUT INSERTED.id
                                      VALUES (@title, @firstname, @lastname, @fullname, @namewithinitials, @idtype, @idnumber, @birthday, @relationship, @familymembers, @gender, @educationlevel, @jobdonebefore, @nationality, @joindate, @position, @department, @email, @mobilenumber, @socialmedia, @socialid, @address)";

                    using (SqlCommand cmd = new SqlCommand(empInsertQuery, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@title", cmb_title.Text);
                        cmd.Parameters.AddWithValue("@firstname", txt_first_name.Text);
                        cmd.Parameters.AddWithValue("@lastname", txt_last_name.Text);
                        cmd.Parameters.AddWithValue("@fullname", txt_full_name.Text);
                        cmd.Parameters.AddWithValue("@namewithinitials", txt_name_init.Text);
                        cmd.Parameters.AddWithValue("@idtype", cmb_id_type.Text);
                        cmd.Parameters.AddWithValue("@idnumber", txt_id_number.Text);
                        cmd.Parameters.AddWithValue("@birthday", dt_birthday.Value);
                        cmd.Parameters.AddWithValue("@relationship", cmb_relationship.Text);
                        cmd.Parameters.AddWithValue("@familymembers", cmb_family_members.Text);
                        cmd.Parameters.AddWithValue("@gender", cmb_gender.Text);
                        cmd.Parameters.AddWithValue("@educationlevel", cmb_education_level.Text);
                        cmd.Parameters.AddWithValue("@jobdonebefore", cmb_job_done_before.Text);
                        cmd.Parameters.AddWithValue("@nationality", cmb_nationality.Text);
                        cmd.Parameters.AddWithValue("@joindate", dt_join_date.Value);
                        cmd.Parameters.AddWithValue("@position", cmb_position.Text);
                        cmd.Parameters.AddWithValue("@department", cmb_department.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@mobilenumber", txt_mobile_number.Text);
                        cmd.Parameters.AddWithValue("@socialmedia", cmb_social_media.Text);
                        cmd.Parameters.AddWithValue("@socialid", txt_social_media.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);

                        sqlConnection.Open();
                        newEmpId = (int)cmd.ExecuteScalar(); // Get new emp id
                        sqlConnection.Close();
                    }

                    if (newEmpId > 0)
                    {
                        MessageBox.Show("New Employee Details Added to the System Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("Do you want to save Salary Details now?", "Continue", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string salaryInsertQuery = @"INSERT INTO SalaryTable (empid, salary, ot_rate, allowances) 
                                                 VALUES (@empid, @salary, @otrate, @allowances)";
                            using (SqlCommand cmdSalary = new SqlCommand(salaryInsertQuery, sqlConnection))
                            {
                                cmdSalary.Parameters.AddWithValue("@empid", newEmpId);
                                cmdSalary.Parameters.AddWithValue("@salary", decimal.Parse(txt_salary.Text));
                                cmdSalary.Parameters.AddWithValue("@otrate", decimal.Parse(txt_ot_rate.Text));
                                cmdSalary.Parameters.AddWithValue("@allowances", decimal.Parse(txt_allowances.Text));

                                sqlConnection.Open();
                                cmdSalary.ExecuteNonQuery();
                                sqlConnection.Close();

                                MessageBox.Show("Salary Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_title.SelectedItem = "-Select Title-";
                                txt_first_name.Clear();
                                txt_last_name.Clear();
                                txt_full_name.Clear();
                                txt_name_init.Clear();
                                cmb_id_type.SelectedItem = "-Select ID Type-";
                                txt_id_number.Clear();
                                dt_birthday.ResetText();
                                cmb_relationship.SelectedItem = "-Select Relationship-";
                                cmb_family_members.SelectedItem = "-Select Family Members-";
                                cmb_gender.SelectedItem = "-Select Your Gender-";
                                cmb_education_level.SelectedItem = "-Select Your Education Level-";
                                cmb_job_done_before.SelectedItem = "-Select Your Choice-";
                                cmb_nationality.SelectedItem = "-Select Your Nationality-";
                                dt_join_date.ResetText();
                                cmb_position.SelectedItem = "-Select Your Position-";
                                cmb_department.SelectedItem = "-Select Your Department-";
                                txt_email.Clear();
                                txt_mobile_number.Clear();
                                cmb_social_media.SelectedItem = "-Select Social Media Type-";
                                pnl_social_media.Hide();
                                txt_address.Clear();
                                txt_salary.Clear();
                                txt_ot_rate.Clear();
                                txt_allowances.Clear();
                            }
                        }
                    }
                }
            }
        }



        private void txt_first_name_TextChanged(object sender, EventArgs e)
        {
            txt_full_name.Text = txt_first_name.Text + " " + txt_last_name.Text;
            string fullname = txt_full_name.Text;
            fullname = fullname.Trim();
            if (fullname.Length > 0)
            {
                string[] nameList = fullname.Split(' ');
                string namewithinitials = "";
                foreach (string name in nameList)
                {
                    if (name != "")
                    {
                        if (namewithinitials == "")
                        {
                            namewithinitials = name[0].ToString();
                        }
                        else
                        {
                            namewithinitials = namewithinitials + " " + name[0];
                        }
                    }
                }
                int lastchar = namewithinitials.Length - 1;
                namewithinitials = namewithinitials.Substring(0, lastchar);
                string lastname = nameList[nameList.Length - 1];
                txt_name_init.Text = namewithinitials + lastname;
            }
            else
            {
                txt_name_init.Clear();
            }
        }

        private void txt_last_name_TextChanged(object sender, EventArgs e)
        {
            txt_full_name.Text = txt_first_name.Text + " " + txt_last_name.Text;
            string fullname = txt_full_name.Text;
            fullname = fullname.Trim();
            if (fullname.Length > 0)
            {
                string[] nameList = fullname.Split(' ');
                string namewithinitials = "";
                foreach (string name in nameList)
                {
                    if (name != "")
                    {
                        if (namewithinitials == "")
                        {
                            namewithinitials = name[0].ToString();
                        }
                        else
                        {
                            namewithinitials = namewithinitials + " " + name[0];
                        }
                    }
                }
                int lastchar = namewithinitials.Length - 1;
                namewithinitials = namewithinitials.Substring(0, lastchar);
                string lastname = nameList[nameList.Length - 1];
                txt_name_init.Text = namewithinitials + lastname;
            }
            else
            {
                txt_name_init.Text = "";
            }
        }

        private void txt_full_name_TextChanged(object sender, EventArgs e)
        {
            txt_full_name.Text = txt_first_name.Text + " " + txt_last_name.Text;
        }

        private void cmb_social_media_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_social_media.Text == "Whatsapp")
            {
                pb_social_media.Image = Properties.Resources.whatsapp__3_;
            }
            else if (cmb_social_media.Text == "Twitter")
            {
                pb_social_media.Image = Properties.Resources.twitter;
            }
            else if (cmb_social_media.Text == "Instagram")
            {
                pb_social_media.Image = Properties.Resources.instagram__2_;
            }
            pnl_social_media.Show();
        }

        private void addemployee_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 15, 15));
            btn_clear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_clear.Width, btn_clear.Height, 15, 15));
            btn_exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_exit.Width, btn_exit.Height, 15, 15));
            cmb_title.SelectedItem = "-Select Title-";
            cmb_id_type.SelectedItem = "-Select ID Type-";
            cmb_relationship.SelectedItem = "-Select Relationship-";
            cmb_family_members.SelectedItem = "-Select Family Members-";
            cmb_gender.SelectedItem = "-Select Your Gender-";
            cmb_education_level.SelectedItem = "-Select Your Education Level-";
            cmb_job_done_before.SelectedItem = "-Select Your Choice-";
            cmb_nationality.SelectedItem = "-Select Your Nationality-";
            cmb_position.SelectedItem = "-Select Your Position-";
            cmb_department.SelectedItem = "-Select Your Department-";
            cmb_social_media.SelectedItem = "-Select Social Media Type-";
            pnl_social_media.Hide();
        }

        private void cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_id_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_salary_Enter(object sender, EventArgs e)
        {
            txt_salary.Clear();
            txt_salary.ForeColor= Color.White;
        }

        private void txt_salary_Leave(object sender, EventArgs e)
        {
            if (txt_salary.Text == "")
            {
                txt_salary.ForeColor = Color.Silver;
                txt_salary.Text = "Ex: 2000";
            }
                
        }

        private void txt_ot_rate_Enter(object sender, EventArgs e)
        {
            txt_ot_rate.Clear();
            txt_ot_rate.ForeColor = Color.White;
        }

        private void txt_ot_rate_Leave(object sender, EventArgs e)
        {
            if (txt_ot_rate.Text == "")
            {
                txt_ot_rate.ForeColor = Color.Silver;
                txt_ot_rate.Text = "Ex: 2000";
            }
        }

        private void txt_allowances_Enter(object sender, EventArgs e)
        {
            txt_allowances.Clear();
            txt_allowances.ForeColor = Color.White;
        }

        private void txt_allowances_Leave(object sender, EventArgs e)
        {
            if (txt_allowances.Text == "")
            {
                txt_allowances.ForeColor = Color.Silver;
                txt_allowances.Text = "Ex: 2000";
            }
        }
    }
}
