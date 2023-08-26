using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace CompanyManagementApp
{
	public partial class AttendanceForm : Form
	{
		public AttendanceForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AttendanceForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			if (loginForm.ShowDialog() == DialogResult.OK)
			{
				LeaveRequestsManagementForm leaveRequestsForm = new LeaveRequestsManagementForm();
				leaveRequestsForm.ShowDialog();
			}
			this.Hide();

		}

		private void clockInBT_Click(object sender, EventArgs e)
		{
			if (int.TryParse(employeeIDTB.Text, out int employeeId))
			{
				InsertAttendanceRecord(employeeId, "Clock In");
				clockInLB.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			}
			else
			{
				MessageBox.Show("Invalid employee ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clockOutBT_Click(object sender, EventArgs e)
		{
			if (int.TryParse(employeeIDTB.Text, out int employeeId))
			{
				InsertAttendanceRecord(employeeId, "Clock Out");
				clockOutLB.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			}
			else
			{
				MessageBox.Show("Invalid employee ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void InsertAttendanceRecord(int employeeId, string attendanceType)
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=company;";
			string query = "INSERT INTO Attendance (employee_id, timestamp, attendance_type) VALUES (@employeeId, NOW(), @attendanceType)";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@employeeId", employeeId);
					command.Parameters.AddWithValue("@attendanceType", attendanceType);

					try
					{
						int rowsAffected = command.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show($"Attendance recorded: {attendanceType}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show("Failed to record attendance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					catch (Exception ex)
					{ MessageBox.Show("You tried to enter data that doesn't exist, try again", ex.Message); }
				}
			}
		}

		private void switchToLeaveReqBT_Click(object sender, EventArgs e)
		{
			if (int.TryParse(employeeIDTB.Text, out int employeeId))
			{
				LeaveRequestForm leaveRequestsForm = new LeaveRequestForm(employeeId);
				leaveRequestsForm.Show();
			}
			else
			{
				MessageBox.Show("Invalid employee ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void exitBT_Click(object sender, EventArgs e)
		{
			this.Close();

		}
	}
}
