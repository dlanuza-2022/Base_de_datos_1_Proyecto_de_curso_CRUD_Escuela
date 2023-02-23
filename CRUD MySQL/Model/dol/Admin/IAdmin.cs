using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    internal interface IAdmin
    {
        void addGroup();
        void modifyGroup();

        void deleteGroup();

        void viewGroups();

        void addTeacher();
        void modifyTeacher();
        void deleteTeacher();
        void viewTeachers();


        void modifyPrincipal();
        void viewPrincipal();










    }
}
