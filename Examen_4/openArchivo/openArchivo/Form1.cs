using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace openArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


public void ReadFile(string path)
{
    string text = System.IO.File.ReadAllText(path);
    // Display the file contents to the console. Variable text is a string.
    System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
    // Example #2
    // Read each line of the file into a string array. Each element
    // of the array is one line of the file.
    string[] lines = System.IO.File.ReadAllLines(path);
    // Display the file contents by using a foreach loop.
    System.Console.WriteLine("Contents of WriteLines2.txt = ");
    foreach (string line in lines)
    {
        // Use a tab to indent each line of the file.
        Console.WriteLine("\t" + line);
    }
    // Keep the console window open in debug mode.
    Console.WriteLine("Press any key to exit.");
    System.Console.ReadLine();
}

    private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();            Stream myStream = null;            string document_path = "";            openFileDialog1.InitialDirectory = "";            openFileDialog1.Title = "Choose a file...";            openFileDialog1.Filter = "txt file|*.txt";            openFileDialog1.FilterIndex = 2;            openFileDialog1.RestoreDirectory = true;            if (openFileDialog1.ShowDialog() == DialogResult.OK)            {                document_path = openFileDialog1.FileName;                if ((myStream = openFileDialog1.OpenFile()) != null)                {                    using (myStream)                    {                        ReadFile(document_path);                    }                }            }
        }



    }
}


