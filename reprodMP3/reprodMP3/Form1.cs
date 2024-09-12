using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reprodMP3
{
    public partial class Form1 : Form
    {

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        //public const int MM_MCINOTIFY = 953;

        //string strFilePath = @"C:\Users\A-01\Desktop\Pensamientos.mp3";

        string[] canciones = new string[]
        {
            @"C:\Users\A-01\Downloads\AIRBAG - Intoxicarme.mp3",
            @"C:\Users\A-01\Downloads\AIRBAG - Apocalipsis Confort.mp3",
            @"C:\Users\A-01\Downloads\AIRBAG - Como un Diamante.mp3",
            @"C:\Users\A-01\Downloads\AIRBAG - Über Puber.mp3"
        };

        string[] nombres = new string[]
        {
            "Intoxicarme",
            "Apocalipsis Confort",
            "Como un Diamante",
            "Über Puber"
        };

        int indCancionActual = 0;

        int duracionCancion = 0;

        public Form1()
        {
            InitializeComponent();

            listBox1.Items.AddRange(nombres);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //mciSendString("seek MediaFile to start", null, 0, IntPtr.Zero);
            // comienzo de 0

            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);

            indCancionActual--;

            if (indCancionActual < 0)
            {
                indCancionActual = canciones.Length - 1;
            }

            string rutaC = canciones[indCancionActual];

            mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);

            const int MAX_PATH = 255;

            string sAlias = "MediaFile";

            StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
            mciSendString("set " + sAlias + " time format milliseconds", null, 0, IntPtr.Zero);
            // Obtenemos el largo del archivo, en millisegundos.

            mciSendString("status " + sAlias + " length", sbBuffer, MAX_PATH, IntPtr.Zero);

            duracionCancion = int.Parse(sbBuffer.ToString());

            trackBar1.Maximum = duracionCancion;

            textBox1.Text = nombres[indCancionActual];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "| |")
            {
                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                button2.Text = "▶️";
                
            }
            else
            {
                string rutaC = canciones[indCancionActual];

                mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);

                const int MAX_PATH = 255;

                string sAlias = "MediaFile";

                StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
                mciSendString("set " + sAlias + " time format milliseconds", null, 0, IntPtr.Zero);
                // Obtenemos el largo del archivo, en millisegundos.

                mciSendString("status " + sAlias + " length", sbBuffer, MAX_PATH, IntPtr.Zero);

                duracionCancion = int.Parse(sbBuffer.ToString());

                trackBar1.Maximum = duracionCancion;

                textBox1.Text = nombres[indCancionActual];

                button2.Text = "| |";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);

            indCancionActual++;

            if (indCancionActual >= canciones.Length)
            {
                indCancionActual = 0;
            }

            string rutaC = canciones[indCancionActual];

            mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);

            const int MAX_PATH = 255;

            string sAlias = "MediaFile";

            StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
            mciSendString("set " + sAlias + " time format milliseconds", null, 0, IntPtr.Zero);
            // Obtenemos el largo del archivo, en millisegundos.

            mciSendString("status " + sAlias + " length", sbBuffer, MAX_PATH, IntPtr.Zero);

            duracionCancion = int.Parse(sbBuffer.ToString());

            trackBar1.Maximum = duracionCancion;

            textBox1.Text = nombres[indCancionActual];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);

                indCancionActual = listBox1.SelectedIndex;

                string rutaC = canciones[indCancionActual];

                mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);

                const int MAX_PATH = 255;

                string sAlias = "MediaFile";

                StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
                mciSendString("set " + sAlias + " time format milliseconds", null, 0, IntPtr.Zero);
                // Obtenemos el largo del archivo, en millisegundos.

                mciSendString("status " + sAlias + " length", sbBuffer, MAX_PATH, IntPtr.Zero);

                duracionCancion = int.Parse(sbBuffer.ToString());

                trackBar1.Maximum = duracionCancion;

                textBox1.Text = nombres[indCancionActual];

                button2.Text = "| |";

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //int posSeleccionada = trackBar1.Value;

            mciSendString($"seek MediaFile to {trackBar1.Value}", null, 0, IntPtr.Zero);

            button2.Text = "| |";

            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = " ";
            openFileDialog1.FileName = "cancion.mp3";
            openFileDialog1.Filter = "MP3 |*.mp3";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName));
            }
        }
    }
}
