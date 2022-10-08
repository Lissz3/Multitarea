namespace Ex3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnView = new System.Windows.Forms.Button();
			this.btnInfo = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.txbInfo = new System.Windows.Forms.TextBox();
			this.tbxManager = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(12, 12);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(108, 23);
			this.btnView.TabIndex = 0;
			this.btnView.Text = "View processes";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// btnInfo
			// 
			this.btnInfo.Location = new System.Drawing.Point(126, 12);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(96, 23);
			this.btnInfo.TabIndex = 1;
			this.btnInfo.Text = "Processes info";
			this.btnInfo.UseVisualStyleBackColor = true;
			this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(228, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(102, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Close processes";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(336, 12);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Kill processes";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(432, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Run App";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(513, 12);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(85, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "Starts with...";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// txbInfo
			// 
			this.txbInfo.Location = new System.Drawing.Point(688, 12);
			this.txbInfo.Name = "txbInfo";
			this.txbInfo.Size = new System.Drawing.Size(100, 23);
			this.txbInfo.TabIndex = 6;
			// 
			// tbxManager
			// 
			this.tbxManager.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbxManager.Location = new System.Drawing.Point(12, 41);
			this.tbxManager.Multiline = true;
			this.tbxManager.Name = "tbxManager";
			this.tbxManager.ReadOnly = true;
			this.tbxManager.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxManager.Size = new System.Drawing.Size(776, 397);
			this.tbxManager.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbxManager);
			this.Controls.Add(this.txbInfo);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.btnView);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnView;
		private Button btnInfo;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private TextBox txbInfo;
		private TextBox tbxManager;
	}
}