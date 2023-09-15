using System.Text;

namespace I02
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstbPaises.Items.Add("Argentina");
            this.lstbPaises.Items.Add("Chile");
            this.lstbPaises.Items.Add("Uruguay");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            decimal edad = this.nupEdad.Value;
            string pais = string.Empty;
            string genero = string.Empty;
            string[] cursos = new string[0];


            foreach (Control item in gbGenero.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    genero = ((RadioButton)item).Text;
                }
            }

            foreach (Control item in gbCursos.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    Array.Resize<string>(ref cursos, cursos.Length + 1);
                    cursos[cursos.Length - 1] = ((CheckBox)item).Text;
                }
            }

            if (this.lstbPaises.SelectedIndex != -1)
            {
                pais = lstbPaises.SelectedItem.ToString();
                Ingresante ingresante = new Ingresante(cursos, direccion, edad, genero, nombre, pais);

                MessageBox.Show(ingresante.Mostrar());
            }

        }

        private void btnHardcode_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Lautaro";
            this.txtDireccion.Text = "Mitre 750";
            this.nupEdad.Value = 25;
            this.lstbPaises.SelectedIndex = 0;
            this.rbMasc.Checked = true;
            this.cbCsharp.Checked = true;
        }

        private void frmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar el form?", "Informacion", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}