using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace RayoMcQueen
{
    public partial class Form1 : Form
    {
        private Automovil carro = new Automovil();
        private bool frenando = false;
        private int tiempoEncendido = 0;
        private bool intentandoEncender = false;


        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            pictureBox1.Image = Properties.Resources.pngwing_com;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            carro.Apagar();

            if (!carro.EstaEncendido())
            {
                lblEstado.Text = "Estado: Apagado";
                lblAccion.Text = "Motor apagado";
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (!carro.EstaEncendido())
            {
                lblEstado.Text = "Estado: El carro está apagado";
                lblAccion.Text = "No puedes acelerar, el carro está apagado";
                return;
            }

            carro.Acelerar();

            lblVelocidad.Text =
                "Velocidad: " + carro.ObtenerVelocidad() + " km/h";

            lblAccion.Text = "Rayo McQueen está acelerando";

        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            carro.Frenar();

            lblVelocidad.Text =
                "Velocidad: " + carro.ObtenerVelocidad() + " km/h";
            lblAccion.Text = "Rayo McQueen está frenando";
        }

        private void btnLuces_Click(object sender, EventArgs e)
        {
            if (!carro.LucesEncendidas())
            {
                carro.EncenderLuces();
                lblLuces.Text = "Luces: Encendidas";
                pictureBox1.Image = Properties.Resources.Luces_encendidas;
                lblAccion.Text = "Luces encendidas";
            }
            else
            {
                carro.ApagarLuces();
                lblLuces.Text = "Luces: Apagadas";
                pictureBox1.Image = Properties.Resources.pngwing_com;
                lblAccion.Text = "Luces apagadas";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left +=
                (carro.ObtenerVelocidad() / 5) *
                carro.ObtenerDireccion();
        }

        private void btnReversa_Click(object sender, EventArgs e)
        {
            if (!carro.EstaEncendido())
            {
                lblAccion.Text = "El carro está apagado";
                return;
            }

            if (carro.ObtenerVelocidad() > 0.2)
            {
                lblAccion.Text = "Debes detener el vehículo completamente";
                return;
            }

            if (!carro.EstaEnReversa())
            {
                carro.ActivarReversa();
                lblAccion.Text = "Reversa activada";
            }
            else
            {
                carro.DesactivarReversa();
                lblAccion.Text = "Reversa desactivada";
            }
        }

        private void timerFreno_Tick(object sender, EventArgs e)
        {
            carro.Frenar();

            lblVelocidad.Text =
                "Velocidad: " + carro.ObtenerVelocidad() + " km/h";

            if (carro.ObtenerVelocidad() == 0)
            {
                timerFreno.Stop();
            }
        }

        private void btnFrenar_MouseDown(object sender, MouseEventArgs e)
        {
            frenando = true;
            timerFreno.Start();

            lblAccion.Text = "Frenando...";
        }

        private void btnFrenar_MouseUp(object sender, MouseEventArgs e)
        {
            frenando = false;
            timerFreno.Stop();

            lblAccion.Text = "Freno liberado";
        }

        private void timerAcelerar_Tick(object sender, EventArgs e)
        {
            carro.Acelerar();

            lblVelocidad.Text =
                "Velocidad: " + carro.ObtenerVelocidad() + " km/h";

            lblAccion.Text = "Velocidad actual: " + carro.ObtenerVelocidad();
            {
                lblAccion.Text = "Velocidad máxima alcanzada";
            }
        }

        private void btnAcelerar_MouseDown(object sender, MouseEventArgs e)
        {
            if (!carro.EstaEncendido())
                return;

            timerInercia.Stop();

            timerAcelerar.Start();

            lblAccion.Text = "Rayo McQueen está acelerando";
        }

        private void btnAcelerar_MouseUp(object sender, MouseEventArgs e)
        {
            timerAcelerar.Stop();

            timerInercia.Start();

            lblAccion.Text = "Perdiendo velocidad...";
        }

        private void timerInercia_Tick(object sender, EventArgs e)
        {
            carro.FrenarSuave();

            lblVelocidad.Text =
                "Velocidad: " + carro.ObtenerVelocidad() + " km/h";

            if (carro.ObtenerVelocidad() == 0)
            {
                timerInercia.Stop();
                lblAccion.Text = "Rayo McQueen está detenido";
            }
        }

        private void timerEncender_Tick(object sender, EventArgs e)
        {
            tiempoEncendido += 100;

            if (tiempoEncendido >= 1000)
            {
                timerEncender.Stop();

                carro.Encender();

                intentandoEncender = false;

                lblEstado.Text = "Estado: Encendido";
                lblAccion.Text = "Motor encendido";
            }
        }

        private void btnEncender_MouseDown(object sender, MouseEventArgs e)
        {
            if (carro.EstaEncendido())
                return;

            intentandoEncender = true;
            tiempoEncendido = 0;

            lblAccion.Text = "Arrancando motor...";

            timerEncender.Start();
        }

        private void btnEncender_MouseUp(object sender, MouseEventArgs e)
        {
            if (!carro.EstaEncendido())
            {
                intentandoEncender = false;

                timerEncender.Stop();

                lblAccion.Text = "Arranque cancelado";
            }
        }
    }
}
