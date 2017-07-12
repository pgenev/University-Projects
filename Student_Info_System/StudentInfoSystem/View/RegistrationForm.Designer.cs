namespace StudentInfoSystem.View
{
    partial class RegistrationForm
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
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdPrepodavatel = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.lblConfirmPassWord = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.btnUserName = new System.Windows.Forms.Label();
            this.txtFacuNumber = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txtConfirmPassWord = new System.Windows.Forms.TextBox();
            this.lblFacuNumber = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRegistration.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.btnClose);
            this.gbRegistration.Controls.Add(this.panel1);
            this.gbRegistration.Controls.Add(this.lblFacuNumber);
            this.gbRegistration.Controls.Add(this.lblConfirmPassWord);
            this.gbRegistration.Controls.Add(this.lblPassWord);
            this.gbRegistration.Controls.Add(this.btnUserName);
            this.gbRegistration.Controls.Add(this.txtConfirmPassWord);
            this.gbRegistration.Controls.Add(this.txtFacuNumber);
            this.gbRegistration.Controls.Add(this.txtPassWord);
            this.gbRegistration.Controls.Add(this.txtUserName);
            this.gbRegistration.Controls.Add(this.btnRegistration);
            this.gbRegistration.Location = new System.Drawing.Point(12, 21);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(398, 325);
            this.gbRegistration.TabIndex = 0;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Регистрационна форма";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdPrepodavatel);
            this.panel1.Controls.Add(this.rdStudent);
            this.panel1.Location = new System.Drawing.Point(219, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 75);
            this.panel1.TabIndex = 3;
            // 
            // rdPrepodavatel
            // 
            this.rdPrepodavatel.AutoSize = true;
            this.rdPrepodavatel.Location = new System.Drawing.Point(18, 37);
            this.rdPrepodavatel.Name = "rdPrepodavatel";
            this.rdPrepodavatel.Size = new System.Drawing.Size(98, 17);
            this.rdPrepodavatel.TabIndex = 0;
            this.rdPrepodavatel.TabStop = true;
            this.rdPrepodavatel.Text = "Преподавател";
            this.rdPrepodavatel.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(18, 14);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(65, 17);
            this.rdStudent.TabIndex = 0;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Студент";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // lblConfirmPassWord
            // 
            this.lblConfirmPassWord.AutoSize = true;
            this.lblConfirmPassWord.Location = new System.Drawing.Point(66, 105);
            this.lblConfirmPassWord.Name = "lblConfirmPassWord";
            this.lblConfirmPassWord.Size = new System.Drawing.Size(100, 13);
            this.lblConfirmPassWord.TabIndex = 2;
            this.lblConfirmPassWord.Text = "Повтори паролата";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(86, 71);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(45, 13);
            this.lblPassWord.TabIndex = 2;
            this.lblPassWord.Text = "Парола";
            // 
            // btnUserName
            // 
            this.btnUserName.AutoSize = true;
            this.btnUserName.Location = new System.Drawing.Point(86, 35);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(67, 13);
            this.btnUserName.TabIndex = 2;
            this.btnUserName.Text = "Потребител";
            // 
            // txtFacuNumber
            // 
            this.txtFacuNumber.Location = new System.Drawing.Point(219, 140);
            this.txtFacuNumber.Name = "txtFacuNumber";
            this.txtFacuNumber.Size = new System.Drawing.Size(140, 20);
            this.txtFacuNumber.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(219, 71);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(140, 20);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(219, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(19, 285);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(123, 23);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Регистрирай се";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // txtConfirmPassWord
            // 
            this.txtConfirmPassWord.Location = new System.Drawing.Point(219, 105);
            this.txtConfirmPassWord.Name = "txtConfirmPassWord";
            this.txtConfirmPassWord.Size = new System.Drawing.Size(140, 20);
            this.txtConfirmPassWord.TabIndex = 1;
            this.txtConfirmPassWord.UseSystemPasswordChar = true;
            // 
            // lblFacuNumber
            // 
            this.lblFacuNumber.AutoSize = true;
            this.lblFacuNumber.Location = new System.Drawing.Point(66, 143);
            this.lblFacuNumber.Name = "lblFacuNumber";
            this.lblFacuNumber.Size = new System.Drawing.Size(104, 13);
            this.lblFacuNumber.TabIndex = 2;
            this.lblFacuNumber.Text = "Факултетен номер";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(164, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Излез";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 358);
            this.Controls.Add(this.gbRegistration);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdPrepodavatel;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.Label lblConfirmPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label btnUserName;
        private System.Windows.Forms.TextBox txtFacuNumber;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFacuNumber;
        private System.Windows.Forms.TextBox txtConfirmPassWord;
        private System.Windows.Forms.Button btnClose;
    }
}