using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button1.Width = 100; 

            //button1.Width = (button1.Width == 100) ? 200 : 100; //if ernario

            MessageBox.Show("eres gay?");

            //button1.Left = 200;

            button2.Left = Random.Next(0, this.Width-button2.Width);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("queres salir pa?", "salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                e.Cancel = false;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
