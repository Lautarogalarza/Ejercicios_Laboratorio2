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
using Audio;

namespace _20201203
{
    public partial class D10S : Form
    {
        private Pic estado;
        private AccesoDB guardarDB;
        private AccesoTXT guardarLog;
        private GolDelSiglo golDelSiglo;

        public D10S()
        {
            InitializeComponent();
            Relato.Avanzar += MostrarGrafico;
            golDelSiglo = new GolDelSiglo();
            guardarDB = new AccesoDB();
            guardarLog = new AccesoTXT();
        }

        private void MostrarGrafico()
        {
            if (this.InvokeRequired)
            {
                AvanceRelato ar = new AvanceRelato(MostrarGrafico);
                this.Invoke(ar);
            }
            else
            {
                switch (estado)
                {
                    case Pic.SePrepara:
                        this.picFondo.Visible = false;
                        break;
                    case Pic.LaTieneMaradona:
                        pic1.Visible = true;
                        break;
                    case Pic.ArrancaConLaPelota:
                        pic1.Visible = false;
                        pic2.Visible = true;
                        break;
                    case Pic.DejaElTendal:
                        pic2.Visible = false;
                        pic3.Visible = true;
                        break;
                    case Pic.VaATocaPra:
                        pic3.Visible = false;
                        pic4.Visible = true;
                        break;
                    case Pic.Gooool:
                        pic4.Visible = false;
                        pic5.Visible = true;
                        break;
                    case Pic.Festeja:
                        pic5.Visible = false;
                        this.picFondo.Visible = true;
                        this.picFondo.Visible = true;
                        estado--;
                        break;
                }
                estado++;
            }
        }

        private void btnGolDelSiglo_Click(object sender, EventArgs e)
        {
            try
            {
                guardarLog.Guardar();
                guardarDB.Guardar();
                golDelSiglo.IniciarJugada();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void btnLeerDb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.guardarDB.Leer());

        }

        private void btnLeerLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.guardarLog.Leer());

        }
        private void D10S_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir?", "Atencion", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                golDelSiglo.CerrarApp();

            }
        }
    }
}
