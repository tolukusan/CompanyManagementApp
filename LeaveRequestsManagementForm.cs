using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace CompanyManagementApp
{
	public partial class LeaveRequestsManagementForm : Form
	{
		private DataTable leaveRequestsDataTable;
		private string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = company; ";

		public LeaveRequestsManagementForm()
		{
			InitializeComponent();
		}

		private void LeaveRequestsManagementForm_Load(object sender, EventArgs e)
		{
			loadLeaveRequests();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void leaveRequestdGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void approveBT_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				int rowIndex = dataGridView.SelectedRows[0].Index;
				int leaveRequestId = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["request_id"].Value);

				updateLeaveRequestStatus(leaveRequestId, "approved");
				loadLeaveRequests();
			}
		}

		private void rejectBT_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				int rowIndex = dataGridView.SelectedRows[0].Index;
				int leaveRequestId = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["request_id"].Value);

				updateLeaveRequestStatus(leaveRequestId, "rejected");
				loadLeaveRequests();
			}
		}

		private void deleteBT_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count > 0)
			{
				int rowIndex = dataGridView.SelectedRows[0].Index;
				int leaveRequestId = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["request_id"].Value);

				deleteLeaveRequest(leaveRequestId);
				loadLeaveRequests();
			}
		}
		private void updateLeaveRequestStatus(int leaveRequestId, string status)
		{
			string query = "UPDATE leaverequests SET status = @status WHERE request_id = @leaveRequestId";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@status", status);
					command.Parameters.AddWithValue("@leaveRequestId", leaveRequestId);

					command.ExecuteNonQuery();
				}
			}
		}
		private void loadLeaveRequests()
		{
			string query = "SELECT * FROM leaverequests;";

			leaveRequestsDataTable = new DataTable();

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
					{
						adapter.Fill(leaveRequestsDataTable);
					}

					dataGridView.DataSource = leaveRequestsDataTable;

				}
			}
		}
		private void deleteLeaveRequest(int leaveRequestId)
		{
			string query = "DELETE FROM LeaveRequests WHERE request_id = @leaveRequestId";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@leaveRequestId", leaveRequestId);

					command.ExecuteNonQuery();
				}
			}
		}

		private void exitBT_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
