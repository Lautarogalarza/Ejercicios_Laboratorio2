using System.Text;

namespace Hilos_Ejemplo5
{
    public partial class Form1 : Form
    {
        CancellationTokenSource CancellationTokenSource;
        List<Task> tasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarHilos();
        }
        private void IniciarHilos()
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;

            CancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellation = CancellationTokenSource.Token;

            Task task1 = new Task(() => IniciarProceso(progressBar1, label1), cancellation);
            Task task2 = new Task(() => IniciarProceso(progressBar2, label2), cancellation);
            Task task3 = new Task(() => IniciarProceso(progressBar3, label3), cancellation);
            Task task4 = new Task(() => IniciarProceso(progressBar4, label4), cancellation);
            Task task5 = new Task(() => IniciarProceso(progressBar5, label5), cancellation);

            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void IniciarProceso(ProgressBar progressBar, Label label)
        {
            while (progressBar.Value < progressBar.Maximum && !CancellationTokenSource.IsCancellationRequested)
            {
                Thread.Sleep(new Random().Next(100, 1000));
                IncrementarBarraProgreso(progressBar, label, Task.CurrentId.Value);
            }

            FinalizarProceso(progressBar, label);
        }

        private void FinalizarProceso(ProgressBar progressBar, Label label)
        {
            if (InvokeRequired)
            {
                object[] parametros = new object[] { progressBar, label };
                Action<ProgressBar, Label> delegado;
                delegado = FinalizarProceso;
                Invoke(delegado, parametros);
            }
            else
            {
                if (progressBar.Value == progressBar.Maximum)
                {
                    label.Text = "FINALIZADO";
                }
                else
                {
                    label.Text = "CANCELADO";
                }
            }
        }

        private void IncrementarBarraProgreso(ProgressBar progressBar, Label label, int idHilo)
        {
            if (InvokeRequired)
            {
                object[] parametros = new object[] { progressBar, label, idHilo };
                Action<ProgressBar, Label, int> delegado;
                delegado = IncrementarBarraProgreso;
                Invoke(delegado, parametros);
            }
            else
            {
                progressBar.Increment(2);
                label.Text = $"Hilo Nro {idHilo} - {progressBar.Value}%";
            }
        }

        private void BtnVerInfo_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in tasks)
            {
                stringBuilder.Append($"Hilo {item.Id} ");
                string mensaje = item.IsCompleted ? "Esta completado." : $"en estado {item.Status}";
                stringBuilder.Append(mensaje);
                stringBuilder.AppendLine();
            }

            MessageBox.Show(stringBuilder.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnReiniciar_Click(object sender, EventArgs e)
        {
            CancellationTokenSource.Cancel();

            while (!tasks.All(h => h.IsCompleted))
            {
                await Task.Delay(1000);
            }

            IniciarHilos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancellationTokenSource.Cancel();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMostrar.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}