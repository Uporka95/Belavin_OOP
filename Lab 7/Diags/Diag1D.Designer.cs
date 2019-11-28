namespace Lab_7
{
    partial class MasEntryDiag
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
			this.mtStrEntry = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.bStrEnter = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mtStrEntry
			// 
			this.mtStrEntry.Location = new System.Drawing.Point(60, 5);
			this.mtStrEntry.Margin = new System.Windows.Forms.Padding(2);
			this.mtStrEntry.Name = "mtStrEntry";
			this.mtStrEntry.Size = new System.Drawing.Size(291, 20);
			this.mtStrEntry.TabIndex = 1;
			this.mtStrEntry.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			this.mtStrEntry.TextChanged += new System.EventHandler(this.mtStrEntry_TextChanged);
			this.mtStrEntry.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.mtStrEntry_PreviewKeyDown);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(374, 11);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 60);
			this.button1.TabIndex = 2;
			this.button1.Text = "Случайные значения";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bStrEnter
			// 
			this.bStrEnter.Location = new System.Drawing.Point(281, 29);
			this.bStrEnter.Margin = new System.Windows.Forms.Padding(2);
			this.bStrEnter.Name = "bStrEnter";
			this.bStrEnter.Size = new System.Drawing.Size(70, 19);
			this.bStrEnter.TabIndex = 3;
			this.bStrEnter.Text = "Ввод";
			this.bStrEnter.UseVisualStyleBackColor = true;
			this.bStrEnter.Click += new System.EventHandler(this.bStrEnter_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 7);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Строка:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.bStrEnter);
			this.panel1.Controls.Add(this.mtStrEntry);
			this.panel1.Location = new System.Drawing.Point(11, 11);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(359, 60);
			this.panel1.TabIndex = 9;
			// 
			// MasEntryDiag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 82);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MasEntryDiag";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ввод массива";
			this.Load += new System.EventHandler(this.MasEntryDiag_Load);
			this.Shown += new System.EventHandler(this.MasEntryDiag_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtStrEntry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bStrEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}