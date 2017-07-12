using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class LoginValidation
    {
        private string _username;
        private string _password;

        public LoginValidation(string username, string pass)
        {
            _username = username;
            _password = pass;
            errText = String.Empty;
        }
        public string errText { get; private set;}

        private bool isShorterThan(string s, int minLength)
        {
            if (s.Length < minLength && s.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isEmpty(string s)
        {
            if (s == "")
            {
               return true;
            }
            else
            {
                return false;
            }

        }

        public bool ValidateUserInput(out User user)
        {
            if (isEmpty(_username))
            {
                 errText += "Не сте въвели потребителско име!\n";
            }
            if (isEmpty(_password))
            {
                errText += "Не сте въвели парола!\n";
            }
            if (isShorterThan(_username, 4))
            {
                errText += "Потребителското име съдържа недостатъчен брой символи!\n";
            }
            if (isShorterThan(_password, 6))
            {
                errText += "Паролата съдържа недостатъчен брой символи!\n";
            }
            if (errText != "")
            {
                user = null;
                return false;
            }

            User queryResult = UserData.IsUserPassCorrect(_username, _password);
            // returns the user role
            if (queryResult == null)
            {
                errText += "Въвели сте грешно потребителско име или парола!";
                user = null;
                return false;
            }
            user = queryResult;
            return true;
     }
        
    }
}
