using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_Herencia.Entidades;

namespace Ejercicio_Herencia.WindowsForm
{
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado MiCalificado;

        public AlumnoCalificado GetCalificado
        {
            get
            {
                return this.MiCalificado;
            }

        }

        public FrmAlumnoCalificado()
        {
            InitializeComponent();

        }


        public FrmAlumnoCalificado(Alumno miAlumno) : this()
        {
            this.txtApellido.Text = miAlumno.GeApellido;
            this.txtLegajo.Text = miAlumno.GetLegajo.ToString();
            this.txtNombre.Text = miAlumno.GetNombre;
            this.cmbExamen.Text = miAlumno.GetExamen.ToString();
            ///////////////////////////////////////////////////////////////////////////////
            this.txtLegajo.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cmbExamen.Enabled = false;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.MiCalificado = new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbExamen.SelectedItem, Convert.ToDouble(this.txtNota.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
