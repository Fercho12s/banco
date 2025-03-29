using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Que todos los paneles ocupen toda la pantalla
            Pinicio.Dock=DockStyle.Fill;
            Psolicitar.Dock = DockStyle.Fill;
            Pbeneficios.Dock = DockStyle.Fill;
            Pcalprestamos.Dock = DockStyle.Fill;

            //Abrir el formulario de inicio y los otros ocultarlos
            //ocultar paneles
            Psolicitar.Hide();
            Pbeneficios.Hide();
            Pcalprestamos.Hide();
            //mostrar panel
            Pinicio.Show();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureLogo_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de inicio y los otros ocultarlos
            //ocultar paneles
            Psolicitar.Hide();
            Pbeneficios.Hide();
            Pcalprestamos.Hide();
            //mostrar panel
            Pinicio.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void prestamosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de inicio y los otros ocultarlos
            //ocultar paneles
            Psolicitar.Hide();
            Pcalprestamos.Hide();
            Psolicitar.Hide();
            //mostrar panel
            Pbeneficios.Show();

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ocultar paneles
            Pbeneficios.Hide();
            Pcalprestamos.Hide();
            Psolicitar.Hide();
            //mostrar panel
            Psolicitar.Show();

            List<string> nombres = new List<string>();

            // Agregar elementos a la lista
            nombres.Add("Con tu identificación, comprobante de ingresos y ganas de crecer, ¡tu préstamo está listo!");
            nombres.Add("Solo tu documento, comprobante de ingresos y en minutos tienes tu préstamo.");
            nombres.Add("Identificación, ingresos y un clic… ¡Así de fácil es tu préstamo!");
            nombres.Add("Sin vueltas: Identificación + ingresos = préstamo aprobado.");
            nombres.Add("Con tu documento y tus ingresos, tu préstamo está a un paso.");

            // Mostrar los elementos de la lista
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
                Thread.Sleep(10000);
            }
        }
    }
}
