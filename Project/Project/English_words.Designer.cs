
namespace Project
{
    partial class English_words
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
            this.back_e = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.e_10 = new System.Windows.Forms.Button();
            this.e_25 = new System.Windows.Forms.Button();
            this.e_50 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_e
            // 
            this.back_e.Location = new System.Drawing.Point(35, 442);
            this.back_e.Name = "back_e";
            this.back_e.Size = new System.Drawing.Size(117, 54);
            this.back_e.TabIndex = 0;
            this.back_e.Text = "BACK";
            this.back_e.UseVisualStyleBackColor = true;
            this.back_e.Click += new System.EventHandler(this.back_e_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Test";
            // 
            // e_10
            // 
            this.e_10.Location = new System.Drawing.Point(109, 193);
            this.e_10.Name = "e_10";
            this.e_10.Size = new System.Drawing.Size(145, 137);
            this.e_10.TabIndex = 2;
            this.e_10.Text = "10";
            this.e_10.UseVisualStyleBackColor = true;
            this.e_10.Click += new System.EventHandler(this.e_10_Click);
            // 
            // e_25
            // 
            this.e_25.Location = new System.Drawing.Point(396, 192);
            this.e_25.Name = "e_25";
            this.e_25.Size = new System.Drawing.Size(145, 137);
            this.e_25.TabIndex = 3;
            this.e_25.Text = "25";
            this.e_25.UseVisualStyleBackColor = true;
            this.e_25.Click += new System.EventHandler(this.e_25_Click);
            // 
            // e_50
            // 
            this.e_50.Location = new System.Drawing.Point(676, 192);
            this.e_50.Name = "e_50";
            this.e_50.Size = new System.Drawing.Size(145, 137);
            this.e_50.TabIndex = 4;
            this.e_50.Text = "50";
            this.e_50.UseVisualStyleBackColor = true;
            this.e_50.Click += new System.EventHandler(this.e_50_Click);
            // 
            // English_words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 520);
            this.Controls.Add(this.e_50);
            this.Controls.Add(this.e_25);
            this.Controls.Add(this.e_10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_e);
            this.Name = "English_words";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button e_10;
        private System.Windows.Forms.Button e_25;
        private System.Windows.Forms.Button e_50;
    }
}