using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Data
{
    class UserData
    {
        public static User IsUserPassCorrect(string username, string password)
        {
            return UserData._IsUserPassCorrect(username, password);
        }
        private static User _IsUserPassCorrect(string username, string password)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username) &&
                               (users.Password == password)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
                return queryResult.ElementAt<User>(0);
            return null;
        }
        public static bool _IfUserExist(string username)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.Username == username)
                               select users.Username).ToArray<string>();
            if (queryResult.Count<string>() > 0)
                return true;
            else
            {
                return false;
            }
        }

        public static bool _IfUserFacNumberExist(string FacuNumber)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            var queryResult = (from users in dc.GetTable<User>()
                               where (users.FacNumber == FacuNumber)
                               select users).ToArray<User>();
            if (queryResult.Count<User>() > 0)
                return true;
            else
            {
                return false;
            }
        }

        public static bool InsertUser(User user)
        {
            UserDataClassesDataContext dc = new UserDataClassesDataContext();
            try
            {
                dc.AddNewUser(user.Username, user.Password, user.FacNumber, user.Role);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
