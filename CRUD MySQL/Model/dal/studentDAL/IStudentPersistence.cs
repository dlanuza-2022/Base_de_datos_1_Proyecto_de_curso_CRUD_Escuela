using CRUD_MySQL.model.dol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dal
{
    internal interface IStudentPersistence
    {
        bool retrieveStudent(Student student);
        bool retrieveStudentList(List<Student> studentList);

        Student readStudent(int id);

        List<Student> readStudentList();

        bool validateStudent(Student student);



    }
}
