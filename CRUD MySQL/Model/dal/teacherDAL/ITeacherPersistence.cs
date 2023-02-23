using CRUD_MySQL.model.dol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dal
{
    internal interface ITeacherPersistence
    {
        bool saveTeacher(Teacher teacher);

        bool saveTeacherList(List<Teacher> teacherList);



        Teacher retrieveTeacher(int id);

        List<Teacher> retrieveTeachers();


        bool validateTeacher(Teacher teacher);



    }
}
