using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo.Entidades;

namespace CentralitaPolimorfismo.WindowsForm
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;

        public CentralitaPolimorfismo.Entidades.Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        public FrmLlamador(CentralitaPolimorfismo.Entidades.Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "9";

        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.TextLength == 0)
            {
                this.cmbFranja.Enabled = true;
            }
            this.txtDestino.Text += "#";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.txtDestino.Text = "";
            this.txtOrigen.Text = "";
            this.cmbFranja.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();

            if (this.txtDestino.Text != "" && this.txtOrigen.Text != "")
            {

                if (this.txtDestino.Text.IndexOf("#") == 0)
                {
                    Provincial.Franja franja;

                    Enum.TryParse<Provincial.Franja>(this.cmbFranja.SelectedValue.ToString(), out franja);

                    Provincial llamada = new Provincial(this.txtOrigen.Text, franja, duracion.Next(0, 50), this.txtDestino.Text);

                    this.centralita += llamada;

                    MessageBox.Show("Llamada Provincial agregada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Limpiar();

                }
                else
                {
                    Random costo = new Random();
                    double costoRandom = costo.NextDouble() * (5.6 - 0.5) + 0.5;
                    Local llamada = new Local(this.txtOrigen.Text, duracion.Next(0, 50), this.txtDestino.Text, (float)costoRandom);

                    this.centralita += llamada;

                    MessageBox.Show("Llamada Local agregada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Limpiar();

                }
            }
            else
            {
                MessageBox.Show("Destinos invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
