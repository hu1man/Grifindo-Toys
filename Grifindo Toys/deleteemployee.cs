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
    public partial class deleteemployee : Form
    {
        public deleteemployee()
        {
            InitializeComponent();
        }

        private void txt_search_box_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txt_search_box.Text.Trim();
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
            lst_search.Items.Clear();

            string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT firstname, lastname FROM EmpTable WHERE firstname LIKE @Search OR lastname LIKE @Search";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string fullName = reader["firstname"] + " " + reader["lastname"];
                    lst_search.Items.Add(fullName);
                }

                reader.Close();
            }
        }


        private void deleteemployee_Load(object sender, EventArgs e)
        {
            btn_delete.Enabled = false;
            LoadAllEmployees(); // Load all on start
        }

        private void LoadAllEmployees()
        {
            lst_search.Items.Clear();

            string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT firstname, lastname FROM EmpTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string fullName = reader["firstname"] + " " + reader["lastname"];
                    lst_search.Items.Add(fullName);
                }

                reader.Close();
            }
        }


        private void lst_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employee = lst_search.SelectedItem.ToString();
            btn_delete.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lst_search.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string selectedName = lst_search.SelectedItem.ToString();
                string[] nameParts = selectedName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? nameParts[1] : "";

                string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Get idnumber from EmpTable
                    string getIdQuery = "SELECT id FROM EmpTable WHERE firstname = @FirstName AND lastname = @LastName";
                    SqlCommand getIdCmd = new SqlCommand(getIdQuery, conn);
                    getIdCmd.Parameters.AddWithValue("@FirstName", firstName);
                    getIdCmd.Parameters.AddWithValue("@LastName", lastName);

                    string idNumber = getIdCmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(idNumber))
                    {
                        // Delete from SalaryTable
                        string deleteSalaryQuery = "DELETE FROM SalaryTable WHERE empid = @IdNumber";
                        SqlCommand deleteSalaryCmd = new SqlCommand(deleteSalaryQuery, conn);
                        deleteSalaryCmd.Parameters.AddWithValue("@IdNumber", idNumber);
                        deleteSalaryCmd.ExecuteNonQuery();

                        // Delete from EmpTable
                        string deleteEmpQuery = "DELETE FROM EmpTable WHERE id = @IdNumber";
                        SqlCommand deleteEmpCmd = new SqlCommand(deleteEmpQuery, conn);
                        deleteEmpCmd.Parameters.AddWithValue("@IdNumber", idNumber);
                        deleteEmpCmd.ExecuteNonQuery();

                        MessageBox.Show("Employee removed from the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }

                    conn.Close();
                }

                btn_delete.Enabled = false;
                txt_search_box.Clear();
                LoadAllEmployees(); // Refresh list
            }
        }

    }
}
