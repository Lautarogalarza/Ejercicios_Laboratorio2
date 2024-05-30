namespace ArchivoDos
{
    public class Archivo
    {
        static string ruta;
        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Ruta del proyecto en el que estoy trabajando, esto se va a guardar en la carpeta bin\debug
            ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @"\Archivos";
        }

        public static void Escribir()
        {
            string completa = ruta + @"\Laboratorio2ParteDos" + DateTime.Now.ToString("HH_mm_ss") + ".txt";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string datos = "Hello there, hubo un error en la linea 32";

                File.WriteAllText(completa,datos);

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

                    datos = File.ReadAllText(completa);
          
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