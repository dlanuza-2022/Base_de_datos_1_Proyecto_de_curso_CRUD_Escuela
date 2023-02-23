using CRUD_MySQL.model.dol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dal
{
    internal interface IPrincipalPersistence
    {
        bool save(Principal principal);

        Principal retrievePrincipal();

        bool validatePrincipal(Principal principal);
        bool validatePrincipal();


    }
}
