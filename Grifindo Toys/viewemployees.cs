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
    public partial class viewemployees : Form
    {
        public viewemployees()
        {
            InitializeComponent();
            Load += ViewEmployees_Load;
            btn_search.Click += Btn_search_Click;
        }
        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim(); // Get the text from the search box
            LoadEmployeeData(searchQuery);
        }
        private void LoadEmployeeData(string searchQuery = "")
        {
            grid.Rows.Clear(); // Clear existing rows

            string connectionString = "Data Source=DESKTOP-RU25KP9;Initial Catalog=Grifindo_Toys_DB;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT Id, FirstName, LastName, Gender, Birthday, Position, MobileNumber FROM EmpTable";

            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Modify the query to filter by first or last name
                query += " WHERE FirstName LIKE @Search OR LastName LIKE @Search";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    command.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    grid.Rows.Add(
                        reader["Id"],
                        reader["FirstName"],
                        reader["LastName"],
                        reader["Gender"],
                        Convert.ToDateTime(reader["Birthday"]).ToShortDateString(),
                        reader["Position"],
                        reader["MobileNumber"]
                    );
                }

                reader.Close();
            }
        }


        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value].Index;
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                scroll.Maximum = grid.RowCount - 1 ;
            }
            catch (Exception)
            {

            }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                scroll.Maximum = grid.RowCount - 1;
            }
            catch (Exception)
            {

            }
        }

        private void viewemployees_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
