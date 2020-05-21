using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string info = txtAddInfo.Text;
            System.IO.File.WriteAllText("../../TextFile.txt", info);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("../../TextFile.txt", true))
            {
                file.WriteLine(info);
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            //Writing to text file.

            string text = System.IO.File.ReadAllText("../../TextFile.txt");
            lblData.Text = text;
            string[] lines = System.IO.File.ReadAllLines("../../TextFile.txt");

            for(int i = 0; i < lines.Length; i++)
            {
                lblData.Text += "\n" + lines[i];
            }
        }
    }
}
