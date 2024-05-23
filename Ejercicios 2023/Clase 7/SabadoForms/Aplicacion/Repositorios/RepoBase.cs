using Applicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repositorios
{
    public abstract class RepoBase<T>
    {
        protected static List<T> clientes;
        public abstract List<T> BuscarTodos();
        public abstract T BuscarPorId(long entityId);
        public abstract void Alta(T entity);
        public abstract void Actualizar(T entity);
        public abstract void Baja(T entity);        public abstract void Guardar();
        public abstract void ActualizarDesdeOrigen();
    }
}
