
namespace Quiz_Juan_Sebastian_Perez
{
    partial class Report
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
            this.Lblreport = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Lblreport
            // 
            this.Lblreport.AutoSize = true;
            this.Lblreport.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblreport.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lblreport.Location = new System.Drawing.Point(370, 26);
            this.Lblreport.Name = "Lblreport";
            this.Lblreport.Size = new System.Drawing.Size(75, 26);
            this.Lblreport.TabIndex = 0;
            this.Lblreport.Text = "REPORT";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(263, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 329);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Lblreport);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Report";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblreport;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}