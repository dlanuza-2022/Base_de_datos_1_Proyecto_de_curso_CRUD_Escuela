using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    internal interface IStudent
    {
        string[] getAsARow();

        void showGrades();

        void enrollSubject();

        void addGrade(decimal grade);

        decimal getGrade(int index);

        void removeGrades();

        void modifyGrade(int index, decimal grade);


        void addSubject(string id);

        void modifySubject(int index, string subject);

        void deleteSubject(int index);

        string getSubject(int index);





    }
}
