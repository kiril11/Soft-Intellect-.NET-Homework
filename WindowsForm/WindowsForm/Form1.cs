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

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter add = new StreamWriter("information.txt",true))
            {
                add.WriteLine("First name is: " + textBox1.Text );
                add.WriteLine("Second name is: " + textBox2.Text );
                add.WriteLine("E-mail is: " + textBox3.Text);
                add.WriteLine();
            }
        }
    }
}
