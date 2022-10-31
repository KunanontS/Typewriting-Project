
namespace Project
{
    partial class WPM_T
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
            this.button1 = new System.Windows.Forms.Button();
            this.save_result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.show_wpm = new System.Windows.Forms.Label();
            this.show_acc = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 93);
            this.button1.TabIndex = 8;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_result
            // 
            this.save_result.BackColor = System.Drawing.Color.White;
            this.save_result.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_result.ForeColor = System.Drawing.Color.Navy;
            this.save_result.Location = new System.Drawing.Point(757, 415);
            this.save_result.Name = "save_result";
            this.save_result.Size = new System.Drawing.Size(168, 93);
            this.save_result.TabIndex = 9;
            this.save_result.Text = "SAVE RESULT";
            this.save_result.UseVisualStyleBackColor = false;
            this.save_result.Click += new System.EventHandler(this.save_result_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 99);
            this.label1.TabIndex = 10;
            this.label1.Text = "WPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 99);
            this.label2.TabIndex = 11;
            this.label2.Text = "ACC";
            // 
            // show_wpm
            // 
            this.show_wpm.AutoSize = true;
            this.show_wpm.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_wpm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(93)))));
            this.show_wpm.Location = new System.Drawing.Point(551, 127);
            this.show_wpm.Name = "show_wpm";
            this.show_wpm.Size = new System.Drawing.Size(100, 99);
            this.show_wpm.TabIndex = 12;
            this.show_wpm.Text = "0";
            // 
            // show_acc
            // 
            this.show_acc.AutoSize = true;
            this.show_acc.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(93)))));
            this.show_acc.Location = new System.Drawing.Point(551, 264);
            this.show_acc.Name = "show_acc";
            this.show_acc.Size = new System.Drawing.Size(100, 99);
            this.show_acc.TabIndex = 13;
            this.show_acc.Text = "0";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-37, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 25);
            this.panel1.TabIndex = 14;
            // 
            // WPM_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(937, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.show_acc);
            this.Controls.Add(this.show_wpm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_result);
            this.Controls.Add(this.button1);
            this.Name = "WPM_T";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPM_T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label show_wpm;
        private System.Windows.Forms.Label show_acc;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
    }
}