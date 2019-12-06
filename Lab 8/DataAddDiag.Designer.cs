namespace Lab_8
{
	partial class DataAddDiag
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
			this.mtName = new System.Windows.Forms.MaskedTextBox();
			this.mtAuthor = new System.Windows.Forms.MaskedTextBox();
			this.mtEditor = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bRand = new System.Windows.Forms.Button();
			this.bInput = new System.Windows.Forms.Button();
			this.gbData = new System.Windows.Forms.GroupBox();
			this.numPos = new System.Windows.Forms.NumericUpDown();
			this.rbToPos = new System.Windows.Forms.RadioButton();
			this.rbToEnd = new System.Windows.Forms.RadioButton();
			this.rbToBegin = new System.Windows.Forms.RadioButton();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.gbData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPos)).BeginInit();
			this.SuspendLayout();
			// 
			// mtName
			// 
			this.mtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mtName.Location = new System.Drawing.Point(118, 19);
			this.mtName.Mask = ">L<?????????????????";
			this.mtName.Name = "mtName";
			this.mtName.Size = new System.Drawing.Size(118, 20);
			this.mtName.TabIndex = 0;
			this.mtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtName_KeyDown);
			// 
			// mtAuthor
			// 
			this.mtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mtAuthor.Location = new System.Drawing.Point(118, 45);
			this.mtAuthor.Mask = ">L<?????????????????";
			this.mtAuthor.Name = "mtAuthor";
			this.mtAuthor.Size = new System.Drawing.Size(118, 20);
			this.mtAuthor.TabIndex = 1;
			// 
			// mtEditor
			// 
			this.mtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mtEditor.Location = new System.Drawing.Point(118, 71);
			this.mtEditor.Mask = ">L<?????????????????";
			this.mtEditor.Name = "mtEditor";
			this.mtEditor.Size = new System.Drawing.Size(118, 20);
			this.mtEditor.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Название:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Автор:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Издатель:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Год издательства:";
			// 
			// bRand
			// 
			this.bRand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bRand.Location = new System.Drawing.Point(96, 243);
			this.bRand.Name = "bRand";
			this.bRand.Size = new System.Drawing.Size(81, 23);
			this.bRand.TabIndex = 9;
			this.bRand.Text = "Случайные";
			this.bRand.UseVisualStyleBackColor = true;
			// 
			// bInput
			// 
			this.bInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bInput.Location = new System.Drawing.Point(177, 243);
			this.bInput.Name = "bInput";
			this.bInput.Size = new System.Drawing.Size(81, 23);
			this.bInput.TabIndex = 4;
			this.bInput.Text = "Ввод";
			this.bInput.UseVisualStyleBackColor = true;
			this.bInput.Click += new System.EventHandler(this.bInput_Click);
			// 
			// gbData
			// 
			this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbData.Controls.Add(this.dtpFrom);
			this.gbData.Controls.Add(this.numPos);
			this.gbData.Controls.Add(this.rbToPos);
			this.gbData.Controls.Add(this.rbToEnd);
			this.gbData.Controls.Add(this.rbToBegin);
			this.gbData.Controls.Add(this.mtName);
			this.gbData.Controls.Add(this.mtAuthor);
			this.gbData.Controls.Add(this.mtEditor);
			this.gbData.Controls.Add(this.label4);
			this.gbData.Controls.Add(this.label3);
			this.gbData.Controls.Add(this.label1);
			this.gbData.Controls.Add(this.label2);
			this.gbData.Location = new System.Drawing.Point(7, 14);
			this.gbData.Name = "gbData";
			this.gbData.Size = new System.Drawing.Size(251, 223);
			this.gbData.TabIndex = 10;
			this.gbData.TabStop = false;
			this.gbData.Text = "Данные";
			// 
			// numPos
			// 
			this.numPos.Location = new System.Drawing.Point(116, 181);
			this.numPos.Name = "numPos";
			this.numPos.Size = new System.Drawing.Size(120, 20);
			this.numPos.TabIndex = 11;
			// 
			// rbToPos
			// 
			this.rbToPos.AutoSize = true;
			this.rbToPos.Location = new System.Drawing.Point(9, 181);
			this.rbToPos.Name = "rbToPos";
			this.rbToPos.Size = new System.Drawing.Size(79, 17);
			this.rbToPos.TabIndex = 10;
			this.rbToPos.Text = "В позицию";
			this.rbToPos.UseVisualStyleBackColor = true;
			// 
			// rbToEnd
			// 
			this.rbToEnd.AutoSize = true;
			this.rbToEnd.Location = new System.Drawing.Point(9, 158);
			this.rbToEnd.Name = "rbToEnd";
			this.rbToEnd.Size = new System.Drawing.Size(65, 17);
			this.rbToEnd.TabIndex = 9;
			this.rbToEnd.Text = "В конец";
			this.rbToEnd.UseVisualStyleBackColor = true;
			// 
			// rbToBegin
			// 
			this.rbToBegin.AutoSize = true;
			this.rbToBegin.Checked = true;
			this.rbToBegin.Location = new System.Drawing.Point(9, 135);
			this.rbToBegin.Name = "rbToBegin";
			this.rbToBegin.Size = new System.Drawing.Size(70, 17);
			this.rbToBegin.TabIndex = 8;
			this.rbToBegin.TabStop = true;
			this.rbToBegin.Text = "В начало";
			this.rbToBegin.UseVisualStyleBackColor = true;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(118, 100);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(118, 20);
			this.dtpFrom.TabIndex = 12;
			// 
			// DataAddDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 273);
			this.ControlBox = false;
			this.Controls.Add(this.gbData);
			this.Controls.Add(this.bInput);
			this.Controls.Add(this.bRand);
			this.Name = "DataAddDiag";
			this.Text = "Добавление книги";
			this.gbData.ResumeLayout(false);
			this.gbData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtName;
		private System.Windows.Forms.MaskedTextBox mtAuthor;
		private System.Windows.Forms.MaskedTextBox mtEditor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bRand;
		private System.Windows.Forms.Button bInput;
		private System.Windows.Forms.GroupBox gbData;
		public System.Windows.Forms.NumericUpDown numPos;
		public System.Windows.Forms.RadioButton rbToPos;
		public System.Windows.Forms.RadioButton rbToEnd;
		public System.Windows.Forms.RadioButton rbToBegin;
		public System.Windows.Forms.DateTimePicker dtpFrom;
	}
}