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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bLoad = new System.Windows.Forms.Button();
			this.bAdd = new System.Windows.Forms.Button();
			this.bOverwrite = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bDelByPos = new System.Windows.Forms.Button();
			this.numDelByPos = new System.Windows.Forms.NumericUpDown();
			this.bDelByName = new System.Windows.Forms.Button();
			this.tbDelByName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gbData = new System.Windows.Forms.GroupBox();
			this.dtpEditor = new System.Windows.Forms.DateTimePicker();
			this.numPos = new System.Windows.Forms.NumericUpDown();
			this.rbToPos = new System.Windows.Forms.RadioButton();
			this.rbToEnd = new System.Windows.Forms.RadioButton();
			this.rbToBegin = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.bDelSelected = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.bSearchByName = new System.Windows.Forms.Button();
			this.tbBookSearch = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.bSearchByEditor = new System.Windows.Forms.Button();
			this.tbEditorSearch = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.bSearchByAuthor = new System.Windows.Forms.Button();
			this.tbAuthorSearch = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.bSearchByTime = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.mtName = new System.Windows.Forms.TextBox();
			this.mtEditor = new System.Windows.Forms.TextBox();
			this.mtAuthor = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDelByPos)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.gbData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// bLoad
			// 
			this.bLoad.AutoSize = true;
			this.bLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bLoad.Location = new System.Drawing.Point(6, 51);
			this.bLoad.Margin = new System.Windows.Forms.Padding(4);
			this.bLoad.Name = "bLoad";
			this.bLoad.Size = new System.Drawing.Size(243, 27);
			this.bLoad.TabIndex = 1;
			this.bLoad.Text = "Открыть";
			this.bLoad.UseVisualStyleBackColor = false;
			this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
			// 
			// bAdd
			// 
			this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bAdd.Location = new System.Drawing.Point(9, 207);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(227, 23);
			this.bAdd.TabIndex = 3;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = false;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bOverwrite
			// 
			this.bOverwrite.AutoSize = true;
			this.bOverwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bOverwrite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bOverwrite.Location = new System.Drawing.Point(6, 22);
			this.bOverwrite.Margin = new System.Windows.Forms.Padding(5);
			this.bOverwrite.Name = "bOverwrite";
			this.bOverwrite.Size = new System.Drawing.Size(243, 27);
			this.bOverwrite.TabIndex = 6;
			this.bOverwrite.Text = "Сохранить";
			this.bOverwrite.UseVisualStyleBackColor = false;
			this.bOverwrite.Click += new System.EventHandler(this.bOverwrite_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "bin";
			this.openFileDialog1.FileName = "data.bin";
			this.openFileDialog1.InitialDirectory = "C:\\";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.Format = "d";
			dataGridViewCellStyle7.NullValue = null;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView1.Location = new System.Drawing.Point(282, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(743, 585);
			this.dataGridView1.TabIndex = 7;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "bin";
			this.saveFileDialog1.FileName = "data.bin";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bDelByPos);
			this.groupBox1.Controls.Add(this.numDelByPos);
			this.groupBox1.Location = new System.Drawing.Point(3, 256);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(194, 59);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Удалить по номеру";
			// 
			// bDelByPos
			// 
			this.bDelByPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bDelByPos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bDelByPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bDelByPos.Location = new System.Drawing.Point(90, 22);
			this.bDelByPos.Name = "bDelByPos";
			this.bDelByPos.Size = new System.Drawing.Size(98, 25);
			this.bDelByPos.TabIndex = 8;
			this.bDelByPos.Text = "Удалить";
			this.bDelByPos.UseVisualStyleBackColor = false;
			this.bDelByPos.Click += new System.EventHandler(this.bDelByPos_Click);
			// 
			// numDelByPos
			// 
			this.numDelByPos.Location = new System.Drawing.Point(6, 26);
			this.numDelByPos.Name = "numDelByPos";
			this.numDelByPos.Size = new System.Drawing.Size(65, 20);
			this.numDelByPos.TabIndex = 6;
			// 
			// bDelByName
			// 
			this.bDelByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bDelByName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bDelByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bDelByName.Location = new System.Drawing.Point(90, 45);
			this.bDelByName.Name = "bDelByName";
			this.bDelByName.Size = new System.Drawing.Size(98, 23);
			this.bDelByName.TabIndex = 10;
			this.bDelByName.Text = "Удалить ";
			this.bDelByName.UseVisualStyleBackColor = false;
			this.bDelByName.Click += new System.EventHandler(this.bDelByName_Click);
			// 
			// tbDelByName
			// 
			this.tbDelByName.Location = new System.Drawing.Point(6, 19);
			this.tbDelByName.Name = "tbDelByName";
			this.tbDelByName.Size = new System.Drawing.Size(182, 20);
			this.tbDelByName.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.bDelByName);
			this.groupBox2.Controls.Add(this.tbDelByName);
			this.groupBox2.Location = new System.Drawing.Point(3, 321);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(194, 78);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Удалить по названию";
			// 
			// gbData
			// 
			this.gbData.Controls.Add(this.mtEditor);
			this.gbData.Controls.Add(this.mtAuthor);
			this.gbData.Controls.Add(this.dtpEditor);
			this.gbData.Controls.Add(this.numPos);
			this.gbData.Controls.Add(this.mtName);
			this.gbData.Controls.Add(this.rbToPos);
			this.gbData.Controls.Add(this.rbToEnd);
			this.gbData.Controls.Add(this.rbToBegin);
			this.gbData.Controls.Add(this.bAdd);
			this.gbData.Controls.Add(this.label4);
			this.gbData.Controls.Add(this.label3);
			this.gbData.Controls.Add(this.label1);
			this.gbData.Controls.Add(this.label2);
			this.gbData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gbData.Location = new System.Drawing.Point(3, 6);
			this.gbData.Name = "gbData";
			this.gbData.Size = new System.Drawing.Size(251, 244);
			this.gbData.TabIndex = 12;
			this.gbData.TabStop = false;
			this.gbData.Text = "Добавить книгу";
			// 
			// dtpEditor
			// 
			this.dtpEditor.Checked = false;
			this.dtpEditor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEditor.Location = new System.Drawing.Point(118, 100);
			this.dtpEditor.Name = "dtpEditor";
			this.dtpEditor.Size = new System.Drawing.Size(118, 20);
			this.dtpEditor.TabIndex = 12;
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Год издательства:";
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.bOverwrite);
			this.groupBox3.Controls.Add(this.bLoad);
			this.groupBox3.Location = new System.Drawing.Point(3, 454);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(251, 88);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Файл";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 7);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(268, 585);
			this.tabControl1.TabIndex = 14;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage1.Controls.Add(this.bDelSelected);
			this.tabPage1.Controls.Add(this.gbData);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(260, 559);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Данные";
			// 
			// bDelSelected
			// 
			this.bDelSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.bDelSelected.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.bDelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bDelSelected.Location = new System.Drawing.Point(9, 405);
			this.bDelSelected.Name = "bDelSelected";
			this.bDelSelected.Size = new System.Drawing.Size(243, 23);
			this.bDelSelected.TabIndex = 13;
			this.bDelSelected.Text = "Удалить выделенные";
			this.bDelSelected.UseVisualStyleBackColor = false;
			this.bDelSelected.Click += new System.EventHandler(this.bDelSelected_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage2.Controls.Add(this.groupBox7);
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Controls.Add(this.groupBox5);
			this.tabPage2.Controls.Add(this.groupBox4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(260, 559);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Поиск";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.bSearchByName);
			this.groupBox7.Controls.Add(this.tbBookSearch);
			this.groupBox7.Controls.Add(this.label9);
			this.groupBox7.Location = new System.Drawing.Point(4, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(251, 73);
			this.groupBox7.TabIndex = 21;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Поиск по названию книги";
			// 
			// bSearchByName
			// 
			this.bSearchByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.bSearchByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bSearchByName.Location = new System.Drawing.Point(173, 44);
			this.bSearchByName.Name = "bSearchByName";
			this.bSearchByName.Size = new System.Drawing.Size(75, 23);
			this.bSearchByName.TabIndex = 19;
			this.bSearchByName.Text = "Показать";
			this.bSearchByName.UseVisualStyleBackColor = false;
			this.bSearchByName.Click += new System.EventHandler(this.bSearchByName_Click);
			// 
			// tbBookSearch
			// 
			this.tbBookSearch.Location = new System.Drawing.Point(49, 19);
			this.tbBookSearch.Name = "tbBookSearch";
			this.tbBookSearch.Size = new System.Drawing.Size(199, 20);
			this.tbBookSearch.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Книга:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.bSearchByEditor);
			this.groupBox6.Controls.Add(this.tbEditorSearch);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Location = new System.Drawing.Point(4, 164);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(251, 93);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Поиск по издательству";
			// 
			// bSearchByEditor
			// 
			this.bSearchByEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bSearchByEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.bSearchByEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bSearchByEditor.Location = new System.Drawing.Point(173, 64);
			this.bSearchByEditor.Name = "bSearchByEditor";
			this.bSearchByEditor.Size = new System.Drawing.Size(75, 23);
			this.bSearchByEditor.TabIndex = 19;
			this.bSearchByEditor.Text = "Показать";
			this.bSearchByEditor.UseVisualStyleBackColor = false;
			this.bSearchByEditor.Click += new System.EventHandler(this.bSearchByEditor_Click);
			// 
			// tbEditorSearch
			// 
			this.tbEditorSearch.Location = new System.Drawing.Point(6, 38);
			this.tbEditorSearch.Name = "tbEditorSearch";
			this.tbEditorSearch.Size = new System.Drawing.Size(242, 20);
			this.tbEditorSearch.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Издательство:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.bSearchByAuthor);
			this.groupBox5.Controls.Add(this.tbAuthorSearch);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Location = new System.Drawing.Point(4, 85);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(251, 73);
			this.groupBox5.TabIndex = 16;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Поиск по автору";
			// 
			// bSearchByAuthor
			// 
			this.bSearchByAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bSearchByAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.bSearchByAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bSearchByAuthor.Location = new System.Drawing.Point(173, 44);
			this.bSearchByAuthor.Name = "bSearchByAuthor";
			this.bSearchByAuthor.Size = new System.Drawing.Size(75, 23);
			this.bSearchByAuthor.TabIndex = 19;
			this.bSearchByAuthor.Text = "Показать";
			this.bSearchByAuthor.UseVisualStyleBackColor = false;
			this.bSearchByAuthor.Click += new System.EventHandler(this.bSearchByAuthor_Click);
			// 
			// tbAuthorSearch
			// 
			this.tbAuthorSearch.Location = new System.Drawing.Point(49, 19);
			this.tbAuthorSearch.Name = "tbAuthorSearch";
			this.tbAuthorSearch.Size = new System.Drawing.Size(199, 20);
			this.tbAuthorSearch.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Автор:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.bSearchByTime);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.dtpFrom);
			this.groupBox4.Controls.Add(this.dtpTo);
			this.groupBox4.Location = new System.Drawing.Point(4, 263);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(251, 98);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Поиск по времени";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "По:";
			// 
			// bSearchByTime
			// 
			this.bSearchByTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bSearchByTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.bSearchByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bSearchByTime.Location = new System.Drawing.Point(173, 69);
			this.bSearchByTime.Name = "bSearchByTime";
			this.bSearchByTime.Size = new System.Drawing.Size(75, 23);
			this.bSearchByTime.TabIndex = 18;
			this.bSearchByTime.Text = "Показать";
			this.bSearchByTime.UseVisualStyleBackColor = false;
			this.bSearchByTime.Click += new System.EventHandler(this.bSearchByTime_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "C:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(48, 17);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(200, 20);
			this.dtpFrom.TabIndex = 10;
			// 
			// dtpTo
			// 
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(48, 44);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(200, 20);
			this.dtpTo.TabIndex = 13;
			// 
			// mtName
			// 
			this.mtName.Location = new System.Drawing.Point(90, 19);
			this.mtName.Name = "mtName";
			this.mtName.Size = new System.Drawing.Size(146, 20);
			this.mtName.TabIndex = 11;
			// 
			// mtEditor
			// 
			this.mtEditor.Location = new System.Drawing.Point(90, 71);
			this.mtEditor.Name = "mtEditor";
			this.mtEditor.Size = new System.Drawing.Size(146, 20);
			this.mtEditor.TabIndex = 15;
			// 
			// mtAuthor
			// 
			this.mtAuthor.Location = new System.Drawing.Point(90, 45);
			this.mtAuthor.Name = "mtAuthor";
			this.mtAuthor.Size = new System.Drawing.Size(146, 20);
			this.mtAuthor.TabIndex = 16;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 604);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numDelByPos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gbData.ResumeLayout(false);
			this.gbData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button bLoad;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bOverwrite;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bDelByName;
		private System.Windows.Forms.TextBox tbDelByName;
		private System.Windows.Forms.Button bDelByPos;
		private System.Windows.Forms.NumericUpDown numDelByPos;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox gbData;
		public System.Windows.Forms.DateTimePicker dtpEditor;
		public System.Windows.Forms.NumericUpDown numPos;
		public System.Windows.Forms.RadioButton rbToPos;
		public System.Windows.Forms.RadioButton rbToEnd;
		public System.Windows.Forms.RadioButton rbToBegin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button bSearchByTime;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button bSearchByName;
		private System.Windows.Forms.TextBox tbBookSearch;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button bSearchByEditor;
		private System.Windows.Forms.TextBox tbEditorSearch;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button bSearchByAuthor;
		private System.Windows.Forms.TextBox tbAuthorSearch;
		private System.Windows.Forms.Button bDelSelected;
		private System.Windows.Forms.TextBox mtEditor;
		private System.Windows.Forms.TextBox mtAuthor;
		private System.Windows.Forms.TextBox mtName;
	}
}

