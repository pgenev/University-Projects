using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class StudentValidation
    {
        public static Student IsThereStudent(User usr)
        {
            return StudentData.GetStudentDataByUser(usr.FacNumber);
        }
        public static bool InsertStudentIfValid(Student s)
        {
            if (s.FirstName == "" || s.SecondName == "" || s.LastName == "" ||
                s.Faculty == "" || s.Specialty == "" || s.FakNumber == "" || s.admGroup == 0 ||
                  s.Potok == "" || s.OKS == 0 || s.StudentStatus == 0 || s.Course == 0)
            {
                return false;
            }
            if (StudentData.InsertStudent(s) == false)
            {
                return false;
            }
                return true;
        }

        public static int?[] GetAllGroups()
        {
            return StudentData.GetAllGroups();
        }

        
        public static string ValidateData(short OKS, short StudentStatus, short Course)
        {
            string wrongData = String.Empty;
            if (OKS < 1 || OKS > 2)
            {
                wrongData += "Невалидна информация относно ОКС!\n";
            }
            if (StudentStatus < 1 || StudentStatus > 2)
            {
                wrongData += "Невалидна информация относно студентския статус!\n";
            }
            if(Course < 1 || Course > 4){
                wrongData += "Въвели сте невалидна информация относно курса!\n";
            }
            if (wrongData == "")
            {
                return wrongData;
            }
             return wrongData;
        }
         
    }
}
