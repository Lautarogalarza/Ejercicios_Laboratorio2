using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate bool DelegadoCajero(Persona persona);
    public class Cajero
    {

        private List<Thread> hiloCajas;
        public static Queue<Persona> personas;

        public Cajero()
        {
            this.hiloCajas = new List<Thread>();
            personas = new Queue<Persona>();
        }


        public void Cobrar(Persona persona, Cajero cajero)
        {
            float montoTotal = 0;
            foreach (Factura item in persona.Facturas)
            {
                montoTotal += item.Precio;
            }

            persona.MontoTotal = montoTotal;
            Thread nuevoHilo = new Thread(persona.MockClicloCajero);
            cajero.hiloCajas.Add(nuevoHilo);
            nuevoHilo.Start();
        }
      
        public void CerrarCajero()
        {
            foreach (Thread item in this.hiloCajas)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }


    }
}
