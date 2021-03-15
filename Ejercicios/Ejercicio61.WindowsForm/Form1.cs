using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio61.Entidades;

namespace Ejercicio61.WindowsForm
{
    public partial class frmPersona : Form
    {
        public int auxId;
     
        public frmPersona()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtId.Text = "";
            this.lstId.Items.Clear();
            this.lstPersonas.Items.Clear();
        }

        public void Refrescar()
        {
            List<Persona> lista = PersonaDAO.Leer();
            this.lstPersonas.Items.Clear();

            foreach (Persona item in lista)
            {
                this.lstPersonas.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona(txtNombre.Text, txtApellido.Text);
                PersonaDAO.Guardar(persona);
                MessageBox.Show("Persona cargada exitosamente");
                this.Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = (Persona)lstPersonas.SelectedItem;

                PersonaDAO.Eliminar(persona);
                MessageBox.Show("Persona Eliminada exitosamente");
                this.Limpiar();
                this.Refrescar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona(auxId,txtNombre.Text, txtApellido.Text);
                PersonaDAO.Modificar(persona);
                MessageBox.Show("Persona modificada exitosamente");
                this.Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            this.lstId.Items.Clear();

            try
            {
                Persona persona = PersonaDAO.LeerPorId(Convert.ToInt32(txtId.Text));

                this.lstId.Items.Add(persona);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void lstPersonas_MouseClick(object sender, MouseEventArgs e)
        {
            Persona persona = (Persona)lstPersonas.SelectedItem;
            this.txtNombre.Text = persona.GetNombre;
            this.txtApellido.Text = persona.GetApellido;
            auxId = persona.GetId;

        }
    }
}
