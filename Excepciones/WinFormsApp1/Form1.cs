namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double kilometros;
            double litros;

            try
            {
                if (String.IsNullOrEmpty(this.txtKilometros.Text) || String.IsNullOrEmpty(this.txtLitros.Text))
                {
                    throw new ParametrosVaciosException();
                }

                kilometros = double.Parse(this.txtKilometros.Text);
                litros = double.Parse(this.txtLitros.Text);
                this.rtx.Text = Calculador.Calcular(kilometros, litros).ToString();
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}