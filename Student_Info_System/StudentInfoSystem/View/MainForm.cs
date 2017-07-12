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
    public partial class MainForm : Form
    {
        public UserStatus userStatus
        { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            userStatus = UserStatus.ANONYMOUS;
            DisableControls();
        }

        
        /*
        public void ShowStudentInfo()
        {
            txtFirstName.Text = "Filip";
            txtSecondName.Text = "Stoilov";
            txtLastName.Text = "Genev";
            txtFaculty.Text = "FKSU";
            txtSpecialty.Text = "KST";
            txtFakNomer.Text = "121212165";
            txtGroup.Text = "53";
            txtPotok.Text = "10";
            comboOKS.SelectedIndex = 1;
            comboStudentStatus.SelectedIndex = 1;
            numCourse.Value = 1;
        }
        */
        public void ShowStudentInfo(Data.Student s)
        {
            txtFirstName.Text = s.FirstName;
            txtSecondName.Text = s.SecondName;
            txtLastName.Text = s.LastName;
            txtFaculty.Text = s.Faculty;
            txtSpecialty.Text = s.Specialty;
            txtFakNomer.Text = s.FakNumber;
            txtGroup.Text = s.admGroup.ToString();
            txtPotok.Text = s.Potok;
            comboOKS.SelectedIndex = (int)s.OKS;
            comboStudentStatus.SelectedIndex = (int)s.StudentStatus;
            numCourse.Value = (int)s.Course;
        }

        public void ClearStudentInfo()
        {
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtLastName.Clear();
            txtFaculty.Clear();
            txtSpecialty.Clear();
            txtFakNomer.Clear();
            txtGroup.Clear();
            txtPotok.Clear();
            comboOKS.SelectedIndex = 0;
            comboStudentStatus.SelectedIndex = 0;
            numCourse.Value = 0;
            pbStudentPhoto.Image = null;
        }
        
        private void EnableControls(){
            gbStudentInfo.Enabled = true;
            gbStudentPhoto.Enabled = true;
            pbStudentPhoto.Visible = true;
            gbPersonalData.Enabled = true;
            miPicture.Visible = true;
            miCertificate.Visible = true;
            miRegistration.Visible = false;

            if (userStatus == UserStatus.ADMIN)
            {
                btnAddStudent.Visible = true;
                btnSpravka.Visible = true;
                
            }

        }
        
        private void DisableControls(){
            gbStudentInfo.Enabled = false;
            gbStudentPhoto.Enabled = false;
            pbStudentPhoto.Visible = false;
            gbPersonalData.Enabled = false;
            miPicture.Visible = false;
            miCertificate.Visible = false;
            btnAddStudent.Visible = false;
            miRegistration.Visible = true;
        }

        private void LogIn()
        {
            LoginForm lf = new LoginForm();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                if (lf.user.Role == 1)
                {
                    Data.Student student = StudentValidation.IsThereStudent(lf.user);
                    ShowStudentInfo(student);
                    userStatus = UserStatus.STUDENT;
                }
                else if (lf.user.Role == 3)
                {
                    userStatus = UserStatus.ADMIN;
                }
                miLogin.Text = "LogOut";
                EnableControls();
            }
        }

        private void LogOut()
        {
                ClearStudentInfo();
                DisableControls();
                userStatus = UserStatus.ANONYMOUS;
                miLogin.Text = "LogIn";
        }

        private void nmLogin_Click(object sender, EventArgs e)
        {
            switch (userStatus)
	{
		case UserStatus.ANONYMOUS:LogIn();
            break;
        case UserStatus.STUDENT:LogOut();
             break;
        case UserStatus.ADMIN:LogOut();
            break;
        default:
            break;
	}
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            AutoBox auto = new AutoBox();
            auto.ShowDialog();

        }

        private void LoadStudentPicture()
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbStudentPhoto.ImageLocation = openPictureDialog.FileName;
                pbStudentPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentPicture();
        }

        private string GenerateInfoText()
        {
            string text = "Уверение:\n";
            text += txtFirstName.Text + " " + txtSecondName.Text + " " +
            txtLastName.Text + "\n";
            text += "е студент/ка във Факултет " + txtFaculty.Text +
            ", специалност " + txtSpecialty.Text;
            text += "\n";
            return text;
        }

        private void uverenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = GenerateInfoText();
            InfoForm infoForm = new InfoForm(text);
            infoForm.Show();
        }
       
       private Data.Student ReadStudentInfo()
       {
            Data.Student st = new Data.Student();
            st.FirstName = txtFirstName.Text;
            st.SecondName = txtSecondName.Text;
            st.LastName = txtLastName.Text;
            st.Faculty = txtFaculty.Text;
            st.Specialty = txtSpecialty.Text;
            st.FakNumber = txtFakNomer.Text;
            int myInt;
            if (int.TryParse(txtGroup.Text, out myInt) == true)
            {
                st.admGroup = myInt;
            }
            st.Potok = txtPotok.Text;
            st.OKS = (short)comboOKS.SelectedIndex;
            st.StudentStatus = (short)comboStudentStatus.SelectedIndex;
            st.Course = (short)numCourse.Value;
            return st;
        }

       private void btnAddStudent_Click(object sender, EventArgs e)
       {
           Student stInfo = ReadStudentInfo();

           if (StudentValidation.ValidateData((short)stInfo.OKS,(short)stInfo.StudentStatus, (short)stInfo.Course) != "")
           {
               MessageBox.Show(StudentValidation.ValidateData((short)stInfo.OKS, (short)stInfo.StudentStatus, (short)stInfo.Course));
               return;
           }
           if (StudentData._IfFacNumberExist(stInfo.FakNumber) == true)
           {
               MessageBox.Show("Студент с такъв факултетен номер вече съществува!");
               return;
           }
           if (StudentValidation.InsertStudentIfValid(stInfo))
           {
               MessageBox.Show("Студентът е успешно добавен!");
           }
           else
           {
               MessageBox.Show("Имаше грешка при въвеждането!");
           }
           
       }

       private void btnSpravka_Click(object sender, EventArgs e)
       {
           GroupsForm gf = new GroupsForm();
           gf.Show();
       }

       private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
       {
           RegistrationForm rf = new RegistrationForm();
           rf.Show();
       }
    }
}
