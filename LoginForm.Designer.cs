namespace CompanyManagementApp
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameTB = new System.Windows.Forms.TextBox();
			this.passwordTB = new System.Windows.Forms.TextBox();
			this.loginBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// usernameTB
			// 
			this.usernameTB.Location = new System.Drawing.Point(169, 104);
			this.usernameTB.Name = "usernameTB";
			this.usernameTB.Size = new System.Drawing.Size(100, 20);
			this.usernameTB.TabIndex = 2;
			// 
			// passwordTB
			// 
			this.passwordTB.Location = new System.Drawing.Point(169, 142);
			this.passwordTB.Name = "passwordTB";
			this.passwordTB.PasswordChar = '*';
			this.passwordTB.Size = new System.Drawing.Size(100, 20);
			this.passwordTB.TabIndex = 3;
			// 
			// loginBT
			// 
			this.loginBT.Location = new System.Drawing.Point(143, 197);
			this.loginBT.Name = "loginBT";
			this.loginBT.Size = new System.Drawing.Size(75, 23);
			this.loginBT.TabIndex = 4;
			this.loginBT.Text = "Login";
			this.loginBT.UseVisualStyleBackColor = true;
			this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.loginBT);
			this.Controls.Add(this.passwordTB);
			this.Controls.Add(this.usernameTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox usernameTB;
		private System.Windows.Forms.TextBox passwordTB;
		private System.Windows.Forms.Button loginBT;
	}
}