namespace CompanyManagementApp
{
	partial class EmployeeRegistrationForm
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
			this.nameTB = new System.Windows.Forms.TextBox();
			this.emailTB = new System.Windows.Forms.TextBox();
			this.phoneTB = new System.Windows.Forms.TextBox();
			this.departmentTB = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.switchToAttendanceBT = new System.Windows.Forms.Button();
			this.submitBT = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.empIDTB = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(192, 103);
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(100, 20);
			this.nameTB.TabIndex = 0;
			// 
			// emailTB
			// 
			this.emailTB.Location = new System.Drawing.Point(192, 138);
			this.emailTB.Name = "emailTB";
			this.emailTB.Size = new System.Drawing.Size(100, 20);
			this.emailTB.TabIndex = 1;
			// 
			// phoneTB
			// 
			this.phoneTB.Location = new System.Drawing.Point(192, 174);
			this.phoneTB.Name = "phoneTB";
			this.phoneTB.Size = new System.Drawing.Size(100, 20);
			this.phoneTB.TabIndex = 2;
			// 
			// departmentTB
			// 
			this.departmentTB.FormattingEnabled = true;
			this.departmentTB.Items.AddRange(new object[] {
            "Human Resources (HR)",
            "Finance",
            "Sales and Marketing",
            "Operations",
            "Information Technology (IT)"});
			this.departmentTB.Location = new System.Drawing.Point(192, 210);
			this.departmentTB.Name = "departmentTB";
			this.departmentTB.Size = new System.Drawing.Size(121, 21);
			this.departmentTB.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(103, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(103, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Phone Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(103, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Department";
			// 
			// switchToAttendanceBT
			// 
			this.switchToAttendanceBT.Location = new System.Drawing.Point(255, 274);
			this.switchToAttendanceBT.Name = "switchToAttendanceBT";
			this.switchToAttendanceBT.Size = new System.Drawing.Size(146, 23);
			this.switchToAttendanceBT.TabIndex = 8;
			this.switchToAttendanceBT.Text = "Attendance Capture";
			this.switchToAttendanceBT.UseVisualStyleBackColor = true;
			this.switchToAttendanceBT.Click += new System.EventHandler(this.switchToAttendanceBT_Click);
			// 
			// submitBT
			// 
			this.submitBT.Location = new System.Drawing.Point(124, 274);
			this.submitBT.Name = "submitBT";
			this.submitBT.Size = new System.Drawing.Size(75, 23);
			this.submitBT.TabIndex = 9;
			this.submitBT.Text = "Submit Data";
			this.submitBT.UseVisualStyleBackColor = true;
			this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(103, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Employee ID";
			// 
			// empIDTB
			// 
			this.empIDTB.Location = new System.Drawing.Point(192, 67);
			this.empIDTB.Name = "empIDTB";
			this.empIDTB.Size = new System.Drawing.Size(100, 20);
			this.empIDTB.TabIndex = 11;
			// 
			// EmployeeRegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.empIDTB);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.submitBT);
			this.Controls.Add(this.switchToAttendanceBT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.departmentTB);
			this.Controls.Add(this.phoneTB);
			this.Controls.Add(this.emailTB);
			this.Controls.Add(this.nameTB);
			this.Name = "EmployeeRegistrationForm";
			this.Text = "Employee Registration";
			this.Load += new System.EventHandler(this.EmployeeRegistrationForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameTB;
		private System.Windows.Forms.TextBox emailTB;
		private System.Windows.Forms.TextBox phoneTB;
		private System.Windows.Forms.ComboBox departmentTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button switchToAttendanceBT;
		private System.Windows.Forms.Button submitBT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox empIDTB;
	}
}

