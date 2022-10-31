using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class T_10 : Form
    {
        int no, count, words_in_list;
        double test = 25;
        public static double all_letters, exact_time, wpm, acc, correct, incorrect;
        bool time_status = true;

        public T_10()
        {
            InitializeComponent();
            words_in_list = words_list.Count();
        }

        public void bongo(int no, Panel x, Panel y)
        {
            if (no % 2 == 0)
            {
                x.Visible = false;
                y.Visible = true;
            }
            else
            {
                x.Visible = true;
                y.Visible = false;
            }
        }

        public void restart()
        {
            ans.ReadOnly = false;
            timer1.Stop(); all_letters = 0; exact_time = 0; wpm = 0; no = 0; incorrect = 0; correct = 0; display1.Clear(); ans.Clear(); time_status = false;
            show_time.Text = (exact_time / 10).ToString(); count = 0;
            q_generator(test, display1, words_list);
            all_letters += display1.Text.Count();
            label2.Text = "0";
        }

        public void word_check(char s, RichTextBox q, int n)
        {
            if (s == '\b' || no == all_letters || s == '\t' || s == '\u001B') return;
            if (q.Text[n] == ' ' && s != ' ') return;
            if (s == q.Text[n])
            {
                q.Select(n, 1);
                q.SelectionColor = Color.Green;
                q.SelectionBackColor = Color.White;
                correct++;
                no += 1;
            }
            else
            {
                q.Select(n, 1);
                q.SelectionColor = Color.Red;
                q.SelectionBackColor = Color.White;
                incorrect++;
                no += 1;
            }
        }

        public void q_generator(double words, RichTextBox que, List<String> wl)
        {
            Random rd = new Random();
            for (int i = 0; i < words; i++)
            {
                int word = rd.Next(words_in_list);
                que.Text += wl[word];
                que.Text += " ";
            }
        }

        List<String> words_list = new List<String>(){"คุณานนต์","ภูมินทร์", "โกสินทร์", "ธัชธรรม", "ภูเนตร", "สิรธีร์", "ธรรถชาติ", "พศวีร์", "จตุโม" , "ชยธร" ,
                                                     "คมคาย","สุดแต่", "ใช้อุบาย", "ผิดใจ", "เยาะเย้ยถากถาง", "สวัสดี", "ชเวริน", "คลาดเวลา", "เล่าขาน" , "น่าสน" ,
                                                     "คะแนนนิยม","ชดเชย", "กวาดตา", "หอมปากหอมคอ", "สวนครัว", "ทบดอก", "พึงระวัง", "ปลาหมึก", "พึงระวัง" , "กระดุม" ,
                                                     "กะเทย","อินเทอร์เน็ต","กะเพรา","กะทันหัน","แกง","ประกอบ","ปลากะพง","ไอศกรีม","ลิดรอน","บุคลากร" ,
                                                     "อนุญาต","ซีเรียล","มุกตลก","สังเกต","แมว","อีเมล","คอมเมนต์","ปรากฏ","กฎหมาย","ออฟฟิศ" ,
                                                     "นะคะ","หลงใหล","ทยอย","ศีรษะ","ออกดอก","โลกา","เสาธง","เฉพาะ","โควตา","กรวย"};

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WPM_T c_e25 = new WPM_T();
            c_e25.ShowDialog();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            exact_time++; ;
            label4.Text = test.ToString();
            show_time.Text = (exact_time / 10).ToString();
            display1.Select(no, 1);                        //ทำ Highlight เวลาพิมพ์
            display1.SelectionBackColor = Color.LightGray; //ทำ Highlight เวลาพิมพ์           
            if (no == all_letters)
            {
                timer1.Stop();
                time_status = false;
                ans.ReadOnly = true;
                if (correct > all_letters)
                {
                    correct = all_letters;
                }
                wpm = Math.Round((((all_letters - test) / 5) - incorrect) / (exact_time / 600), 0);
                if (wpm < 0) { wpm = 0; }
                acc = Math.Round(((correct - test) / (all_letters - test)) * 100, 0);
                this.Hide();
                WPM_T c_e25 = new WPM_T();
                c_e25.ShowDialog();
                this.Close();
            }
            Refresh();
        }
        private void b_t10_Click(object sender, EventArgs e)
        {
            this.Hide();
            main c_t = new main();
            c_t.ShowDialog();
            this.Close();
        }
        private void num_of_words_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (num_of_words.Text == "10 Words")
            {
                test = 10; restart(); label4.Text = test.ToString();
            }
            else if (num_of_words.Text == "25 Words")
            {
                test = 25; restart(); label4.Text = test.ToString();
            }
            else if (num_of_words.Text == "50 Words")
            {
                test = 50; restart(); label4.Text = test.ToString();
            }
        }
        private void restart_b_Click(object sender, EventArgs e)
        {
            if (display1.Text.Count() != 0) restart();
        }
        private void ans_KeyDown(object sender, KeyEventArgs e)
        {
            bongo(no, panel1, panel2);
            if (e.KeyCode == Keys.Escape && retab.CheckState == CheckState.Checked)
            {
                restart();
            }
            if (e.KeyCode == Keys.Space && no != all_letters && num_of_words.Text != "Number of Words")
            {
                ans.Clear();
                if (display1.Text[no] == ' ')
                {
                    count += 1;
                    label2.Text = count.ToString();
                    return;
                }
                else
                {
                    int find_space = 0;
                    for (int i = 0; i < all_letters; i++)
                    {
                        if (display1.Text[no + i] != ' ')
                        {
                            find_space += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    display1.Select(no, find_space);
                    display1.SelectionColor = Color.Red;
                    display1.SelectionBackColor = Color.White;
                    incorrect += find_space;
                    no += find_space;
                    count += 1;
                    label2.Text = count.ToString();
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                if (no != 0)
                {
                    display1.Select(no, 1);
                    if (display1.Text[no - 1] == ' ') return; //กันไม่ให้กลับไปแก้คำที่ผ่านมา
                    display1.Select(no - 1, 1);
                    if (display1.SelectionColor == Color.Green)
                    {
                        display1.SelectionColor = Color.Black;
                        display1.Select(no, 1);
                        display1.SelectionColor = Color.Black;
                        display1.SelectionBackColor = Color.White;
                        correct -= 1; no -= 1;
                    }
                    else if (display1.SelectionColor == Color.Red)
                    {
                        display1.SelectionColor = Color.Black;
                        display1.Select(no, 1);
                        display1.SelectionColor = Color.Black;
                        display1.SelectionBackColor = Color.White;
                        incorrect -= 1; no -= 1;
                    }
                }
            }
        }
        private void ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            bongo(no, panel1, panel2);
            if (no != all_letters && e.KeyChar != '\u001B' && num_of_words.Text != "Number of Words")
            {
                {
                    word_check(e.KeyChar, display1, no);
                    timer1.Start();
                    //display.Text += "No. " + no.ToString() + " " + "Correct : " + correct.ToString() + " Incorrect : " + incorrect.ToString() + " "; //Check
                    //display.Text += "\r\n";
                }
            }
        }
    }
}
