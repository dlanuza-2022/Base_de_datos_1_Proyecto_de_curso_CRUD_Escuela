using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    interface IPrincipal
    {
        string[] getAsARow();
        void addNewTeacher();

        void modifyTeachers();

        void seeTeacherDetails();

        void addNewStudent();

        void modifyStudents();

        void promoteStudent();

        void addNewGroup();

        void modifyGroup();

    }
}
