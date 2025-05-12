using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace pryAccastelloControlDeTiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            lblTiempo.Text = "0.00 s";
        }

        Stopwatch cronometro = new Stopwatch();
        bool temporizadorCorriendo = false;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            if (!temporizadorCorriendo)
            {
                cronometro.Restart();
                temporizadorCorriendo = true;
                btnTemporizador.Text = "Detener";
                lblTiempo.Text = "0.00 s";
            }
            else
            {
                cronometro.Stop();
                temporizadorCorriendo = false;
                btnTemporizador.Text = "Iniciar";
                lblTiempo.Text = $"{cronometro.Elapsed.TotalSeconds:F2} s";
            }
        }
    }
}
