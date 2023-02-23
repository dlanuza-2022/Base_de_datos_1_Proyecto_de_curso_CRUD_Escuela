using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    public class Subject
    {
        private Guid UUID;
        private string name;
        private string description;

        public Guid UUID1 { get => UUID; set => UUID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
