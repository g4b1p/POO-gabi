using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reproductorMP3
{
    public partial class Form1 : Form
    {
        //WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        //public const int MM_MCINOTIFY = 953;
        string strFilePath = @"C:\Users\A-01\Desktop\Pensamientos.mp3";

        /*protected override void WndProc(ref Message m)
        {
            if (m.Msg == MM_MCINOTIFY)
            {
                // The file is done playing, do whatever
        }

            base.WndProc(ref m);
        }*/

        string rutaActual;
        
        int duracion;

        Timer timepo = new Timer();

        string[] urls =
        {
            @"C:\Users\A-01\Desktop\Pensamientos.mp3",
            @"C:\Users\A-01\Desktop\Intoxicarme.mp3"
        };

        string[] nombres =
        {
            "Pensamientos",
            "Intoxicarme"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cambiar o saltear musica
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comenzar de nuevo
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*player.URL = @"C:\Users\Alumno\Desktop\Pensamientos.mp3";
           
            if (button2.Text == "| |")
            {
                button2.Text = "▶️";
                //player.controls.stop();
            }
            else
            {
                button2.Text = "| |";
                //player.controls.play();
            }*/

            if (button2.Text == "| |")
            {
                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                //mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                button2.Text = "▶️";
            }
            else
            {
                string sCommand = "open \"" + strFilePath + "\" type mpegvideo alias MediaFile";
                mciSendString(sCommand, null, 0, IntPtr.Zero);

                sCommand = "play MediaFile";
                mciSendString(sCommand, null, 0, Handle);
                button2.Text = "| |";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                rutaActual = urls[listBox1.SelectedIndex];

                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                //mciSendString("close MediaFile", null, 0, IntPtr.Zero);

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            string sCommand = "open \"" + strFilePath + "\" type mpegvideo alias MediaFile";
            mciSendString(sCommand, null, 0, IntPtr.Zero);

            sCommand = "play MediaFile";
            mciSendString(sCommand, null, 0, Handle);
            button2.Text = "| |";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
