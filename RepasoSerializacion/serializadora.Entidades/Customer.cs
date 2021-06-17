using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializadora.Entidades
{
    public class Customer : Entity
    {
        private string name;
        private string lastName;
        private int age;
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public Customer()
        {

        }
        public Customer(string name, string lastName, int age, int id):base(id)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

    }
}
