using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseworkManagmentApplication
{
    public partial class UpdateScrutiny : Form
    {
        public UpdateScrutiny()
        {
            InitializeComponent();
            for (int i = 0; i < DeadlineClasses.assignments.Count; i++)
            {
                comboBoxAssignment.Items.Add(DeadlineClasses.assignments[i].getName());
            }            
        }
        string currentUser = Form1.cUser;
        
        private void UpdateScrutiny_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@".\\users.txt");

            string line;
            string ModeratorLine;
            string ModLeadLine;
            string directorOfStudyLine;
            string externalExaminerLine;
            while ((line = reader.ReadLine()) != null)
            {
                //Module Leader
                StreamReader ModLeadReader = new StreamReader(@".\\ModuleLeaderChecklist.txt");
                while ((ModLeadLine = ModLeadReader.ReadLine()) != null)
                {
                    checkedListBoxModerator.Items.Add(ModLeadLine);
                }
                // Director of Study, Programme Director - Panel
                StreamReader DosReader = new StreamReader(@".\\PanelChecklist.txt");
                while ((directorOfStudyLine = DosReader.ReadLine()) != null)
                {
                    checkedListBoxModerator.Items.Add(directorOfStudyLine);
                }
                //Moderator
                StreamReader ModReader = new StreamReader(@".\\ModeratorChecklist.txt");
                while ((ModeratorLine = ModReader.ReadLine()) != null)
                {
                    checkedListBoxModerator.Items.Add(ModeratorLine);
                }
                //External Examiner
                StreamReader extExamReader = new StreamReader(@".\\ExternalExaminer.txt");
                while ((externalExaminerLine = extExamReader.ReadLine()) != null)
                {
                    checkedListBoxModerator.Items.Add(externalExaminerLine);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxAssignment.SelectedItem == null)
            {
                MessageBox.Show("Please Select An assignment");
            }
            else
            {
                StreamWriter writer = new StreamWriter(@".\\" + comboBoxAssignment.Text + "ScrutinyForm.txt");
                {
                    foreach (var item in checkedListBoxModerator.CheckedItems)
                    {
                        writer.WriteLine(item.ToString() + " yes");
                    }
                }
                writer.Close();
                for (int i = 0; i < checkedListBoxModerator.Items.Count; i++)
                {
                    checkedListBoxModerator.SetItemChecked(i, false);
                }

                MessageBox.Show("Scrutiny Form Saved");
            }          
        }

        
    } 
}