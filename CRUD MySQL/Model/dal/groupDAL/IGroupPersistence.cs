using CRUD_MySQL.model.dol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dal
{
    internal interface IGroupPersistence
    {
        bool saveGroup(Group group);

        bool saveGroupList(List<Group> groupList);

        Group retrieveGroup(int id);

        List<Group> retrieveGroupList();

        bool validateGroup(Group group);

    }
}
