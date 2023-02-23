
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MySQL.model.dol
{
    public class Teacher : Person, ITeacher
    {



        public Teacher() : base()
        { 
        }




       
        private decimal mensualWage;
        private int tenure;
        private DateTime entryDate;
        private LinkedList<string> subjects;
        private LinkedList<string> assingedGroups;

        public decimal MensualWage { get => mensualWage; set => mensualWage = value; }
        public int Tenure { get => tenure; set => tenure = value; }
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
        public LinkedList<string> Subjects { get => subjects; set => subjects = value; }
        internal LinkedList<string> AssingedGroups { get => assingedGroups; set => assingedGroups = value; }

        public string[] getAsRow()
        {
            throw new NotImplementedException();
        }
    }
}
