namespace Lab_7
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtArrayView = new System.Windows.Forms.RichTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lArray = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// rtArrayView
			// 
			this.rtArrayView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtArrayView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtArrayView.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtArrayView.Location = new System.Drawing.Point(214, 6);
			this.rtArrayView.Name = "rtArrayView";
			this.rtArrayView.ReadOnly = true;
			this.rtArrayView.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.rtArrayView.Size = new System.Drawing.Size(277, 266);
			this.rtArrayView.TabIndex = 0;
			this.rtArrayView.Text = "";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Одномерный",
            "Двумерный",
            "Рваный"});
			this.comboBox1.Location = new System.Drawing.Point(67, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// lArray
			// 
			this.lArray.AutoSize = true;
			this.lArray.Location = new System.Drawing.Point(12, 9);
			this.lArray.Name = "lArray";
			this.lArray.Size = new System.Drawing.Size(49, 13);
			this.lArray.TabIndex = 2;
			this.lArray.Text = "Массив:";
			this.lArray.Click += new System.EventHandler(this.label1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 284);
			this.Controls.Add(this.lArray);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.rtArrayView);
			this.MinimumSize = new System.Drawing.Size(518, 322);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Массивы";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lArray;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		public System.Windows.Forms.RichTextBox rtArrayView;
	}
}

