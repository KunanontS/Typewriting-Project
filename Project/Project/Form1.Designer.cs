
namespace Project
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.c_e = new System.Windows.Forms.Button();
            this.c_t = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(137)))), ((int)(((byte)(232)))));
            this.label1.Font = new System.Drawing.Font("Harrington", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "PaoType";
            // 
            // c_e
            // 
            this.c_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.c_e.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_e.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c_e.Location = new System.Drawing.Point(12, 155);
            this.c_e.Name = "c_e";
            this.c_e.Size = new System.Drawing.Size(350, 350);
            this.c_e.TabIndex = 1;
            this.c_e.Text = "ENG";
            this.c_e.UseVisualStyleBackColor = false;
            this.c_e.Click += new System.EventHandler(this.c_e_Click);
            // 
            // c_t
            // 
            this.c_t.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(48)))));
            this.c_t.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_t.Location = new System.Drawing.Point(576, 155);
            this.c_t.Name = "c_t";
            this.c_t.Size = new System.Drawing.Size(350, 350);
            this.c_t.TabIndex = 2;
            this.c_t.Text = "TH";
            this.c_t.UseVisualStyleBackColor = false;
            this.c_t.Click += new System.EventHandler(this.c_t_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(137)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-22, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 149);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 25);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select a test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(938, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c_t);
            this.Controls.Add(this.c_e);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaoType";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button c_e;
        private System.Windows.Forms.Button c_t;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

