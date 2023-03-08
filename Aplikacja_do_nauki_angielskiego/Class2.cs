using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aplikacja_do_nauki_angielskiego
{
    public static class load
    {
        public static void loaddata()
        {
            string file = "wordspl.txt";
            if(File.Exists(file)) 
            {
                string[] lines = File.ReadAllLines(file);
                MyData.wordspl = new List<string>(lines);
            }
        }
        public static void loadpl() 
        {
            string file1 = "wordsen.txt";
            if(File.Exists(file1)) 
            {
                string[] lines1 = File.ReadAllLines(file1);
                MyData.wordsen = new List<string>(lines1);
            }
        }

    }
}
