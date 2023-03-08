using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.IO;

namespace Aplikacja_do_nauki_angielskiego
{
    public partial class Form2 : Form
    {

        
       
        
    

        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] lines = textBox1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                MyData.wordspl.Add(line);
            }

            textBox1.Text = "";

            string[] xyz = textBox2.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in xyz)
            {
                MyData.wordsen.Add(line);
            }

            textBox2.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
