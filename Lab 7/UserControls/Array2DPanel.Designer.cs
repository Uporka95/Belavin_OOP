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
            this.bDelMean = new System.Windows.Forms.Button();
            this.bCreate1d = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.bClear);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bDelMean);
            this.groupBox1.Controls.Add(this.bCreate1d);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(214, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия над массивом";
            // 
            // bDelMean
            // 
            this.bDelMean.AllowDrop = true;
            this.bDelMean.AutoSize = true;
            this.bDelMean.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDelMean.Location = new System.Drawing.Point(7, 55);
            this.bDelMean.Margin = new System.Windows.Forms.Padding(4);
            this.bDelMean.Name = "bDelMean";
            this.bDelMean.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.bDelMean.Size = new System.Drawing.Size(200, 33);
            this.bDelMean.TabIndex = 1;
            this.bDelMean.Text = "Добавить столбец";
            this.bDelMean.UseVisualStyleBackColor = true;
            // 
            // bCreate1d
            // 
            this.bCreate1d.AutoSize = true;
            this.bCreate1d.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCreate1d.Location = new System.Drawing.Point(7, 22);
            this.bCreate1d.Margin = new System.Windows.Forms.Padding(4);
            this.bCreate1d.Name = "bCreate1d";
            this.bCreate1d.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.bCreate1d.Size = new System.Drawing.Size(200, 33);
            this.bCreate1d.TabIndex = 0;
            this.bCreate1d.Text = "Создать";
            this.bCreate1d.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(7, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.button2.Size = new System.Drawing.Size(200, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Загрузить из файла";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(7, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить в файл";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.AutoSize = true;
            this.bClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.bClear.Location = new System.Drawing.Point(7, 154);
            this.bClear.Margin = new System.Windows.Forms.Padding(4);
            this.bClear.Name = "bClear";
            this.bClear.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.bClear.Size = new System.Drawing.Size(200, 33);
            this.bClear.TabIndex = 6;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            // 
            // Array2DPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Array2DPanel";
            this.Size = new System.Drawing.Size(214, 196);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDelMean;
        private System.Windows.Forms.Button bCreate1d;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bClear;
    }
}
