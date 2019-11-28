namespace Lab_8
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
			this.bLoad = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bAdd = new System.Windows.Forms.Button();
			this.bFind = new System.Windows.Forms.Button();
			this.bDelete = new System.Windows.Forms.Button();
			this.bOverwrite = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// bLoad
			// 
			this.bLoad.Location = new System.Drawing.Point(589, 216);
			this.bLoad.Name = "bLoad";
			this.bLoad.Size = new System.Drawing.Size(87, 23);
			this.bLoad.TabIndex = 1;
			this.bLoad.Text = "Загрузить из";
			this.bLoad.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Autor,
            this.Editor,
            this.Edition});
			this.dataGridView1.Location = new System.Drawing.Point(93, 11);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView1.Size = new System.Drawing.Size(583, 202);
			this.dataGridView1.TabIndex = 2;
			// 
			// Book
			// 
			this.Book.HeaderText = "Книга";
			this.Book.Name = "Book";
			this.Book.ReadOnly = true;
			// 
			// Autor
			// 
			this.Autor.HeaderText = "Автор";
			this.Autor.Name = "Autor";
			this.Autor.ReadOnly = true;
			// 
			// Editor
			// 
			this.Editor.HeaderText = "Издательство";
			this.Editor.Name = "Editor";
			this.Editor.ReadOnly = true;
			// 
			// Edition
			// 
			this.Edition.HeaderText = "Год издания";
			this.Edition.Name = "Edition";
			this.Edition.ReadOnly = true;
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(12, 12);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(75, 23);
			this.bAdd.TabIndex = 3;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bFind
			// 
			this.bFind.Location = new System.Drawing.Point(12, 41);
			this.bFind.Name = "bFind";
			this.bFind.Size = new System.Drawing.Size(75, 23);
			this.bFind.TabIndex = 4;
			this.bFind.Text = "Найти";
			this.bFind.UseVisualStyleBackColor = true;
			this.bFind.Click += new System.EventHandler(this.bFind_Click);
			// 
			// bDelete
			// 
			this.bDelete.Location = new System.Drawing.Point(12, 70);
			this.bDelete.Name = "bDelete";
			this.bDelete.Size = new System.Drawing.Size(75, 23);
			this.bDelete.TabIndex = 5;
			this.bDelete.Text = "Удалить";
			this.bDelete.UseVisualStyleBackColor = true;
			// 
			// bOverwrite
			// 
			this.bOverwrite.Location = new System.Drawing.Point(508, 215);
			this.bOverwrite.Name = "bOverwrite";
			this.bOverwrite.Size = new System.Drawing.Size(75, 24);
			this.bOverwrite.TabIndex = 6;
			this.bOverwrite.Text = "Сохранить";
			this.bOverwrite.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(688, 252);
			this.Controls.Add(this.bOverwrite);
			this.Controls.Add(this.bDelete);
			this.Controls.Add(this.bFind);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button bLoad;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Book;
		private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Editor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bFind;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.Button bOverwrite;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

