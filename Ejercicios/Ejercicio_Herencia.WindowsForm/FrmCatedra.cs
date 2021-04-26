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
    public partial class FrmCatedra : Form
    {
        private Catedra MiCatedra;
        private List<AlumnoCalificado> MisCalificados = new List<AlumnoCalificado>();


        public FrmCatedra()
        {
            InitializeComponent();

            foreach (ETipoOrdenamiento Ordenamiento in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                cmbOrdenar.Items.Add(Ordenamiento);
            }
            this.cmbOrdenar.SelectedItem = ETipoOrdenamiento.ApellidoAscendete;
            this.StartPosition = FormStartPosition.CenterScreen;
            MiCatedra = new Catedra();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            FrmAlumno newFrmAlumno = new FrmAlumno();
            newFrmAlumno.ShowDialog();

            if (newFrmAlumno.DialogResult == DialogResult.OK)
            {
                for (int i = 0; i < this.MiCatedra.GetAlumnos.Count; i++)
                {
                    if (MiCatedra.GetAlumnos[i] == newFrmAlumno.GetAlumno)
                    {
                        flag = true;
                        MessageBox.Show("El legajo ya existe", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (flag == false && this.MiCatedra + newFrmAlumno.GetAlumno)
                {
                    MessageBox.Show("Alumno cargado exitosamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizarListadoAlumnos();
                }
            }
            else if (newFrmAlumno.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("No se cargo el alumno", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ActualizarListadoAlumnos()
        {
            this.lsbAlumnos.Items.Clear();
            string ORDENAMIENTO = Convert.ToString(this.cmbOrdenar.SelectedItem);

            switch (ORDENAMIENTO)
            {
                case "LegajoAscendete":
                    this.MiCatedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case "LegajoDescendete":
                    this.MiCatedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                case "ApellidoAscendete":
                    this.MiCatedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case "ApellidoDescendete":
                    this.MiCatedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
            }

            foreach (Alumno item in MiCatedra.GetAlumnos)
            {
                this.lsbAlumnos.Items.Add(item.MostrarAlumno());
            }
        }


        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Object.Equals(MiCatedra, null) == false)
            {
                this.ActualizarListadoAlumnos();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (this.lsbAlumnos.SelectedIndex >= 0)
            {
                FrmAlumno formAlumnoModificado = new FrmAlumno(MiCatedra.GetAlumnos[lsbAlumnos.SelectedIndex]);
                formAlumnoModificado.ShowDialog();

                if (formAlumnoModificado.DialogResult == DialogResult.OK)
                {
                    this.MiCatedra[this.lsbAlumnos.SelectedIndex] = formAlumnoModificado.GetAlumno;
                    MessageBox.Show("Alumno modificado exitosamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizarListadoAlumnos();
                }
                else if (formAlumnoModificado.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("No se modificado el alumno", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (this.lsbAlumnos.SelectedIndex >= 0)
            {

                FrmAlumnoCalificado newFrmCalificado = new FrmAlumnoCalificado(MiCatedra.GetAlumnos[lsbAlumnos.SelectedIndex]);
                newFrmCalificado.ShowDialog();

                if (newFrmCalificado.DialogResult == DialogResult.OK)
                {
                    this.MiCatedra.GetAlumnos.Remove(MiCatedra.GetAlumnos[this.lsbAlumnos.SelectedIndex]);//REMUEVO
                    this.ActualizarListadoAlumnos();//ACTUALIZO
                    this.lsbAlumnoCalificado.Items.Clear();//LIMPIO

                    MessageBox.Show("Alumno Eliminado exitosamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (AlumnoCalificado item in this.MisCalificados)
                    {
                        this.lsbAlumnoCalificado.Items.Add(item.MostrarCalificado());//MUESTRO               
                    }
                }

                else if (newFrmCalificado.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("No se califico el alumno", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             if (this.lsbAlumnos.SelectedIndex >= 0)
            {
                FrmAlumno formAlumnoModificado = new FrmAlumno(MiCatedra.GetAlumnos[lsbAlumnos.SelectedIndex]);
                formAlumnoModificado.ShowDialog();

                if (formAlumnoModificado.DialogResult == DialogResult.OK)
                {
                    this.MiCatedra.GetAlumnos.Remove(MiCatedra.GetAlumnos[this.lsbAlumnos.SelectedIndex]);//REMUEVO
                    MessageBox.Show("Alumno modificado exitosamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizarListadoAlumnos();
                }
                else if (formAlumnoModificado.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("No se modificado el alumno", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
