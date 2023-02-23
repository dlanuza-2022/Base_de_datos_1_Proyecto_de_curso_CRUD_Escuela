using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MySQL.model.dol
{
    
    public class Student : Person, IStudent
    {

        public Student() : base()
        {
            grades = new decimal[6];
            gradeNumber = 0;
        }



        public string[] getAsARow()
        {
            string[] row = new string[1];



        }

        public void showGrades()
        {
            throw new NotImplementedException();
        }

        public void enrollSubject()
        {
            throw new NotImplementedException();
        }

        public void addGrade(decimal grade)
        {
            if(gradeNumber < 6)
            {
                grades[gradeNumber] = grade;
                gradeNumber++;
            }
            else
            {
                MessageBox.Show("Este estudiante no admite mas notas!");
            }
           
        }

        public void removeGrades()
        {
            for(int i = 0; i < grades.Length; i++) 
            {
                grades[i] = 0;
            }
        }

        public void modifyGrade(int index, decimal grade)
        {
            grades[index] = grade;
        }

        public decimal getGrade(int index)
        {
            throw new NotImplementedException();
        }

        public void addSubject(string id)
        {
            throw new NotImplementedException();
        }

        public void modifySubject(int index, string subject)
        {
            throw new NotImplementedException();
        }

        public void deleteSubject(int index)
        {
            throw new NotImplementedException();
        }

        public string getSubject(int index)
        {
            throw new NotImplementedException();
        }





        private Guid id;

        private DateTime entryDate;

        
        private decimal[] grades;
        private int gradeNumber;



        private string[] enrroledSubjects;


        public Guid Id { get => id; set => id = value; }
      
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
        public decimal[] Grades { get => grades; set => grades = value; }
        public int GradeNumber { get => gradeNumber; set => gradeNumber = value; }
        public string[] EnrroledSubjects { get => enrroledSubjects; set => enrroledSubjects = value; }
    }
}
