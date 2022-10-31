
namespace Project
{
    partial class T_10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_10));
            this.b_t10 = new System.Windows.Forms.Button();
            this.display1 = new System.Windows.Forms.RichTextBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.restart_b = new System.Windows.Forms.Button();
            this.num_of_words = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.show_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.retab = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_t10
            // 
            this.b_t10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.b_t10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_t10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.b_t10.Location = new System.Drawing.Point(32, 434);
            this.b_t10.Name = "b_t10";
            this.b_t10.Size = new System.Drawing.Size(144, 74);
            this.b_t10.TabIndex = 0;
            this.b_t10.Text = "BACK";
            this.b_t10.UseVisualStyleBackColor = false;
            this.b_t10.Click += new System.EventHandler(this.b_t10_Click);
            // 
            // display1
            // 
            this.display1.Font = new System.Drawing.Font("Angsana New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display1.Location = new System.Drawing.Point(12, 51);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(913, 211);
            this.display1.TabIndex = 1;
            this.display1.Text = "";
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(366, 269);
            this.ans.Multiline = true;
            this.ans.Name = "ans";
            this.ans.ReadOnly = true;
            this.ans.Size = new System.Drawing.Size(225, 64);
            this.ans.TabIndex = 2;
            this.ans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ans_KeyDown);
            this.ans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ans_KeyPress);
            // 
            // restart_b
            // 
            this.restart_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.restart_b.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.restart_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.restart_b.Location = new System.Drawing.Point(597, 269);
            this.restart_b.Name = "restart_b";
            this.restart_b.Size = new System.Drawing.Size(89, 64);
            this.restart_b.TabIndex = 4;
            this.restart_b.Text = "RESTART";
            this.restart_b.UseVisualStyleBackColor = false;
            this.restart_b.Click += new System.EventHandler(this.restart_b_Click);
            // 
            // num_of_words
            // 
            this.num_of_words.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_of_words.FormattingEnabled = true;
            this.num_of_words.Items.AddRange(new object[] {
            "10 Words",
            "25 Words",
            "50 Words"});
            this.num_of_words.Location = new System.Drawing.Point(32, 299);
            this.num_of_words.Name = "num_of_words";
            this.num_of_words.Size = new System.Drawing.Size(144, 24);
            this.num_of_words.TabIndex = 5;
            this.num_of_words.Text = "Number of Words";
            this.num_of_words.SelectedIndexChanged += new System.EventHandler(this.num_of_words_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(128, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // show_time
            // 
            this.show_time.AutoSize = true;
            this.show_time.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.show_time.Location = new System.Drawing.Point(70, 19);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(19, 21);
            this.show_time.TabIndex = 7;
            this.show_time.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(176, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(391, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 176);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(391, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 176);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // retab
            // 
            this.retab.AutoSize = true;
            this.retab.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retab.Location = new System.Drawing.Point(205, 488);
            this.retab.Name = "retab";
            this.retab.Size = new System.Drawing.Size(145, 20);
            this.retab.TabIndex = 11;
            this.retab.Text = "Enable \"ESC\" to restart";
            this.retab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "เลือกจำนวนคำที่จะฝึกเพื่อเริ่ม\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "เวลา : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "/";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(17)))), ((int)(((byte)(89)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.button1.Location = new System.Drawing.Point(781, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 74);
            this.button1.TabIndex = 20;
            this.button1.Text = "VIEW RESULT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(937, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.retab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.show_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_of_words);
            this.Controls.Add(this.restart_b);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.b_t10);
            this.Name = "T_10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thai";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_t10;
        private System.Windows.Forms.RichTextBox display1;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Button restart_b;
        private System.Windows.Forms.ComboBox num_of_words;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label show_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox retab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}