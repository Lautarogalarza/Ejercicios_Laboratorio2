using System;

namespace Hilos_Ejemplo1
{
    internal class Program
    {
        private static DateTime time;
        private static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            time = DateTime.Now;

            Task hilo = Task.Run(EjecutarSincronico);
            Task hilo2 = Task.Run(EjecutarEnParalelo);

            Task.WaitAll(hilo,hilo2);

            Console.WriteLine("FINALIZARON TODOS LOS HILOS");
        }


        public static void EjecutarEnParalelo()
        {
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-A"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-B"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-C"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-D"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-E"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-F"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-G"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-H"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-I"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-J"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-K"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-L"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-M"));
            tareas.Enqueue(() => EjecutarTarea("PARALLEL-N"));

            foreach (Action tarea in tareas)
            {
                Task.Run(tarea);
            }
        }

        public static void EjecutarSincronico()
        {
            Queue<Action> tareas = new Queue<Action>();
            tareas.Enqueue(() => EjecutarTareaSync("SINC-A"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-B"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-C"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-D"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-E"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-F"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-G"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-H"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-I"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-J"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-K"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-L"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-M"));
            tareas.Enqueue(() => EjecutarTareaSync("SINC-N"));

            foreach (Action tarea in tareas)
            {
                tarea();
            }
        }

        public static void EjecutarTarea(string codigo)
        {
            int tiempo = random.Next(1000, 5000);
            Thread.Sleep(tiempo);
            Console.WriteLine($"{DateTime.Now:T} - Tarea {codigo} completada en {tiempo} ms.");
        }

        public static void EjecutarTareaSync(string codigo)
        {
            int tiempo = random.Next(1000, 5000);
            Thread.Sleep(tiempo);
            Console.WriteLine($"{DateTime.Now:T} - Tarea {codigo} completada en {(DateTime.Now - time).TotalSeconds} ms.");
        }
    }
}