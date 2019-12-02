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
        }
        string currentUser = Form1.cUser;        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateScrutiny_Load(object sender, EventArgs e)
        {
            string line;
            string moduleLeaderLine;
            string moderatorLine;
            string panelLine;
            string externalExaminerLine;
            StreamReader reader = new StreamReader(@".\\users.txt"); //Reading data from users.txt to validate current user & type

            while ((line = reader.ReadLine()) != null) //loop through each line in users.txt
            {
                //Module Leader Checklist
                if (line.Contains(currentUser) && line.Contains("Module Leader")) //If that line contains the current username & is a module leader type
                {
                    //add each line from ModuleLeaderChecklist.txt to the check box
                    StreamReader moduleLeaderReader = new StreamReader(@".\\ModuleLeaderChecklist.txt");
                    while ((moduleLeaderLine = moduleLeaderReader.ReadLine()) != null)
                    {
                        checkedListBox1.Items.Add(moduleLeaderLine); //Add current line to CheckedListBox1
                    }
                }

                //Moderator Checklist
                if (line.Contains(currentUser) && line.Contains("Moderator"))
                {
                    StreamReader moderatorReader = new StreamReader(@".\\ModeratorChecklist.txt");
                    while ((moderatorLine = moderatorReader.ReadLine()) != null)
                    {
                        checkedListBox1.Items.Add(moderatorLine);
                    }
                }

                //External Examiner Checklist
                if (line.Contains(currentUser) && line.Contains("ExtExam"))
                {
                    StreamReader externalExaminerReader = new StreamReader(@".\\ExternalExaminerChecklist.txt");
                    while ((externalExaminerLine = externalExaminerReader.ReadLine()) != null)
                    {
                        checkedListBox1.Items.Add(externalExaminerLine);
                    }
                }

                //Panel Checklist
                if (line.Contains(currentUser) && line.Contains("Panel"))
                {
                    StreamReader panelReader = new StreamReader(@".\\PanelChecklist.txt");
                    while ((panelLine = panelReader.ReadLine()) != null)
                    {
                        checkedListBox1.Items.Add(panelLine);
                    }
                }
            }
        }
    }
}
