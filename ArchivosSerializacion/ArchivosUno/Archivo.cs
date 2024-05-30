namespace ArchivosUno
{
    public static class Archivo
    {

        static string ruta;

        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }

        public static void Escribir(string nombre)
        {
            string completa = ruta + @"\" + nombre + ".txt";
            try
            {

                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    sw.WriteLine("FECHA");
                    sw.WriteLine(DateTime.Now.ToString());
                }
            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static string Leer()
        {
            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))
                {
                    string completa = ruta + @"\Laboratorio2ParteDos20_39_00.txt";

                    using (StreamReader sr = new StreamReader(completa))
                    {
                        //string linea;
                        datos = sr.ReadToEnd();

                        //while ( (linea = sr.ReadLine()) != null)
                        //{
                        //    datos += "\n" + linea;
                        //}
                    }
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }



    }
}