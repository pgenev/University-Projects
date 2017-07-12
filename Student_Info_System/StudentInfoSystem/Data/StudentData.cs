using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    class StudentData
    {
        public static Student GetStudentDataByUser(string fakNumber)
        {
            StudentDataClassesDataContext dc = new StudentDataClassesDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               where (students.FakNumber == fakNumber)
                               select students).ToArray<Student>();
            if (queryResult.Count<Student>() > 0)
            {
                return queryResult[0];
            }
            else
            {
                return null;
            }
        }

        // добавено от мен
        public static bool _IfFacNumberExist(string facNumber)
        {
            StudentDataClassesDataContext dc = new StudentDataClassesDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               where (students.FakNumber == facNumber)
                               select students).ToArray<Student>();
            if (queryResult.Count<Student>() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InsertStudent(Student s)
        {
            StudentDataClassesDataContext dc = new StudentDataClassesDataContext();
            try
            {
                dc.AddNewStudent(s.FirstName, s.SecondName, s.LastName, s.Faculty, s.Specialty, s.OKS, s.StudentStatus,
                s.FakNumber, s.Course, s.Potok, s.admGroup);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static int?[] GetAllGroups()
        {
            StudentDataClassesDataContext dc = new StudentDataClassesDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               select students.admGroup).Distinct().ToArray<int?>();
            if (queryResult.Length > 0)
            {
                return queryResult;
            }
            else
            {
                return null;
            }
        }
    }
}
