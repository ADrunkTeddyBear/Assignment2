namespace Assignment2
{
    partial class frmTermsAndConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTermsAndConditions));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbxTermsAndConditions = new System.Windows.Forms.CheckBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.cbxExit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(102, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // cbxTermsAndConditions
            // 
            this.cbxTermsAndConditions.AutoSize = true;
            this.cbxTermsAndConditions.Location = new System.Drawing.Point(46, 182);
            this.cbxTermsAndConditions.Name = "cbxTermsAndConditions";
            this.cbxTermsAndConditions.Size = new System.Drawing.Size(248, 17);
            this.cbxTermsAndConditions.TabIndex = 2;
            this.cbxTermsAndConditions.Text = "Check this to agree to the terms and conditions";
            this.cbxTermsAndConditions.UseVisualStyleBackColor = true;
            this.cbxTermsAndConditions.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(46, 280);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // cbxExit
            // 
            this.cbxExit.AutoSize = true;
            this.cbxExit.Location = new System.Drawing.Point(46, 219);
            this.cbxExit.Name = "cbxExit";
            this.cbxExit.Size = new System.Drawing.Size(107, 17);
            this.cbxExit.TabIndex = 4;
            this.cbxExit.Text = "Check this to exit";
            this.cbxExit.UseVisualStyleBackColor = true;
            this.cbxExit.CheckedChanged += new System.EventHandler(this.cbxExit_CheckedChanged);
            // 
            // frmTermsAndConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 337);
            this.Controls.Add(this.cbxExit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cbxTermsAndConditions);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmTermsAndConditions";
            this.Text = "Nikheel\'s Stationery Warehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cbxTermsAndConditions;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.CheckBox cbxExit;
    }
}