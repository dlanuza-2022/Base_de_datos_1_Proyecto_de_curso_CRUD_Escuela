using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    internal interface IGroup
    {
        Subject getSubjectAtIndex(int index);
        void setSubjectAtIndex(int index, Subject subject);

        void addSubject(Subject subject);


        void removeAllSubjects();

        void addStudent(Student student);

        void modifyStudentAtIndex(int index, Student student);

        void removeStundentAtIndex(int index);

        void showStudents();


    }
}
