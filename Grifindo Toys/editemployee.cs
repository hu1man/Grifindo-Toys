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
    public partial class editemployee : Form
    {
        public editemployee()
        {
            InitializeComponent();
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            txt_search.TextChanged += txt_search_TextChanged;
            lst_search.SelectedIndexChanged += Lst_search_SelectedIndexChanged;
        }

        private void editemployee_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChange(object sender, EventArgs e)
        {
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                PopulateSearchList(searchQuery);
            }
            else
            {
                lst_search.Items.Clear(); // Clear the list box if the search text is empty
            }
        }


        private void PopulateSearchList(string searchQuery)
        {
            lst_search.Items.Clear(); // Clear existing items

            string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT FirstName, LastName FROM EmpTable WHERE FirstName LIKE @Search OR LastName LIKE @Search";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string fullName = reader["FirstName"] + " " + reader["LastName"];
                    lst_search.Items.Add(fullName); // Add full name to the list box
                }

                reader.Close();
            }
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

        private void lst_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lst_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_search.SelectedItem != null)
            {
                string selectedName = lst_search.SelectedItem.ToString();
                LoadEmployeeDetails(selectedName);
            }
        }

        private void LoadEmployeeDetails(string fullName)
        {
            string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT * FROM EmpTable WHERE fullname = @FullName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", fullName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    cmb_title.SelectedItem = reader["title"].ToString();
                    txt_first_name.Text = reader["firstname"].ToString();
                    txt_last_name.Text = reader["lastname"].ToString();
                    txt_full_name.Text = reader["fullname"].ToString();
                    txt_name_init.Text = reader["namewithinitials"].ToString();
                    cmb_id_type.SelectedItem = reader["idtype"].ToString();
                    txt_id_number.Text = reader["idnumber"].ToString();
                    dt_birthday.Value = Convert.ToDateTime(reader["birthday"]);
                    cmb_relationship.SelectedItem = reader["relationship"].ToString();
                    cmb_family_members.SelectedItem = reader["familymembers"].ToString();
                    cmb_gender.SelectedItem = reader["gender"].ToString();
                    cmb_education_level.SelectedItem = reader["educationlevel"].ToString();
                    cmb_job_done_before.SelectedItem = reader["jobdonebefore"].ToString();
                    cmb_nationality.SelectedItem = reader["nationality"].ToString();
                    dt_join_date.Value = Convert.ToDateTime(reader["joindate"]);
                    cmb_position.SelectedItem = reader["position"].ToString();
                    cmb_department.SelectedItem = reader["department"].ToString();
                    txt_email.Text = reader["email"].ToString();
                    txt_mobile_number.Text = reader["mobilenumber"].ToString();
                    cmb_social_media.SelectedItem = reader["socialmedia"].ToString();
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
                    txt_social_media.Text = reader["socialid"].ToString();
                    txt_address.Text = reader["address"].ToString();
                }

                reader.Close(); // Close the first reader before starting the second

                // Now load salary data using employee ID or ID Number
                string salaryQuery = "SELECT salary, ot_rate, allowances FROM SalaryTable WHERE empid = (SELECT id FROM EmpTable WHERE fullname = @FullName)";
                SqlCommand salaryCommand = new SqlCommand(salaryQuery, connection);
                salaryCommand.Parameters.AddWithValue("@FullName", fullName);

                SqlDataReader salaryReader = salaryCommand.ExecuteReader();
                if (salaryReader.Read())
                {
                    txt_salary.Text = salaryReader["salary"].ToString();
                    txt_ot_rate.Text = salaryReader["ot_rate"].ToString();
                    txt_allowances.Text = salaryReader["allowances"].ToString();
                }
                salaryReader.Close();

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Required Field Validation
            if (string.IsNullOrWhiteSpace(txt_id_number.Text) ||
                string.IsNullOrWhiteSpace(txt_first_name.Text) ||
                string.IsNullOrWhiteSpace(txt_last_name.Text) ||
                dt_birthday.Value.Date == DateTime.Now.Date ||
                string.IsNullOrWhiteSpace(txt_mobile_number.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_salary.Text) ||
                string.IsNullOrWhiteSpace(txt_ot_rate.Text) ||
                string.IsNullOrWhiteSpace(txt_allowances.Text))
            {
                MessageBox.Show("Please fill all required fields including salary details!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you Sure You Want to Update Employee Details???", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // Update EmpTable
                    string updateEmpQuery = @"UPDATE EmpTable SET title=@title, firstname=@firstname, lastname=@lastname, fullname=@fullname,
                    namewithinitials=@namewithinitials, idtype=@idtype, idnumber=@idnumber, birthday=@birthday, relationship=@relationship,
                    familymembers=@familymembers, gender=@gender, educationlevel=@educationlevel, jobdonebefore=@jobdonebefore,
                    nationality=@nationality, joindate=@joindate, position=@position, department=@department, email=@email,
                    mobilenumber=@mobilenumber, socialmedia=@socialmedia, socialid=@socialid, address=@address
                    WHERE idnumber=@idnumber";

                    using (SqlCommand empCmd = new SqlCommand(updateEmpQuery, sqlConnection))
                    {
                        empCmd.Parameters.AddWithValue("@title", cmb_title.Text);
                        empCmd.Parameters.AddWithValue("@firstname", txt_first_name.Text);
                        empCmd.Parameters.AddWithValue("@lastname", txt_last_name.Text);
                        empCmd.Parameters.AddWithValue("@fullname", txt_full_name.Text);
                        empCmd.Parameters.AddWithValue("@namewithinitials", txt_name_init.Text);
                        empCmd.Parameters.AddWithValue("@idtype", cmb_id_type.Text);
                        empCmd.Parameters.AddWithValue("@idnumber", txt_id_number.Text);
                        empCmd.Parameters.AddWithValue("@birthday", dt_birthday.Value);
                        empCmd.Parameters.AddWithValue("@relationship", cmb_relationship.Text);
                        empCmd.Parameters.AddWithValue("@familymembers", cmb_family_members.Text);
                        empCmd.Parameters.AddWithValue("@gender", cmb_gender.Text);
                        empCmd.Parameters.AddWithValue("@educationlevel", cmb_education_level.Text);
                        empCmd.Parameters.AddWithValue("@jobdonebefore", cmb_job_done_before.Text);
                        empCmd.Parameters.AddWithValue("@nationality", cmb_nationality.Text);
                        empCmd.Parameters.AddWithValue("@joindate", dt_join_date.Value);
                        empCmd.Parameters.AddWithValue("@position", cmb_position.Text);
                        empCmd.Parameters.AddWithValue("@department", cmb_department.Text);
                        empCmd.Parameters.AddWithValue("@email", txt_email.Text);
                        empCmd.Parameters.AddWithValue("@mobilenumber", txt_mobile_number.Text);
                        empCmd.Parameters.AddWithValue("@socialmedia", cmb_social_media.Text);
                        empCmd.Parameters.AddWithValue("@socialid", txt_social_media.Text);
                        empCmd.Parameters.AddWithValue("@address", txt_address.Text);

                        empCmd.ExecuteNonQuery();
                    }

                    // Get empid to update salary
                    string getEmpIdQuery = "SELECT id FROM EmpTable WHERE idnumber=@idnumber";
                    int empId;
                    using (SqlCommand idCmd = new SqlCommand(getEmpIdQuery, sqlConnection))
                    {
                        idCmd.Parameters.AddWithValue("@idnumber", txt_id_number.Text);
                        empId = (int)idCmd.ExecuteScalar();
                    }

                    // Check if salary record exists
                    string checkSalaryQuery = "SELECT COUNT(*) FROM SalaryTable WHERE empid=@empid";
                    using (SqlCommand checkCmd = new SqlCommand(checkSalaryQuery, sqlConnection))
                    {
                        checkCmd.Parameters.AddWithValue("@empid", empId);
                        int count = (int)checkCmd.ExecuteScalar();

                        string salaryQuery;
                        if (count > 0)
                        {
                            // Update existing salary
                            salaryQuery = @"UPDATE SalaryTable SET salary=@salary, ot_rate=@otrate, allowances=@allowances WHERE empid=@empid";
                        }
                        else
                        {
                            // Insert new salary
                            salaryQuery = @"INSERT INTO SalaryTable (empid, salary, ot_rate, allowances) VALUES (@empid, @salary, @otrate, @allowances)";
                        }

                        using (SqlCommand salaryCmd = new SqlCommand(salaryQuery, sqlConnection))
                        {
                            salaryCmd.Parameters.AddWithValue("@empid", empId);
                            salaryCmd.Parameters.AddWithValue("@salary", decimal.Parse(txt_salary.Text));
                            salaryCmd.Parameters.AddWithValue("@otrate", decimal.Parse(txt_ot_rate.Text));
                            salaryCmd.Parameters.AddWithValue("@allowances", decimal.Parse(txt_allowances.Text));
                            salaryCmd.ExecuteNonQuery();
                        }
                    }

                    sqlConnection.Close();
                }

                MessageBox.Show("Employee and Salary Data Updated Successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            {
                txt_full_name.Text = txt_first_name.Text + " " + txt_last_name.Text;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
