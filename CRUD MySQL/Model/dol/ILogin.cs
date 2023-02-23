using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    internal interface ILogin
    {
        void login(string username, string password);
        void logout();
    }
}
