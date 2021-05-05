using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaExcepciones.Entidades;

namespace CentralitaExcepciones.WindowsForm
{
    public partial class FrmPrincipal : Form
    {
        private Centralita centralita;
        FrmLlamador formLlamador;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.centralita = new Centralita();
        }

        private void btnLLamada_Click(object sender, EventArgs e)
        {
            formLlamador = new FrmLlamador(centralita);
            formLlamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(formLlamador.Centralita, Llamada.TipoLlamada.Todas);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(formLlamador.Centralita, Llamada.TipoLlamada.Local);
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(formLlamador.Centralita, Llamada.TipoLlamada.Provincial);
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
