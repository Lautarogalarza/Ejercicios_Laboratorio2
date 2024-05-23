using Aplicacion.Repositorios;

namespace Aplicacion.Vista
{
    public partial class FrmPrincipal : Form
    {
        ClienteRepoArchivos repoArchivos;
        public FrmPrincipal()
        {
            repoArchivos = new ClienteRepoArchivos();
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)//SE VA
        {

            if (MessageBox.Show("Seguro que desea salir?", "Atencion", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void visualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerVisualizer frm = new FrmCustomerVisualizer(this.customerRepository);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ///SE VA
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (Path.GetExtension(openFileDialog.FileName) is ".xml")
                        {
                            this.repoArchivos.ActualizarDesdeOrigen(openFileDialog.FileName);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede abrir: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }
        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.repoArchivos.Guardar(repoArchivos.BuscarTodos()))
                {
                    MessageBox.Show("Clientes serializados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se puede Guardar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede Guardar: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }
    }
}