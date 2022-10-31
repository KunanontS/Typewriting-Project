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
    public partial class E_10 : Form
    {
        public E_10()
        {
            InitializeComponent();
        }
        int words_count = 1;
        double time_count = 0;
        int all_letters;
        int correct = 0;
        int wrong = 0;
        double wpm;
        List<String> words_list = new List<String>(){ "real", "both", "another", "boy", "girl", "hello", "other", "possible", "number", "during" ,
                                                      "well", "hold", "to", "no", "lead", "just", "problem", "off", "place", "with" ,
                                                      "between", "you", "around", "since", "develop", "govern", "consider", "thing", "each", "follow",
                                                      "most", "begin", "seem", "old", "down", "time", "state", "mean", "look", "school",
                                                      "through", "present", "which", "without", "also", "become", "valorant", "dota", "darksoul", "counter",
                                                      "show", "year", "few", "very", "we", "one", "she", "fact", "people", "strike"};
        List<String> charac = new List<String>() {"a","b","c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        private void back_e10_Click(object sender, EventArgs e)
        {
            this.Hide();
            English_words back = new English_words();
            back.ShowDialog();
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            var count = new List<int>();
            for (int i = 0; i < 10; i++) 
            {
                int word = rd.Next(60);           
                if (string.IsNullOrEmpty(Box1.Text))
                {
                    Box1.Text += words_list[word];
                    all_letters += Box1.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box2.Text))
                {
                    Box2.Text += words_list[word];
                    all_letters += Box2.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box3.Text))
                {
                    Box3.Text += words_list[word];
                    all_letters += Box3.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box4.Text))
                {
                    Box4.Text += words_list[word];
                    all_letters += Box4.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box5.Text))
                {
                    Box5.Text += words_list[word];
                    all_letters += Box5.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box6.Text))
                {
                    Box6.Text += words_list[word];
                    all_letters += Box6.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box7.Text))
                {
                    Box7.Text += words_list[word];
                    all_letters += Box7.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box8.Text))
                {
                    Box8.Text += words_list[word];
                    all_letters += Box8.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box9.Text))
                {
                    Box9.Text += words_list[word];
                    all_letters += Box9.Text.Count();
                }
                else if (string.IsNullOrEmpty(Box10.Text))
                {
                    Box10.Text += words_list[word];
                    all_letters += Box10.Text.Count();
                }
            }
        }
        private void restart_Click(object sender, EventArgs e)
        {
            Box1.Clear(); Box2.Clear(); Box3.Clear(); Box4.Clear(); Box5.Clear(); Box6.Clear(); Box7.Clear(); Box8.Clear(); Box9.Clear(); Box10.Clear(); ans.Clear();
            Box1.ForeColor = Color.Black; Box2.ForeColor = Color.Black; Box3.ForeColor = Color.Black; Box4.ForeColor = Color.Black; Box5.ForeColor = Color.Black; Box6.ForeColor = Color.Black;
            Box7.ForeColor = Color.Black; Box8.ForeColor = Color.Black; Box9.ForeColor = Color.Black; Box10.ForeColor = Color.Black;
            words_count = 1; 
            time_count = 0;
            time.Text = time_count.ToString();
            textBox1.Clear();
            timer1.Stop();

        }

        private void ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                if (ans.Text.StartsWith(" ")) 
                {
                    ans.Text = ans.Text.Substring(1);
                }
                if (words_count == 10)
                {
                    //this.Hide();
                    //WPM gowpm = new WPM();
                    //gowpm.ShowDialog();
                    //this.Close();
                    timer1.Stop();
                    wpm = (all_letters / 5) / (time_count/ 600);
                    textBox1.Text += wpm.ToString();
                    
                }
                if (ans.Text == Box1.Text && words_count == 1)
                {
                    Box1.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box1.Text && words_count == 1)
                {
                    Box1.ForeColor = Color.Red;
                    wrong += 1; 
                }
                else if (ans.Text == Box2.Text && words_count == 2)
                {
                    Box2.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box2.Text && words_count == 2)
                {
                    Box2.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box3.Text && words_count == 3)
                {
                    Box3.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box3.Text && words_count == 3)
                {
                    Box3.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box4.Text && words_count == 4)
                {
                    Box4.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box4.Text && words_count == 4)
                {
                    Box4.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box5.Text && words_count == 5)
                {
                    Box5.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box5.Text && words_count == 5)
                {
                    Box5.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box6.Text && words_count == 6)
                {
                    Box6.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box6.Text && words_count == 6)
                {
                    Box6.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box7.Text && words_count == 7)
                {
                    Box7.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box7.Text && words_count == 7)
                {
                    Box7.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box8.Text && words_count == 8)
                {
                    Box8.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box8.Text && words_count == 8)
                {
                    Box8.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box9.Text && words_count == 9)
                {
                    Box9.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box9.Text && words_count == 9)
                {
                    Box9.ForeColor = Color.Red;
                    wrong += 1;
                }
                else if (ans.Text == Box10.Text && words_count == 10)
                {
                    Box10.ForeColor = Color.Green;
                    correct += 1;
                }
                else if (ans.Text != Box10.Text && words_count == 10)
                {
                    Box10.ForeColor = Color.Red;
                    wrong += 1;
                }                
                textBox1.Text += words_count.ToString();
                textBox1.Text += "\r\n";
                textBox1.Text += ans.Text;
                textBox1.Text += "\r\n";
                ans.Clear();
                words_count += 1;
            }           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_count++;
            time.Text = time_count.ToString();
        }

        private void E_10_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void ans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (   e.KeyChar.ToString() == "a" || e.KeyChar.ToString() == "b" || e.KeyChar.ToString() == "c" || e.KeyChar.ToString() == "d"
                || e.KeyChar.ToString() == "e" || e.KeyChar.ToString() == "f" || e.KeyChar.ToString() == "g" || e.KeyChar.ToString() == "h"
                || e.KeyChar.ToString() == "i" || e.KeyChar.ToString() == "j" || e.KeyChar.ToString() == "k" || e.KeyChar.ToString() == "l"
                || e.KeyChar.ToString() == "m" || e.KeyChar.ToString() == "n" || e.KeyChar.ToString() == "o" || e.KeyChar.ToString() == "p"
                || e.KeyChar.ToString() == "q" || e.KeyChar.ToString() == "r" || e.KeyChar.ToString() == "s" || e.KeyChar.ToString() == "t"
                || e.KeyChar.ToString() == "u" || e.KeyChar.ToString() == "v" || e.KeyChar.ToString() == "w" || e.KeyChar.ToString() == "x"
                || e.KeyChar.ToString() == "y" || e.KeyChar.ToString() == "z" ) 
            {
                timer1.Start();
            }
          
        }
    }
}
