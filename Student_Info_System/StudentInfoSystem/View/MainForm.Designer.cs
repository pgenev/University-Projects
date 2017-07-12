namespace StudentInfoSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.miCertificate = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStudentInfo = new System.Windows.Forms.TabControl();
            this.tabStudentInfo = new System.Windows.Forms.TabPage();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnSpravka = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.comboStudentStatus = new System.Windows.Forms.ComboBox();
            this.comboOKS = new System.Windows.Forms.ComboBox();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.lblFakNumber = new System.Windows.Forms.Label();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtPotok = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblOKS = new System.Windows.Forms.Label();
            this.lblPotok = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.txtFakNomer = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbStudentPhoto = new System.Windows.Forms.GroupBox();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControlStudentInfo.SuspendLayout();
            this.tabStudentInfo.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.gbPersonalData.SuspendLayout();
            this.gbStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miLogin,
            this.miHelp,
            this.miPicture,
            this.miCertificate,
            this.miRegistration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.Size = new System.Drawing.Size(49, 20);
            this.miLogin.Text = "Login";
            this.miLogin.Click += new System.EventHandler(this.nmLogin_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // miPicture
            // 
            this.miPicture.Name = "miPicture";
            this.miPicture.Size = new System.Drawing.Size(85, 20);
            this.miPicture.Text = "Load Picture";
            this.miPicture.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // miCertificate
            // 
            this.miCertificate.Name = "miCertificate";
            this.miCertificate.Size = new System.Drawing.Size(73, 20);
            this.miCertificate.Text = "Certificate";
            this.miCertificate.Click += new System.EventHandler(this.uverenieToolStripMenuItem_Click);
            // 
            // miRegistration
            // 
            this.miRegistration.Name = "miRegistration";
            this.miRegistration.Size = new System.Drawing.Size(82, 20);
            this.miRegistration.Text = "Registration";
            this.miRegistration.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // tabControlStudentInfo
            // 
            this.tabControlStudentInfo.Controls.Add(this.tabStudentInfo);
            this.tabControlStudentInfo.Controls.Add(this.tabPage1);
            this.tabControlStudentInfo.Location = new System.Drawing.Point(0, 27);
            this.tabControlStudentInfo.Name = "tabControlStudentInfo";
            this.tabControlStudentInfo.SelectedIndex = 0;
            this.tabControlStudentInfo.Size = new System.Drawing.Size(447, 342);
            this.tabControlStudentInfo.TabIndex = 1;
            // 
            // tabStudentInfo
            // 
            this.tabStudentInfo.Controls.Add(this.gbStudentInfo);
            this.tabStudentInfo.Controls.Add(this.gbPersonalData);
            this.tabStudentInfo.Controls.Add(this.gbStudentPhoto);
            this.tabStudentInfo.Location = new System.Drawing.Point(4, 22);
            this.tabStudentInfo.Name = "tabStudentInfo";
            this.tabStudentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentInfo.Size = new System.Drawing.Size(439, 316);
            this.tabStudentInfo.TabIndex = 0;
            this.tabStudentInfo.Text = "Студенти";
            this.tabStudentInfo.UseVisualStyleBackColor = true;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.btnSpravka);
            this.gbStudentInfo.Controls.Add(this.btnAddStudent);
            this.gbStudentInfo.Controls.Add(this.comboStudentStatus);
            this.gbStudentInfo.Controls.Add(this.comboOKS);
            this.gbStudentInfo.Controls.Add(this.numCourse);
            this.gbStudentInfo.Controls.Add(this.lblFakNumber);
            this.gbStudentInfo.Controls.Add(this.lblStudentStatus);
            this.gbStudentInfo.Controls.Add(this.txtGroup);
            this.gbStudentInfo.Controls.Add(this.txtPotok);
            this.gbStudentInfo.Controls.Add(this.lblGroup);
            this.gbStudentInfo.Controls.Add(this.lblOKS);
            this.gbStudentInfo.Controls.Add(this.lblPotok);
            this.gbStudentInfo.Controls.Add(this.lblSpecialty);
            this.gbStudentInfo.Controls.Add(this.lblCourse);
            this.gbStudentInfo.Controls.Add(this.lblFaculty);
            this.gbStudentInfo.Controls.Add(this.txtFakNomer);
            this.gbStudentInfo.Controls.Add(this.txtSpecialty);
            this.gbStudentInfo.Controls.Add(this.txtFaculty);
            this.gbStudentInfo.Location = new System.Drawing.Point(8, 107);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(425, 203);
            this.gbStudentInfo.TabIndex = 2;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студентска информация";
            // 
            // btnSpravka
            // 
            this.btnSpravka.Location = new System.Drawing.Point(284, 164);
            this.btnSpravka.Name = "btnSpravka";
            this.btnSpravka.Size = new System.Drawing.Size(113, 23);
            this.btnSpravka.TabIndex = 6;
            this.btnSpravka.Text = "Справка студенти";
            this.btnSpravka.UseVisualStyleBackColor = true;
            this.btnSpravka.Visible = false;
            this.btnSpravka.Click += new System.EventHandler(this.btnSpravka_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(284, 126);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(113, 23);
            this.btnAddStudent.TabIndex = 5;
            this.btnAddStudent.Text = "Добави студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // comboStudentStatus
            // 
            this.comboStudentStatus.FormattingEnabled = true;
            this.comboStudentStatus.Items.AddRange(new object[] {
            "Избери...",
            "Активен",
            "Прекъснал"});
            this.comboStudentStatus.Location = new System.Drawing.Point(94, 99);
            this.comboStudentStatus.Name = "comboStudentStatus";
            this.comboStudentStatus.Size = new System.Drawing.Size(75, 21);
            this.comboStudentStatus.TabIndex = 4;
            // 
            // comboOKS
            // 
            this.comboOKS.FormattingEnabled = true;
            this.comboOKS.Items.AddRange(new object[] {
            "Избери...",
            "Бакалавър",
            "Магистър"});
            this.comboOKS.Location = new System.Drawing.Point(94, 69);
            this.comboOKS.Name = "comboOKS";
            this.comboOKS.Size = new System.Drawing.Size(75, 21);
            this.comboOKS.TabIndex = 3;
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(294, 20);
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(48, 20);
            this.numCourse.TabIndex = 2;
            // 
            // lblFakNumber
            // 
            this.lblFakNumber.AutoSize = true;
            this.lblFakNumber.Location = new System.Drawing.Point(21, 126);
            this.lblFakNumber.Name = "lblFakNumber";
            this.lblFakNumber.Size = new System.Drawing.Size(67, 13);
            this.lblFakNumber.TabIndex = 0;
            this.lblFakNumber.Text = "Фак.Номер";
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(38, 99);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(41, 13);
            this.lblStudentStatus.TabIndex = 0;
            this.lblStudentStatus.Text = "Статус";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(294, 74);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(59, 20);
            this.txtGroup.TabIndex = 1;
            // 
            // txtPotok
            // 
            this.txtPotok.Location = new System.Drawing.Point(294, 46);
            this.txtPotok.Name = "txtPotok";
            this.txtPotok.Size = new System.Drawing.Size(59, 20);
            this.txtPotok.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(240, 77);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "Група";
            // 
            // lblOKS
            // 
            this.lblOKS.AutoSize = true;
            this.lblOKS.Location = new System.Drawing.Point(44, 72);
            this.lblOKS.Name = "lblOKS";
            this.lblOKS.Size = new System.Drawing.Size(29, 13);
            this.lblOKS.TabIndex = 0;
            this.lblOKS.Text = "ОКС";
            // 
            // lblPotok
            // 
            this.lblPotok.AutoSize = true;
            this.lblPotok.Location = new System.Drawing.Point(240, 46);
            this.lblPotok.Name = "lblPotok";
            this.lblPotok.Size = new System.Drawing.Size(38, 13);
            this.lblPotok.TabIndex = 0;
            this.lblPotok.Text = "Поток";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(15, 46);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(73, 13);
            this.lblSpecialty.TabIndex = 0;
            this.lblSpecialty.Text = "Специалност";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(240, 20);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(31, 13);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Курс";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(22, 20);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(57, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Факултет";
            // 
            // txtFakNomer
            // 
            this.txtFakNomer.Location = new System.Drawing.Point(94, 126);
            this.txtFakNomer.Name = "txtFakNomer";
            this.txtFakNomer.Size = new System.Drawing.Size(75, 20);
            this.txtFakNomer.TabIndex = 1;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(94, 43);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(75, 20);
            this.txtSpecialty.TabIndex = 1;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(94, 19);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(75, 20);
            this.txtFaculty.TabIndex = 1;
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.lblLastName);
            this.gbPersonalData.Controls.Add(this.txtLastName);
            this.gbPersonalData.Controls.Add(this.txtSecondName);
            this.gbPersonalData.Controls.Add(this.lblSecondName);
            this.gbPersonalData.Controls.Add(this.txtFirstName);
            this.gbPersonalData.Controls.Add(this.lblFirstName);
            this.gbPersonalData.Location = new System.Drawing.Point(178, 3);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(255, 98);
            this.gbPersonalData.TabIndex = 1;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Лични данни";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(95, 41);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(100, 20);
            this.txtSecondName.TabIndex = 1;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(21, 41);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(53, 13);
            this.lblSecondName.TabIndex = 2;
            this.lblSecondName.Text = "Презиме";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Име";
            // 
            // gbStudentPhoto
            // 
            this.gbStudentPhoto.Controls.Add(this.pbStudentPhoto);
            this.gbStudentPhoto.Location = new System.Drawing.Point(8, 6);
            this.gbStudentPhoto.Name = "gbStudentPhoto";
            this.gbStudentPhoto.Size = new System.Drawing.Size(137, 95);
            this.gbStudentPhoto.TabIndex = 0;
            this.gbStudentPhoto.TabStop = false;
            this.gbStudentPhoto.Text = "Снимка";
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.Location = new System.Drawing.Point(9, 17);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(122, 72);
            this.pbStudentPhoto.TabIndex = 0;
            this.pbStudentPhoto.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(439, 316);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Оценки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 371);
            this.Controls.Add(this.tabControlStudentInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlStudentInfo.ResumeLayout(false);
            this.tabStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            this.gbStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControlStudentInfo;
        private System.Windows.Forms.TabPage tabStudentInfo;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFakNumber;
        private System.Windows.Forms.Label lblStudentStatus;
        private System.Windows.Forms.TextBox txtFakNomer;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtPotok;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblOKS;
        private System.Windows.Forms.Label lblPotok;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.ComboBox comboStudentStatus;
        private System.Windows.Forms.ComboBox comboOKS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.ToolStripMenuItem miPicture;
        private System.Windows.Forms.GroupBox gbStudentPhoto;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.ToolStripMenuItem miCertificate;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnSpravka;
        private System.Windows.Forms.ToolStripMenuItem miRegistration;
    }
}