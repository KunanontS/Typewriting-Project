
namespace Project
{
    partial class WPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WPM));
            this.label1 = new System.Windows.Forms.Label();
            this.show_wpm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.show_acc = new System.Windows.Forms.Label();
            this.save_result = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "WPM";
            // 
            // show_wpm
            // 
            this.show_wpm.AutoSize = true;
            this.show_wpm.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_wpm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(93)))));
            this.show_wpm.Location = new System.Drawing.Point(551, 127);
            this.show_wpm.Name = "show_wpm";
            this.show_wpm.Size = new System.Drawing.Size(100, 99);
            this.show_wpm.TabIndex = 1;
            this.show_wpm.Text = "0";
            this.show_wpm.Click += new System.EventHandler(this.show_wpm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 99);
            this.label2.TabIndex = 2;
            this.label2.Text = "ACC";
            // 
            // show_acc
            // 
            this.show_acc.AutoSize = true;
            this.show_acc.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(93)))));
            this.show_acc.Location = new System.Drawing.Point(551, 264);
            this.show_acc.Name = "show_acc";
            this.show_acc.Size = new System.Drawing.Size(100, 99);
            this.show_acc.TabIndex = 3;
            this.show_acc.Text = "0";
            // 
            // save_result
            // 
            this.save_result.BackColor = System.Drawing.Color.White;
            this.save_result.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_result.ForeColor = System.Drawing.Color.Navy;
            this.save_result.Location = new System.Drawing.Point(757, 415);
            this.save_result.Name = "save_result";
            this.save_result.Size = new System.Drawing.Size(168, 93);
            this.save_result.TabIndex = 4;
            this.save_result.Text = "SAVE RESULT";
            this.save_result.UseVisualStyleBackColor = false;
            this.save_result.Click += new System.EventHandler(this.save_result_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(208)))), ((int)(((byte)(187)))));
            this.panel2.Location = new System.Drawing.Point(-53, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1434, 25);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 93);
            this.button1.TabIndex = 7;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // WPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(937, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_result);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.show_acc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show_wpm);
            this.Controls.Add(this.label1);
            this.Name = "WPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPM";
            this.Load += new System.EventHandler(this.WPM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label show_wpm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label show_acc;
        private System.Windows.Forms.Button save_result;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}