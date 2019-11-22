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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lArray = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bCreate1d = new System.Windows.Forms.Button();
			this.bDelMean = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(214, 6);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(277, 266);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bDelMean);
			this.groupBox1.Controls.Add(this.bCreate1d);
			this.groupBox1.Location = new System.Drawing.Point(12, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 86);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Действия над массивом";
			// 
			// bCreate1d
			// 
			this.bCreate1d.Location = new System.Drawing.Point(6, 19);
			this.bCreate1d.Name = "bCreate1d";
			this.bCreate1d.Size = new System.Drawing.Size(104, 23);
			this.bCreate1d.TabIndex = 0;
			this.bCreate1d.Text = "Создать";
			this.bCreate1d.UseVisualStyleBackColor = true;
			// 
			// bDelMean
			// 
			this.bDelMean.AllowDrop = true;
			this.bDelMean.Location = new System.Drawing.Point(6, 48);
			this.bDelMean.Name = "bDelMean";
			this.bDelMean.Size = new System.Drawing.Size(104, 23);
			this.bDelMean.TabIndex = 1;
			this.bDelMean.Text = "Удалить среднее";
			this.bDelMean.UseVisualStyleBackColor = true;
			this.bDelMean.Click += new System.EventHandler(this.bCreate1d_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 284);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lArray);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.richTextBox1);
			this.MinimumSize = new System.Drawing.Size(519, 323);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lArray;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bDelMean;
		private System.Windows.Forms.Button bCreate1d;
	}
}

