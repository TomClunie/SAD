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
        public string bLine;
        public string bLine1;
        public string bLine2;
        private void UpdateScrutiny_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Assessment 1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = listBox1.SelectedItem.ToString();
            var ass = comboBox1.SelectedItem.ToString();
            using (StreamWriter writer = new StreamWriter(@".\\ScrutinyComplete.txt", true))
            {
                writer.WriteLine(text + "," + ass);
                writer.Close();
            }
            listBox1.Items.Remove(text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                string line;
                string moderatorLine;
                StreamReader reader = new StreamReader(@".\\users.txt"); //Reading data from users.txt to validate current user & type

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(currentUser) && line.Contains("Module Leader"))
                    {
                        StreamReader completeReader2 = new StreamReader(@".\\ScrutinyComplete.txt");
                        StreamReader moderatorReader = new StreamReader(@".\\ModuleLeaderChecklist.txt");
                        while ((moderatorLine = moderatorReader.ReadLine()) != null)
                        {
                            listBox1.Items.Add(moderatorLine);
                        }
                        while ((moderatorLine = completeReader2.ReadLine()) != null)
                        {
                            string[] components = line.Split(',');
                            string one = components[0];
                            string two = components[1];

                            if (moderatorLine.Contains(one) && moderatorLine.Contains(two))
                            {
                                listBox1.Items.Remove(moderatorLine);
                            }
                        }
                        completeReader2.Close();
                    }
                }
            }
            /*while ((line = reader.ReadLine()) != null) //loop through each line in users.txt
        {
            //Module Leader Checklist
            if (line.Contains(currentUser) && line.Contains("Module Leader")) //If that line contains the current username & is a module leader type
            {
                StreamReader completeReader1 = new StreamReader(@".\\ScrutinyComplete.txt");
                //add each line from ModuleLeaderChecklist.txt to the check box
                StreamReader moduleLeaderReader = new StreamReader(@".\\ModuleLeaderChecklist.txt");
                while ((moduleLeaderLine = moduleLeaderReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(moduleLeaderLine); //Add current line to CheckedListBox1                        
                }
                while ((moduleLeaderLine = completeReader1.ReadLine()) != null)
                {
                    listBox1.Items.Remove(moduleLeaderLine);
                }
                completeReader1.Close();
            }

            //Moderator Checklist
            if (line.Contains(currentUser) && line.Contains("Moderator"))
            {
                StreamReader completeReader2 = new StreamReader(@".\\ScrutinyComplete.txt");
                StreamReader moderatorReader = new StreamReader(@".\\ModeratorChecklist.txt");
                while ((moderatorLine = moderatorReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(moderatorLine);
                }
                while ((moderatorLine = completeReader2.ReadLine()) != null)
                {
                    listBox1.Items.Remove(moderatorLine);
                }
                completeReader2.Close();
            }

            //External Examiner Checklist
            if (line.Contains(currentUser) && line.Contains("ExtExam"))
            {
                StreamReader completeReader3 = new StreamReader(@".\\ScrutinyComplete.txt");
                StreamReader externalExaminerReader = new StreamReader(@".\\ExternalExaminerChecklist.txt");
                while ((externalExaminerLine = externalExaminerReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(externalExaminerLine);
                }
                while ((externalExaminerLine = completeReader3.ReadLine()) != null)
                {
                    listBox1.Items.Remove(externalExaminerLine);
                }
                completeReader3.Close();
            }

            //Panel Checklist
            if (line.Contains(currentUser) && line.Contains("Panel"))
            {
                StreamReader completeReader4 = new StreamReader(@".\\ScrutinyComplete.txt");
                StreamReader panelReader = new StreamReader(@".\\PanelChecklist.txt");
                while ((panelLine = panelReader.ReadLine()) != null)
                {
                    listBox1.Items.Add(panelLine);
                }
                while ((panelLine = completeReader4.ReadLine()) != null)
                {
                    listBox1.Items.Remove(panelLine);
                }
                completeReader4.Close();
            }
        }
             */
        }
    } 
}