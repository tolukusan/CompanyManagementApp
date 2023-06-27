namespace CompanyManagementApp
{
	partial class AttendanceForm
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
			this.clockInBT = new System.Windows.Forms.Button();
			this.clockOutBT = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.switchToEmpRegBT = new System.Windows.Forms.Button();
			this.switchToLeaveReqBT = new System.Windows.Forms.Button();
			this.submitBT = new System.Windows.Forms.Button();
			this.clockInLB = new System.Windows.Forms.Label();
			this.ClockOutLB = new System.Windows.Forms.Label();
			this.LeaveReqManBT = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clockInBT
			// 
			this.clockInBT.Location = new System.Drawing.Point(3, 130);
			this.clockInBT.Name = "clockInBT";
			this.clockInBT.Size = new System.Drawing.Size(75, 23);
			this.clockInBT.TabIndex = 0;
			this.clockInBT.Text = "Clock In";
			this.clockInBT.UseVisualStyleBackColor = true;
			// 
			// clockOutBT
			// 
			this.clockOutBT.Location = new System.Drawing.Point(3, 166);
			this.clockOutBT.Name = "clockOutBT";
			this.clockOutBT.Size = new System.Drawing.Size(75, 23);
			this.clockOutBT.TabIndex = 1;
			this.clockOutBT.Text = "Clock Out";
			this.clockOutBT.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Attendance Capture";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// switchToEmpRegBT
			// 
			this.switchToEmpRegBT.Location = new System.Drawing.Point(3, 204);
			this.switchToEmpRegBT.Name = "switchToEmpRegBT";
			this.switchToEmpRegBT.Size = new System.Drawing.Size(141, 23);
			this.switchToEmpRegBT.TabIndex = 3;
			this.switchToEmpRegBT.Text = "Employee Registration Form";
			this.switchToEmpRegBT.UseVisualStyleBackColor = true;
			// 
			// switchToLeaveReqBT
			// 
			this.switchToLeaveReqBT.Location = new System.Drawing.Point(3, 245);
			this.switchToLeaveReqBT.Name = "switchToLeaveReqBT";
			this.switchToLeaveReqBT.Size = new System.Drawing.Size(149, 23);
			this.switchToLeaveReqBT.TabIndex = 4;
			this.switchToLeaveReqBT.Text = "Leave Requests";
			this.switchToLeaveReqBT.UseVisualStyleBackColor = true;
			// 
			// submitBT
			// 
			this.submitBT.Location = new System.Drawing.Point(169, 91);
			this.submitBT.Name = "submitBT";
			this.submitBT.Size = new System.Drawing.Size(75, 23);
			this.submitBT.TabIndex = 10;
			this.submitBT.Text = "Submit Data";
			this.submitBT.UseVisualStyleBackColor = true;
			// 
			// clockInLB
			// 
			this.clockInLB.AutoSize = true;
			this.clockInLB.Location = new System.Drawing.Point(100, 135);
			this.clockInLB.Name = "clockInLB";
			this.clockInLB.Size = new System.Drawing.Size(22, 13);
			this.clockInLB.TabIndex = 11;
			this.clockInLB.Text = "-----";
			// 
			// ClockOutLB
			// 
			this.ClockOutLB.AutoSize = true;
			this.ClockOutLB.Location = new System.Drawing.Point(100, 171);
			this.ClockOutLB.Name = "ClockOutLB";
			this.ClockOutLB.Size = new System.Drawing.Size(22, 13);
			this.ClockOutLB.TabIndex = 12;
			this.ClockOutLB.Text = "-----";
			// 
			// LeaveReqManBT
			// 
			this.LeaveReqManBT.Location = new System.Drawing.Point(11, 285);
			this.LeaveReqManBT.Name = "LeaveReqManBT";
			this.LeaveReqManBT.Size = new System.Drawing.Size(123, 35);
			this.LeaveReqManBT.TabIndex = 13;
			this.LeaveReqManBT.Text = "View Leave Requests (Manager Only)";
			this.LeaveReqManBT.UseVisualStyleBackColor = true;
			this.LeaveReqManBT.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 91);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "EmployeeID";
			// 
			// AttendanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.LeaveReqManBT);
			this.Controls.Add(this.ClockOutLB);
			this.Controls.Add(this.clockInLB);
			this.Controls.Add(this.submitBT);
			this.Controls.Add(this.switchToLeaveReqBT);
			this.Controls.Add(this.switchToEmpRegBT);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.clockOutBT);
			this.Controls.Add(this.clockInBT);
			this.Name = "AttendanceForm";
			this.Text = "AttendanceForm";
			this.Load += new System.EventHandler(this.AttendanceForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button clockInBT;
		private System.Windows.Forms.Button clockOutBT;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button switchToEmpRegBT;
		private System.Windows.Forms.Button switchToLeaveReqBT;
		private System.Windows.Forms.Button submitBT;
		private System.Windows.Forms.Label clockInLB;
		private System.Windows.Forms.Label ClockOutLB;
		private System.Windows.Forms.Button LeaveReqManBT;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
	}
}