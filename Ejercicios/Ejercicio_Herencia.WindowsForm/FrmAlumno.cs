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
    public partial class FrmAlumno : Form
    {
        private Alumno MiAlumno;

        public Alumno GetAlumno
        {
            get
            {
                return this.MiAlumno;
            }

        }

        public FrmAlumno()
        {
            InitializeComponent();

            foreach (ETipoExamen examen in Enum.GetValues(typeof(ETipoExamen)))
            {
                cmbExamen.Items.Add(examen);
            }

            this.cmbExamen.SelectedItem = ETipoExamen.Final;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FrmAlumno(Alumno miAlumno) : this()
        {
            this.txtApellido.Text = miAlumno.GeApellido;
            this.txtLegajo.Text = miAlumno.GetLegajo.ToString();
            this.txtNombre.Text = miAlumno.GetNombre;
            this.cmbExamen.Text = miAlumno.GetExamen.ToString();
            this.txtLegajo.Enabled = false;

        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.MiAlumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbExamen.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
