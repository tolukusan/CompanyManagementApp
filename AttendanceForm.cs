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
				leaveRequestsForm.Show();
			}
			this.Close();

		}
	}
}
