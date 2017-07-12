using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Logic;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            ReadUserInfo();
        }

        private Data.User ReadUserInfo()
        {
            Data.User user = new Data.User();
            user.Username = txtUserName.Text;
            user.Password = txtPassWord.Text;
            user.FacNumber = txtFacuNumber.Text;
            user.Role = radioButtons();
            return user;
        }

        private int radioButtons()
        {
            int role = 0;
            if(rdStudent.Checked)
            {
                role = 1;
            } else if (rdPrepodavatel.Checked){
                role = 3;
            }
            return role;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {

            if (txtConfirmPassWord.Text.Equals(txtPassWord.Text))
            {
                Data.User user = ReadUserInfo();
                if (UserData._IfUserExist(user.Username))
                {
                    MessageBox.Show("Такъв потребител вече съществува!");
                    return;
                }
                if (UserData._IfUserFacNumberExist(txtFacuNumber.Text))
                {
                    MessageBox.Show("Вече съществува такъв потребител с такъв факултетен номер!");
                    return;
                }
                if (RegisterValidation.InsertUserIfValid(user))
                {
                    MessageBox.Show("Вие се регистрирахте успешно!");
                }
                else
                {
                    MessageBox.Show("Неуспешна регистрация!");
                }
            }
            else
            {
                MessageBox.Show("Паролите не съвпадат!");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
