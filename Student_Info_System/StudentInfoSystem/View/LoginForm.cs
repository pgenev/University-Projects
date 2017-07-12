﻿using System;
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
    public partial class LoginForm : Form
    {
        public User user { get; private set; }
        public LoginForm()
        {
            user = null;
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginValidation lv =
                new LoginValidation(textUser.Text, textPass.Text);
            User usr;
            if (lv.ValidateUserInput(out usr))
            {
                this.user = usr;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(lv.errText);
            }
        }

        
    }
}
