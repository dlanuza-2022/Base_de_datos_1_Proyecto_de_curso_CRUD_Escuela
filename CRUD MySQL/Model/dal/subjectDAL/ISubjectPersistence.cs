using CRUD_MySQL.model.dol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dal
{
    internal interface ISubjectPersistence
    {
        bool saveSubjects();

        List<Subject> retrieveSubjects();


        bool validateSubject(Subject subject);

    }
}
