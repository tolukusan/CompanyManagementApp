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
	public partial class LeaveRequestForm : Form
	{
		private int employeeId;
		public LeaveRequestForm(int employeeId)
		{
			InitializeComponent();
			this.employeeId = employeeId;
		}

		private void LeaveRequestForm_Load(object sender, EventArgs e)
		{

		}

		private void submitBT_Click(object sender, EventArgs e)
		{
			// Retrieve leave request details from the form controls
			DateTime startDate = dateTimePickerStart.Value;
			DateTime endDate = dateTimePickerEnd.Value;
			string reason = reasonTB.Text;

			// Validate the leave request details (you can add your own validation logic here)

			// Insert the leave request into the database
			InsertLeaveRequest(startDate, endDate, reason);

			MessageBox.Show("Leave request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ClearForm();
		}
		private void InsertLeaveRequest(DateTime startDate, DateTime endDate, string reason)
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=company;";  
			string query = "INSERT INTO leaverequests (employee_id, start_date, end_date, reason, status) " +
						   "VALUES (@employeeId, @startDate, @endDate, @reason, 'Pending')";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@employeeId", employeeId);
					command.Parameters.AddWithValue("@startDate", startDate);
					command.Parameters.AddWithValue("@endDate", endDate);
					command.Parameters.AddWithValue("@reason", reason);

					command.ExecuteNonQuery();
				}
			}
		}

		private void ClearForm()
		{
			dateTimePickerStart.Value = DateTime.Today;
			dateTimePickerEnd.Value = DateTime.Today;
			reasonTB.Clear();
		}
	}
}
