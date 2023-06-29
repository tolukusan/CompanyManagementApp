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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void loginBT_Click(object sender, EventArgs e)
		{
			string username = usernameTB.Text;
			string password = passwordTB.Text;

			bool isAuthenticated = AuthenticateUser(username, password);

			if (isAuthenticated)
			{
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool AuthenticateUser(string username, string password)
		{
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=company;";
			string query = "SELECT COUNT(*) FROM managers_passwords WHERE username = @username AND password = @password";
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				using (MySqlCommand command = new MySqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@username", username);
					command.Parameters.AddWithValue("@password", password);
					int count = Convert.ToInt32(command.ExecuteScalar());

					return count > 0;
				}
			}
		}
	}
}
