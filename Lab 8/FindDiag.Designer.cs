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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbFindByAuthor
			// 
			this.rbFindByAuthor.AutoSize = true;
			this.rbFindByAuthor.Location = new System.Drawing.Point(3, 101);
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
			this.rbFindByTime.Location = new System.Drawing.Point(3, 3);
			this.rbFindByTime.Name = "rbFindByTime";
			this.rbFindByTime.Size = new System.Drawing.Size(164, 17);
			this.rbFindByTime.TabIndex = 2;
			this.rbFindByTime.TabStop = true;
			this.rbFindByTime.Text = "Поиск по времени издания";
			this.rbFindByTime.UseVisualStyleBackColor = true;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(45, 26);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(144, 20);
			this.dtpFrom.TabIndex = 0;
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(45, 53);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(144, 20);
			this.dtpTo.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "C:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "По:";
			// 
			// mtName
			// 
			this.mtName.Location = new System.Drawing.Point(45, 124);
			this.mtName.Mask = ">L<?????????????????";
			this.mtName.Name = "mtName";
			this.mtName.Size = new System.Drawing.Size(144, 20);
			this.mtName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Автор:";
			// 
			// bOK
			// 
			this.bOK.Location = new System.Drawing.Point(114, 156);
			this.bOK.Name = "bOK";
			this.bOK.Size = new System.Drawing.Size(75, 23);
			this.bOK.TabIndex = 9;
			this.bOK.Text = "Показать";
			this.bOK.UseVisualStyleBackColor = true;
			this.bOK.Click += new System.EventHandler(this.bOK_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(217, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(527, 264);
			this.dataGridView1.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.rbFindByTime);
			this.panel1.Controls.Add(this.rbFindByAuthor);
			this.panel1.Controls.Add(this.bOK);
			this.panel1.Controls.Add(this.dtpFrom);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.dtpTo);
			this.panel1.Controls.Add(this.mtName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(11, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 264);
			this.panel1.TabIndex = 11;
			// 
			// FindDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 288);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FindDiag";
			this.Text = "Поиск";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
	}
}