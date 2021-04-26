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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipo;
        public FrmMostrar(CentralitaPolimorfismo.Entidades.Centralita centralita, Llamada.TipoLlamada tipo)
        {
            this.centralita = centralita;
            this.tipo = tipo;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch (this.tipo)
            {
                case Llamada.TipoLlamada.Local:
                    this.rtbMostrar.AppendText("Facturacion Local: " + centralita.GananciaPorLocal.ToString("##.##"));
                    break;
                case Llamada.TipoLlamada.Provincial:
                    this.rtbMostrar.AppendText("Facturacion Provincial: " + centralita.GananciaPorProvincial.ToString("##.##"));
                    break;
                case Llamada.TipoLlamada.Todas:
                    this.rtbMostrar.AppendText("Facturacion Total: " + centralita.GananciaTotal.ToString("##.##"));
                    break;
                default:
                    break;
            }
        }
    }
}
