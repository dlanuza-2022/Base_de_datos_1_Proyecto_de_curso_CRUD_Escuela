using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    public class GroupCatalog
    {
        public GroupCatalog()
        { 
        
            groups= new List<Group>();
        }



        private List<Group> groups;

        public List<Group> Groups { get => groups; set => groups = value; }
    }
}
