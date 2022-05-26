using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            DtgvPersonas.DataSource = PersonaAccesoDatos.Leer();
            DtgvPersonas.Update();
            DtgvPersonas.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DtgvPersonas.SelectedRows.Count > 0)
            {
                Persona persona = (Persona)DtgvPersonas.CurrentRow.DataBoundItem;
                PersonaAccesoDatos.Eliminar(persona.Id);
                Refrescar();
            }
        }
    }
}
