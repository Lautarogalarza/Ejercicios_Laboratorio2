using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {

        Cajero cajero;
        public FrmPrincipal()
        {
            InitializeComponent();
            cajero = new Cajero();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());

            foreach (Persona item in Cajero.personas)
            {
                this.lstIngresado.Items.Add(item);
            }

        }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Persona.InformaCajero -= Archivos.Guardar;
            Persona.InformaCajero -= Serializadora.Guardar;
            Persona.InformaCajero -= PersonaDAO.Insertar;

            try
            {
                if ((Persona)this.lstIngresado.SelectedItem != null)
                {

                    Persona nuevaPersona = (Persona)this.lstIngresado.SelectedItem;
                    nuevaPersona.InformaEstado += this.per_InformaEstado;

                    Persona.InformaCajero += Archivos.Guardar;
                    Persona.InformaCajero += Serializadora.Guardar;
                    Persona.InformaCajero += PersonaDAO.Insertar;

                    cajero.Cobrar(nuevaPersona, cajero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ActualizarEstados()
        {
            this.lstIngresado.Items.Clear();
            this.lstAtendido.Items.Clear();
            this.lstCobrado.Items.Clear();

            foreach (Persona item in Cajero.personas)
            {
                switch (item.Estado)
                {
                    case Persona.EEstado.Ingresado:
                        this.lstIngresado.Items.Add(item);
                        break;
                    case Persona.EEstado.Atendido:
                        this.lstAtendido.Items.Add(item);
                        break;
                    case Persona.EEstado.Cobrado:
                        this.lstCobrado.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }
        }


        private void per_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Persona.DelegadoEstado d = new Persona.DelegadoEstado(per_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cajero.CerrarCajero();
        }
    }
}
