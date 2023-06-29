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
			this.switchToLeaveReqBT = new System.Windows.Forms.Button();
			this.clockInLB = new System.Windows.Forms.Label();
			this.clockOutLB = new System.Windows.Forms.Label();
			this.ReqManBT = new System.Windows.Forms.Button();
			this.employeeIDTB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// clockInBT
			// 
			this.clockInBT.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.clockInBT.Location = new System.Drawing.Point(12, 110);
			this.clockInBT.Name = "clockInBT";
			this.clockInBT.Size = new System.Drawing.Size(95, 35);
			this.clockInBT.TabIndex = 0;
			this.clockInBT.Text = "Clock In";
			this.clockInBT.UseVisualStyleBackColor = true;
			this.clockInBT.Click += new System.EventHandler(this.clockInBT_Click);
			// 
			// clockOutBT
			// 
			this.clockOutBT.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.clockOutBT.Location = new System.Drawing.Point(12, 165);
			this.clockOutBT.Name = "clockOutBT";
			this.clockOutBT.Size = new System.Drawing.Size(95, 35);
			this.clockOutBT.TabIndex = 1;
			this.clockOutBT.Text = "Clock Out";
			this.clockOutBT.UseVisualStyleBackColor = true;
			this.clockOutBT.Click += new System.EventHandler(this.clockOutBT_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Attendance Capture";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// switchToLeaveReqBT
			// 
			this.switchToLeaveReqBT.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.switchToLeaveReqBT.Location = new System.Drawing.Point(12, 266);
			this.switchToLeaveReqBT.Name = "switchToLeaveReqBT";
			this.switchToLeaveReqBT.Size = new System.Drawing.Size(160, 60);
			this.switchToLeaveReqBT.TabIndex = 4;
			this.switchToLeaveReqBT.Text = "Make Leave Requests";
			this.switchToLeaveReqBT.UseVisualStyleBackColor = true;
			this.switchToLeaveReqBT.Click += new System.EventHandler(this.switchToLeaveReqBT_Click);
			// 
			// clockInLB
			// 
			this.clockInLB.AutoSize = true;
			this.clockInLB.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.clockInLB.Location = new System.Drawing.Point(130, 115);
			this.clockInLB.Name = "clockInLB";
			this.clockInLB.Size = new System.Drawing.Size(45, 21);
			this.clockInLB.TabIndex = 11;
			this.clockInLB.Text = "-----";
			// 
			// clockOutLB
			// 
			this.clockOutLB.AutoSize = true;
			this.clockOutLB.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.clockOutLB.Location = new System.Drawing.Point(130, 156);
			this.clockOutLB.Name = "clockOutLB";
			this.clockOutLB.Size = new System.Drawing.Size(45, 21);
			this.clockOutLB.TabIndex = 12;
			this.clockOutLB.Text = "-----";
			// 
			// ReqManBT
			// 
			this.ReqManBT.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.ReqManBT.Location = new System.Drawing.Point(215, 266);
			this.ReqManBT.Name = "ReqManBT";
			this.ReqManBT.Size = new System.Drawing.Size(180, 60);
			this.ReqManBT.TabIndex = 13;
			this.ReqManBT.Text = "View Leave Requests (Manager Only)";
			this.ReqManBT.UseVisualStyleBackColor = true;
			this.ReqManBT.Click += new System.EventHandler(this.button1_Click);
			// 
			// employeeIDTB
			// 
			this.employeeIDTB.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.employeeIDTB.Location = new System.Drawing.Point(123, 48);
			this.employeeIDTB.Name = "employeeIDTB";
			this.employeeIDTB.Size = new System.Drawing.Size(100, 33);
			this.employeeIDTB.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F);
			this.label2.Location = new System.Drawing.Point(8, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 21);
			this.label2.TabIndex = 15;
			this.label2.Text = "EmployeeID";
			// 
			// AttendanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.employeeIDTB);
			this.Controls.Add(this.ReqManBT);
			this.Controls.Add(this.clockOutLB);
			this.Controls.Add(this.clockInLB);
			this.Controls.Add(this.switchToLeaveReqBT);
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
		private System.Windows.Forms.Button switchToLeaveReqBT;
		private System.Windows.Forms.Label clockInLB;
		private System.Windows.Forms.Label clockOutLB;
		private System.Windows.Forms.Button ReqManBT;
		private System.Windows.Forms.TextBox employeeIDTB;
		private System.Windows.Forms.Label label2;
	}
}