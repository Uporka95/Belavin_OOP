namespace Lab_7
{
    partial class Diag2D
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.numCol = new System.Windows.Forms.NumericUpDown();
            this.numStr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bStrEnter = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.bRandom = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numCol);
            this.panel2.Controls.Add(this.numStr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 60);
            this.panel2.TabIndex = 13;
            // 
            // numCol
            // 
            this.numCol.Location = new System.Drawing.Point(58, 31);
            this.numCol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCol.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCol.Name = "numCol";
            this.numCol.Size = new System.Drawing.Size(90, 20);
            this.numCol.TabIndex = 5;
            this.numCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numStr
            // 
            this.numStr.Location = new System.Drawing.Point(58, 6);
            this.numStr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numStr.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numStr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStr.Name = "numStr";
            this.numStr.Size = new System.Drawing.Size(90, 20);
            this.numStr.TabIndex = 4;
            this.numStr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Столбцы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Строки";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bStrEnter);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(177, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 133);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Строка n:";
            // 
            // bStrEnter
            // 
            this.bStrEnter.Location = new System.Drawing.Point(281, 112);
            this.bStrEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bStrEnter.Name = "bStrEnter";
            this.bStrEnter.Size = new System.Drawing.Size(70, 19);
            this.bStrEnter.TabIndex = 3;
            this.bStrEnter.Text = "Ввод";
            this.bStrEnter.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(60, 5);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(291, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // bRandom
            // 
            this.bRandom.Location = new System.Drawing.Point(536, 10);
            this.bRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRandom.Name = "bRandom";
            this.bRandom.Size = new System.Drawing.Size(94, 60);
            this.bRandom.TabIndex = 11;
            this.bRandom.Text = "Случайные значения";
            this.bRandom.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 191);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 48);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Diag2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 375);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRandom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Diag2D";
            this.Text = "Diag2D";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numCol;
        private System.Windows.Forms.NumericUpDown numStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bStrEnter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button bRandom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}