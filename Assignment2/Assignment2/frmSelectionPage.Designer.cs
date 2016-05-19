namespace Assignment2
{
    partial class frmSelectionPage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbtOrder = new System.Windows.Forms.RadioButton();
            this.rbtReport = new System.Windows.Forms.RadioButton();
            this.rbtCapture = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Help.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(165, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(16, 156);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Help
            // 
            this.Help.Controls.Add(this.tabPage1);
            this.Help.Controls.Add(this.tabPage2);
            this.Help.Location = new System.Drawing.Point(0, 0);
            this.Help.Name = "Help";
            this.Help.SelectedIndex = 0;
            this.Help.Size = new System.Drawing.Size(272, 249);
            this.Help.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(264, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbtOrder
            // 
            this.rbtOrder.AutoSize = true;
            this.rbtOrder.Location = new System.Drawing.Point(16, 93);
            this.rbtOrder.Name = "rbtOrder";
            this.rbtOrder.Size = new System.Drawing.Size(94, 17);
            this.rbtOrder.TabIndex = 3;
            this.rbtOrder.Text = "Make an order";
            this.rbtOrder.UseVisualStyleBackColor = true;
            this.rbtOrder.CheckedChanged += new System.EventHandler(this.rbtOrder_CheckedChanged);
            // 
            // rbtReport
            // 
            this.rbtReport.AutoSize = true;
            this.rbtReport.Location = new System.Drawing.Point(19, 116);
            this.rbtReport.Name = "rbtReport";
            this.rbtReport.Size = new System.Drawing.Size(89, 17);
            this.rbtReport.TabIndex = 4;
            this.rbtReport.Text = "Display report";
            this.rbtReport.UseVisualStyleBackColor = true;
            // 
            // rbtCapture
            // 
            this.rbtCapture.AutoSize = true;
            this.rbtCapture.Checked = true;
            this.rbtCapture.Location = new System.Drawing.Point(17, 70);
            this.rbtCapture.Name = "rbtCapture";
            this.rbtCapture.Size = new System.Drawing.Size(91, 17);
            this.rbtCapture.TabIndex = 2;
            this.rbtCapture.TabStop = true;
            this.rbtCapture.Text = "Capture stock";
            this.rbtCapture.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.rbtCapture);
            this.tabPage1.Controls.Add(this.rbtReport);
            this.tabPage1.Controls.Add(this.rbtOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(264, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Menu";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to Nikheels stationery Warehouse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please select an option below";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(157, 117);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Please press and hold the ctrl button when selecting multiple items";
            // 
            // frmSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Help);
            this.Name = "frmSelectionPage";
            this.Text = "Nikheel\'s Stationery Warehouse";
            this.Help.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl Help;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtCapture;
        private System.Windows.Forms.RadioButton rbtReport;
        private System.Windows.Forms.RadioButton rbtOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

