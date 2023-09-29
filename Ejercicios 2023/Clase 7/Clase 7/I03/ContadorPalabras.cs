using System.Text;

namespace I03
{
    public partial class ContadorPalabras : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> palabrasLista;

        public ContadorPalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            palabrasLista = new List<string>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContarPalabras(rtbEntrada.Text);
            MessageBox.Show(Mostrar());
        }

        public void ContarPalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            palabrasLista.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));


            foreach (string palabra in palabrasLista)
            {
                if (palabrasLista.Count >= 3)
                {
                    if (!diccionario.ContainsKey(palabra) && palabra != " ")
                    {
                        diccionario.Add(palabra, 1);
                    }
                    else
                    {
                        diccionario[palabra] += 1;
                    }
                }
                else
                {
                    break;
                }
            }


        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            if (diccionario.Count > 0)
            {
                while (i < 3)
                {
                    foreach (KeyValuePair<string, int> elemento in diccionario)
                    {
                        if (diccionario.Values.Max() == elemento.Value && i < 3)
                        {
                            eliminar = elemento.Key;
                            sb.AppendLine($"{elemento.Key}   {elemento.Value}");
                            break;
                        }
                    }

                    if (diccionario.Remove(eliminar))
                    {
                        i++;
                    }
                }
            }


            return sb.ToString();
        }
    }
}
