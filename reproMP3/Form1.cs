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

namespace reproMP3
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        // StringBuilder -> string q puede cambiar


        //public const int MM_MCINOTIFY = 953;

        //string strFilePath = @"C:\Users\Gaby Plata\Downloads\AIRBAG - Intoxicarme.mp3";

        string[] canciones = new string[]
        {
            @"C:\Users\Gaby Plata\Downloads\AIRBAG - Intoxicarme.mp3",
            @"C:\Users\Gaby Plata\Downloads\AIRBAG - Apocalipsis Confort.mp3",
            @"C:\Users\Gaby Plata\Downloads\AIRBAG - Como un Diamante.mp3",
            @"C:\Users\Gaby Plata\Downloads\AIRBAG - Über Puber.mp3"
        };

        string[] nombres = new string[]
        {
            "Intoxicarme",
            "Apocalipsis Confort",
            "Como un Diamante",
            "Über Puber"
        };

        int indiceCancionActual = 0;

        int duracionCancion = 0;

        //Timer tiempo = new Timer(); //? ------

        public Form1()
        {
            InitializeComponent();

            //listBox1.Items.AddRange(canciones);

            //listBox1.Items.AddRange(new string[] { "Intoxicarme", "Apocalipsis Confort", "Como un Diamante", "Über Puber" });

            listBox1.Items.AddRange(nombres);

            //tiempo.Interval = 1000; // interval -> 1000ms = 1s
            //tiempo.Tick += Tiempo_Tick; //? ------
        }
                
        /*
        private void Tiempo_Tick(object sender, EventArgs e) //? ------
        {
            // throw new NotImplementedException();

            StringBuilder posActual = new StringBuilder(128); 
            // objeto para almacenar la posActual 

            mciSendString("status MediaFile position", posActual, 128, IntPtr.Zero);
            // para obtener la posActual

            int posicion = int.Parse(posActual.ToString());
            // convierte la cadena de la posActual en int

            if (posicion <= duracionCancion) // si la posActual es menor o igual a la duracion total ..
            {
                trackBar1.Value = posicion;
                // trackBar1.Value -> repre la posActual del trackBar1
                // -  actualiza la pos del TrackBar para reflejar la posActual de la cancion
            }
            else
            {
                tiempo.Stop();
            }
        }
        */
        
        private void button1_Click(object sender, EventArgs e)
        {
            // debe comenzar de nuevo

            mciSendString("seek MediaFile to start", null, 0, IntPtr.Zero); // comienza de 0
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "| |")
            {
                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                button2.Text = "▶️";
                //tiempo.Stop();
            }
            else
            {
                string rutaC = canciones[indiceCancionActual];
                // obtengo la ruta de la cancionActual

                mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);

                StringBuilder duracion = new StringBuilder(128); //?
                // creo un StringBuilder donde guardo la duracion 

                mciSendString("status MediaFile length", duracion, 128, IntPtr.Zero); //?
                // obtiene la duracion

                duracionCancion = int.Parse(duracion.ToString());
                // convierte en int

                trackBar1.Maximum = duracionCancion;
                // pone el valor max del TrackBar a la duracion

                textBox1.Text = nombres[indiceCancionActual];
                // muestra nombre en textBox

                button2.Text = "| |";

                //tiempo.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // cambiar o saltear musica

            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);

            indiceCancionActual = (indiceCancionActual + 1) % canciones.Length; //? ------
            // avanza al siguiente índice de cancion, y vuelve al inicio si llega al final del array

            string rutaC = canciones[indiceCancionActual];

            mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);

            StringBuilder duracion = new StringBuilder(128);
            mciSendString("status MediaFile length", duracion, 128, IntPtr.Zero);
            duracionCancion = int.Parse(duracion.ToString());
            trackBar1.Maximum = duracionCancion;

            textBox1.Text = nombres[indiceCancionActual];

            //tiempo.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lista de canciones para cambiar

            /*
            mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);

            indiceCancionActual = listBox1.SelectedIndex;


            string rutaC = canciones[indiceCancionActual];

            string sCommand = $"open \"{rutaC}\" type mpegvideo alias MediaFile";
            mciSendString(sCommand, null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);


            StringBuilder duracion = new StringBuilder(128);
            // creo un buffer donde guardo la duracion

            mciSendString("status MediaFile length", duracion, 128, IntPtr.Zero);
            // "status MediaFile length" -> para obtener la duracion

            duracionCancion = int.Parse(duracion.ToString());
            // es de tipo string

            trackBar1.Maximum = duracionCancion;
            //  el TrackBar esta al máximo valor de la duracion
            */
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // muestra el transcurso de la cancion y es posible cambiar

            int nuevaPosicion = trackBar1.Value;
            // trackBar1.Value -> obt o est un int q es la posActual del trackBar
            // obtengo el trackBar1.Value, que representa la posición deseada en la cancion

            mciSendString($"seek MediaFile to {nuevaPosicion}", null, 0, IntPtr.Zero);
            // mueve la pos de reproduccion a la pos q desee

            button2.Text = "| |";

            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // si hay una canción seleccionada ...
            {
                mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);

                indiceCancionActual = listBox1.SelectedIndex; // esa cancion sera la cancionActual

                string rutaC = canciones[indiceCancionActual];

                mciSendString($"open \"{rutaC}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);

                StringBuilder duracion = new StringBuilder(128);
                mciSendString("status MediaFile length", duracion, 128, IntPtr.Zero);
                duracionCancion = int.Parse(duracion.ToString());
                trackBar1.Maximum = duracionCancion;

                textBox1.Text = nombres[indiceCancionActual];

                button2.Text = "| |";

                //tiempo.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
