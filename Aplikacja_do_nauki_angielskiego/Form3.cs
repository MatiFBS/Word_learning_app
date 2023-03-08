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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
           
            InitializeComponent();
            //dodawanie listy MyData.words do texboxa - slowka angielskie
            foreach (string elem in MyData.wordspl)
            {
                textBox1.AppendText(elem + Environment.NewLine);
            }
            //dodawanie listy MyData.wordspl do texboxa - slowka polskie
            foreach(string elem1 in MyData.wordsen)
            {
                textBox2.AppendText(elem1 + Environment.NewLine);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {       
            //ładuje dane z pliku wordspl.txt
            load.loaddata();
            textBox1.Text = string.Join(Environment.NewLine, MyData.wordspl);

            //ładuje dane z pliku wordsen.txt
            load.loadpl();
            textBox2.Text = string.Join(Environment.NewLine, MyData.wordsen);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

