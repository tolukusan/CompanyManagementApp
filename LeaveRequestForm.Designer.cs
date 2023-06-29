namespace CompanyManagementApp
{
	partial class LeaveRequestForm
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
			this.submitBT = new System.Windows.Forms.Button();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.reasonTB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.exitBT = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// submitBT
			// 
			this.submitBT.Location = new System.Drawing.Point(44, 287);
			this.submitBT.Name = "submitBT";
			this.submitBT.Size = new System.Drawing.Size(75, 23);
			this.submitBT.TabIndex = 10;
			this.submitBT.Text = "Submit";
			this.submitBT.UseVisualStyleBackColor = true;
			this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Location = new System.Drawing.Point(44, 154);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerStart.TabIndex = 11;
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.Location = new System.Drawing.Point(44, 234);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerEnd.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Start Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(120, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "End Date";
			// 
			// reasonTB
			// 
			this.reasonTB.Location = new System.Drawing.Point(310, 143);
			this.reasonTB.MaxLength = 0;
			this.reasonTB.Name = "reasonTB";
			this.reasonTB.Size = new System.Drawing.Size(217, 20);
			this.reasonTB.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(392, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Reason";
			// 
			// exitBT
			// 
			this.exitBT.Location = new System.Drawing.Point(169, 287);
			this.exitBT.Name = "exitBT";
			this.exitBT.Size = new System.Drawing.Size(75, 23);
			this.exitBT.TabIndex = 17;
			this.exitBT.Text = "Exit";
			this.exitBT.UseVisualStyleBackColor = true;
			// 
			// LeaveRequestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.exitBT);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.reasonTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerEnd);
			this.Controls.Add(this.dateTimePickerStart);
			this.Controls.Add(this.submitBT);
			this.Name = "LeaveRequestForm";
			this.Text = "LeaveRequestForm";
			this.Load += new System.EventHandler(this.LeaveRequestForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button submitBT;
		private System.Windows.Forms.DateTimePicker dateTimePickerStart;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox reasonTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button exitBT;
	}
}