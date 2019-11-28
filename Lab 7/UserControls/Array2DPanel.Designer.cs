namespace Lab_7
{
    partial class Array2DPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bClear = new System.Windows.Forms.Button();
			this.bLoadFrom = new System.Windows.Forms.Button();
			this.bSaveIn = new System.Windows.Forms.Button();
			this.bDelMean = new System.Windows.Forms.Button();
			this.bCreate1d = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.bClear);
			this.groupBox1.Controls.Add(this.bLoadFrom);
			this.groupBox1.Controls.Add(this.bSaveIn);
			this.groupBox1.Controls.Add(this.bDelMean);
			this.groupBox1.Controls.Add(this.bCreate1d);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupBox1.Size = new System.Drawing.Size(174, 165);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Действия над массивом";
			// 
			// bClear
			// 
			this.bClear.AutoSize = true;
			this.bClear.Dock = System.Windows.Forms.DockStyle.Top;
			this.bClear.Location = new System.Drawing.Point(5, 131);
			this.bClear.Name = "bClear";
			this.bClear.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.bClear.Size = new System.Drawing.Size(164, 28);
			this.bClear.TabIndex = 6;
			this.bClear.Text = "Очистить";
			this.bClear.UseVisualStyleBackColor = true;
			this.bClear.Click += new System.EventHandler(this.bClear_Click);
			// 
			// bLoadFrom
			// 
			this.bLoadFrom.AllowDrop = true;
			this.bLoadFrom.AutoSize = true;
			this.bLoadFrom.Dock = System.Windows.Forms.DockStyle.Top;
			this.bLoadFrom.Location = new System.Drawing.Point(5, 103);
			this.bLoadFrom.Name = "bLoadFrom";
			this.bLoadFrom.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.bLoadFrom.Size = new System.Drawing.Size(164, 28);
			this.bLoadFrom.TabIndex = 5;
			this.bLoadFrom.Text = "Загрузить из файла";
			this.bLoadFrom.UseVisualStyleBackColor = true;
			this.bLoadFrom.Click += new System.EventHandler(this.bLoadFrom_Click);
			// 
			// bSaveIn
			// 
			this.bSaveIn.AllowDrop = true;
			this.bSaveIn.AutoSize = true;
			this.bSaveIn.Dock = System.Windows.Forms.DockStyle.Top;
			this.bSaveIn.Location = new System.Drawing.Point(5, 75);
			this.bSaveIn.Name = "bSaveIn";
			this.bSaveIn.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.bSaveIn.Size = new System.Drawing.Size(164, 28);
			this.bSaveIn.TabIndex = 4;
			this.bSaveIn.Text = "Сохранить в файл";
			this.bSaveIn.UseVisualStyleBackColor = true;
			this.bSaveIn.Click += new System.EventHandler(this.bSaveIn_Click);
			// 
			// bDelMean
			// 
			this.bDelMean.AllowDrop = true;
			this.bDelMean.AutoSize = true;
			this.bDelMean.Dock = System.Windows.Forms.DockStyle.Top;
			this.bDelMean.Location = new System.Drawing.Point(5, 47);
			this.bDelMean.Name = "bDelMean";
			this.bDelMean.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.bDelMean.Size = new System.Drawing.Size(164, 28);
			this.bDelMean.TabIndex = 1;
			this.bDelMean.Text = "Добавить столбец";
			this.bDelMean.UseVisualStyleBackColor = true;
			this.bDelMean.Click += new System.EventHandler(this.bDelMean_Click);
			// 
			// bCreate1d
			// 
			this.bCreate1d.AutoSize = true;
			this.bCreate1d.Dock = System.Windows.Forms.DockStyle.Top;
			this.bCreate1d.Location = new System.Drawing.Point(5, 19);
			this.bCreate1d.Name = "bCreate1d";
			this.bCreate1d.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.bCreate1d.Size = new System.Drawing.Size(164, 28);
			this.bCreate1d.TabIndex = 0;
			this.bCreate1d.Text = "Создать";
			this.bCreate1d.UseVisualStyleBackColor = true;
			this.bCreate1d.Click += new System.EventHandler(this.bCreate1d_Click);
			// 
			// Array2DPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Array2DPanel";
			this.Size = new System.Drawing.Size(174, 165);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDelMean;
        private System.Windows.Forms.Button bCreate1d;
        private System.Windows.Forms.Button bLoadFrom;
        private System.Windows.Forms.Button bSaveIn;
        private System.Windows.Forms.Button bClear;
    }
}
