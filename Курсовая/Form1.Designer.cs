namespace Курсовая
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.printEditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.derivedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.publicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.holderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.printEditionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.derivedType,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publicationDataGridViewTextBoxColumn,
            this.editorDataGridViewTextBoxColumn,
            this.Rating,
            this.holderDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.printEditionBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(976, 569);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.VirtualMode = true;
			// 
			// printEditionBindingSource
			// 
			this.printEditionBindingSource.DataSource = typeof(Курсовая.PrintEdition);
			// 
			// derivedType
			// 
			this.derivedType.DataPropertyName = "derivedType";
			this.derivedType.HeaderText = "Тип печатного издания";
			this.derivedType.Name = "derivedType";
			this.derivedType.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// authorDataGridViewTextBoxColumn
			// 
			this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
			this.authorDataGridViewTextBoxColumn.HeaderText = "Автор";
			this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
			// 
			// publicationDataGridViewTextBoxColumn
			// 
			this.publicationDataGridViewTextBoxColumn.DataPropertyName = "Publication";
			this.publicationDataGridViewTextBoxColumn.HeaderText = "Дата издания";
			this.publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
			// 
			// editorDataGridViewTextBoxColumn
			// 
			this.editorDataGridViewTextBoxColumn.DataPropertyName = "Editor";
			this.editorDataGridViewTextBoxColumn.HeaderText = "Издатель";
			this.editorDataGridViewTextBoxColumn.Name = "editorDataGridViewTextBoxColumn";
			// 
			// Rating
			// 
			this.Rating.DataPropertyName = "Rating";
			this.Rating.HeaderText = "Рейтинг";
			this.Rating.Name = "Rating";
			// 
			// holderDataGridViewTextBoxColumn
			// 
			this.holderDataGridViewTextBoxColumn.DataPropertyName = "Holder";
			this.holderDataGridViewTextBoxColumn.HeaderText = "Текущий держатель";
			this.holderDataGridViewTextBoxColumn.Name = "holderDataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 593);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.printEditionBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource printEditionBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn derivedType;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn editorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
		private System.Windows.Forms.DataGridViewTextBoxColumn holderDataGridViewTextBoxColumn;
	}
}

