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
    public partial class Deadlines : Form
    {
        //Deadline lists
        //List<AdminPanel> panels = new List<AdminPanel>();
        //List<AdminMeeting> meetings = new List<AdminMeeting>();
        //List<Assignment> assignments = new List<Assignment>();

        public Deadlines()
        {
            InitializeComponent();
        }

        private void Deadlines_Load(object sender, EventArgs e)
        {
            //Set initial date time picker value
            dateTimePicker.Value = DateTime.Now;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear items and selection if selected item in combo box 1 changes
            richTextBox.Clear();
            dateTimePicker.Value = DateTime.Now;
            comboBoxName.SelectedIndex = -1;
            comboBoxName.Items.Clear();
            comboBoxUser.SelectedIndex = -1;
            comboBoxUser.Items.Clear();

            //Change contents of the 2nd combo box depending on which item is selected in the first combobox
            if (comboBoxType.SelectedIndex == 0)
            {       
                for (int i = 0; i < DeadlineClasses.panels.Count; i++)
                {
                    comboBoxName.Items.Add(DeadlineClasses.panels[i].getName());
                }
                for (int j = 0; j < User.listOfUsers.Count; j++)
                {
                    if (User.listOfUsers[j].GetType().ToString().Contains("FacultyHub"))
                    {
                        comboBoxUser.Items.Add(User.listOfUsers[j].getName());
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                for (int i = 0; i < DeadlineClasses.meetings.Count; i++)
                {
                    comboBoxName.Items.Add(DeadlineClasses.meetings[i].getName());
                }

                for (int j = 0; j < User.listOfUsers.Count; j++)
                {
                    if (User.listOfUsers[j].GetType().ToString().Contains("FacultyHub"))
                    {
                        comboBoxUser.Items.Add(User.listOfUsers[j].getName());
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                for (int i = 0; i < DeadlineClasses.assignments.Count; i++)
                {
                    comboBoxName.Items.Add(DeadlineClasses.assignments[i].getName());
                    
                }

                for (int j = 0; j < User.listOfUsers.Count; j++)
                {
                    if (User.listOfUsers[j].GetType().ToString().Contains("ModuleLeader") || User.listOfUsers[j].GetType().ToString().Contains("Academic") || User.listOfUsers[j].GetType().ToString().Contains("Moderator") || User.listOfUsers[j].GetType().ToString().Contains("ProgrammeDirector"))
                    {
                        comboBoxUser.Items.Add(User.listOfUsers[j].getName());
                    }
                }
            }
        }

        //Display information for each selected item
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                for (int i = 0; i < DeadlineClasses.panels.Count; i++)
                {
                    if (DeadlineClasses.panels[i].getName() == comboBoxName.Text.ToString())
                    {
                        richTextBox.Text = DeadlineClasses.panels[i].getComment();
                        dateTimePicker.Value = DateTime.Parse(DeadlineClasses.panels[i].getDueDate());

                        var username = DeadlineClasses.panels[i].getUser();

                        for (int j = 0; j < User.listOfUsers.Count; j++)
                        {
                            if (username == User.listOfUsers[j].getUsername())
                            {
                                comboBoxUser.SelectedItem = User.listOfUsers[j].getName();
                            }
                        }
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 1)
            {
                for (int i = 0; i < DeadlineClasses.meetings.Count; i++)
                {
                    if (DeadlineClasses.meetings[i].getName() == comboBoxName.Text.ToString())
                    {
                        richTextBox.Text = DeadlineClasses.meetings[i].getComment();
                        dateTimePicker.Value = DateTime.Parse(DeadlineClasses.meetings[i].getDueDate());

                        var username = DeadlineClasses.meetings[i].getUser();

                        for (int j = 0; j < User.listOfUsers.Count; j++)
                        {
                            if (username == User.listOfUsers[j].getUsername())
                            {
                                comboBoxUser.SelectedItem = User.listOfUsers[j].getName();
                            }
                        }
                    }
                }
            }

            if (comboBoxType.SelectedIndex == 2)
            {
                for (int i = 0; i < DeadlineClasses.assignments.Count; i++)
                {
                    if (DeadlineClasses.assignments[i].getName() == comboBoxName.Text.ToString())
                    {
                        richTextBox.Text = DeadlineClasses.assignments[i].getComment();
                        dateTimePicker.Value = DateTime.Parse(DeadlineClasses.assignments[i].getDueDate());

                        var username = DeadlineClasses.assignments[i].getUser();

                        for (int j = 0; j < User.listOfUsers.Count; j++)
                        {
                            if (username == User.listOfUsers[j].getUsername())
                            {
                                comboBoxUser.SelectedItem = User.listOfUsers[j].getName();
                            }
                        }
                    }
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {   //Validation
            if (comboBoxName.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                //Removing items
                if (comboBoxType.SelectedIndex == 0)
                {
                    for (int i = 0; i < DeadlineClasses.panels.Count; i++)
                    {
                        if (DeadlineClasses.panels[i].getName() == comboBoxName.Text.ToString())
                        {
                            DeadlineClasses.panels.RemoveAt(i);
                            comboBoxName.Items.Remove(comboBoxName.SelectedItem);
                            comboBoxName.Text = "";
                            comboBoxUser.Items.Remove(comboBoxUser.SelectedItem);
                            comboBoxUser.SelectedIndex = -1;
                            richTextBox.Clear();
                            dateTimePicker.Value = DateTime.Now;
                        }
                    }
                }

                if (comboBoxType.SelectedIndex == 1)
                {
                    for (int i = 0; i < DeadlineClasses.meetings.Count; i++)
                    {
                        if (DeadlineClasses.meetings[i].getName() == comboBoxName.Text.ToString())
                        {
                            DeadlineClasses.meetings.RemoveAt(i);
                            comboBoxName.Items.Remove(comboBoxName.SelectedItem);
                            comboBoxName.Text = "";
                            comboBoxUser.Items.Remove(comboBoxUser.SelectedItem);
                            comboBoxUser.SelectedIndex = -1;
                            richTextBox.Clear();
                            dateTimePicker.Value = DateTime.Now;
                        }
                    }
                }

                if (comboBoxType.SelectedIndex == 2)
                {
                    for (int i = 0; i < DeadlineClasses.assignments.Count; i++)
                    {
                        if (DeadlineClasses.assignments[i].getName() == comboBoxName.Text.ToString())
                        {
                            DeadlineClasses.assignments.RemoveAt(i);
                            comboBoxName.Items.Remove(comboBoxName.SelectedItem);
                            comboBoxName.Text = "";
                            comboBoxUser.Items.Remove(comboBoxUser.SelectedItem);
                            comboBoxUser.SelectedIndex = -1;
                            richTextBox.Clear();
                            dateTimePicker.Value = DateTime.Now;
                        }
                    }
                }

                //Rewrite file
                using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt"))
                {
                    for (int i = 0; i < DeadlineClasses.panels.Count; i++)
                    {
                        writer.WriteLine(DeadlineClasses.panels[i].getInfo());
                    }
                    for (int i = 0; i < DeadlineClasses.meetings.Count; i++)
                    {
                        writer.WriteLine(DeadlineClasses.meetings[i].getInfo());
                    }
                    for (int i = 0; i < DeadlineClasses.assignments.Count; i++)
                    {
                        writer.WriteLine(DeadlineClasses.assignments[i].getInfo());
                    }
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Validation
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else if (comboBoxName.Text.ToString() == "")
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                //Add new items to the elements and write them to file
                var dueDate = dateTimePicker.Value.ToShortDateString();
                var setDate = DateTime.Now.ToShortDateString();

                if (comboBoxType.SelectedIndex == 0)
                {
                    var name = comboBoxUser.SelectedItem.ToString();
                    string username = "";

                    for (int i = 0; i < User.listOfUsers.Count; i++)
                    {
                        if (User.listOfUsers[i].getName() == name)
                        {
                            username = User.listOfUsers[i].getUsername();
                        }
                    }

                    if (richTextBox.TextLength == 0)
                    {
                        DeadlineClasses.panels.Add(new AdminPanel(comboBoxName.Text.ToString(), username, dueDate, setDate, ""));
                    }
                    else
                    {
                        DeadlineClasses.panels.Add(new AdminPanel(comboBoxName.Text.ToString(), username, dueDate, setDate, richTextBox.Text));
                    }

                    comboBoxName.Items.Add(comboBoxName.Text.ToString());
                    comboBoxName.Text = "";
                    comboBoxUser.SelectedIndex = -1;
                    richTextBox.Clear();
                    dateTimePicker.Value = DateTime.Now;
                    MessageBox.Show("Item has been added");

                    int index = DeadlineClasses.panels.Count - 1;
                    using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt", true))
                    {
                        writer.WriteLine(DeadlineClasses.panels[index].getInfo(), Environment.NewLine);
                    }

                }

                if (comboBoxType.SelectedIndex == 1)
                {
                    var name = comboBoxUser.SelectedItem.ToString();
                    string username = "";

                    for (int i = 0; i < User.listOfUsers.Count; i++)
                    {
                        if (User.listOfUsers[i].getName() == name)
                        {
                            username = User.listOfUsers[i].getUsername();
                        }
                    }

                    if (richTextBox.TextLength == 0)
                    {

                        DeadlineClasses.meetings.Add(new AdminMeeting(comboBoxName.Text.ToString(), username, dueDate, setDate, ""));
                    }
                    else
                    {
                        DeadlineClasses.meetings.Add(new AdminMeeting(comboBoxName.Text.ToString(), username, dueDate, setDate, richTextBox.Text));
                    }

                    comboBoxName.Items.Add(comboBoxName.Text.ToString());
                    comboBoxName.Text = "";
                    comboBoxUser.SelectedIndex = -1;
                    richTextBox.Clear();
                    dateTimePicker.Value = DateTime.Now;
                    MessageBox.Show("Item has been added");

                    int index = DeadlineClasses.meetings.Count - 1;
                    using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt", true))
                    {
                        writer.WriteLine(DeadlineClasses.meetings[index].getInfo(), Environment.NewLine);
                    }
                }

                if (comboBoxType.SelectedIndex == 2)
                {
                    var name = comboBoxUser.SelectedItem.ToString();
                    string username = "";

                    for (int i = 0; i < User.listOfUsers.Count; i++)
                    {
                        if (User.listOfUsers[i].getName() == name)
                        {
                            username = User.listOfUsers[i].getUsername();
                        }
                    }

                    if (richTextBox.TextLength == 0)
                    {
                        DeadlineClasses.assignments.Add(new Assignment(comboBoxName.Text.ToString(), username, dueDate, setDate, ""));
                    }
                    else
                    {
                        DeadlineClasses.assignments.Add(new Assignment(comboBoxName.Text.ToString(), username, dueDate, setDate, richTextBox.Text));
                    }
                    comboBoxName.Items.Add(comboBoxName.Text.ToString());
                    comboBoxName.Text = "";
                    comboBoxUser.SelectedIndex = -1;
                    richTextBox.Clear();
                    dateTimePicker.Value = DateTime.Now;
                    MessageBox.Show("Item has been added");

                    int index = DeadlineClasses.assignments.Count - 1;
                    using (StreamWriter writer = new StreamWriter(@".\\deadlines.txt", true))
                    {
                        writer.WriteLine(DeadlineClasses.assignments[index].getInfo(), Environment.NewLine);
                    }
                }
            }
        }
    }
}
