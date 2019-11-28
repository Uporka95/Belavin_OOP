namespace Lab_7.Diags
{
    partial class DiagJag
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
			this.pSizeEntry = new System.Windows.Forms.Panel();
			this.bBeginEntry = new System.Windows.Forms.Button();
			this.numStr = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.pArrayEntry = new System.Windows.Forms.Panel();
			this.mtStringEntry = new System.Windows.Forms.MaskedTextBox();
			this.lStrNum = new System.Windows.Forms.Label();
			this.bStrEnter = new System.Windows.Forms.Button();
			this.bRandom = new System.Windows.Forms.Button();
			this.pSizeEntry.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStr)).BeginInit();
			this.pArrayEntry.SuspendLayout();
			this.SuspendLayout();
			// 
			// pSizeEntry
			// 
			this.pSizeEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pSizeEntry.Controls.Add(this.bBeginEntry);
			this.pSizeEntry.Controls.Add(this.numStr);
			this.pSizeEntry.Controls.Add(this.label1);
			this.pSizeEntry.Location = new System.Drawing.Point(11, 11);
			this.pSizeEntry.Margin = new System.Windows.Forms.Padding(2);
			this.pSizeEntry.Name = "pSizeEntry";
			this.pSizeEntry.Size = new System.Drawing.Size(164, 88);
			this.pSizeEntry.TabIndex = 16;
			// 
			// bBeginEntry
			// 
			this.bBeginEntry.Location = new System.Drawing.Point(7, 53);
			this.bBeginEntry.Name = "bBeginEntry";
			this.bBeginEntry.Size = new System.Drawing.Size(141, 23);
			this.bBeginEntry.TabIndex = 9;
			this.bBeginEntry.Text = "Начать ввод";
			this.bBeginEntry.UseVisualStyleBackColor = true;
			this.bBeginEntry.Click += new System.EventHandler(this.bBeginEntry_Click);
			// 
			// numStr
			// 
			this.numStr.Location = new System.Drawing.Point(58, 14);
			this.numStr.Margin = new System.Windows.Forms.Padding(2);
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
            10,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Строки";
			// 
			// pArrayEntry
			// 
			this.pArrayEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pArrayEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pArrayEntry.Controls.Add(this.mtStringEntry);
			this.pArrayEntry.Controls.Add(this.lStrNum);
			this.pArrayEntry.Controls.Add(this.bStrEnter);
			this.pArrayEntry.Enabled = false;
			this.pArrayEntry.Location = new System.Drawing.Point(184, 12);
			this.pArrayEntry.Margin = new System.Windows.Forms.Padding(2);
			this.pArrayEntry.Name = "pArrayEntry";
			this.pArrayEntry.Size = new System.Drawing.Size(355, 87);
			this.pArrayEntry.TabIndex = 15;
			// 
			// mtStringEntry
			// 
			this.mtStringEntry.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mtStringEntry.Location = new System.Drawing.Point(76, 10);
			this.mtStringEntry.Margin = new System.Windows.Forms.Padding(2);
			this.mtStringEntry.Name = "mtStringEntry";
			this.mtStringEntry.Size = new System.Drawing.Size(273, 23);
			this.mtStringEntry.TabIndex = 1;
			this.mtStringEntry.TextChanged += new System.EventHandler(this.mtStringEntry_TextChanged);
			// 
			// lStrNum
			// 
			this.lStrNum.AutoSize = true;
			this.lStrNum.Location = new System.Drawing.Point(2, 14);
			this.lStrNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lStrNum.Name = "lStrNum";
			this.lStrNum.Size = new System.Drawing.Size(55, 13);
			this.lStrNum.TabIndex = 8;
			this.lStrNum.Text = "Строка n:";
			// 
			// bStrEnter
			// 
			this.bStrEnter.Location = new System.Drawing.Point(268, 46);
			this.bStrEnter.Margin = new System.Windows.Forms.Padding(2);
			this.bStrEnter.Name = "bStrEnter";
			this.bStrEnter.Size = new System.Drawing.Size(81, 32);
			this.bStrEnter.TabIndex = 3;
			this.bStrEnter.Text = "Ввод";
			this.bStrEnter.UseVisualStyleBackColor = true;
			this.bStrEnter.Click += new System.EventHandler(this.bStrEnter_Click);
			this.bStrEnter.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mtStringEntry_PreviewKeyDown);
			// 
			// bRandom
			// 
			this.bRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bRandom.Location = new System.Drawing.Point(543, 11);
			this.bRandom.Margin = new System.Windows.Forms.Padding(2);
			this.bRandom.Name = "bRandom";
			this.bRandom.Size = new System.Drawing.Size(86, 88);
			this.bRandom.TabIndex = 14;
			this.bRandom.Text = "Случайные значения";
			this.bRandom.UseVisualStyleBackColor = true;
			this.bRandom.Click += new System.EventHandler(this.bRandom_Click);
			// 
			// DiagJag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 102);
			this.Controls.Add(this.pSizeEntry);
			this.Controls.Add(this.pArrayEntry);
			this.Controls.Add(this.bRandom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DiagJag";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ввод массива";
			this.pSizeEntry.ResumeLayout(false);
			this.pSizeEntry.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStr)).EndInit();
			this.pArrayEntry.ResumeLayout(false);
			this.pArrayEntry.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel pSizeEntry;
		private System.Windows.Forms.Button bBeginEntry;
		private System.Windows.Forms.NumericUpDown numStr;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pArrayEntry;
		private System.Windows.Forms.MaskedTextBox mtStringEntry;
		private System.Windows.Forms.Label lStrNum;
		private System.Windows.Forms.Button bStrEnter;
		private System.Windows.Forms.Button bRandom;
	}
}