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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
            comboLoadAllGroups();
           
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDatabaseDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentInfoDatabaseDataSet.Students);

        }

        private void comboLoadAllGroups()
        {
            int?[] groups = StudentValidation.GetAllGroups();
            foreach (int? group in groups)
            {
                string currentGroup = group.ToString();
                comboGroups.Items.Add(currentGroup);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillBy(this.studentInfoDatabaseDataSet.Students, ((int)(System.Convert.ChangeType(comboGroups.SelectedItem, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

       

       
       

        

        

       

       
    }
}
