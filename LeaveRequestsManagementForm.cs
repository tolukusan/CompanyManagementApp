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
	public partial class LeaveRequestsManagementForm : Form
	{
        private DataTable leaveRequestsDataTable;

        public LeaveRequestsManagementForm()
		{
			InitializeComponent();
		}

		private void LeaveRequestsManagementForm_Load(object sender, EventArgs e)
		{
            loadLeaveRequests();
        }

        public enum LeaveRequestStatus
        {
            Pending,
            Approved,
            Rejected
        }

        private void loadLeaveRequests()
		{
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = company; ";
            string query = "SELECT * FROM leaverequests";

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

                updateLeaveRequestStatus(leaveRequestId, LeaveRequestStatus.Approved);
                loadLeaveRequests();
            }
        }

		private void rejectBT_Click(object sender, EventArgs e)
		{
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                int leaveRequestId = Convert.ToInt32(dataGridView.Rows[rowIndex].Cells["request_id"].Value);

                updateLeaveRequestStatus(leaveRequestId, LeaveRequestStatus.Rejected);
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
        private void updateLeaveRequestStatus(int leaveRequestId, LeaveRequestStatus status)
        {
            string connectionString = "Your_Connection_String"; // Replace with your actual connection string
            string query = "UPDATE leaverequests SET status = @status WHERE request_id = @leaveRequestId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status", status.ToString());
                    command.Parameters.AddWithValue("@leaveRequestId", leaveRequestId);

                    command.ExecuteNonQuery();
                }
            }
        }
        private void deleteLeaveRequest(int leaveRequestId)
        {
            string connectionString = "Your_Connection_String"; // Replace with your actual connection string
            string query = "DELETE FROM LeaveRequests WHERE leave_request_id = @leaveRequestId";

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

    }
}
