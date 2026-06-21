using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayoMcQueen
{
    public class Automovil
    {
        private bool encendido;
        private bool luces;
        private int velocidad;

        public void Encender()
        {
            encendido = true;
        }

        public void Apagar()
        {
            if (velocidad == 0)
                encendido = false;
        }

        private const int VELOCIDAD_MAXIMA = 220;

        public void Acelerar()
        {
            if (!encendido)
                return;

            velocidad += 10;

            if (velocidad > VELOCIDAD_MAXIMA)
                velocidad = VELOCIDAD_MAXIMA;
        }

        public void Frenar()
        {
            if (velocidad > 0)
                velocidad -= 10;

            if (velocidad < 0)
                velocidad = 0;
        }

        public void FrenarSuave()
        {
            if (velocidad > 0)
            {
                velocidad -= 2;
            }

            if (velocidad < 0)
            {
                velocidad = 0;
            }
        }

        public int ObtenerVelocidad()
        {
            return velocidad;
        }

        public bool EstaEncendido()
        {
            return encendido;
        }

        public void EncenderLuces()
        {
            luces = true;
        }

        public void ApagarLuces()
        {
            luces = false;
        }

        public bool LucesEncendidas()
        {
            return luces;
        }

        public void Reversa()
        {
            if (encendido)
            {
                velocidad = -15;
            }
        }
        private bool reversa;
        private int direccion = 1;

        public void ActivarReversa()
        {
            reversa = true;
            direccion = -1;
        }

        public void DesactivarReversa()
        {
            reversa = false;
            direccion = 1;
        }

        public bool EstaEnReversa()
        {
            return reversa;
        }

        public int ObtenerDireccion()
        {
            return direccion;
        }
    }
}
