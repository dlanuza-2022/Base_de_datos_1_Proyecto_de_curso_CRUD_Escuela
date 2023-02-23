using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MySQL.model.dol
{



    public class Group : IGroup
    {
        public Group(string name)
        {
            numStudents = 0;
            groupName= name;
            UUID = Guid.NewGuid();
            subjects = new Subject[6];
            subjectNumber= 0;
        }



        private Guid UUID;


        private short numStudents;
        private string groupName;
        private Teacher teacher;
        private List<Student> students;

        private Subject[] subjects;

        private int subjectNumber;


        public string GroupName { get => groupName; set => groupName = value; }
        public List<Student> Students { get => students; set => students = value; }
        public Teacher Teacher { get => teacher; set => teacher = value; }
        public short NumStudents { get => numStudents; set => numStudents = value; }
        public Guid UUID1 { get => UUID; set => UUID = value; }
        public Subject[] Subjects { get => subjects; set => subjects = value; }
        public int SubjectNumber { get => subjectNumber; set => subjectNumber = value; }


        public Subject getSubjectAtIndex(int index)
        {
            return subjects[index];
        }

        public void setSubjectAtIndex(int index, Subject subject)
        {
            subjects[index] = subject;
        }

        public void addSubject(Subject subject)
        {
            if(subjectNumber < 6)
            {
                subjects[subjectNumber] = subject;
                subjectNumber++;
            }
            else
            {
                MessageBox.Show("Este grupo ya no admite nuevas materias!");
            }
        
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void modifyStudentAtIndex(int index, Student student)
        {
            students.Insert(index, student);
        }

        public void removeStundentAtIndex(int index)
        {
            Students.RemoveAt(index);
        }

        public void showStudents()
        {
            throw new NotImplementedException();
        }

        public void removeAllSubjects()
        {

            for (int i = 0; i < 6; i++)
            {
                subjects[i] = null;
            }

            subjectNumber = 0;
        }
    }
}
