namespace CompanyManagementApp
{
	partial class LeaveRequestsManagementForm
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.approveBT = new System.Windows.Forms.Button();
			this.rejectBT = new System.Windows.Forms.Button();
			this.deleteBT = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(560, 284);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaveRequestdGV_CellContentClick);
			// 
			// approveBT
			// 
			this.approveBT.Location = new System.Drawing.Point(119, 319);
			this.approveBT.Name = "approveBT";
			this.approveBT.Size = new System.Drawing.Size(75, 23);
			this.approveBT.TabIndex = 1;
			this.approveBT.Text = "approve";
			this.approveBT.UseVisualStyleBackColor = true;
			this.approveBT.Click += new System.EventHandler(this.approveBT_Click);
			// 
			// rejectBT
			// 
			this.rejectBT.Location = new System.Drawing.Point(231, 319);
			this.rejectBT.Name = "rejectBT";
			this.rejectBT.Size = new System.Drawing.Size(75, 23);
			this.rejectBT.TabIndex = 2;
			this.rejectBT.Text = "reject";
			this.rejectBT.UseVisualStyleBackColor = true;
			this.rejectBT.Click += new System.EventHandler(this.rejectBT_Click);
			// 
			// deleteBT
			// 
			this.deleteBT.Location = new System.Drawing.Point(349, 319);
			this.deleteBT.Name = "deleteBT";
			this.deleteBT.Size = new System.Drawing.Size(75, 23);
			this.deleteBT.TabIndex = 3;
			this.deleteBT.Text = "delete";
			this.deleteBT.UseVisualStyleBackColor = true;
			this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
			// 
			// LeaveRequestsManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.deleteBT);
			this.Controls.Add(this.rejectBT);
			this.Controls.Add(this.approveBT);
			this.Controls.Add(this.dataGridView);
			this.Name = "LeaveRequestsManagementForm";
			this.Text = "Leave Requests Management";
			this.Load += new System.EventHandler(this.LeaveRequestsManagementForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button approveBT;
		private System.Windows.Forms.Button rejectBT;
		private System.Windows.Forms.Button deleteBT;
	}
}