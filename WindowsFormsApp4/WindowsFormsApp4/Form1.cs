using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// prueba

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // 1) al hacer doble click en el primer listbox eliminar el item si es que su poscion es impar
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex % 2 == 0) 
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        // 2) al hacer click en el button1 mover al listbox2 los numeros mayores de 10
        private void button1_Click(object sender, EventArgs e)
        {
            //ListBox listBox = new ListBox();

            //foreach (ListViewItem item in listBox.Items)
            //{
            //    if (item.SubItems.Count > 10)
            //    {
            //        listBox2.Items.Add(item.SubItems[10]);
            //        listBox1.Items.Remove(item.SubItems[10]);

            //    }
            //}

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int ea = listBox1.Items.Count;

                if (ea > 10)
                {
                    listBox2.Items.Add(i);
                    listBox1.Items.RemoveAt(i);
                }
            }
        }

        // 3) al hacer click en el button2 hacer desaparacer todos los items del listbox2 y a los 3s insertarlos en el listbox1
        private void button2_Click(object sender, EventArgs e)
        {
            //listBox2.Items.Remove(listBox2.Items);

            listBox2.Items.Clear();
            listBox2.Items.Add(listBox2.Items);


            Timer timer = new Timer();

            timer.Start();

            if (timer.Interval == 3000)
            {
                timer.Stop();
                listBox1.Items.Add(listBox2.Items);
            }
        }
    }
}
