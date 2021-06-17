using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializadora.Entidades
{
    
    public class Entity
    {
        private long id;

        public long Id
        {
            get
            {
                return this.id;
            }
            set { this.id = value; }
        }

        public Entity()
        {

        }
        public Entity(int id)
        {
            this.id = id;
        }


    }
}
