namespace Lab_8
{
	partial class FindDiag
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
			this.rbFindByAuthor = new System.Windows.Forms.RadioButton();
			this.rbFindByTime = new System.Windows.Forms.RadioButton();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mtName = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rbFindByAuthor
			// 
			this.rbFindByAuthor.AutoSize = true;
			this.rbFindByAuthor.Location = new System.Drawing.Point(12, 110);
			this.rbFindByAuthor.Name = "rbFindByAuthor";
			this.rbFindByAuthor.Size = new System.Drawing.Size(109, 17);
			this.rbFindByAuthor.TabIndex = 3;
			this.rbFindByAuthor.TabStop = true;
			this.rbFindByAuthor.Text = "Поиск по автору";
			this.rbFindByAuthor.UseVisualStyleBackColor = true;
			// 
			// rbFindByTime
			// 
			this.rbFindByTime.AutoSize = true;
			this.rbFindByTime.Checked = true;
			this.rbFindByTime.Location = new System.Drawing.Point(12, 12);
			this.rbFindByTime.Name = "rbFindByTime";
			this.rbFindByTime.Size = new System.Drawing.Size(164, 17);
			this.rbFindByTime.TabIndex = 2;
			this.rbFindByTime.TabStop = true;
			this.rbFindByTime.Text = "Поиск по времени издания";
			this.rbFindByTime.UseVisualStyleBackColor = true;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(54, 35);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(144, 20);
			this.dtpFrom.TabIndex = 0;
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(54, 61);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(144, 20);
			this.dtpTo.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "C:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "По:";
			// 
			// mtName
			// 
			this.mtName.Location = new System.Drawing.Point(54, 133);
			this.mtName.Mask = ">L<?????????????????";
			this.mtName.Name = "mtName";
			this.mtName.Size = new System.Drawing.Size(144, 20);
			this.mtName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Автор:";
			// 
			// bOK
			// 
			this.bOK.Location = new System.Drawing.Point(123, 165);
			this.bOK.Name = "bOK";
			this.bOK.Size = new System.Drawing.Size(75, 23);
			this.bOK.TabIndex = 9;
			this.bOK.Text = "Ок";
			this.bOK.UseVisualStyleBackColor = true;
			this.bOK.Click += new System.EventHandler(this.bOK_Click);
			// 
			// FindDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(209, 200);
			this.Controls.Add(this.bOK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.mtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpTo);
			this.Controls.Add(this.dtpFrom);
			this.Controls.Add(this.rbFindByAuthor);
			this.Controls.Add(this.rbFindByTime);
			this.Name = "FindDiag";
			this.Text = "Поиск";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bOK;
		public System.Windows.Forms.DateTimePicker dtpTo;
		public System.Windows.Forms.DateTimePicker dtpFrom;
		public System.Windows.Forms.MaskedTextBox mtName;
		public System.Windows.Forms.RadioButton rbFindByAuthor;
		public System.Windows.Forms.RadioButton rbFindByTime;
	}
}