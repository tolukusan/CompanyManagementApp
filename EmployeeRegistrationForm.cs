using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CompanyManagementApp
{
	public partial class EmployeeRegistrationForm : Form
	{
		public EmployeeRegistrationForm()
		{
			InitializeComponent();
		}

		private void EmployeeRegistrationForm_Load(object sender, EventArgs e)
		{

		}

		private void submitBT_Click(object sender, EventArgs e)
		{
            string employee_id = empIDTB.Text;
            string name = nameTB.Text;
            string email = emailTB.Text;
            string phone = phoneTB.Text;
            string department = departmentTB.Text;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=company;"; // Replace with your actual connection string
            string query = "INSERT INTO Employees (employee_id, name, email, phone, department) VALUES (@employee_id, @name, @email, @phone, @department)";

            MySqlConnection connection = new MySqlConnection(connectionString);            
            
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@employee_id", employee_id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@department", department);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee registered successfully!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empIDTB.Clear(); nameTB.Clear(); emailTB.Clear(); phoneTB.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to register employee.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred, details as follows: " + ex.Message);
            }



        }

		private void switchToAttendanceBT_Click(object sender, EventArgs e)
		{
            AttendanceForm.Show();
            EmployeeRegistrationForm.Close();

		}
	}
}
