namespace Lab_11
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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabSortedList = new System.Windows.Forms.TabPage();
			this.tabList = new System.Windows.Forms.TabPage();
			this.tabQueue = new System.Windows.Forms.TabPage();
			this.tabSortedDictionary = new System.Windows.Forms.TabPage();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabSortedList);
			this.tabControl1.Controls.Add(this.tabList);
			this.tabControl1.Controls.Add(this.tabQueue);
			this.tabControl1.Controls.Add(this.tabSortedDictionary);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(994, 620);
			this.tabControl1.TabIndex = 0;
			// 
			// tabSortedList
			// 
			this.tabSortedList.Location = new System.Drawing.Point(4, 22);
			this.tabSortedList.Name = "tabSortedList";
			this.tabSortedList.Padding = new System.Windows.Forms.Padding(3);
			this.tabSortedList.Size = new System.Drawing.Size(986, 594);
			this.tabSortedList.TabIndex = 0;
			this.tabSortedList.Text = "SortedList";
			this.tabSortedList.UseVisualStyleBackColor = true;
			// 
			// tabList
			// 
			this.tabList.Location = new System.Drawing.Point(4, 22);
			this.tabList.Name = "tabList";
			this.tabList.Padding = new System.Windows.Forms.Padding(3);
			this.tabList.Size = new System.Drawing.Size(986, 594);
			this.tabList.TabIndex = 1;
			this.tabList.Text = "List";
			this.tabList.UseVisualStyleBackColor = true;
			// 
			// tabQueue
			// 
			this.tabQueue.Location = new System.Drawing.Point(4, 22);
			this.tabQueue.Name = "tabQueue";
			this.tabQueue.Size = new System.Drawing.Size(986, 594);
			this.tabQueue.TabIndex = 2;
			this.tabQueue.Text = "Queue";
			this.tabQueue.UseVisualStyleBackColor = true;
			// 
			// tabSortedDictionary
			// 
			this.tabSortedDictionary.Location = new System.Drawing.Point(4, 22);
			this.tabSortedDictionary.Name = "tabSortedDictionary";
			this.tabSortedDictionary.Size = new System.Drawing.Size(986, 594);
			this.tabSortedDictionary.TabIndex = 3;
			this.tabSortedDictionary.Text = "SortedDictionary";
			this.tabSortedDictionary.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 620);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabSortedList;
		private System.Windows.Forms.TabPage tabList;
		private System.Windows.Forms.TabPage tabQueue;
		private System.Windows.Forms.TabPage tabSortedDictionary;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}

