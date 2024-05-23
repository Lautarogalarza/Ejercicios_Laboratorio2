using Aplicacion.Archivos;
using Aplicacion.Excepciones;
using Applicacion.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Repositorios
{
    public class ClienteRepoArchivos : RepoBase<Cliente>
    {
        Serializadora<List<Cliente>> serializadora;

        public ClienteRepoArchivos()
        {
            serializadora = new Xml<List<Cliente>>();
        }
        static ClienteRepoArchivos()
        {
            clientes = new List<Cliente>();

            for (int i = 0; i < 20; i++)
            {
                var customer = new Cliente();
                customer.Id = i + 1;
                customer.Nombre = "Cliente Nro" + customer.Id;
                customer.Apellido = "CustomerLastname" + customer.Id;
                customer.Edad = 20 + (int)customer.Id;

                clientes.Add(customer);
            }
           
        }

        public override void Alta(Cliente entity)
        {
            try
            {
                long lastId = (long)(clientes[clientes.Count - 1]).Id;
                entity.Id = lastId + 1;
                if (clientes != entity)
                {
                    clientes.Add(entity);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new TechnicalException(
                    string.Format("No se pudo crear el cliente \"{0} {1}\".", entity.Nombre, entity.Apellido),
                    ex);
            }
        }


        public override void Actualizar(Cliente entity)
        {
            Cliente customer = this.BuscarPorId(entity.Id);
            customer.Nombre = entity.Nombre;
            customer.Apellido = entity.Apellido;
            customer.Edad = entity.Edad;
        }


        public override void Baja(Cliente entity)
        {
            clientes.Remove(BuscarPorId(entity.Id));
        }

        public override Cliente BuscarPorId(long entityId)
        {
            return  clientes.Where(x => x.Id == entityId).FirstOrDefault();
        }

        public override List<Cliente> BuscarTodos()
        {
            return clientes;
        }

        public override void Guardar()
        {
            serializadora.Guardar("",clientes);
        }

        public override void ActualizarDesdeOrigen()
        {
            //customers.AddRange(customerSerializer.Read(path));
        }
    }
}
