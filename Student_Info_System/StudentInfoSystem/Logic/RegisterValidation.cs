using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class RegisterValidation
    {
        public static bool InsertUserIfValid(User user)
        {
            if (user.Username == "" || user.Username.Length < 4 || user.Password == "" ||
                user.Password.Length < 6 || user.FacNumber == "" || user.Role == 0)
            {
                return false;
            }
            else
            {
                if (UserData.InsertUser(user))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
