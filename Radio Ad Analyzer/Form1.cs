using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Ad_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public Color debugMode { get; set; }
       
        private void button8_Click(object sender, EventArgs e)
        {
        Button b = ((Button)sender);
        b.Font = new Font(b.Font, FontStyle.Bold);
    }
        private void label44_Click(object sender, EventArgs e)
        {
         
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
       
    }
}
