using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Audio;

namespace Entidades
{
    public class GolDelSiglo
    {
        private Thread hiloRelato;

        public void CerrarApp()
        {
            if (hiloRelato!=null && hiloRelato.IsAlive)
            {
                hiloRelato.Abort();
            }

        }

        public void IniciarJugada()
        {
            if (hiloRelato!=null && hiloRelato.IsAlive)
            {
                throw new JugadaActivaException();
            }
            else
            {
                hiloRelato = new Thread(Relato.VictorHugoMorales);
                hiloRelato.Start();
            }
        }

    }
}
