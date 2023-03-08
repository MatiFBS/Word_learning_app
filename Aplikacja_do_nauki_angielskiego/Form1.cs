using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_do_nauki_angielskiego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string file = "wordspl.txt";
            string content = string.Join(Environment.NewLine, MyData.wordspl);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write(content); // zapisz całą zawartość, włącznie z separatorami nowej linii
            }

            string file1 = "wordsen.txt";
            string content1 = string.Join(Environment.NewLine, MyData.wordsen);
            using (StreamWriter writer1 = new StreamWriter(file1))
            {
                writer1.Write(content1); // zapisz całą zawartość, włącznie z separatorami nowej linii
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
