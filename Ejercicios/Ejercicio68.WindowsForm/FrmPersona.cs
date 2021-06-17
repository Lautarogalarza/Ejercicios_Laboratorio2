using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio68.Entidades;

namespace Ejercicio68.WindowsForm
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        public FrmPersona()
        {
            InitializeComponent();
          
        }


        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.persona is null)
            {
                this.persona = new Persona();
                this.persona.EventoString += new DelegadoString(NotificarCambio);
                this.persona.Nombre = txtNombre.Text;
                this.persona.Apellido = txtApellido.Text;
                btnCrear.Text = "Actualizar";

            }
            else
            {
                this.persona.Nombre = txtNombre.Text;
                this.persona.Apellido = txtApellido.Text;
            }

        }
    }
}
